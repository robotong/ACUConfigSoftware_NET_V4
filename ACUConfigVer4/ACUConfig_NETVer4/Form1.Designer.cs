namespace ACUConfig_NETVer4
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonDeviceManage = new System.Windows.Forms.Button();
            this.textBoxIPAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxRec = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelRecCnt = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelSendCnt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRS485ExtendAddress = new System.Windows.Forms.TextBox();
            this.comboBoxWorkMode = new System.Windows.Forms.ComboBox();
            this.comboBoxRS485_4GBaud = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxRS485ExtendBaud = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxRS485SensorBaud = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonModbusWrite1 = new System.Windows.Forms.Button();
            this.buttonModbusRead1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxUpLoadPeriod = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxSensorTotalNum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxAddressACU = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonRelayConfiguration = new System.Windows.Forms.Button();
            this.buttonFormSensor = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonOpenClose = new System.Windows.Forms.Button();
            this.buttonRenewCom = new System.Windows.Forms.Button();
            this.comboBaudrate = new System.Windows.Forms.ComboBox();
            this.labelBaudrate = new System.Windows.Forms.Label();
            this.comboPortName = new System.Windows.Forms.ComboBox();
            this.labelPortName = new System.Windows.Forms.Label();
            this.timerSerialPort = new System.Windows.Forms.Timer(this.components);
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBoxTestValue = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBoxTestRegLength = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxTestRegAdress = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxTestDeviceAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonTestWrite = new System.Windows.Forms.Button();
            this.buttonTestRead = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDeviceManage
            // 
            this.buttonDeviceManage.Location = new System.Drawing.Point(374, 153);
            this.buttonDeviceManage.Name = "buttonDeviceManage";
            this.buttonDeviceManage.Size = new System.Drawing.Size(95, 23);
            this.buttonDeviceManage.TabIndex = 10;
            this.buttonDeviceManage.Text = "设备管理";
            this.buttonDeviceManage.UseVisualStyleBackColor = true;
            this.buttonDeviceManage.Click += new System.EventHandler(this.buttonDeviceManage_Click);
            // 
            // textBoxIPAddress
            // 
            this.textBoxIPAddress.Location = new System.Drawing.Point(58, 20);
            this.textBoxIPAddress.Name = "textBoxIPAddress";
            this.textBoxIPAddress.Size = new System.Drawing.Size(108, 21);
            this.textBoxIPAddress.TabIndex = 11;
            this.textBoxIPAddress.Text = "192.168.1.200";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "IP地址";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "端口";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(207, 20);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(49, 21);
            this.textBoxPort.TabIndex = 13;
            this.textBoxPort.Text = "4196";
            // 
            // textBoxRec
            // 
            this.textBoxRec.Location = new System.Drawing.Point(6, 20);
            this.textBoxRec.Multiline = true;
            this.textBoxRec.Name = "textBoxRec";
            this.textBoxRec.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRec.Size = new System.Drawing.Size(325, 148);
            this.textBoxRec.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelRecCnt);
            this.groupBox1.Controls.Add(this.buttonClear);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxRec);
            this.groupBox1.Location = new System.Drawing.Point(20, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 204);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "接受区";
            // 
            // labelRecCnt
            // 
            this.labelRecCnt.AutoSize = true;
            this.labelRecCnt.Location = new System.Drawing.Point(89, 179);
            this.labelRecCnt.Name = "labelRecCnt";
            this.labelRecCnt.Size = new System.Drawing.Size(11, 12);
            this.labelRecCnt.TabIndex = 20;
            this.labelRecCnt.Text = "0";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(240, 174);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(69, 23);
            this.buttonClear.TabIndex = 19;
            this.buttonClear.Text = "清除";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "接收字节数：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonConnect);
            this.groupBox2.Controls.Add(this.textBoxPort);
            this.groupBox2.Controls.Add(this.textBoxIPAddress);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(20, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 51);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Socket设置区";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(262, 18);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(69, 23);
            this.buttonConnect.TabIndex = 18;
            this.buttonConnect.Text = "连接";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnet_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelSendCnt);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.buttonSend);
            this.groupBox3.Controls.Add(this.textBoxSend);
            this.groupBox3.Location = new System.Drawing.Point(20, 335);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(340, 92);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发送区";
            // 
            // labelSendCnt
            // 
            this.labelSendCnt.AutoSize = true;
            this.labelSendCnt.Location = new System.Drawing.Point(89, 65);
            this.labelSendCnt.Name = "labelSendCnt";
            this.labelSendCnt.Size = new System.Drawing.Size(11, 12);
            this.labelSendCnt.TabIndex = 23;
            this.labelSendCnt.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 22;
            this.label6.Text = "发送字节数：";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(240, 60);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(69, 23);
            this.buttonSend.TabIndex = 21;
            this.buttonSend.Text = "发送";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBoxSend
            // 
            this.textBoxSend.Location = new System.Drawing.Point(6, 20);
            this.textBoxSend.Multiline = true;
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(325, 34);
            this.textBoxSend.TabIndex = 16;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.textBoxRS485ExtendAddress);
            this.groupBox5.Controls.Add(this.comboBoxWorkMode);
            this.groupBox5.Controls.Add(this.comboBoxRS485_4GBaud);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.comboBoxRS485ExtendBaud);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.comboBoxRS485SensorBaud);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.buttonModbusWrite1);
            this.groupBox5.Controls.Add(this.buttonModbusRead1);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.textBoxUpLoadPeriod);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.textBoxSensorTotalNum);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.textBoxAddressACU);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(366, 199);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(351, 191);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "配置";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 12);
            this.label4.TabIndex = 44;
            this.label4.Text = "挂载扩展设备地址";
            // 
            // textBoxRS485ExtendAddress
            // 
            this.textBoxRS485ExtendAddress.Location = new System.Drawing.Point(287, 101);
            this.textBoxRS485ExtendAddress.Name = "textBoxRS485ExtendAddress";
            this.textBoxRS485ExtendAddress.Size = new System.Drawing.Size(55, 21);
            this.textBoxRS485ExtendAddress.TabIndex = 43;
            // 
            // comboBoxWorkMode
            // 
            this.comboBoxWorkMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWorkMode.FormattingEnabled = true;
            this.comboBoxWorkMode.Items.AddRange(new object[] {
            "0被动读取",
            "1主动上传"});
            this.comboBoxWorkMode.Location = new System.Drawing.Point(72, 102);
            this.comboBoxWorkMode.Name = "comboBoxWorkMode";
            this.comboBoxWorkMode.Size = new System.Drawing.Size(84, 20);
            this.comboBoxWorkMode.TabIndex = 42;
            // 
            // comboBoxRS485_4GBaud
            // 
            this.comboBoxRS485_4GBaud.FormattingEnabled = true;
            this.comboBoxRS485_4GBaud.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200"});
            this.comboBoxRS485_4GBaud.Location = new System.Drawing.Point(281, 128);
            this.comboBoxRS485_4GBaud.Name = "comboBoxRS485_4GBaud";
            this.comboBoxRS485_4GBaud.Size = new System.Drawing.Size(61, 20);
            this.comboBoxRS485_4GBaud.TabIndex = 39;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(162, 131);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 12);
            this.label13.TabIndex = 38;
            this.label13.Text = "4G通信模块波特率";
            // 
            // comboBoxRS485ExtendBaud
            // 
            this.comboBoxRS485ExtendBaud.FormattingEnabled = true;
            this.comboBoxRS485ExtendBaud.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200"});
            this.comboBoxRS485ExtendBaud.Location = new System.Drawing.Point(281, 75);
            this.comboBoxRS485ExtendBaud.Name = "comboBoxRS485ExtendBaud";
            this.comboBoxRS485ExtendBaud.Size = new System.Drawing.Size(61, 20);
            this.comboBoxRS485ExtendBaud.TabIndex = 37;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(162, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 12);
            this.label12.TabIndex = 36;
            this.label12.Text = "挂载扩展设备波特率";
            // 
            // comboBoxRS485SensorBaud
            // 
            this.comboBoxRS485SensorBaud.FormattingEnabled = true;
            this.comboBoxRS485SensorBaud.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200"});
            this.comboBoxRS485SensorBaud.Location = new System.Drawing.Point(281, 48);
            this.comboBoxRS485SensorBaud.Name = "comboBoxRS485SensorBaud";
            this.comboBoxRS485SensorBaud.Size = new System.Drawing.Size(61, 20);
            this.comboBoxRS485SensorBaud.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(162, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 12);
            this.label11.TabIndex = 34;
            this.label11.Text = "挂载传感器波特率";
            // 
            // buttonModbusWrite1
            // 
            this.buttonModbusWrite1.Location = new System.Drawing.Point(191, 159);
            this.buttonModbusWrite1.Name = "buttonModbusWrite1";
            this.buttonModbusWrite1.Size = new System.Drawing.Size(60, 23);
            this.buttonModbusWrite1.TabIndex = 32;
            this.buttonModbusWrite1.Text = "写入";
            this.buttonModbusWrite1.UseVisualStyleBackColor = true;
            this.buttonModbusWrite1.Click += new System.EventHandler(this.buttonModbusWrite1_Click);
            // 
            // buttonModbusRead1
            // 
            this.buttonModbusRead1.Location = new System.Drawing.Point(82, 159);
            this.buttonModbusRead1.Name = "buttonModbusRead1";
            this.buttonModbusRead1.Size = new System.Drawing.Size(60, 23);
            this.buttonModbusRead1.TabIndex = 31;
            this.buttonModbusRead1.Text = "读取";
            this.buttonModbusRead1.UseVisualStyleBackColor = true;
            this.buttonModbusRead1.Click += new System.EventHandler(this.buttonModbusRead1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 12);
            this.label10.TabIndex = 24;
            this.label10.Text = "上传间隔(MS)";
            // 
            // textBoxUpLoadPeriod
            // 
            this.textBoxUpLoadPeriod.Location = new System.Drawing.Point(101, 128);
            this.textBoxUpLoadPeriod.Name = "textBoxUpLoadPeriod";
            this.textBoxUpLoadPeriod.Size = new System.Drawing.Size(55, 21);
            this.textBoxUpLoadPeriod.TabIndex = 23;
            this.textBoxUpLoadPeriod.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxUpLoadPeriod_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 22;
            this.label9.Text = "工作模式";
            // 
            // textBoxSensorTotalNum
            // 
            this.textBoxSensorTotalNum.Location = new System.Drawing.Point(101, 75);
            this.textBoxSensorTotalNum.Name = "textBoxSensorTotalNum";
            this.textBoxSensorTotalNum.Size = new System.Drawing.Size(55, 21);
            this.textBoxSensorTotalNum.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "挂载设备数";
            // 
            // textBoxAddressACU
            // 
            this.textBoxAddressACU.Location = new System.Drawing.Point(101, 48);
            this.textBoxAddressACU.Name = "textBoxAddressACU";
            this.textBoxAddressACU.Size = new System.Drawing.Size(55, 21);
            this.textBoxAddressACU.TabIndex = 15;
            this.textBoxAddressACU.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxAddressACU_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "ACU地址";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(240, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(285, 24);
            this.label15.TabIndex = 23;
            this.label15.Text = "智能网关控制器配置软件";
            // 
            // buttonRelayConfiguration
            // 
            this.buttonRelayConfiguration.Location = new System.Drawing.Point(480, 153);
            this.buttonRelayConfiguration.Name = "buttonRelayConfiguration";
            this.buttonRelayConfiguration.Size = new System.Drawing.Size(95, 23);
            this.buttonRelayConfiguration.TabIndex = 25;
            this.buttonRelayConfiguration.Text = "继电器配置";
            this.buttonRelayConfiguration.UseVisualStyleBackColor = true;
            this.buttonRelayConfiguration.Click += new System.EventHandler(this.buttonRelayConfiguration_Click);
            // 
            // buttonFormSensor
            // 
            this.buttonFormSensor.Location = new System.Drawing.Point(594, 153);
            this.buttonFormSensor.Name = "buttonFormSensor";
            this.buttonFormSensor.Size = new System.Drawing.Size(95, 23);
            this.buttonFormSensor.TabIndex = 26;
            this.buttonFormSensor.Text = "传感器配置";
            this.buttonFormSensor.UseVisualStyleBackColor = true;
            this.buttonFormSensor.Click += new System.EventHandler(this.buttonFormSensor_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 517);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(734, 22);
            this.statusStrip1.TabIndex = 27;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonOpenClose);
            this.groupBox4.Controls.Add(this.buttonRenewCom);
            this.groupBox4.Controls.Add(this.comboBaudrate);
            this.groupBox4.Controls.Add(this.labelBaudrate);
            this.groupBox4.Controls.Add(this.comboPortName);
            this.groupBox4.Controls.Add(this.labelPortName);
            this.groupBox4.Location = new System.Drawing.Point(374, 68);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(348, 51);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "串口设置区";
            // 
            // buttonOpenClose
            // 
            this.buttonOpenClose.Location = new System.Drawing.Point(268, 20);
            this.buttonOpenClose.Name = "buttonOpenClose";
            this.buttonOpenClose.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenClose.TabIndex = 88;
            this.buttonOpenClose.Text = "打开串口";
            this.buttonOpenClose.UseVisualStyleBackColor = true;
            this.buttonOpenClose.Click += new System.EventHandler(this.buttonOpenClose_Click);
            // 
            // buttonRenewCom
            // 
            this.buttonRenewCom.Location = new System.Drawing.Point(207, 20);
            this.buttonRenewCom.Name = "buttonRenewCom";
            this.buttonRenewCom.Size = new System.Drawing.Size(55, 23);
            this.buttonRenewCom.TabIndex = 87;
            this.buttonRenewCom.Text = "刷新";
            this.buttonRenewCom.UseVisualStyleBackColor = true;
            this.buttonRenewCom.Click += new System.EventHandler(this.buttonRenewCom_Click);
            // 
            // comboBaudrate
            // 
            this.comboBaudrate.FormattingEnabled = true;
            this.comboBaudrate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "256000"});
            this.comboBaudrate.Location = new System.Drawing.Point(145, 22);
            this.comboBaudrate.Name = "comboBaudrate";
            this.comboBaudrate.Size = new System.Drawing.Size(58, 20);
            this.comboBaudrate.TabIndex = 86;
            this.comboBaudrate.Text = "115200";
            // 
            // labelBaudrate
            // 
            this.labelBaudrate.AutoSize = true;
            this.labelBaudrate.Location = new System.Drawing.Point(98, 25);
            this.labelBaudrate.Name = "labelBaudrate";
            this.labelBaudrate.Size = new System.Drawing.Size(41, 12);
            this.labelBaudrate.TabIndex = 85;
            this.labelBaudrate.Text = "波特率";
            // 
            // comboPortName
            // 
            this.comboPortName.FormattingEnabled = true;
            this.comboPortName.Location = new System.Drawing.Point(41, 22);
            this.comboPortName.Name = "comboPortName";
            this.comboPortName.Size = new System.Drawing.Size(51, 20);
            this.comboPortName.TabIndex = 84;
            // 
            // labelPortName
            // 
            this.labelPortName.AutoSize = true;
            this.labelPortName.Location = new System.Drawing.Point(6, 25);
            this.labelPortName.Name = "labelPortName";
            this.labelPortName.Size = new System.Drawing.Size(29, 12);
            this.labelPortName.TabIndex = 83;
            this.labelPortName.Text = "串口";
            // 
            // timerSerialPort
            // 
            this.timerSerialPort.Interval = 200;
            this.timerSerialPort.Tick += new System.EventHandler(this.timerSerialPort_Tick);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBoxTestValue);
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Controls.Add(this.textBoxTestRegLength);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.textBoxTestRegAdress);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.textBoxTestDeviceAddress);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.buttonTestWrite);
            this.groupBox6.Controls.Add(this.buttonTestRead);
            this.groupBox6.Location = new System.Drawing.Point(366, 396);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(351, 84);
            this.groupBox6.TabIndex = 29;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "测试";
            // 
            // textBoxTestValue
            // 
            this.textBoxTestValue.Location = new System.Drawing.Point(215, 57);
            this.textBoxTestValue.Name = "textBoxTestValue";
            this.textBoxTestValue.Size = new System.Drawing.Size(38, 21);
            this.textBoxTestValue.TabIndex = 45;
            this.textBoxTestValue.Text = "65535";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(180, 60);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(29, 12);
            this.label21.TabIndex = 44;
            this.label21.Text = "数值";
            // 
            // textBoxTestRegLength
            // 
            this.textBoxTestRegLength.Location = new System.Drawing.Point(65, 57);
            this.textBoxTestRegLength.Name = "textBoxTestRegLength";
            this.textBoxTestRegLength.Size = new System.Drawing.Size(38, 21);
            this.textBoxTestRegLength.TabIndex = 41;
            this.textBoxTestRegLength.Text = "1";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 60);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 12);
            this.label19.TabIndex = 40;
            this.label19.Text = "读取数量";
            // 
            // textBoxTestRegAdress
            // 
            this.textBoxTestRegAdress.Location = new System.Drawing.Point(177, 22);
            this.textBoxTestRegAdress.Name = "textBoxTestRegAdress";
            this.textBoxTestRegAdress.Size = new System.Drawing.Size(40, 21);
            this.textBoxTestRegAdress.TabIndex = 39;
            this.textBoxTestRegAdress.Text = "40000";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(106, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 12);
            this.label18.TabIndex = 38;
            this.label18.Text = "寄存器地址";
            // 
            // textBoxTestDeviceAddress
            // 
            this.textBoxTestDeviceAddress.Location = new System.Drawing.Point(65, 22);
            this.textBoxTestDeviceAddress.Name = "textBoxTestDeviceAddress";
            this.textBoxTestDeviceAddress.Size = new System.Drawing.Size(35, 21);
            this.textBoxTestDeviceAddress.TabIndex = 35;
            this.textBoxTestDeviceAddress.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 34;
            this.label8.Text = "设备地址";
            // 
            // buttonTestWrite
            // 
            this.buttonTestWrite.Location = new System.Drawing.Point(259, 55);
            this.buttonTestWrite.Name = "buttonTestWrite";
            this.buttonTestWrite.Size = new System.Drawing.Size(43, 23);
            this.buttonTestWrite.TabIndex = 33;
            this.buttonTestWrite.Text = "写入";
            this.buttonTestWrite.UseVisualStyleBackColor = true;
            this.buttonTestWrite.Click += new System.EventHandler(this.buttonTestWrite_Click);
            // 
            // buttonTestRead
            // 
            this.buttonTestRead.Location = new System.Drawing.Point(109, 55);
            this.buttonTestRead.Name = "buttonTestRead";
            this.buttonTestRead.Size = new System.Drawing.Size(43, 23);
            this.buttonTestRead.TabIndex = 32;
            this.buttonTestRead.Text = "读取";
            this.buttonTestRead.UseVisualStyleBackColor = true;
            this.buttonTestRead.Click += new System.EventHandler(this.buttonTestRead_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 539);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonFormSensor);
            this.Controls.Add(this.buttonRelayConfiguration);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonDeviceManage);
            this.Name = "Form1";
            this.Text = "智能网关控制器配置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDeviceManage;
        private System.Windows.Forms.TextBox textBoxIPAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.TextBox textBoxRec;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelRecCnt;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelSendCnt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonModbusWrite1;
        private System.Windows.Forms.Button buttonModbusRead1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxUpLoadPeriod;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxSensorTotalNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxAddressACU;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button buttonRelayConfiguration;
        private System.Windows.Forms.Button buttonFormSensor;
        private System.Windows.Forms.ComboBox comboBoxRS485_4GBaud;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBoxRS485ExtendBaud;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxRS485SensorBaud;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxWorkMode;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonOpenClose;
        private System.Windows.Forms.Button buttonRenewCom;
        private System.Windows.Forms.ComboBox comboBaudrate;
        private System.Windows.Forms.Label labelBaudrate;
        private System.Windows.Forms.ComboBox comboPortName;
        private System.Windows.Forms.Label labelPortName;
        private System.Windows.Forms.Timer timerSerialPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxRS485ExtendAddress;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBoxTestRegLength;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxTestRegAdress;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxTestDeviceAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonTestWrite;
        private System.Windows.Forms.Button buttonTestRead;
        private System.Windows.Forms.TextBox textBoxTestValue;
        private System.Windows.Forms.Label label21;
    }
}

