﻿namespace ACUConfig_NETVer4
{
    partial class FormRelayConfiguration
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
            this.comboBoxRelayAddr = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxData4Enable = new System.Windows.Forms.CheckBox();
            this.checkBoxData3Enable = new System.Windows.Forms.CheckBox();
            this.checkBoxData2Enable = new System.Windows.Forms.CheckBox();
            this.checkBoxData1Enable = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxWhichDataL = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxWitchDataH = new System.Windows.Forms.ComboBox();
            this.textBoxRelayAddr = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxInputNum = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxPolar = new System.Windows.Forms.ComboBox();
            this.textBoxBaud = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxLimitDown = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLimitUp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxMode = new System.Windows.Forms.ComboBox();
            this.buttonRead = new System.Windows.Forms.Button();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonCloseRelay = new System.Windows.Forms.Button();
            this.buttonOpenRelay = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxRelayAddr
            // 
            this.comboBoxRelayAddr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRelayAddr.FormattingEnabled = true;
            this.comboBoxRelayAddr.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comboBoxRelayAddr.Location = new System.Drawing.Point(89, 18);
            this.comboBoxRelayAddr.Name = "comboBoxRelayAddr";
            this.comboBoxRelayAddr.Size = new System.Drawing.Size(88, 20);
            this.comboBoxRelayAddr.TabIndex = 0;
            this.comboBoxRelayAddr.SelectedIndexChanged += new System.EventHandler(this.comboBoxRelayAddr_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "继电器地址";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.checkBoxData4Enable);
            this.groupBox1.Controls.Add(this.checkBoxData3Enable);
            this.groupBox1.Controls.Add(this.checkBoxData2Enable);
            this.groupBox1.Controls.Add(this.checkBoxData1Enable);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.comboBox5);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.comboBox6);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.textBoxStatus);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.comboBoxWhichDataL);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.comboBoxWitchDataH);
            this.groupBox1.Controls.Add(this.textBoxRelayAddr);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBoxInputNum);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBoxPolar);
            this.groupBox1.Controls.Add(this.textBoxBaud);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxLimitDown);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxLimitUp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxMode);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(742, 191);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参数配置";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // checkBoxData4Enable
            // 
            this.checkBoxData4Enable.AutoSize = true;
            this.checkBoxData4Enable.Location = new System.Drawing.Point(563, 100);
            this.checkBoxData4Enable.Name = "checkBoxData4Enable";
            this.checkBoxData4Enable.Size = new System.Drawing.Size(78, 16);
            this.checkBoxData4Enable.TabIndex = 38;
            this.checkBoxData4Enable.Text = "使能数据4";
            this.checkBoxData4Enable.UseVisualStyleBackColor = true;
            // 
            // checkBoxData3Enable
            // 
            this.checkBoxData3Enable.AutoSize = true;
            this.checkBoxData3Enable.Location = new System.Drawing.Point(381, 100);
            this.checkBoxData3Enable.Name = "checkBoxData3Enable";
            this.checkBoxData3Enable.Size = new System.Drawing.Size(78, 16);
            this.checkBoxData3Enable.TabIndex = 37;
            this.checkBoxData3Enable.Text = "使能数据3";
            this.checkBoxData3Enable.UseVisualStyleBackColor = true;
            // 
            // checkBoxData2Enable
            // 
            this.checkBoxData2Enable.AutoSize = true;
            this.checkBoxData2Enable.Location = new System.Drawing.Point(563, 20);
            this.checkBoxData2Enable.Name = "checkBoxData2Enable";
            this.checkBoxData2Enable.Size = new System.Drawing.Size(78, 16);
            this.checkBoxData2Enable.TabIndex = 36;
            this.checkBoxData2Enable.Text = "使能数据2";
            this.checkBoxData2Enable.UseVisualStyleBackColor = true;
            // 
            // checkBoxData1Enable
            // 
            this.checkBoxData1Enable.AutoSize = true;
            this.checkBoxData1Enable.Location = new System.Drawing.Point(381, 20);
            this.checkBoxData1Enable.Name = "checkBoxData1Enable";
            this.checkBoxData1Enable.Size = new System.Drawing.Size(78, 16);
            this.checkBoxData1Enable.TabIndex = 35;
            this.checkBoxData1Enable.Text = "使能数据1";
            this.checkBoxData1Enable.UseVisualStyleBackColor = true;
            this.checkBoxData1Enable.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(561, 151);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 12);
            this.label16.TabIndex = 34;
            this.label16.Text = "数据号";
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.comboBox5.Location = new System.Drawing.Point(620, 148);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(100, 20);
            this.comboBox5.TabIndex = 33;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(561, 125);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 12);
            this.label17.TabIndex = 32;
            this.label17.Text = "传感器号";
            // 
            // comboBox6
            // 
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comboBox6.Location = new System.Drawing.Point(620, 122);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(100, 20);
            this.comboBox6.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(561, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 30;
            this.label14.Text = "数据号";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.comboBox3.Location = new System.Drawing.Point(620, 68);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(100, 20);
            this.comboBox3.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(561, 45);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 28;
            this.label15.Text = "传感器号";
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comboBox4.Location = new System.Drawing.Point(620, 42);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(100, 20);
            this.comboBox4.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(379, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 26;
            this.label12.Text = "数据号";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.comboBox1.Location = new System.Drawing.Point(438, 148);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 20);
            this.comboBox1.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(379, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 24;
            this.label13.Text = "传感器号";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comboBox2.Location = new System.Drawing.Point(438, 122);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 20);
            this.comboBox2.TabIndex = 23;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(230, 101);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.ReadOnly = true;
            this.textBoxStatus.Size = new System.Drawing.Size(100, 21);
            this.textBoxStatus.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(171, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 21;
            this.label11.Text = "状态";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(379, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 20;
            this.label10.Text = "数据号";
            // 
            // comboBoxWhichDataL
            // 
            this.comboBoxWhichDataL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWhichDataL.FormattingEnabled = true;
            this.comboBoxWhichDataL.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.comboBoxWhichDataL.Location = new System.Drawing.Point(438, 68);
            this.comboBoxWhichDataL.Name = "comboBoxWhichDataL";
            this.comboBoxWhichDataL.Size = new System.Drawing.Size(100, 20);
            this.comboBoxWhichDataL.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(379, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "传感器号";
            // 
            // comboBoxWitchDataH
            // 
            this.comboBoxWitchDataH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWitchDataH.FormattingEnabled = true;
            this.comboBoxWitchDataH.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comboBoxWitchDataH.Location = new System.Drawing.Point(438, 42);
            this.comboBoxWitchDataH.Name = "comboBoxWitchDataH";
            this.comboBoxWitchDataH.Size = new System.Drawing.Size(100, 20);
            this.comboBoxWitchDataH.TabIndex = 17;
            // 
            // textBoxRelayAddr
            // 
            this.textBoxRelayAddr.Location = new System.Drawing.Point(65, 20);
            this.textBoxRelayAddr.Name = "textBoxRelayAddr";
            this.textBoxRelayAddr.ReadOnly = true;
            this.textBoxRelayAddr.Size = new System.Drawing.Size(100, 21);
            this.textBoxRelayAddr.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "当前地址";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(171, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "联动标号";
            // 
            // comboBoxInputNum
            // 
            this.comboBoxInputNum.FormattingEnabled = true;
            this.comboBoxInputNum.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.comboBoxInputNum.Location = new System.Drawing.Point(230, 74);
            this.comboBoxInputNum.Name = "comboBoxInputNum";
            this.comboBoxInputNum.Size = new System.Drawing.Size(100, 20);
            this.comboBoxInputNum.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "输出极性";
            // 
            // comboBoxPolar
            // 
            this.comboBoxPolar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPolar.FormattingEnabled = true;
            this.comboBoxPolar.Items.AddRange(new object[] {
            "同相",
            "反相"});
            this.comboBoxPolar.Location = new System.Drawing.Point(230, 47);
            this.comboBoxPolar.Name = "comboBoxPolar";
            this.comboBoxPolar.Size = new System.Drawing.Size(100, 20);
            this.comboBoxPolar.TabIndex = 11;
            // 
            // textBoxBaud
            // 
            this.textBoxBaud.Location = new System.Drawing.Point(65, 101);
            this.textBoxBaud.Name = "textBoxBaud";
            this.textBoxBaud.Size = new System.Drawing.Size(100, 21);
            this.textBoxBaud.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "滞环宽度";
            // 
            // textBoxLimitDown
            // 
            this.textBoxLimitDown.Location = new System.Drawing.Point(65, 74);
            this.textBoxLimitDown.Name = "textBoxLimitDown";
            this.textBoxLimitDown.Size = new System.Drawing.Size(100, 21);
            this.textBoxLimitDown.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "动作下限";
            // 
            // textBoxLimitUp
            // 
            this.textBoxLimitUp.Location = new System.Drawing.Point(65, 47);
            this.textBoxLimitUp.Name = "textBoxLimitUp";
            this.textBoxLimitUp.Size = new System.Drawing.Size(100, 21);
            this.textBoxLimitUp.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "动作上限";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "运行模式";
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMode.FormattingEnabled = true;
            this.comboBoxMode.Items.AddRange(new object[] {
            "0非自动模式",
            "1单数据模式",
            "2多数据与模式",
            "3多数据或模式",
            "4联动模式"});
            this.comboBoxMode.Location = new System.Drawing.Point(230, 21);
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.Size = new System.Drawing.Size(100, 20);
            this.comboBoxMode.TabIndex = 3;
            // 
            // buttonRead
            // 
            this.buttonRead.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonRead.Location = new System.Drawing.Point(278, 300);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(75, 23);
            this.buttonRead.TabIndex = 3;
            this.buttonRead.Text = "读取";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // buttonWrite
            // 
            this.buttonWrite.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonWrite.Location = new System.Drawing.Point(443, 300);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(75, 23);
            this.buttonWrite.TabIndex = 4;
            this.buttonWrite.Text = "写入";
            this.buttonWrite.UseVisualStyleBackColor = true;
            this.buttonWrite.Click += new System.EventHandler(this.buttonWrite_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.buttonCloseRelay);
            this.groupBox2.Controls.Add(this.buttonOpenRelay);
            this.groupBox2.Location = new System.Drawing.Point(12, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(742, 53);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "继电器测试";
            // 
            // buttonCloseRelay
            // 
            this.buttonCloseRelay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCloseRelay.Location = new System.Drawing.Point(439, 20);
            this.buttonCloseRelay.Name = "buttonCloseRelay";
            this.buttonCloseRelay.Size = new System.Drawing.Size(60, 23);
            this.buttonCloseRelay.TabIndex = 22;
            this.buttonCloseRelay.Text = "关";
            this.buttonCloseRelay.UseVisualStyleBackColor = true;
            this.buttonCloseRelay.Click += new System.EventHandler(this.buttonCloseRelay_Click);
            // 
            // buttonOpenRelay
            // 
            this.buttonOpenRelay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonOpenRelay.Location = new System.Drawing.Point(274, 20);
            this.buttonOpenRelay.Name = "buttonOpenRelay";
            this.buttonOpenRelay.Size = new System.Drawing.Size(60, 23);
            this.buttonOpenRelay.TabIndex = 21;
            this.buttonOpenRelay.Text = "开";
            this.buttonOpenRelay.UseVisualStyleBackColor = true;
            this.buttonOpenRelay.Click += new System.EventHandler(this.buttonOpenRelay_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 331);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(766, 22);
            this.statusStrip1.TabIndex = 6;
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
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormRelayConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 353);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonWrite);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxRelayAddr);
            this.Name = "FormRelayConfiguration";
            this.Text = "继电器配置";
            this.Load += new System.EventHandler(this.FormRelayConfiguration_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxRelayAddr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxLimitUp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxMode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxInputNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxPolar;
        private System.Windows.Forms.TextBox textBoxBaud;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxLimitDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxRelayAddr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonWrite;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonCloseRelay;
        private System.Windows.Forms.Button buttonOpenRelay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxWhichDataL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxWitchDataH;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.CheckBox checkBoxData1Enable;
        private System.Windows.Forms.CheckBox checkBoxData2Enable;
        private System.Windows.Forms.CheckBox checkBoxData4Enable;
        private System.Windows.Forms.CheckBox checkBoxData3Enable;
    }
}