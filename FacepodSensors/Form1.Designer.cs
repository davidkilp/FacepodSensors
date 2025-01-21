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
            labelTCPU = new Label();
            label3 = new Label();
            labelTTop = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            labelCurrent = new Label();
            label6 = new Label();
            labelBusV = new Label();
            label5 = new Label();
            labelPower = new Label();
            label2 = new Label();
            buttonStart = new Button();
            buttonStop = new Button();
            labelState = new Label();
            groupBox3 = new GroupBox();
            label4 = new Label();
            numericRate = new NumericUpDown();
            openFileDialog1 = new OpenFileDialog();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericRate).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelTCPU);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(labelTTop);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(28, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(321, 121);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Temperature";
            // 
            // labelTCPU
            // 
            labelTCPU.AutoSize = true;
            labelTCPU.Location = new Point(225, 73);
            labelTCPU.Name = "labelTCPU";
            labelTCPU.Size = new Size(45, 25);
            labelTCPU.TabIndex = 3;
            labelTCPU.Text = "N/A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 73);
            label3.Name = "label3";
            label3.Size = new Size(199, 25);
            label3.TabIndex = 2;
            label3.Text = "Temperature CPU (°C):";
            // 
            // labelTTop
            // 
            labelTTop.AutoSize = true;
            labelTTop.Location = new Point(225, 39);
            labelTTop.Name = "labelTTop";
            labelTTop.Size = new Size(45, 25);
            labelTTop.TabIndex = 1;
            labelTTop.Text = "N/A";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 39);
            label1.Name = "label1";
            label1.Size = new Size(193, 25);
            label1.TabIndex = 0;
            label1.Text = "Temperature Top (°C):";
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
            groupBox2.Location = new Point(28, 177);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(321, 154);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Power";
            // 
            // labelCurrent
            // 
            labelCurrent.AutoSize = true;
            labelCurrent.Location = new Point(222, 109);
            labelCurrent.Name = "labelCurrent";
            labelCurrent.Size = new Size(45, 25);
            labelCurrent.TabIndex = 5;
            labelCurrent.Text = "N/A";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 109);
            label6.Name = "label6";
            label6.Size = new Size(109, 25);
            label6.TabIndex = 4;
            label6.Text = "Current (A):";
            // 
            // labelBusV
            // 
            labelBusV.AutoSize = true;
            labelBusV.Location = new Point(222, 68);
            labelBusV.Name = "labelBusV";
            labelBusV.Size = new Size(45, 25);
            labelBusV.TabIndex = 3;
            labelBusV.Text = "N/A";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 68);
            label5.Name = "label5";
            label5.Size = new Size(144, 25);
            label5.TabIndex = 2;
            label5.Text = "Bus Voltage (V):";
            // 
            // labelPower
            // 
            labelPower.AutoSize = true;
            labelPower.Location = new Point(222, 32);
            labelPower.Name = "labelPower";
            labelPower.Size = new Size(45, 25);
            labelPower.TabIndex = 1;
            labelPower.Text = "N/A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 32);
            label2.Name = "label2";
            label2.Size = new Size(103, 25);
            label2.TabIndex = 0;
            label2.Text = "Power (W):";
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
            buttonStop.Location = new Point(130, 28);
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
            labelState.Location = new Point(28, 545);
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
            groupBox3.Location = new Point(28, 348);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(321, 171);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Continous Updates";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 100);
            label4.Name = "label4";
            label4.Size = new Size(109, 32);
            label4.TabIndex = 6;
            label4.Text = "Rate/sec:";
            // 
            // numericRate
            // 
            numericRate.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericRate.Location = new Point(130, 93);
            numericRate.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numericRate.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericRate.Name = "numericRate";
            numericRate.Size = new Size(120, 39);
            numericRate.TabIndex = 5;
            numericRate.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericRate.ValueChanged += numericRate_ValueChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 604);
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
    }
}
