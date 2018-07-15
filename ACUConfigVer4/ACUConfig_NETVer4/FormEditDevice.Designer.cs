namespace ACUConfig_NETVer4
{
    partial class FormEditDevice
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDeviceName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxDestPort = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxDestIP = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBoxWorkMode = new System.Windows.Forms.ComboBox();
            this.textBoxGateway = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxMask = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxIPMode = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxFlowControl = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxStopBits = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxPatity = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxDataBits = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonSet = new System.Windows.Forms.Button();
            this.buttonDefault = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "设备名称";
            // 
            // textBoxDeviceName
            // 
            this.textBoxDeviceName.Location = new System.Drawing.Point(77, 12);
            this.textBoxDeviceName.Name = "textBoxDeviceName";
            this.textBoxDeviceName.Size = new System.Drawing.Size(86, 21);
            this.textBoxDeviceName.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxDestPort);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.textBoxDestIP);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.comboBoxWorkMode);
            this.groupBox2.Controls.Add(this.textBoxGateway);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxMask);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxPort);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxIP);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBoxIPMode);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 245);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "网络设置";
            // 
            // textBoxDestPort
            // 
            this.textBoxDestPort.Location = new System.Drawing.Point(89, 216);
            this.textBoxDestPort.Name = "textBoxDestPort";
            this.textBoxDestPort.Size = new System.Drawing.Size(114, 21);
            this.textBoxDestPort.TabIndex = 15;
            this.textBoxDestPort.Text = "255.255.255.255";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 219);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 16;
            this.label13.Text = "目标端口";
            // 
            // textBoxDestIP
            // 
            this.textBoxDestIP.Location = new System.Drawing.Point(89, 186);
            this.textBoxDestIP.Name = "textBoxDestIP";
            this.textBoxDestIP.Size = new System.Drawing.Size(114, 21);
            this.textBoxDestIP.TabIndex = 13;
            this.textBoxDestIP.Text = "255.255.255.255";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 189);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 12);
            this.label14.TabIndex = 14;
            this.label14.Text = "目的IP或域名";
            // 
            // comboBoxWorkMode
            // 
            this.comboBoxWorkMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWorkMode.FormattingEnabled = true;
            this.comboBoxWorkMode.Items.AddRange(new object[] {
            "TCP 服务器",
            "TCP 客户端",
            "UDP",
            "UDP 组播"});
            this.comboBoxWorkMode.Location = new System.Drawing.Point(89, 103);
            this.comboBoxWorkMode.Name = "comboBoxWorkMode";
            this.comboBoxWorkMode.Size = new System.Drawing.Size(114, 20);
            this.comboBoxWorkMode.TabIndex = 12;
            // 
            // textBoxGateway
            // 
            this.textBoxGateway.Location = new System.Drawing.Point(89, 159);
            this.textBoxGateway.Name = "textBoxGateway";
            this.textBoxGateway.Size = new System.Drawing.Size(114, 21);
            this.textBoxGateway.TabIndex = 10;
            this.textBoxGateway.Text = "255.255.255.255";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "网关";
            // 
            // textBoxMask
            // 
            this.textBoxMask.Location = new System.Drawing.Point(89, 129);
            this.textBoxMask.Name = "textBoxMask";
            this.textBoxMask.Size = new System.Drawing.Size(114, 21);
            this.textBoxMask.TabIndex = 8;
            this.textBoxMask.Text = "255.255.255.255";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "子网掩码";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "工作模式";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(89, 76);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(114, 21);
            this.textBoxPort.TabIndex = 4;
            this.textBoxPort.Text = "255.255.255.255";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "端口";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(89, 49);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(114, 21);
            this.textBoxIP.TabIndex = 2;
            this.textBoxIP.Text = "255.255.255.255";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "IP地址";
            // 
            // comboBoxIPMode
            // 
            this.comboBoxIPMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIPMode.FormattingEnabled = true;
            this.comboBoxIPMode.Items.AddRange(new object[] {
            "静态",
            "动态"});
            this.comboBoxIPMode.Location = new System.Drawing.Point(89, 23);
            this.comboBoxIPMode.Name = "comboBoxIPMode";
            this.comboBoxIPMode.Size = new System.Drawing.Size(114, 20);
            this.comboBoxIPMode.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP模式";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxFlowControl);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.comboBoxStopBits);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.comboBoxPatity);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.comboBoxDataBits);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.comboBoxBaudRate);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(12, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 156);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "串口设置";
            // 
            // comboBoxFlowControl
            // 
            this.comboBoxFlowControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFlowControl.FormattingEnabled = true;
            this.comboBoxFlowControl.Items.AddRange(new object[] {
            "无",
            "CTS/RTS",
            "DTR/DSR",
            "XON/XOFF"});
            this.comboBoxFlowControl.Location = new System.Drawing.Point(65, 124);
            this.comboBoxFlowControl.Name = "comboBoxFlowControl";
            this.comboBoxFlowControl.Size = new System.Drawing.Size(121, 20);
            this.comboBoxFlowControl.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 11;
            this.label12.Text = "流控";
            // 
            // comboBoxStopBits
            // 
            this.comboBoxStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStopBits.FormattingEnabled = true;
            this.comboBoxStopBits.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBoxStopBits.Location = new System.Drawing.Point(65, 98);
            this.comboBoxStopBits.Name = "comboBoxStopBits";
            this.comboBoxStopBits.Size = new System.Drawing.Size(121, 20);
            this.comboBoxStopBits.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 9;
            this.label11.Text = "停止位";
            // 
            // comboBoxPatity
            // 
            this.comboBoxPatity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPatity.FormattingEnabled = true;
            this.comboBoxPatity.Items.AddRange(new object[] {
            "无校验",
            "奇校验",
            "偶校验",
            "标记",
            "空格"});
            this.comboBoxPatity.Location = new System.Drawing.Point(65, 72);
            this.comboBoxPatity.Name = "comboBoxPatity";
            this.comboBoxPatity.Size = new System.Drawing.Size(121, 20);
            this.comboBoxPatity.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 7;
            this.label10.Text = "校验位";
            // 
            // comboBoxDataBits
            // 
            this.comboBoxDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDataBits.FormattingEnabled = true;
            this.comboBoxDataBits.Items.AddRange(new object[] {
            "8位",
            "7位",
            "6位",
            "5位"});
            this.comboBoxDataBits.Location = new System.Drawing.Point(65, 46);
            this.comboBoxDataBits.Name = "comboBoxDataBits";
            this.comboBoxDataBits.Size = new System.Drawing.Size(121, 20);
            this.comboBoxDataBits.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 5;
            this.label9.Text = "数据位";
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "7200",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "76800",
            "115200",
            "240800",
            "460800"});
            this.comboBoxBaudRate.Location = new System.Drawing.Point(65, 20);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(121, 20);
            this.comboBoxBaudRate.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "波特率";
            // 
            // buttonSet
            // 
            this.buttonSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSet.Location = new System.Drawing.Point(357, 263);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(75, 23);
            this.buttonSet.TabIndex = 4;
            this.buttonSet.Text = "修改设置";
            this.buttonSet.UseVisualStyleBackColor = true;
            this.buttonSet.Click += new System.EventHandler(this.buttonSet_Click);
            // 
            // buttonDefault
            // 
            this.buttonDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDefault.Location = new System.Drawing.Point(12, 263);
            this.buttonDefault.Name = "buttonDefault";
            this.buttonDefault.Size = new System.Drawing.Size(91, 23);
            this.buttonDefault.TabIndex = 5;
            this.buttonDefault.Text = "恢复默认参数";
            this.buttonDefault.UseVisualStyleBackColor = true;
            this.buttonDefault.Click += new System.EventHandler(this.buttonDefault_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSave.Location = new System.Drawing.Point(109, 263);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(91, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "保存当前参数";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLoad.Location = new System.Drawing.Point(206, 263);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(91, 23);
            this.buttonLoad.TabIndex = 7;
            this.buttonLoad.Text = "加载保存参数";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // FormEditDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 298);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDefault);
            this.Controls.Add(this.buttonSet);
            this.Controls.Add(this.textBoxDeviceName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormEditDevice";
            this.Text = "设备设置";
            this.Load += new System.EventHandler(this.FormEditDevice_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDeviceName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxWorkMode;
        private System.Windows.Forms.TextBox textBoxGateway;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxMask;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxIPMode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxFlowControl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxStopBits;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxPatity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxDataBits;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonSet;
        private System.Windows.Forms.Button buttonDefault;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.TextBox textBoxDestPort;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxDestIP;
        private System.Windows.Forms.Label label14;
    }
}