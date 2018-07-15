using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using ZLDevManage;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Net.NetworkInformation;
using System.Web;
using System.IO.Ports;

using LiuCommoncodes;
using Modbus.ModbusRTU_特殊修改_不通用;

//public string Text_Send;

namespace ACUConfig_NETVer4
{
    public partial class Form1 : Form
    {

        #region 子窗口对象

        FormDeviceManagement formDeviceMangement;
        FormRelayConfiguration formRelayConfiguration;
        FormSensor formSensorConfiguration;

        #endregion

        #region Socket
        Socket socketControl = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);//创建一个Socket
        Thread th;
        int RecCnt = 0, SendCnt = 0;
        private StringBuilder builder = new StringBuilder();//避免在事件处理方法中反复的创建，定义到外面。
        #endregion

        readonly byte ACU_Address = 255;

        /// <summary>
        /// 是否没有执行完串口接收的invoke相关操作
        /// 【防止关闭串口时卡死在close()时用到】
        /// </summary>
        private bool CommListening = false;
        /// <summary>
        /// 是否正在关闭串口，执行Application.DoEvents,并阻止再次invoke
        /// 【防止关闭串口时卡死在close()时用到】
        /// </summary>
        private bool CommClosing = false;

        #region Modbus
        ModbusRTU ModbusMaster;
        SerialPort2 serialPort2;
        SerialPort comm = new SerialPort();


        DateTime ModbusCmdTime = new DateTime(2000, 1, 1, 0, 0, 0);

        public const int MODBUS_RESPONSE_TIME_MAX_MM = 2000;

        #endregion

        List<byte[]> OpenCmdBytes = new List<byte[]>();
        List<byte[]> CloseCmdBytes = new List<byte[]>();

        SystemConfig SystemConfig1 = new SystemConfig();

        public Form1()
        {
            InitializeComponent();
            OpenCmdBytes.Add(new byte[8] { 0x01, 0x05, 0x00, 0x00, 0xFF, 0x00, 0x8C, 0x3A });  //1
            OpenCmdBytes.Add(new byte[8] { 0x01, 0x05, 0x00, 0x01, 0xFF, 0x00, 0xDD, 0xFA });  //2
            OpenCmdBytes.Add(new byte[8] { 0x01, 0x05, 0x00, 0x02, 0xFF, 0x00, 0x2D, 0xFA });  //3
            OpenCmdBytes.Add(new byte[8] { 0x01, 0x05, 0x00, 0x03, 0xFF, 0x00, 0x7C, 0x3A });  //4
            OpenCmdBytes.Add(new byte[8] { 0x01, 0x05, 0x00, 0x04, 0xFF, 0x00, 0xCD, 0xFB });  //5
            OpenCmdBytes.Add(new byte[8] { 0x01, 0x05, 0x00, 0x05, 0xFF, 0x00, 0x9C, 0x3B });  //6
            OpenCmdBytes.Add(new byte[8] { 0x01, 0x05, 0x00, 0x06, 0xFF, 0x00, 0x6C, 0x3B });  //7
            OpenCmdBytes.Add(new byte[8] { 0x01, 0x05, 0x00, 0x07, 0xFF, 0x00, 0x3D, 0xFB });  //8

            CloseCmdBytes.Add(new byte[8] { 0x00, 0x05, 0x00, 0x00, 0x00, 0x00, 0xCD, 0xCA });  //1
            CloseCmdBytes.Add(new byte[8] { 0x01, 0x05, 0x00, 0x01, 0x00, 0x00, 0x9C, 0x0A });  //2
            CloseCmdBytes.Add(new byte[8] { 0x01, 0x05, 0x00, 0x02, 0x00, 0x00, 0x6C, 0x0A });  //3
            CloseCmdBytes.Add(new byte[8] { 0x01, 0x05, 0x00, 0x03, 0x00, 0x00, 0x3D, 0xCA });  //4
            CloseCmdBytes.Add(new byte[8] { 0x01, 0x05, 0x00, 0x04, 0x00, 0x00, 0x8C, 0x0B });  //5
            CloseCmdBytes.Add(new byte[8] { 0x01, 0x05, 0x00, 0x05, 0x00, 0x00, 0xDD, 0xCB });  //6
            CloseCmdBytes.Add(new byte[8] { 0x01, 0x05, 0x00, 0x06, 0x00, 0x00, 0x2D, 0xCB });  //7
            CloseCmdBytes.Add(new byte[8] { 0x01, 0x05, 0x00, 0x07, 0x00, 0x00, 0x7C, 0x0B });  //8

            serialPort2 = new SerialPort2(socketControl);
            ModbusMaster = new ModbusRTU(serialPort2, ModbusRTUmode.Master);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(ZLDM.Init(4196).ToString());
           // MessageBox.Show(ParamDevExitInSubnet.未找到.ToString()+"a");

            //初始化下拉串口名称列表框
            string[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);
            comboPortName.Items.AddRange(ports);
            comboPortName.SelectedIndex = comboPortName.Items.Count > 0 ? 0 : -1;
            //            comboBaudrate.SelectedIndex = comboBaudrate.Items.IndexOf("9600");
            //初始化SerialPort对象
            comm.NewLine = "\r\n";
            comm.RtsEnable = true;//根据实际情况吧。


            for (int i = 0; i < 248; i++)
            {
                //this.comboBoxAddressACU.Items.Add(i);
            }

            toolStripStatusLabel1.Text = "";
        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ZLDM.Exit();
        }

 



