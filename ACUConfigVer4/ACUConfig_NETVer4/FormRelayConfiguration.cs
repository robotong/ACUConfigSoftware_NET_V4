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

                        if (this.checkBoxDataON1.CheckState == CheckState.Checked)
                        {
                            RelayConfig1.DataON1 = 1;
                        }
                        else
                        {
                            RelayConfig1.DataON1 = 0;
                        }

                        if (this.checkBoxDataON2.CheckState == CheckState.Checked)
                        {
                            RelayConfig1.DataON2 = 1;
                        }
                        else
                        {
                            RelayConfig1.DataON2 = 0;
                        }

                        if (this.checkBoxDataON3.CheckState == CheckState.Checked)
                        {
                            RelayConfig1.DataON3 = 1;
                        }
                        else
                        {
                            RelayConfig1.DataON3 = 0;
                        }

                        if (this.checkBoxDataON4.CheckState == CheckState.Checked)
                        {
                            RelayConfig1.DataON4 = 1;
                        }
                        else
                        {
                            RelayConfig1.DataON4 = 0;
                        }

                        RelayConfig1.WhichSensor1 = this.comboBoxWhichSensor1.SelectedIndex;
                        RelayConfig1.WhichData1 = this.comboBoxWhichData1.SelectedIndex;
                        RelayConfig1.WhichSensor2 = this.comboBoxWhichSensor2.SelectedIndex;
                        RelayConfig1.WhichData2 = this.comboBoxWhichData2.SelectedIndex;
                        RelayConfig1.WhichSensor3 = this.comboBoxWhichSensor3.SelectedIndex;
                        RelayConfig1.WhichData3 = this.comboBoxWhichData3.SelectedIndex;
                        RelayConfig1.WhichSensor4 = this.comboBoxWhichSensor4.SelectedIndex;
                        RelayConfig1.WhichData4 = this.comboBoxWhichData4.SelectedIndex;

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
          //  this.comboBoxWitchDataH.SelectedIndex = RelayConfig1.WitchDataH;
          //  this.comboBoxWhichDataL.SelectedIndex = RelayConfig1.WitchDataL;

            this.comboBoxWhichSensor1.SelectedIndex = RelayConfig1.WhichSensor1;
            this.comboBoxWhichData1.SelectedIndex = RelayConfig1.WhichData1;
            if (RelayConfig1.DataON1 == 1)
            {
                this.checkBoxDataON1.CheckState = CheckState.Checked;
            }
            else
            {
                this.checkBoxDataON1.CheckState = CheckState.Unchecked;
            }

            this.comboBoxWhichSensor2.SelectedIndex = RelayConfig1.WhichSensor2;
            this.comboBoxWhichData2.SelectedIndex = RelayConfig1.WhichData2;
            if (RelayConfig1.DataON2 == 1)
            {
                this.checkBoxDataON2.CheckState = CheckState.Checked;
            }
            else
            {
                this.checkBoxDataON2.CheckState = CheckState.Unchecked;
            }

            this.comboBoxWhichSensor3.SelectedIndex = RelayConfig1.WhichSensor3;
            this.comboBoxWhichData3.SelectedIndex = RelayConfig1.WhichData3;
            if (RelayConfig1.DataON3 == 1)
            {
                this.checkBoxDataON3.CheckState = CheckState.Checked;
            }
            else
            {
                this.checkBoxDataON3.CheckState = CheckState.Unchecked;
            }

            this.comboBoxWhichSensor4.SelectedIndex = RelayConfig1.WhichSensor4;
            this.comboBoxWhichData4.SelectedIndex = RelayConfig1.WhichData4;
            if (RelayConfig1.DataON4 == 1)
            {
                this.checkBoxDataON4.CheckState = CheckState.Checked;
            }
            else
            {
                this.checkBoxDataON4.CheckState = CheckState.Unchecked;
            }

            

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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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

        public int WhichSensor1;
        public int WhichData1;
        public int WhichSensor2;
        public int WhichData2;
        public int WhichSensor3;
        public int WhichData3;
        public int WhichSensor4;
        public int WhichData4;
        public int DataON1;
        public int DataON2;
        public int DataON3;
        public int DataON4;

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
            //result[3] = this.Baud;
            //result[4] = Convert.ToUInt16(this.WitchDataH << 8 + this.WitchDataL);

            //result[3] = Convert.ToUInt16((this.WhichSensor2 << 11) + (this.WhichData2 << 9) + (this.DataON2 << 8) + (this.WhichSensor1 << 3) + (this.WhichData1 << 1) + this.DataON1);
            result[3] = Convert.ToUInt16((this.WhichSensor2 << 11) + (this.WhichData2 << 9) + (this.DataON2 << 8) + (this.WhichSensor1 << 3) + (this.WhichData1 << 1) + this.DataON1);
            result[4] = Convert.ToUInt16((this.WhichSensor4 << 11) + (this.WhichData4 << 9) + (this.DataON4 << 8) + (this.WhichSensor3 << 3) + (this.WhichData3 << 1) + this.DataON3);

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
            //this.WitchDataH = (Convert.ToInt32(array[4]) >> 8) & 0xff;
            //this.WitchDataL = (Convert.ToInt32(array[4])) & 0xff;

            this.WhichSensor1 = (Convert.ToInt32(array[3]) >> 3) & 0x1F;
            this.WhichData1 = (Convert.ToInt32(array[3]) >> 1) & 0x03;
            this.DataON1 = (Convert.ToInt32(array[3]) ) & 0x01;

            this.WhichSensor2 = (Convert.ToInt32(array[3]) >> 11) & 0x1F;
            this.WhichData2 = (Convert.ToInt32(array[3]) >> 9) & 0x03;
            this.DataON2 = (Convert.ToInt32(array[3] >> 8)) & 0x01;

            this.WhichSensor3 = (Convert.ToInt32(array[4]) >> 3) & 0x1F;
            this.WhichData3 = (Convert.ToInt32(array[4]) >> 1) & 0x03;
            this.DataON3 = (Convert.ToInt32(array[4])) & 0x01;

            this.WhichSensor4 = (Convert.ToInt32(array[4]) >> 11) & 0x1F;
            this.WhichData4 = (Convert.ToInt32(array[4]) >> 9) & 0x03;
            this.DataON4 = (Convert.ToInt32(array[4]) >> 8) & 0x01;

            this.Polar = array[5];
            this.InputNum = array[5];
            this.Status = ((int)array[7]) != 0;

            RelayAddr = Convert.ToInt32(regAddr-RegHeadAddress);
            RelayAddr /= RegCount;
        }
    }
}
