namespace Klimatyzacja
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.InsideLabel = new System.Windows.Forms.Label();
            this.AirLabel = new System.Windows.Forms.Label();
            this.OutsideLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.OBox = new System.Windows.Forms.TextBox();
            this.MaterialLabel = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.Pb1 = new System.Windows.Forms.PictureBox();
            this.Pb2 = new System.Windows.Forms.PictureBox();
            this.Logs = new System.Windows.Forms.RichTextBox();
            this.LogLabel = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.ScenarioLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.DesiredBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.StpBtn = new System.Windows.Forms.Button();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            this.SuspendLayout();
            // 
            // IBox
            // 
            this.IBox.Enabled = false;
            this.IBox.Location = new System.Drawing.Point(203, 440);
            this.IBox.Name = "IBox";
            this.IBox.Size = new System.Drawing.Size(100, 20);
            this.IBox.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(545, 440);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // InsideLabel
            // 
            this.InsideLabel.AutoSize = true;
            this.InsideLabel.Location = new System.Drawing.Point(200, 404);
            this.InsideLabel.Name = "InsideLabel";
            this.InsideLabel.Size = new System.Drawing.Size(98, 13);
            this.InsideLabel.TabIndex = 5;
            this.InsideLabel.Text = "Temperautre Inside";
            // 
            // AirLabel
            // 
            this.AirLabel.AutoSize = true;
            this.AirLabel.Location = new System.Drawing.Point(514, 404);
            this.AirLabel.Name = "AirLabel";
            this.AirLabel.Size = new System.Drawing.Size(178, 13);
            this.AirLabel.TabIndex = 6;
            this.AirLabel.Text = "Air Conditioning Supply Temperautre";
            // 
            // OutsideLabel
            // 
            this.OutsideLabel.AutoSize = true;
            this.OutsideLabel.Location = new System.Drawing.Point(20, 404);
            this.OutsideLabel.Name = "OutsideLabel";
            this.OutsideLabel.Size = new System.Drawing.Size(106, 13);
            this.OutsideLabel.TabIndex = 7;
            this.OutsideLabel.Text = "Temperature Outside";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Winter (-18, -10)",
            "Summer (15, 27)",
            "Roll (-20, 20)"});
            this.comboBox1.Location = new System.Drawing.Point(65, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // OBox
            // 
            this.OBox.Enabled = false;
            this.OBox.Location = new System.Drawing.Point(26, 440);
            this.OBox.Name = "OBox";
            this.OBox.Size = new System.Drawing.Size(100, 20);
            this.OBox.TabIndex = 9;
            // 
            // MaterialLabel
            // 
            this.MaterialLabel.AutoSize = true;
            this.MaterialLabel.Location = new System.Drawing.Point(346, 23);
            this.MaterialLabel.Name = "MaterialLabel";
            this.MaterialLabel.Size = new System.Drawing.Size(49, 13);
            this.MaterialLabel.TabIndex = 10;
            this.MaterialLabel.Text = "Materials";
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.GrayText;
            this.trackBar1.Location = new System.Drawing.Point(203, 487);
            this.trackBar1.Maximum = 30;
            this.trackBar1.Minimum = 10;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 11;
            this.trackBar1.Value = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.BackColor = System.Drawing.SystemColors.GrayText;
            this.trackBar2.Location = new System.Drawing.Point(26, 487);
            this.trackBar2.Maximum = 30;
            this.trackBar2.Minimum = -20;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(104, 45);
            this.trackBar2.TabIndex = 12;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // Pb1
            // 
            this.Pb1.Location = new System.Drawing.Point(23, 91);
            this.Pb1.Name = "Pb1";
            this.Pb1.Size = new System.Drawing.Size(211, 269);
            this.Pb1.TabIndex = 13;
            this.Pb1.TabStop = false;
            // 
            // Pb2
            // 
            this.Pb2.Location = new System.Drawing.Point(291, 91);
            this.Pb2.Name = "Pb2";
            this.Pb2.Size = new System.Drawing.Size(159, 269);
            this.Pb2.TabIndex = 14;
            this.Pb2.TabStop = false;
            // 
            // Logs
            // 
            this.Logs.Location = new System.Drawing.Point(583, 91);
            this.Logs.Name = "Logs";
            this.Logs.Size = new System.Drawing.Size(306, 269);
            this.Logs.TabIndex = 15;
            this.Logs.Text = "";
            // 
            // LogLabel
            // 
            this.LogLabel.AutoSize = true;
            this.LogLabel.Location = new System.Drawing.Point(661, 63);
            this.LogLabel.Name = "LogLabel";
            this.LogLabel.Size = new System.Drawing.Size(133, 13);
            this.LogLabel.TabIndex = 16;
            this.LogLabel.Text = "Temperature Change Logs";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Wood",
            "Brick",
            "Reinforce Concrete"});
            this.comboBox2.Location = new System.Drawing.Point(311, 49);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // ScenarioLabel
            // 
            this.ScenarioLabel.AutoSize = true;
            this.ScenarioLabel.Location = new System.Drawing.Point(104, 23);
            this.ScenarioLabel.Name = "ScenarioLabel";
            this.ScenarioLabel.Size = new System.Drawing.Size(49, 13);
            this.ScenarioLabel.TabIndex = 18;
            this.ScenarioLabel.Text = "Scenario";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 36);
            this.button1.TabIndex = 19;
            this.button1.Text = "Generate Scenarios";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(710, 415);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(84, 45);
            this.StartBtn.TabIndex = 20;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // DesiredBox
            // 
            this.DesiredBox.Enabled = false;
            this.DesiredBox.Location = new System.Drawing.Point(370, 440);
            this.DesiredBox.Name = "DesiredBox";
            this.DesiredBox.Size = new System.Drawing.Size(100, 20);
            this.DesiredBox.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Desired Temperature";
            // 
            // trackBar3
            // 
            this.trackBar3.BackColor = System.Drawing.SystemColors.GrayText;
            this.trackBar3.Location = new System.Drawing.Point(370, 487);
            this.trackBar3.Maximum = 30;
            this.trackBar3.Minimum = 10;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(104, 45);
            this.trackBar3.TabIndex = 23;
            this.trackBar3.Value = 10;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // StpBtn
            // 
            this.StpBtn.Location = new System.Drawing.Point(810, 415);
            this.StpBtn.Name = "StpBtn";
            this.StpBtn.Size = new System.Drawing.Size(79, 45);
            this.StpBtn.TabIndex = 24;
            this.StpBtn.Text = "Stop";
            this.StpBtn.UseVisualStyleBackColor = true;
            this.StpBtn.Click += new System.EventHandler(this.StpBtn_Click);
            // 
            // trackBar4
            // 
            this.trackBar4.BackColor = System.Drawing.SystemColors.GrayText;
            this.trackBar4.Enabled = false;
            this.trackBar4.LargeChange = 0;
            this.trackBar4.Location = new System.Drawing.Point(497, 107);
            this.trackBar4.Maximum = 50;
            this.trackBar4.Minimum = -50;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar4.Size = new System.Drawing.Size(45, 253);
            this.trackBar4.TabIndex = 25;
            this.trackBar4.Value = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "  Heating";
            // 
            // trackBar5
            // 
            this.trackBar5.BackColor = System.Drawing.SystemColors.GrayText;
            this.trackBar5.Location = new System.Drawing.Point(545, 487);
            this.trackBar5.Maximum = 50;
            this.trackBar5.Minimum = -20;
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Size = new System.Drawing.Size(104, 45);
            this.trackBar5.TabIndex = 27;
            this.trackBar5.Value = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(901, 544);
            this.Controls.Add(this.trackBar5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar4);
            this.Controls.Add(this.StpBtn);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DesiredBox);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ScenarioLabel);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.LogLabel);
            this.Controls.Add(this.Logs);
            this.Controls.Add(this.Pb2);
            this.Controls.Add(this.Pb1);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.MaterialLabel);
            this.Controls.Add(this.OBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.OutsideLabel);
            this.Controls.Add(this.AirLabel);
            this.Controls.Add(this.InsideLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.IBox);
            this.Name = "Form1";
            this.Text = "Klimatyzacja";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox IBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label InsideLabel;
        private System.Windows.Forms.Label AirLabel;
        private System.Windows.Forms.Label OutsideLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox OBox;
        private System.Windows.Forms.Label MaterialLabel;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.PictureBox Pb1;
        private System.Windows.Forms.PictureBox Pb2;
        private System.Windows.Forms.RichTextBox Logs;
        private System.Windows.Forms.Label LogLabel;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label ScenarioLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.TextBox DesiredBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Button StpBtn;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar5;
    }
}