        private void buttonDeviceManage_Click(object sender, EventArgs e)
        {
            if (null == formDeviceMangement)
                formDeviceMangement = new FormDeviceManagement();
            if (formDeviceMangement.IsDisposed)
                formDeviceMangement = new FormDeviceManagement();
            formDeviceMangement.Show();
            formDeviceMangement.Activate();
        }

        #region Socket部分
        private void buttonConnet_Click(object sender, EventArgs e)
        {
            if (buttonConnect.Text == "连接")
            {
                if (comm.IsOpen)
                    this.buttonOpenClose_Click(this.buttonOpenClose, new EventArgs());

                toolStripStatusLabel1.Text = "正在连接中……";

                IPAddress ips = IPAddress.Parse(this.textBoxIPAddress.Text);//("192.168.2.1");
                IPEndPoint ipe = new IPEndPoint(ips, Convert.ToInt32(this.textBoxPort.Text));//把ip和端口转化为IPEndPoint实例
                socketControl = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    socketControl.Connect(ipe);//连接到服务器
                    toolStripStatusLabel1.Text = "";
                    MessageBox.Show("连接成功");
                    serialPort2 = new SerialPort2(socketControl);
                    ModbusMaster = new ModbusRTU(serialPort2, ModbusRTUmode.Master);

                    ModbusMaster.DeviceAddress = ACU_Address;

                    th = new Thread(ReceiveMsg);
                    th.IsBackground = true;
                    th.Start();
                    buttonConnect.Text = "断开";
                }
                catch (Exception ex)
                {
                    toolStripStatusLabel1.Text = "";
                    MessageBox.Show(ex.Message);
                }

            }
            else if (buttonConnect.Text == "断开")
            {
                toolStripStatusLabel1.Text = "正在断开连接……";
                th.Abort();

                socketControl.Close();

                buttonConnect.Text = "连接";
                toolStripStatusLabel1.Text = "";
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.RecCnt = 0;
            this.SendCnt = 0;
            this.labelSendCnt.Text = "0";
            this.labelRecCnt.Text = "0";
            this.textBoxRec.Text = "";
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {

            try
            {
                string sendstring = this.textBoxSend.Text;
                sendstring = sendstring.Replace(" ", "");
                byte[] bs = StringOperation.HexstringToHexBytes(sendstring);
                socketControl.Send(bs, bs.Length, 0);
                SendCnt += bs.Length;
                this.labelSendCnt.Text = SendCnt.ToString();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }
        }


        private void timerSerialPort_Tick(object sender, EventArgs e)
        {
            
            if (this.CommClosing)//如果正在关闭，忽略操作，直接返回，尽快的完成串口监听线程的一次循环
                return;          //【防止关闭串口时卡死在close()时用到】
            try
            {
                this.CommListening = true;//设置标记，说明我已经开始处理数据，一会儿要使用系统UI的。

                if (comm.BytesToRead > 0)
                {
                    byte[] buffer = new byte[comm.BytesToRead];
                    comm.Read(buffer, 0, comm.BytesToRead);
                    ModbusRespeonseResult responseResult = ModbusMaster.Response(buffer);

                    ReciveHandler(buffer, responseResult);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("接受数据处理程序异常\r\n\r\n" + ex.ToString());
            }
            finally
            { this.CommListening = false; }
        }

        int loop_cnt_test = 0;
        void ReceiveMsg()
        {
            while (true)
            {
                loop_cnt_test++;
                //if ((DateTime.Now - ModbusCmdTime).Seconds > 2)
                //  ModbusMaster.Reset();
                try
                {
                    //byte[] buffer = new byte[1024 * 1024];
                    //int n = socketControl.Available;
                    if (socketControl.Available > 0)
                    {
                        byte[] buffer = new byte[1];
                        socketControl.Receive(buffer, 1, 0);
                        ModbusRespeonseResult responseResult = ModbusMaster.Response(buffer);

                        ReciveHandler(buffer, responseResult);
                    }
                }
                catch (ThreadAbortException ex)
                {
                    toolStripStatusLabel1.Text = "";
                    MessageBox.Show("成功终止监听进程");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("错误\r\n\r\n" + ex.Message);
                    //th.Join(); 
                    break;
                }
            }

        }
        void ReciveHandler(byte[] buffer, ModbusRespeonseResult responseResult)
        {
            //因为要访问ui资源，所以需要使用invoke方式同步ui。
            this.Invoke((EventHandler)(delegate
            {
                builder.Clear();
                //判断是否是显示为16禁止
                /*if (checkBoxHexViewR.Checked)
                {
                    //依次的拼接出16进制字符串
                    foreach (byte b in comt_buf)
                    {
                        builder.Append(b.ToString("X2") + " ");
                    }
                }
                else
                {
                    builder.Append(Encoding.ASCII.GetString(comt_buf));//直接按ASCII规则转换成字符串
                }*/
                builder.Append(buffer[0].ToString("X2") + " ");
                //依次的拼接出16进制字符串
                //foreach (byte b in buffer)
                //{
                //builder.Append(b.ToString("X2") + " ");
                //}
                //追加的形式添加到文本框末端，并滚动到最后。
                this.textBoxRec.AppendText(builder.ToString());
                builder.Clear();
                //修改接收计数
                RecCnt += 1;
                this.labelRecCnt.Text = RecCnt.ToString();

                //string s2 = Encoding.UTF8.GetString(buffer, 0, 1);
                //ShowMsg(s2);


                if (responseResult == ModbusRespeonseResult.Recieved)
                {
                    if ((ModbusMaster.CmdRecord.Address >= RelayConfig.RegHeadAddress)
                        && (ModbusMaster.CmdRecord.Address <= RelayConfig.RegTailAddress))
                    {
                        if (formRelayConfiguration != null)
                        {
                            if (!formRelayConfiguration.IsDisposed)
                            {
                                formRelayConfiguration.ShowRelayData(ModbusMaster.CmdRecord.Address, ModbusMaster.Buffer.ToArray());
                            }
                        }
                    }
                    else if ((ModbusMaster.CmdRecord.Address >= RelayConfig.CeilHeadAddress)
                        && (ModbusMaster.CmdRecord.Address <= RelayConfig.CeilTailAddress))
                    {
                        if (formRelayConfiguration != null)
                        {
                            if (!formRelayConfiguration.IsDisposed)
                            {
                                formRelayConfiguration.buttonRead_Click(formRelayConfiguration.buttonRead, new EventArgs());
                            }
                        }
                    }
                    else if ((ModbusMaster.CmdRecord.Address >= SensorConfig.RWHeadAddress)
                        && (ModbusMaster.CmdRecord.Address <= SensorConfig.RWTailAddress))
                    {
                        if (formSensorConfiguration != null)
                        {
                            if (!formSensorConfiguration.IsDisposed)
                            {
                                formSensorConfiguration.ShowSensorRWdata(ModbusMaster.CmdRecord.Address, ModbusMaster.Buffer.ToArray());
                            }
                        }
                    }
                    else if ((ModbusMaster.CmdRecord.Address >= SensorConfig.ROHeadAddress)
                        && (ModbusMaster.CmdRecord.Address <= SensorConfig.ROTailAddress))
                    {
                        if (formSensorConfiguration != null)
                        {
                            if (!formSensorConfiguration.IsDisposed)
                            {
                                formSensorConfiguration.ShowSensorROdata(ModbusMaster.Buffer.ToArray());
                            }
                        }
                    }
                    else if ((ModbusMaster.CmdRecord.Address >= SystemConfig.HeadAddress)
                        && (ModbusMaster.CmdRecord.Address <= SystemConfig.TailAddress))
                    {
                        SystemConfig1.SetValue(ModbusMaster.Buffer.ToArray());

                        this.textBoxAddressACU.Text = SystemConfig1.AddressACU.ToString();
                        this.textBoxSensorTotalNum.Text = SystemConfig1.SensorTotalNum.ToString();
                        this.comboBoxWorkMode.SelectedIndex = SystemConfig1.WorkMode;
                        this.textBoxUpLoadPeriod.Text = SystemConfig1.UploadPeriod.ToString();
                        this.comboBoxRS485SensorBaud.SelectedIndex = SystemConfig1.RS485SensorBaud;
                        this.comboBoxRS485ExtendBaud.SelectedIndex = SystemConfig1.RS485ExtendBaud;
                        this.textBoxRS485ExtendAddress.Text = SystemConfig1.RS485ExtendAddress.ToString();
                        this.comboBoxRS485_4GBaud.SelectedIndex = SystemConfig1.Rs485_4GBaud;

                        toolStripStatusLabel1.Text = "读取成功";
                    }

                    }
                else if (responseResult == ModbusRespeonseResult.Writen)
                {
                    if ((ModbusMaster.CmdRecord.Address >= RelayConfig.RegHeadAddress)
                       && (ModbusMaster.CmdRecord.Address <= RelayConfig.RegTailAddress))
                    {
                        if (formRelayConfiguration != null)
                        {
                            if (!formRelayConfiguration.IsDisposed)
                            {
                                formRelayConfiguration.timer1.Stop();
                                formRelayConfiguration.toolStripStatusLabel1.Text = "写入成功";
                            }
                        }
                    }
                    else if ((ModbusMaster.CmdRecord.Address >= SensorConfig.RWHeadAddress)
                        && (ModbusMaster.CmdRecord.Address <= SensorConfig.RWTailAddress))
                    {
                        if (formSensorConfiguration != null)
                        {
                            if (!formSensorConfiguration.IsDisposed)
                            {
                                formSensorConfiguration.timer1.Stop();
                                formSensorConfiguration.toolStripStatusLabel1.Text = "写入成功";
                            }
                        }
                    }
                    else if ((ModbusMaster.CmdRecord.Address >= SystemConfig.HeadAddress)
                        && (ModbusMaster.CmdRecord.Address <= SystemConfig.TailAddress))
                    {
                        toolStripStatusLabel1.Text = "写入成功";
                    }
                }

                if (ModbusCmdTime.CompareTo(new DateTime(2000, 1, 1, 0, 0, 0)) != 0)
                {
                    TimeSpan ts = DateTime.Now - ModbusCmdTime;
                    if (ts.Milliseconds > MODBUS_RESPONSE_TIME_MAX_MM)
                    {
                        ModbusCmdTime = new DateTime(2000, 1, 1, 0, 0, 0);

                        toolStripStatusLabel1.Text = "响应超时";
                    }
                }

            }));

        }

        #endregion

        private void buttonLocalIP_Click(object sender, EventArgs e)
        {
            string name = Dns.GetHostName();
            IPAddress[] ipadrlist = Dns.GetHostAddresses(name);
            foreach (IPAddress ipa in ipadrlist)
            {
//               if (ipa.AddressFamily == AddressFamily.InterNetwork)
//                    MessageBox.Show(ipa.ToString());
            }

//            IPHostEntry localhost = Dns.GetHostEntry(name);
            //for (int i = 0; i < localhost.AddressList.Length; i++)
                //MessageBox.Show(localhost.AddressList[i].ToString());


            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface ni in interfaces)
            {
                if (ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    foreach (UnicastIPAddressInformation ip in
                        ni.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            MessageBox.Show(ip.Address.ToString());
                        }
                    }
                }
            }

        }

