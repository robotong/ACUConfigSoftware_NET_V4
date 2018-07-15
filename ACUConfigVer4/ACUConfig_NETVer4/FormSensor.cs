using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Modbus.ModbusRTU_特殊修改_不通用;

namespace ACUConfig_NETVer4
{
    public partial class FormSensor : Form
    {
        ModbusRTU Master;

        const int SENSOR_COUNT_MAX = 32;

        SensorConfig SensorConfi1 = new SensorConfig();

        public FormSensor(ModbusRTU master)
        {
            InitializeComponent();

            Master = master;
        }

        private void FormSensor_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < SENSOR_COUNT_MAX; i++)
            {
                this.comboBoxSensorNo.Items.Add(i);
            }

            this.comboBoxSensorNo.SelectedIndex = 0;

            toolStripStatusLabel1.Text = "";
            timer1.Interval = Form1.MODBUS_RESPONSE_TIME_MAX_MM;
        }

        private void comboBoxSensorNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonRead_Click(this.buttonRead, new EventArgs());
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            try
            {
                if (Master.IsConnected)
                {
                    if (comboBoxSensorNo.SelectedIndex >= 0)
                    {
                        ushort add = SensorConfig.RWHeadAddress;
                        add += Convert.ToUInt16(comboBoxSensorNo.SelectedIndex * SensorConfig.RWregCount);

                        Master.ReadHoldingRegisters(add, SensorConfig.RWregCount);

                        this.toolStripStatusLabel1.Text = "正在读取(0/2)……";
                        timer1.Start();
                    }
                }
                else { MessageBox.Show("Socket未连接或者串口未打开", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void buttonWrite_Click(object sender, EventArgs e)
        {
            try
            {
                if (Master.IsConnected)
                {
                    if (comboBoxSensorNo.SelectedIndex >= 0)
                    {
                        ushort add = SensorConfig.RWHeadAddress;
                        add += Convert.ToUInt16(comboBoxSensorNo.SelectedIndex * SensorConfig.RWregCount);

                        SensorConfi1.SensorNumber = Convert.ToUInt16(this.textBoxSensorNumber.Text);
                        SensorConfi1.SensorAddress = Convert.ToUInt16(this.textBoxSensorAddress.Text);
                        SensorConfi1.SensorSerialNumber = Convert.ToUInt16(this.textBoxSensorSerialNumber.Text);
                        SensorConfi1.DataFirstAddress = Convert.ToUInt16(this.textBoxDataFirstAddress.Text);
                        SensorConfi1.DataQuantity = Convert.ToUInt16(this.textBoxDataQuantity.Text);

                        Master.WriteMulitipleRegisters(add, SensorConfi1.GetRWdataArray());

                        this.toolStripStatusLabel1.Text = "正在写入……";
                        timer1.Start();
                    }
                }
                else { MessageBox.Show("Socket未连接或者串口未打开", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        public void ShowSensorRWdata(ushort regAddr, ushort[] dataArr)
        {
            SensorConfi1.SetRWdataValued(regAddr, dataArr);

            this.textBoxSensorNo.Text = SensorConfi1.SensorNo.ToString();
            this.textBoxSensorNumber.Text = SensorConfi1.SensorNumber.ToString();
            this.textBoxSensorAddress.Text = SensorConfi1.SensorAddress.ToString();
            this.textBoxSensorSerialNumber.Text = SensorConfi1.SensorSerialNumber.ToString();
            this.textBoxDataFirstAddress.Text = SensorConfi1.DataFirstAddress.ToString();
            this.textBoxDataQuantity.Text = SensorConfi1.DataQuantity.ToString();

            this.textBoxDataRegAddress.Text = "";
            this.comboBoxSensorState.SelectedIndex = -1;

            try
            {
                if (Master.IsConnected)
                {
                    if (comboBoxSensorNo.SelectedIndex >= 0)
                    {
                        ushort add = SensorConfig.ROHeadAddress;
                        add += Convert.ToUInt16(comboBoxSensorNo.SelectedIndex * SensorConfig.ROregCount);

                        Master.ReadHoldingRegisters(add, SensorConfig.ROregCount);

                        this.toolStripStatusLabel1.Text = "正在读取(1/2)……";
                    }
                }
                else { MessageBox.Show("Socket未连接或者串口未打开", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        public void ShowSensorROdata(ushort[] dataArr)
        {
            SensorConfi1.SetROdataValued(dataArr);

            this.textBoxDataRegAddress.Text = SensorConfi1.DataRegAddress.ToString();
            this.comboBoxSensorState.SelectedIndex = SensorConfi1.SensorSate;

            timer1.Stop();
            this.toolStripStatusLabel1.Text = "读取成功";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "响应超时";
            timer1.Stop();
        }

    }

    public class SensorConfig
    {
        public const ushort RWHeadAddress = 42000;
        public const ushort RWTailAddress = 42999;
        public const int RWregCount = 5;

        public const ushort ROHeadAddress = 43128;
        public const ushort ROTailAddress = 43191;
        public const int ROregCount = 2;

        public int SensorNo;

        public ushort SensorNumber;
        public ushort SensorAddress;
        public ushort SensorSerialNumber;
        public ushort DataFirstAddress;
        public ushort DataQuantity;
        public ushort DataRegAddress;
        public ushort SensorSate;

        public SensorConfig() { }

        public void SetRWdataValued(ushort regAddr, ushort[] array)
        {
            this.SensorNumber = array[0];
            this.SensorAddress = array[1];
            this.SensorSerialNumber = array[2];
            this.DataFirstAddress = array[3];
            this.DataQuantity = array[4];

            SensorNo = Convert.ToInt32(regAddr - RWHeadAddress);
            SensorNo /= RWregCount;
        }
        public ushort[] GetRWdataArray()
        {
            ushort[] result = new ushort[RWregCount];

            result[0] = this.SensorNumber;
            result[1] = this.SensorAddress;
            result[2] = this.SensorSerialNumber;
            result[3] = this.DataFirstAddress;
            result[4] = this.DataQuantity;

            return result;
        }

        public void SetROdataValued(ushort[] array)
        {
            this.DataRegAddress = array[0];
            this.SensorSate = array[1];
        }
    }
}
