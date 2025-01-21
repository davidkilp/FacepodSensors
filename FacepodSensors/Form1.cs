using FpPowerDisplay;
using FpTempDisplay;

#nullable disable

namespace FacepodSensors
{
    public partial class Form1 : Form
    {
        IntPtr pTempSensor = 0;
        IntPtr pPwrSensor = 0;
        bool doUpdate = false;
        Int32 updateRate = 5;    // default update: 5 seconds
        StreamWriter logFile = null;
        ToolStripMenuItem openMenuItem;
        ToolStripMenuItem closeMenuItem;

        public Form1()
        {
            InitializeComponent();
            InitialzeMenu();
            //this.FormClosing += new FormClosingEventHandler(this.MainForm_FormClosing);
            labelState.Text = "stopped";
            buttonStart.Enabled = true;
            buttonStop.Enabled = false;
            numericRate.Value = updateRate;

            // Power Sensor may not be present on early board so do it first
            if (!InitPowerSensor())
            {
                groupBox2.Enabled = false;
            }

            if (!InitTempSensor())
            {
                groupBox1.Enabled = false;
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Ensure the file is closed when the form is closing
            if (logFile != null)
            {
                logFile.Close();
                logFile.Dispose();
            }
        }

        private void InitialzeMenu()
        {
            MenuStrip menuStrip = new MenuStrip();

            // Create the "File" menu item
            ToolStripMenuItem fileMenuItem = new ToolStripMenuItem("File");

            // Create sub-items for the "File" menu
            openMenuItem = new ToolStripMenuItem("Save Log as...");
            closeMenuItem = new ToolStripMenuItem("Close Log");
            ToolStripMenuItem exitMenuItem = new ToolStripMenuItem("Exit");

            // Add click event handlers
            openMenuItem.Click += new EventHandler(OpenMenuItem_Click);
            closeMenuItem.Click += new EventHandler(CloseMenuItem_Click);
            exitMenuItem.Click += new EventHandler(ExitMenuItem_Click);

            closeMenuItem.Enabled = false;

            // Add sub-items to the "File" menu
            fileMenuItem.DropDownItems.Add(openMenuItem);
            fileMenuItem.DropDownItems.Add(closeMenuItem);
            fileMenuItem.DropDownItems.Add(exitMenuItem);

            // Add the "File" menu to the MenuStrip
            menuStrip.Items.Add(fileMenuItem);

            // Add the MenuStrip to the form
            this.MainMenuStrip = menuStrip;
            this.Controls.Add(menuStrip);
        }

        private bool InitTempSensor()
        {
            try
            {
                pTempSensor = TempSensors.FpTemp_Instantiate();
                buttonStart.Enabled = true;
                UpdateReadings();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Temperature Sensor hardware not detected.\n" + ex.Message);
                labelState.Text = "Temperature Sensor hardware not detected.";
                buttonStart.Enabled = false;
                return false;
            }

            return true;
        }

        private bool InitPowerSensor()
        {
            try
            {
                pPwrSensor = PowerSensor.FpPwr_Instantiate();
                buttonStart.Enabled = true;
                UpdateReadings();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Power Sensor hardware not detected.\n" + ex.Message);
                labelState.Text = "Power Sensor hardware not detected.";
                buttonStart.Enabled = false;
                return false;
            }

            return true;
        }


        private void OpenMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV Log files (*.csv)|*.csv|All files (*.*)|*.*";
            ofd.Multiselect = false;
            ofd.Title = "Select CSV Log file";
            ofd.CheckFileExists = false;    // allow user to specify a new file
            ofd.InitialDirectory = @"C:\Temp";
            ofd.RestoreDirectory = true;
            string csvHeaderSep = "sep=,";
            string csvHeaderTitles = "Date,Top Temperature(°C),CPU Temperature(°C),Bus Voltage(V),Current(A),Power(W)";
            string selectedPath = "";
            bool addCSVheader = false;

            // We must run the OpenFileDialog in its own thread see 
            // ApartmentState.MTA vs ApartmentState.STA (default) 
            Thread t = new Thread((ThreadStart)(() =>
            {

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedPath = ofd.FileName;
                }
            }));

            // Run your code from a thread that joins the STA Thread
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();

            // check if the file exists
            if (!System.IO.File.Exists(selectedPath))
            {
                addCSVheader = true;
            }

            // Create or Append to the selected file
            if (selectedPath != "")
            {
                try
                {
                    logFile = new StreamWriter(selectedPath, true);

                    closeMenuItem.Enabled = true;
                    openMenuItem.Enabled = false;

                    // Add the header information on a new file
                    if (addCSVheader)
                    {
                        logFile.WriteLine(csvHeaderSep);
                        logFile.WriteLine(csvHeaderTitles);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error opening file: {ex.Message}");
                }
            }

        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            if (logFile != null)
            {
                logFile.Close();
            }
            this.Close();
        }

        private void CloseMenuItem_Click(object sender, EventArgs e)
        {
            logFile.Close();
            logFile = null;
            closeMenuItem.Enabled = false;
            openMenuItem.Enabled = true;
        }

        private void UpdateReadings()
        {
            if (pTempSensor != 0)
            {
                double temperature = TempSensors.FpTS_getTemperature(pTempSensor, TempSensors.TEMP_SENSOR.TOP);
                labelTTop.Text = temperature.ToString("0.00");

                temperature = TempSensors.FpTS_getTemperature(pTempSensor, TempSensors.TEMP_SENSOR.CPU);
                labelTCPU.Text = temperature.ToString("0.00");
            }

            if (pPwrSensor != 0)
            {
                labelBusV.Text = PowerSensor.FpPwr_getBusVoltage(pPwrSensor).ToString("0.00");
                labelCurrent.Text = PowerSensor.FpPwr_getCurrent(pPwrSensor).ToString("0.000");
                labelPower.Text = PowerSensor.FpPwr_getPower(pPwrSensor).ToString("0.00");
            }

            // If logging is enabled, the output a new CSV row of data
            if (logFile != null)
            {
                string csv = DateTime.Now.ToString() + "," + labelTTop.Text + "," + labelTCPU.Text +
                                "," + labelBusV.Text + "," + labelCurrent.Text + "," + labelPower.Text;
                logFile.WriteLine(csv);
            }

        }

        private async void buttonStart_Click(object sender, EventArgs e)
        {
            labelState.Text = "running";
            buttonStart.Enabled = false;
            buttonStop.Enabled = true;
            doUpdate = true;

            // start asynchronous operation
            await Task.Run(() =>
            {
                TimeConsumingOperation();
            });

        }

        // Cancel background task
        private void buttonStop_Click(object sender, EventArgs e)
        {
            labelState.Text = "stopped";
            buttonStart.Enabled = true;
            buttonStop.Enabled = false;
            doUpdate = false;
        }

        private void InvokeUI(Action a)
        {
            this.BeginInvoke(new MethodInvoker(a));
        }

        // time consuming operation
        private void TimeConsumingOperation()
        {

            while (doUpdate)
            {
                InvokeUI(() =>
                {
                    UpdateReadings();

                });
                System.Threading.Thread.Sleep(updateRate * 1000);
            }
        }

        private void numericRate_ValueChanged(object sender, EventArgs e)
        {
            updateRate = (Int32)numericRate.Value;
        }

    }
}
