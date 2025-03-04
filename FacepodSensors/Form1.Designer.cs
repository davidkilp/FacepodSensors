namespace FacepodSensors
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label7 = new Label();
            labelTCPU = new Label();
            label3 = new Label();
            labelTTop = new Label();
            label1 = new Label();
            labelSystemT = new Label();
            label14 = new Label();
            labelChipsetT = new Label();
            label12 = new Label();
            labelCPUT = new Label();
            label10 = new Label();
            label8 = new Label();
            groupBox2 = new GroupBox();
            labelCurrent = new Label();
            label6 = new Label();
            labelBusV = new Label();
            label5 = new Label();
            labelPower = new Label();
            label2 = new Label();
            labelVbat = new Label();
            label20 = new Label();
            label12V = new Label();
            label18 = new Label();
            label5V = new Label();
            label16 = new Label();
            buttonStart = new Button();
            buttonStop = new Button();
            labelState = new Label();
            groupBox3 = new GroupBox();
            label4 = new Label();
            numericRate = new NumericUpDown();
            openFileDialog1 = new OpenFileDialog();
            groupBox4 = new GroupBox();
            labelFanRpm = new Label();
            label13 = new Label();
            label9 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericRate).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(labelTCPU);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(labelTTop);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(211, 129);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Carrier Board";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 29);
            label7.Name = "label7";
            label7.Size = new Size(192, 25);
            label7.TabIndex = 4;
            label7.Text = "Temperature Sensors:";
            // 
            // labelTCPU
            // 
            labelTCPU.AutoSize = true;
            labelTCPU.Location = new Point(130, 86);
            labelTCPU.Name = "labelTCPU";
            labelTCPU.Size = new Size(45, 25);
            labelTCPU.TabIndex = 3;
            labelTCPU.Text = "N/A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 86);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 2;
            label3.Text = "CPU (°C):";
            // 
            // labelTTop
            // 
            labelTTop.AutoSize = true;
            labelTTop.Location = new Point(130, 61);
            labelTTop.Name = "labelTTop";
            labelTTop.Size = new Size(45, 25);
            labelTTop.TabIndex = 1;
            labelTTop.Text = "N/A";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 61);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 0;
            label1.Text = "Top (°C):";
            // 
            // labelSystemT
            // 
            labelSystemT.AutoSize = true;
            labelSystemT.Location = new Point(127, 104);
            labelSystemT.Name = "labelSystemT";
            labelSystemT.Size = new Size(45, 25);
            labelSystemT.TabIndex = 11;
            labelSystemT.Text = "N/A";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 104);
            label14.Name = "label14";
            label14.Size = new Size(110, 25);
            label14.TabIndex = 10;
            label14.Text = "System (°C):";
            // 
            // labelChipsetT
            // 
            labelChipsetT.AutoSize = true;
            labelChipsetT.Location = new Point(126, 79);
            labelChipsetT.Name = "labelChipsetT";
            labelChipsetT.Size = new Size(45, 25);
            labelChipsetT.TabIndex = 9;
            labelChipsetT.Text = "N/A";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 79);
            label12.Name = "label12";
            label12.Size = new Size(115, 25);
            label12.TabIndex = 8;
            label12.Text = "Chipset (°C):";
            // 
            // labelCPUT
            // 
            labelCPUT.AutoSize = true;
            labelCPUT.Location = new Point(126, 54);
            labelCPUT.Name = "labelCPUT";
            labelCPUT.Size = new Size(45, 25);
            labelCPUT.TabIndex = 7;
            labelCPUT.Text = "N/A";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 54);
            label10.Name = "label10";
            label10.Size = new Size(88, 25);
            label10.TabIndex = 6;
            label10.Text = "CPU (°C):";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 29);
            label8.Name = "label8";
            label8.Size = new Size(192, 25);
            label8.TabIndex = 5;
            label8.Text = "Temperature Sensors:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(labelCurrent);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(labelBusV);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(labelPower);
            groupBox2.Controls.Add(label2);
            groupBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 165);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(211, 129);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Input Power";
            // 
            // labelCurrent
            // 
            labelCurrent.AutoSize = true;
            labelCurrent.Location = new Point(130, 79);
            labelCurrent.Name = "labelCurrent";
            labelCurrent.Size = new Size(45, 25);
            labelCurrent.TabIndex = 5;
            labelCurrent.Text = "N/A";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 79);
            label6.Name = "label6";
            label6.Size = new Size(109, 25);
            label6.TabIndex = 4;
            label6.Text = "Current (A):";
            // 
            // labelBusV
            // 
            labelBusV.AutoSize = true;
            labelBusV.Location = new Point(130, 54);
            labelBusV.Name = "labelBusV";
            labelBusV.Size = new Size(45, 25);
            labelBusV.TabIndex = 3;
            labelBusV.Text = "N/A";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 54);
            label5.Name = "label5";
            label5.Size = new Size(110, 25);
            label5.TabIndex = 2;
            label5.Text = "+24V Input:";
            // 
            // labelPower
            // 
            labelPower.AutoSize = true;
            labelPower.Location = new Point(130, 29);
            labelPower.Name = "labelPower";
            labelPower.Size = new Size(45, 25);
            labelPower.TabIndex = 1;
            labelPower.Text = "N/A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 29);
            label2.Name = "label2";
            label2.Size = new Size(103, 25);
            label2.TabIndex = 0;
            label2.Text = "Power (W):";
            // 
            // labelVbat
            // 
            labelVbat.AutoSize = true;
            labelVbat.Location = new Point(126, 214);
            labelVbat.Name = "labelVbat";
            labelVbat.Size = new Size(45, 25);
            labelVbat.TabIndex = 11;
            labelVbat.Text = "N/A";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(6, 214);
            label20.Name = "label20";
            label20.Size = new Size(91, 25);
            label20.TabIndex = 10;
            label20.Text = "RTC Vbat:";
            // 
            // label12V
            // 
            label12V.AutoSize = true;
            label12V.Location = new Point(126, 185);
            label12V.Name = "label12V";
            label12V.Size = new Size(45, 25);
            label12V.TabIndex = 9;
            label12V.Text = "N/A";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(6, 185);
            label18.Name = "label18";
            label18.Size = new Size(61, 25);
            label18.TabIndex = 8;
            label18.Text = "+12V:";
            // 
            // label5V
            // 
            label5V.AutoSize = true;
            label5V.Location = new Point(127, 160);
            label5V.Name = "label5V";
            label5V.Size = new Size(45, 25);
            label5V.TabIndex = 7;
            label5V.Text = "N/A";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(6, 160);
            label16.Name = "label16";
            label16.Size = new Size(51, 25);
            label16.TabIndex = 6;
            label16.Text = "+5V:";
            // 
            // buttonStart
            // 
            buttonStart.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonStart.Location = new Point(6, 28);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(97, 42);
            buttonStart.TabIndex = 3;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonStop
            // 
            buttonStop.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonStop.Location = new Point(109, 28);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(97, 42);
            buttonStop.TabIndex = 4;
            buttonStop.Text = "Stop";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += buttonStop_Click;
            // 
            // labelState
            // 
            labelState.AutoSize = true;
            labelState.Location = new Point(12, 469);
            labelState.Name = "labelState";
            labelState.Size = new Size(29, 15);
            labelState.TabIndex = 5;
            labelState.Text = "N/A";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(numericRate);
            groupBox3.Controls.Add(buttonStop);
            groupBox3.Controls.Add(buttonStart);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(12, 300);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(211, 152);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Continous Updates";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 100);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 6;
            label4.Text = "Rate/sec:";
            // 
            // numericRate
            // 
            numericRate.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericRate.Location = new Point(99, 92);
            numericRate.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numericRate.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericRate.Name = "numericRate";
            numericRate.Size = new Size(76, 39);
            numericRate.TabIndex = 5;
            numericRate.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericRate.ValueChanged += numericRate_ValueChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(labelFanRpm);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(labelSystemT);
            groupBox4.Controls.Add(labelVbat);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(label18);
            groupBox4.Controls.Add(labelChipsetT);
            groupBox4.Controls.Add(label20);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(label16);
            groupBox4.Controls.Add(labelCPUT);
            groupBox4.Controls.Add(label12V);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(label5V);
            groupBox4.Controls.Add(label8);
            groupBox4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(229, 30);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(203, 264);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "COM-Express";
            // 
            // labelFanRpm
            // 
            labelFanRpm.AutoSize = true;
            labelFanRpm.Location = new Point(126, 239);
            labelFanRpm.Name = "labelFanRpm";
            labelFanRpm.Size = new Size(45, 25);
            labelFanRpm.TabIndex = 14;
            labelFanRpm.Text = "N/A";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 239);
            label13.Name = "label13";
            label13.Size = new Size(101, 25);
            label13.TabIndex = 13;
            label13.Text = "Fan (RPM):";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 135);
            label9.Name = "label9";
            label9.Size = new Size(80, 25);
            label9.TabIndex = 12;
            label9.Text = "Voltage:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 507);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(labelState);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Facepod Sensors";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericRate).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label labelTCPU;
        private Label label3;
        private Label labelTTop;
        private GroupBox groupBox2;
        private Label labelBusV;
        private Label label5;
        private Label labelPower;
        private Label label2;
        private Label labelCurrent;
        private Label label6;
        private Button buttonStart;
        private Button buttonStop;
        private Label labelState;
        private GroupBox groupBox3;
        private Label label4;
        private NumericUpDown numericRate;
        private OpenFileDialog openFileDialog1;
        private Label labelCPUT;
        private Label label10;
        private Label label8;
        private Label label7;
        private Label labelSystemT;
        private Label label14;
        private Label labelChipsetT;
        private Label label12;
        private Label labelVbat;
        private Label label20;
        private Label label12V;
        private Label label18;
        private Label label5V;
        private Label label16;
        private GroupBox groupBox4;
        private Label label9;
        private Label labelFanRpm;
        private Label label13;
    }
}
