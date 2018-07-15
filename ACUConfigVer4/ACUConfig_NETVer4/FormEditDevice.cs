using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

using ZLDevManage;
using LiuCommoncodes;

namespace ACUConfig_NETVer4
{
    public partial class FormEditDevice : Form
    {
        string DevID;
        DevicePara myDevicePara;

        public FormEditDevice(string devid)
        {
            InitializeComponent();
            DevID = devid;
        }

        private void FormEditDevice_Load(object sender, EventArgs e)
        {
            this.textBoxDeviceName.Text = ZLDM.GetDevParamString(DevID, ZLDM.PARAM_DEV_NAME);
            this.comboBoxBaudRate.SelectedIndex = ZLDM.GetDevParamInt(DevID, ZLDM.PARAM_BAUNDRATE);
            this.comboBoxDataBits.SelectedIndex = ZLDM.GetDevParamInt(DevID, ZLDM.PARAM_DATA_BITS);
            this.comboBoxPatity.SelectedIndex = ZLDM.GetDevParamInt(DevID, ZLDM.PARAM_PARITY);
            this.comboBoxStopBits.SelectedIndex = ZLDM.GetDevParamInt(DevID, ZLDM.PARAM_STOP_BIT);
            this.comboBoxFlowControl.SelectedIndex = ZLDM.GetDevParamInt(DevID, ZLDM.PARAM_FLOW_CONTROL);
            this.comboBoxIPMode.SelectedIndex = ZLDM.GetDevParamInt(DevID, ZLDM.PARAM_IP_MODE);
            this.textBoxIP.Text = ZLDM.GetDevParamString(DevID, ZLDM.PARAM_DEV_LOCAL_IP);
            this.textBoxPort.Text = ZLDM.GetDevParamInt(DevID, ZLDM.PARAM_DEV_LOCAL_PORT).ToString();
            this.comboBoxWorkMode.SelectedIndex = ZLDM.GetDevParamInt(DevID, ZLDM.PARAM_WORK_MODE);
            this.textBoxMask.Text = ZLDM.GetDevParamString(DevID, ZLDM.PARAM_NET_MASK);
            this.textBoxGateway.Text = ZLDM.GetDevParamString(DevID, ZLDM.PARAM_GATEWAY);
            this.textBoxDestIP.Text = ZLDM.GetDevParamString(DevID, ZLDM.PARAM_DEST_IP);
            this.textBoxDestPort.Text = ZLDM.GetDevParamInt(DevID, ZLDM.PARAM_DEST_PORT).ToString();

        }

