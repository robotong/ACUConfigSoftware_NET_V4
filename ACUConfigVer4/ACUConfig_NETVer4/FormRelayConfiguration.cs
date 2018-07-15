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
    public partial class FormRelayConfiguration : Form
    {
        ModbusRTU Master;

        RelayConfig RelayConfig1 = new RelayConfig();

        public FormRelayConfiguration(ModbusRTU master)
        {
            InitializeComponent();

            Master = master;
        }

        private void FormRelayConfiguration_Load(object sender, EventArgs e)
        {
            comboBoxRelayAddr.SelectedIndex = 0;
            timer1.Interval = Form1.MODBUS_RESPONSE_TIME_MAX_MM;
        }

        private void comboBoxRelayAddr_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonRead_Click(this.buttonRead, new EventArgs());
        }

        public void buttonRead_Click(object sender, EventArgs e)
        {
            try
            {
                if (Master.IsConnected)
                {
                    if (comboBoxRelayAddr.SelectedIndex >= 0)
                    {
                        ushort add = RelayConfig.RegHeadAddress;
                        add += Convert.ToUInt16(comboBoxRelayAddr.SelectedIndex * RelayConfig.RegCount);

                        Master.ReadHoldingRegisters(add, RelayConfig.RegCount);
                        toolStripStatusLabel1.Text = "正在读取……";
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
                    if (comboBoxRelayAddr.SelectedIndex >= 0)
                    {
                        ushort add = RelayConfig.RegHeadAddress;
                        add += Convert.ToUInt16(comboBoxRelayAddr.SelectedIndex * RelayConfig.RegCount);

                        RelayConfig1.Mode = Convert.ToUInt16(this.comboBoxMode.SelectedIndex);
                        RelayConfig1.LimitUp = Convert.ToUInt16(this.textBoxLimitUp.Text);
                        RelayConfig1.LimitDown = Convert.ToUInt16(this.textBoxLimitDown.Text);
                        RelayConfig1.Baud = Convert.ToUInt16(this.textBoxBaud.Text);
                        RelayConfig1.Polar = Convert.ToUInt16(this.comboBoxPolar.SelectedIndex);
                        RelayConfig1.InputNum = Convert.ToUInt16(this.comboBoxInputNum.SelectedIndex);
                        

                        Master.WriteMulitipleRegisters(add, RelayConfig1.GetArray());

                        toolStripStatusLabel1.Text = "正在写入……";
                        timer1.Start();
                    }
                }
                else { MessageBox.Show("Socket未连接或者串口未打开", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        public void ShowRelayData(ushort regAddr, ushort[] dataArr)
        {
            RelayConfig1.SetValue(regAddr, dataArr);

            this.textBoxRelayAddr.Text = RelayConfig1.RelayAddr.ToString();
            this.textBoxLimitUp.Text = RelayConfig1.LimitUp.ToString();
            this.textBoxLimitDown.Text = RelayConfig1.LimitDown.ToString();
            this.textBoxBaud.Text = RelayConfig1.Baud.ToString();
            this.comboBoxInputNum.SelectedIndex = RelayConfig1.InputNum;
            this.comboBoxMode.SelectedIndex = RelayConfig1.Mode;
            this.comboBoxPolar.SelectedIndex = RelayConfig1.Polar;
            this.comboBoxWitchDataH.SelectedIndex = RelayConfig1.WitchDataH;
            this.comboBoxWhichDataL.SelectedIndex = RelayConfig1.WitchDataL;
            if (RelayConfig1.Status)
                this.textBoxStatus.Text = "导通";
            else
                this.textBoxStatus.Text = "关断";

            toolStripStatusLabel1.Text = "读取成功";
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "响应超时";
            timer1.Stop();
        }

        private void buttonOpenRelay_Click(object sender, EventArgs e)
        {
            try
            {
                if (Master.IsConnected)
                {
                    int index = this.comboBoxRelayAddr.SelectedIndex;

                    Master.WriteSingleCeil((ushort)(this.comboBoxRelayAddr.SelectedIndex + RelayConfig.CeilHeadAddress), true);
                }
                else
                {
                    MessageBox.Show("Socket未连接或者串口未打开", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void buttonCloseRelay_Click(object sender, EventArgs e)
        {
            try
            {
                if (Master.IsConnected)
                {
                    int index = this.comboBoxRelayAddr.SelectedIndex;

                    Master.WriteSingleCeil((ushort)(this.comboBoxRelayAddr.SelectedIndex), false);
                }
                else
                {
                    MessageBox.Show("Socket未连接或者串口未打开", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

    }

    public class RelayConfig
    {
        public const int RegCount = 8;
        public const ushort RegHeadAddress = 41000;
        public const ushort RegTailAddress = 41999;
        public const ushort CeilHeadAddress = 0;
        public const ushort CeilTailAddress = 7;

        public UInt16 Mode;
        public UInt16 LimitUp;
        public UInt16 LimitDown;
        /// <summary>
        /// 传感器号
        /// </summary>
        public int WitchDataH;
        /// <summary>
        /// 数据号
        /// </summary>
        public int WitchDataL;
        public UInt16 Baud;
        public UInt16 Polar;
        public UInt16 InputNum;
        public bool Status;

        /// <summary>
        /// 不是Modbus寄存器
        /// </summary>
        public int RelayAddr;

        public ushort[] GetArray()
        {
            ushort[] result = new ushort[RegCount - 1];

            result[0] = this.Mode;
            result[1] = this.LimitUp;
            result[2] = this.LimitDown;
            result[3] = this.Baud;
            result[4] = Convert.ToUInt16(this.WitchDataH << 8 + this.WitchDataL);
            result[5] = this.Polar;
            result[6] = this.InputNum;

            return result;
        }

        public void SetValue(ushort regAddr, ushort[] array)
        {
            this.Mode = array[0];
            this.LimitUp = array[1];
            this.LimitDown = array[2];
            this.Baud = array[3];
            this.WitchDataH = (Convert.ToInt32(array[4]) >> 8) & 0xff;
            this.WitchDataL = (Convert.ToInt32(array[4])) & 0xff;
            this.Polar = array[5];
            this.InputNum = array[5];
            this.Status = ((int)array[7]) != 0;

            RelayAddr = Convert.ToInt32(regAddr-RegHeadAddress);
            RelayAddr /= RegCount;
        }
    }
}
