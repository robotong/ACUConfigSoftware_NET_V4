using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ZLDevManage;

namespace ACUConfig_NETVer4
{
    public partial class FormDeviceManagement : Form
    {
        const int Index类型 = 0;
        const int Index设备名称 = 1;
        const int Index设备IP = 2;
        const int Index目的IP = 3;
        const int Index模式 = 4;
        const int IndexTCP连接 = 5;
        const int Index虚拟串口号 = 6;
        const int Index虚拟串口状态 = 7;
        const int Index设备ID = 8;

        FormEditDevice formEditDevice;

        public FormDeviceManagement()
        {
            InitializeComponent();
        }

        private void FormDeviceManagement_Load(object sender, EventArgs e)
        {
            string mes = "初始化失败!\r\n\r\n";
            mes += "中止：停止打开“" + this.Text + "”窗口\r\n";
            mes += "重试：重新初始化\r\n";
            mes += "忽略：不进行初始化，直接打开窗口\r\n";
            while (0 == ZLDM.Init(4196))
            {
                DialogResult result = MessageBox.Show(mes, "警告", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
                if (result == System.Windows.Forms.DialogResult.Abort)
                {
                    this.Close();
                    break;
                }
                else if (result == System.Windows.Forms.DialogResult.Ignore)
                    break;
            }

            this.dataGridView1.Rows.Clear();
            this.toolStripStatusLabel1.Text = "";
        }

        private void FormDeviceManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            ZLDM.Exit();
        }

        private void button_StartSearchDev_Click(object sender, EventArgs e)
        {

            int DeviceNumber, paraInt;
            string DevID;
            DeviceNumber = ZLDM.StartSearchDev();

            this.dataGridView1.Rows.Clear();
            if (DeviceNumber > 0)
                this.dataGridView1.Rows.Add(DeviceNumber);

            for (int i = 0; i < DeviceNumber; i++)
            {
                //设备ID
                //DevID = ZLDM.GetDevID(0);//只能显示第一个设备
                DevID = ZLDM.GetDevID(i);
                this.dataGridView1.Rows[i].Cells[Index设备ID].Value = DevID;
                //类型
                paraInt = ZLDM.GetDevParamInt(DevID, ZLDM.PARAM_DEV_EXIST_IN_SUBNET);
                this.dataGridView1.Rows[i].Cells[Index类型].Value = Enum.Parse(typeof(ParamDevExitInSubnet), paraInt.ToString()).ToString();
                //设备名称
                this.dataGridView1.Rows[i].Cells[Index设备名称].Value = ZLDM.GetDevParamString(DevID, ZLDM.PARAM_DEV_NAME);
                //设备IP
                this.dataGridView1.Rows[i].Cells[Index设备IP].Value = ZLDM.GetDevParamString(DevID, ZLDM.PARAM_DEV_LOCAL_IP);
                //目的IP
                this.dataGridView1.Rows[i].Cells[Index目的IP].Value = ZLDM.GetDevParamString(DevID, ZLDM.PARAM_DEST_IP);
                //模式
                paraInt = ZLDM.GetDevParamInt(DevID, ZLDM.PARAM_WORK_MODE);
                this.dataGridView1.Rows[i].Cells[Index模式].Value = Enum.Parse(typeof(ParamWorkMode), paraInt.ToString()).ToString();
                //TCP连接状态
                paraInt = ZLDM.GetDevParamInt(DevID, ZLDM.PARAM_LINK_STATUS);
                this.dataGridView1.Rows[i].Cells[IndexTCP连接].Value = Enum.Parse(typeof(ParamLinkStatus), paraInt.ToString()).ToString();
            }


            this.toolStripStatusLabel1.Text = "搜索到" + DeviceNumber.ToString() + "个设备";

        }

        private void buttonEditDevice_Click(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = "";
            if (this.dataGridView1.SelectedCells.Count > 0)
            {
                int rowIndex = this.dataGridView1.SelectedCells[0].RowIndex;
                string deviceID = this.dataGridView1.Rows[rowIndex].Cells[Index设备ID].Value.ToString();
                //MessageBox.Show(deviceID);
                if (formEditDevice == null)
                    formEditDevice = new FormEditDevice(deviceID);
                if (formEditDevice.IsDisposed)
                    formEditDevice = new FormEditDevice(deviceID);
                formEditDevice.Show();
                formEditDevice.Activate();
            }
        }
    }
}