        private void buttonModbusRead1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ModbusMaster.IsConnected)
                {
                    ModbusMaster.DeviceAddress = ACU_Address;//Convert.ToByte(this.comboBoxAddressACU.SelectedIndex);

                    ModbusMaster.ReadHoldingRegisters(SystemConfig.HeadAddress, SystemConfig.RegCount);

                    ModbusCmdTime = DateTime.Now;
                    toolStripStatusLabel1.Text = "正在读取……";
                }
                else { MessageBox.Show("Socket未连接", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void buttonModbusWrite1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ModbusMaster.IsConnected)
                {
                    ModbusMaster.DeviceAddress = ACU_Address;// Convert.ToByte(this.comboBoxAddressACU.SelectedIndex);

                    SystemConfig1.AddressACU = Convert.ToUInt16(this.textBoxAddressACU.Text);
                    SystemConfig1.SensorTotalNum = Convert.ToUInt16(this.textBoxSensorTotalNum.Text);
                    SystemConfig1.WorkMode = Convert.ToUInt16(this.comboBoxWorkMode.SelectedIndex);
                    SystemConfig1.UploadPeriod = Convert.ToUInt16(this.textBoxUpLoadPeriod.Text);
                    SystemConfig1.RS485SensorBaud = Convert.ToUInt16(this.comboBoxRS485SensorBaud.SelectedIndex);
                    SystemConfig1.RS485ExtendBaud = Convert.ToUInt16(this.comboBoxRS485ExtendBaud.SelectedIndex);
                    SystemConfig1.RS485ExtendAddress = Convert.ToUInt16(this.textBoxRS485ExtendAddress.Text);
                    SystemConfig1.Rs485_4GBaud = Convert.ToUInt16(this.comboBoxRS485_4GBaud.SelectedIndex);

                    ModbusMaster.WriteMulitipleRegisters(SystemConfig.HeadAddress, SystemConfig1.GetArray());

                    ModbusCmdTime = DateTime.Now;
                    toolStripStatusLabel1.Text = "正在写入……";
                }
                else { MessageBox.Show("Socket未连接或者串口未打开", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }




        private void buttonRelayConfiguration_Click(object sender, EventArgs e)
        {
            if (!socketControl.Connected)
            {
                MessageBox.Show("Socket未连接或者串口为打开", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (formRelayConfiguration == null)
                formRelayConfiguration = new FormRelayConfiguration(this.ModbusMaster);
            if(formRelayConfiguration.IsDisposed)
                formRelayConfiguration = new FormRelayConfiguration(this.ModbusMaster);
            formRelayConfiguration.Show();
            formRelayConfiguration.Activate();
        }

        private void buttonFormSensor_Click(object sender, EventArgs e)
        {
            if (!socketControl.Connected)
            {
                MessageBox.Show("Socket未连接", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (formSensorConfiguration == null)
                formSensorConfiguration = new FormSensor(this.ModbusMaster);
            if (formSensorConfiguration.IsDisposed)
                formSensorConfiguration = new FormSensor(this.ModbusMaster);
            formSensorConfiguration.Show();
            formSensorConfiguration.Activate();
        }

        private void comboBoxAddressACU_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonModbusRead1_Click(this.buttonModbusRead1, new EventArgs());
        }

        private void textBoxUpLoadPeriod_Validating(object sender, CancelEventArgs e)
        {
            int period;
            if (int.TryParse(this.textBoxUpLoadPeriod.Text, out period))
            {
                if (period < 200)
                    this.textBoxUpLoadPeriod.Text = "200";
            }
            else if (textBoxUpLoadPeriod.Text != "")
            {
                this.textBoxUpLoadPeriod.Text = "500";
                MessageBox.Show("请输入整形数字", "格式错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxAddressACU_Validating(object sender, CancelEventArgs e)
        {
            int add;
            TextBox box = (TextBox)sender;
            if (int.TryParse(box.Text, out add))
            {
                if (add < 0)
                    box.Text = "0";
                if (add > 255)
                    box.Text = "255";
            }
            else if (box.Text != "")
            {
                this.textBoxAddressACU.Text = "0";
                MessageBox.Show("请输入0~247内的整形数字", "格式错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRenewCom_Click(object sender, EventArgs e)
        {
            if (this.comm.IsOpen)
            {
                MessageBox.Show("请关闭串口后再进行刷新", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string[] ports = SerialPort.GetPortNames();
                Array.Sort(ports);
                comboPortName.Items.Clear();
                comboPortName.Items.AddRange(ports);
            }
        }

        private void buttonOpenClose_Click(object sender, EventArgs e)
        {
            try
            {
                this.Invoke((EventHandler)(delegate
                {
                    //根据当前串口对象，来判断操作
                    if (comm.IsOpen)
                    {
                        this.CommClosing = true;
                        while (this.CommListening)
                            Application.DoEvents();//【防止关闭串口时卡死在close()时用到】
                        comm.Close();//打开时点击，则关闭串口
                        this.CommClosing = false;
                    }
                    else
                    {
                        if (buttonConnect.Text == "断开")
                            buttonConnet_Click(this.buttonConnect, new EventArgs());

                        //关闭时点击，则设置好端口，波特率后打开
                        try
                        {
                            comm.PortName = comboPortName.Text;
                            comm.BaudRate = int.Parse(comboBaudrate.Text);
                            comm.Parity = Parity.None;
                            comm.Open();
                            comm.Read(new byte[comm.BytesToRead], 0, comm.BytesToRead);//把缓冲区的数据全部清除

                            this.ModbusMaster = new ModbusRTU(comm, ModbusRTUmode.Master);

                        }
                        catch (Exception ex)
                        {
                            //捕获到异常信息，创建一个新的comm对象，之前的不能用了。
                            comm = new SerialPort();
                            //现实异常信息给客户。
                            MessageBox.Show("打开串口时出现如下异常：\r\n\r\n" + ex.Message);
                        }
                    }
                    //设置按钮的状态
                    buttonOpenClose.Text = comm.IsOpen ? "关闭串口" : "打开串口";
                }));
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.ToString());
            }
        }

        private void buttonTestRead_Click(object sender, EventArgs e)
        {
            try
            {
                byte deviceAddress = Convert.ToByte(this.textBoxTestDeviceAddress.Text);
                ushort regAddress = Convert.ToUInt16(this.textBoxTestRegAdress.Text);
                ushort regLength = Convert.ToUInt16(this.textBoxTestRegLength.Text);

                byte oldDeviceAddress = ModbusMaster.DeviceAddress; //以免测试对正常的程序有影响。这里储存测试前的设备地址，发送完读取命令后，里面修改回原来的地址

                ModbusMaster.DeviceAddress = deviceAddress;
                ModbusMaster.ReadHoldingRegisters(regAddress, regLength);

                ModbusMaster.DeviceAddress = oldDeviceAddress;
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void buttonTestWrite_Click(object sender, EventArgs e)
        {
            try
            {
                byte deviceAddress = Convert.ToByte(this.textBoxTestDeviceAddress.Text);
                ushort regAddress = Convert.ToUInt16(this.textBoxTestRegAdress.Text);
                ushort regValue = Convert.ToUInt16(this.textBoxTestValue.Text);

                byte oldDeviceAddress = ModbusMaster.DeviceAddress; //以免测试对正常的程序有影响。这里储存测试前的设备地址，发送完读取命令后，里面修改回原来的地址

                ModbusMaster.DeviceAddress = deviceAddress;
                ModbusMaster.WriteSingleResiter(regAddress, regValue);

                ModbusMaster.DeviceAddress = oldDeviceAddress;
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }






    }

    public enum ReadParaGroup
    {
        None,
        ParaGroup1,
        ParaGroup2
    }

    public class SystemConfig
    {
        public const ushort HeadAddress = 44000;
        public const ushort TailAddress = 44007;
        public const int RegCount = 8;

        public ushort AddressACU;
        public ushort SensorTotalNum;
        public ushort WorkMode;
        public ushort UploadPeriod;
        public ushort RS485SensorBaud;
        public ushort RS485ExtendBaud;
        public ushort RS485ExtendAddress;
        public ushort Rs485_4GBaud;

        public SystemConfig() { }

        public ushort[] GetArray()
        {
            ushort[] result = new ushort[RegCount];

            result[0] = this.AddressACU;
            result[1] = this.SensorTotalNum;
            result[2] = this.WorkMode;
            result[3] = this.UploadPeriod;
            result[4] = this.RS485SensorBaud;
            result[5] = this.RS485ExtendBaud;
            result[6] = this.RS485ExtendAddress;
            result[7] = this.Rs485_4GBaud;

            return result;
        }

        public void SetValue(ushort[] value)
        {
            this.AddressACU = value[0];
            this.SensorTotalNum = value[1];
            this.WorkMode = value[2];
            this.UploadPeriod = value[3];
            this.RS485SensorBaud = value[4];
            this.RS485ExtendBaud = value[5];
            this.RS485ExtendAddress = value[6];
            this.Rs485_4GBaud = value[7];
        }
    }

}
