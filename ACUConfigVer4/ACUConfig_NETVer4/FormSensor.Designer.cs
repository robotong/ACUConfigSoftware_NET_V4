namespace ACUConfig_NETVer4
{
    partial class FormSensor
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
            this.components = new System.ComponentModel.Container();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.buttonRead = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxSensorNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxDataRegAddress = new System.Windows.Forms.TextBox();
            this.comboBoxSensorState = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSensorAddress = new System.Windows.Forms.TextBox();
            this.textBoxSensorNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDataQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDataFirstAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSensorSerialNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSensorNo = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonWrite
            // 
            this.buttonWrite.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonWrite.Location = new System.Drawing.Point(144, 287);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(75, 23);
            this.buttonWrite.TabIndex = 9;
            this.buttonWrite.Text = "写入";
            this.buttonWrite.UseVisualStyleBackColor = true;
            this.buttonWrite.Click += new System.EventHandler(this.buttonWrite_Click);
            // 
            // buttonRead
            // 
            this.buttonRead.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonRead.Location = new System.Drawing.Point(20, 287);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(75, 23);
            this.buttonRead.TabIndex = 8;
            this.buttonRead.Text = "读取";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBoxSensorNumber);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBoxDataRegAddress);
            this.groupBox1.Controls.Add(this.comboBoxSensorState);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxSensorAddress);
            this.groupBox1.Controls.Add(this.textBoxSensorNo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxDataQuantity);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxDataFirstAddress);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxSensorSerialNumber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 243);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参数配置";
            // 
            // textBoxSensorNumber
            // 
            this.textBoxSensorNumber.Location = new System.Drawing.Point(107, 47);
            this.textBoxSensorNumber.Name = "textBoxSensorNumber";
            this.textBoxSensorNumber.Size = new System.Drawing.Size(100, 21);
            this.textBoxSensorNumber.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 22;
            this.label9.Text = "传感器序号";
            // 
            // textBoxDataRegAddress
            // 
            this.textBoxDataRegAddress.Location = new System.Drawing.Point(107, 182);
            this.textBoxDataRegAddress.Name = "textBoxDataRegAddress";
            this.textBoxDataRegAddress.Size = new System.Drawing.Size(100, 21);
            this.textBoxDataRegAddress.TabIndex = 21;
            // 
            // comboBoxSensorState
            // 
            this.comboBoxSensorState.Enabled = false;
            this.comboBoxSensorState.FormattingEnabled = true;
            this.comboBoxSensorState.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.comboBoxSensorState.Location = new System.Drawing.Point(107, 209);
            this.comboBoxSensorState.Name = "comboBoxSensorState";
            this.comboBoxSensorState.Size = new System.Drawing.Size(100, 20);
            this.comboBoxSensorState.TabIndex = 11;
            this.comboBoxSensorState.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 20;
            this.label7.Text = "在线状态";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "数据在REG中地址";
            // 
            // textBoxSensorAddress
            // 
            this.textBoxSensorAddress.Location = new System.Drawing.Point(107, 74);
            this.textBoxSensorAddress.Name = "textBoxSensorAddress";
            this.textBoxSensorAddress.Size = new System.Drawing.Size(100, 21);
            this.textBoxSensorAddress.TabIndex = 17;
            // 
            // textBoxSensorNo
            // 
            this.textBoxSensorNo.Location = new System.Drawing.Point(107, 20);
            this.textBoxSensorNo.Name = "textBoxSensorNo";
            this.textBoxSensorNo.ReadOnly = true;
            this.textBoxSensorNo.Size = new System.Drawing.Size(100, 21);
            this.textBoxSensorNo.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "当前序号";
            // 
            // textBoxDataQuantity
            // 
            this.textBoxDataQuantity.Location = new System.Drawing.Point(107, 155);
            this.textBoxDataQuantity.Name = "textBoxDataQuantity";
            this.textBoxDataQuantity.Size = new System.Drawing.Size(100, 21);
            this.textBoxDataQuantity.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "数据个数";
            // 
            // textBoxDataFirstAddress
            // 
            this.textBoxDataFirstAddress.Location = new System.Drawing.Point(107, 128);
            this.textBoxDataFirstAddress.Name = "textBoxDataFirstAddress";
            this.textBoxDataFirstAddress.Size = new System.Drawing.Size(100, 21);
            this.textBoxDataFirstAddress.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "数据首地址";
            // 
            // textBoxSensorSerialNumber
            // 
            this.textBoxSensorSerialNumber.Location = new System.Drawing.Point(107, 101);
            this.textBoxSensorSerialNumber.Name = "textBoxSensorSerialNumber";
            this.textBoxSensorSerialNumber.Size = new System.Drawing.Size(100, 21);
            this.textBoxSensorSerialNumber.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "传感器序列号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "传感器地址";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "传感器序号";
            // 
            // comboBoxSensorNo
            // 
            this.comboBoxSensorNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSensorNo.FormattingEnabled = true;
            this.comboBoxSensorNo.Location = new System.Drawing.Point(101, 12);
            this.comboBoxSensorNo.Name = "comboBoxSensorNo";
            this.comboBoxSensorNo.Size = new System.Drawing.Size(100, 20);
            this.comboBoxSensorNo.TabIndex = 5;
            this.comboBoxSensorNo.SelectedIndexChanged += new System.EventHandler(this.comboBoxSensorNo_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 318);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(241, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormSensor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 340);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonWrite);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSensorNo);
            this.Name = "FormSensor";
            this.Text = "传感器配置";
            this.Load += new System.EventHandler(this.FormSensor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonWrite;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxSensorNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDataQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDataFirstAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSensorSerialNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSensorNo;
        private System.Windows.Forms.TextBox textBoxSensorAddress;
        private System.Windows.Forms.TextBox textBoxDataRegAddress;
        private System.Windows.Forms.ComboBox comboBoxSensorState;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxSensorNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.Timer timer1;
    }
}