        private void ShowPara()
        {
            this.textBoxDeviceName.Text = myDevicePara.DeviceName;
            this.comboBoxBaudRate.SelectedIndex = myDevicePara.BaudRate;
            this.comboBoxDataBits.SelectedIndex = myDevicePara.DataBits;
            this.comboBoxPatity.SelectedIndex = myDevicePara.Parity;
            this.comboBoxStopBits.SelectedIndex = myDevicePara.StopBits;
            this.comboBoxFlowControl.SelectedIndex = myDevicePara.FlowControl;
            this.comboBoxIPMode.SelectedIndex = myDevicePara.IPMode;
            this.textBoxIP.Text = myDevicePara.IPaddress;
            this.textBoxPort.Text = myDevicePara.Port.ToString();
            this.comboBoxWorkMode.SelectedIndex = myDevicePara.WorkMode;
            this.textBoxMask.Text = myDevicePara.NetMask;
            this.textBoxGateway.Text = myDevicePara.Gateway;
            this.textBoxDestIP.Text = myDevicePara.DestIP;
            this.textBoxDestPort.Text = myDevicePara.DestPort.ToString();
        }
        private bool GetPara()
        {
            bool result = true;
            if (myDevicePara == null)
                myDevicePara = new DevicePara();
            myDevicePara.DeviceName = this.textBoxDeviceName.Text;
            myDevicePara.BaudRate = this.comboBoxBaudRate.SelectedIndex;
            myDevicePara.DataBits = this.comboBoxDataBits.SelectedIndex;
            myDevicePara.Parity = this.comboBoxPatity.SelectedIndex;
            myDevicePara.StopBits = this.comboBoxStopBits.SelectedIndex;
            myDevicePara.FlowControl = this.comboBoxFlowControl.SelectedIndex;
            myDevicePara.IPMode = this.comboBoxIPMode.SelectedIndex;
            //IP地址
            if (StringOperation.IsIP(this.textBoxIP.Text))
                myDevicePara.IPaddress = this.textBoxIP.Text;
            else
            {
                result = false;
                MessageBox.Show("IP地址格式错误,请重新输入", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //this.textBoxPort.Text = myDevicePara.Port.ToString();
            myDevicePara.WorkMode = this.comboBoxWorkMode.SelectedIndex;
            //子网掩码
            if (StringOperation.IsIP(this.textBoxMask.Text))
                myDevicePara.NetMask = this.textBoxMask.Text;
            else
            {
                result = false;
                MessageBox.Show("子网掩码格式错误,请重新输入", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //网关
            if (StringOperation.IsIP(this.textBoxGateway.Text))
                myDevicePara.Gateway = this.textBoxGateway.Text;
            else
            {
                result = false;
                MessageBox.Show("网关格式错误,请重新输入", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //端口号
            if (!int.TryParse(this.textBoxPort.Text, out myDevicePara.Port))
            {
                MessageBox.Show("端口号错误,请重新输入", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }
            //目标IP地址
            if (StringOperation.IsIP(this.textBoxDestIP.Text))
                myDevicePara.DestIP = this.textBoxDestIP.Text;
            else
            {
                result = false;
                MessageBox.Show("目的IP或域名格式错误,请重新输入", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //目标端口号
            if (!int.TryParse(this.textBoxDestPort.Text, out myDevicePara.DestPort))
            {
                MessageBox.Show("目标端口号错误,请重新输入", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }

            return result;
        }

        private void buttonDefault_Click(object sender, EventArgs e)
        {
            myDevicePara = new DevicePara();
            ShowPara();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (GetPara())
            {
                myDevicePara.Save();
            }

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            myDevicePara = DevicePara.Load(myDevicePara.Path_PathName);
            ShowPara();
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            int result = 0, resultcnt = 0;
            if (!GetPara())  //从控件中获得参数失败，则不发送修改参数命令
                return;
            result += ZLDM.SetDevParamString(DevID, myDevicePara.DeviceName, ZLDM.PARAM_DEV_NAME);
            resultcnt++;
            result += ZLDM.SetDevParamInt(DevID, myDevicePara.BaudRate, ZLDM.PARAM_BAUNDRATE);
            resultcnt++;
            result += ZLDM.SetDevParamInt(DevID, myDevicePara.DataBits, ZLDM.PARAM_DATA_BITS);
            resultcnt++;
            result += ZLDM.SetDevParamInt(DevID, myDevicePara.Parity, ZLDM.PARAM_PARITY);
            resultcnt++;
            result += ZLDM.SetDevParamInt(DevID, myDevicePara.StopBits, ZLDM.PARAM_STOP_BIT);
            resultcnt++;
            result += ZLDM.SetDevParamInt(DevID, myDevicePara.FlowControl, ZLDM.PARAM_FLOW_CONTROL);
            resultcnt++;
            result += ZLDM.SetDevParamInt(DevID, myDevicePara.IPMode, ZLDM.PARAM_IP_MODE);
            resultcnt++;
            result += ZLDM.SetDevParamString(DevID, myDevicePara.IPaddress, ZLDM.PARAM_DEV_LOCAL_IP);
            resultcnt++;
            result += ZLDM.SetDevParamInt(DevID, myDevicePara.Port, ZLDM.PARAM_DEV_LOCAL_PORT);
            resultcnt++;
            result += ZLDM.SetDevParamInt(DevID, myDevicePara.WorkMode, ZLDM.PARAM_WORK_MODE);
            resultcnt++;
            result += ZLDM.SetDevParamString(DevID, myDevicePara.NetMask, ZLDM.PARAM_NET_MASK);
            resultcnt++;
            result += ZLDM.SetDevParamString(DevID, myDevicePara.Gateway, ZLDM.PARAM_GATEWAY);
            resultcnt++;
            result += ZLDM.SetDevParamString(DevID, myDevicePara.DestIP, ZLDM.PARAM_DEST_IP);
            resultcnt++;
            result += ZLDM.SetDevParamInt(DevID, myDevicePara.DestPort, ZLDM.PARAM_DEST_PORT);
            resultcnt++;

            if (result != resultcnt)
            {
                MessageBox.Show("设置失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ZLDM.SetDevParamExcute(DevID);
                MessageBox.Show("设置成功", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonLocalIP_Click(object sender, EventArgs e)
        {
            string name = Dns.GetHostName();
            IPAddress[] ipadrlist = Dns.GetHostAddresses(name);
            foreach (IPAddress ipa in ipadrlist)
            {
                if (ipa.AddressFamily == AddressFamily.InterNetwork)
                    MessageBox.Show(ipa.ToString());
            }
        }

    }

    [Serializable]
    class DevicePara : SaveFileHexClass<DevicePara>
    {
        public string DeviceName = "ZLDEV0001";
        public int BaudRate = 11; //115200 
        public int DataBits = 0;
        public int Parity = 0;
        public int StopBits = 0;
        public int FlowControl = 0;
        public int IPMode = 0;
        public string IPaddress = "192.168.1.200";
        public int Port = 4196;
        public int WorkMode = 0;
        public string NetMask = "255.255.255.0";
        public string Gateway = "192.168.1.1";
        public string DestIP = "192.168.1.211";
        public int DestPort = 4096;


        public readonly string Path_PathName;
        
        public DevicePara()
            : base(".ZLDMpara")
        {
            Path_PathName = System.AppDomain.CurrentDomain.BaseDirectory + "ZLDMuserPara" +base.FileExc;
        }

        public void Save()
        {
            base.Save(this.Path_PathName);            
        }

    }
}
