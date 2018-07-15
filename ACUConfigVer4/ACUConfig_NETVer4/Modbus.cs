using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.IO.Ports;
using System.Net;
using System.Windows.Forms;
using System.Net.Sockets;


namespace Modbus
{
    namespace ModbusRTU_特殊修改_不通用
    {
        /// <summary>
        /// 创建日期：2016-02-23
        /// 修改日期：2016-02-25
        /// 编写：刘永钦
        /// </summary>
        public class ModbusRTU
        {
            private SerialPort2 Port;
            private ModbusRTUmode mode = ModbusRTUmode.Master;
            /// <summary>
            /// 对于从机来说，是自己的设备地址，写入无效，只能在声明对象时赋值
            /// 对于主机来说，是目标从站的地址，可以写入修改目标从站
            /// </summary>
            private byte deviceAddress = 1;

            public ModbusRTUcmdRecord CmdRecord = new ModbusRTUcmdRecord();

            private int PortBufcount;
            private byte[] PortBuf;
            private Queue<byte> PortBufQueue = new Queue<byte>();
            private bool recieved = false;
            /// <summary>
            /// 读取来的字
            /// </summary>
            public ModebusRTUResultBuffer Buffer = new ModebusRTUResultBuffer();

            #region 属性
            /// <summary>
            /// 对于从机来说，是自己的设备地址，写入无效，只能在声明对象时赋值
            /// 对于主机来说，是目标从站的地址，可以写入修改目标从站
            /// </summary>
            public byte DeviceAddress
            {
                get { return this.deviceAddress; }
                set
                {
                    if (this.mode == ModbusRTUmode.Master)
                        this.deviceAddress = value;
                }
            }

            /// <summary>
            /// 读取之后自动复位为false
            /// </summary>
            public bool Recieved
            {
                get
                {
                    if (this.recieved)
                    {
                        this.recieved = false;
                        return true;
                    }
                    else
                        return false;
                }
            }

            public bool IsConnected
            {
                get { return this.Port.IsConnected; }
            }

            #endregion

            public ModbusRTU(SerialPort2 port,ModbusRTUmode mode)
            {
                this.Port = port;
                this.mode = mode;
                this.deviceAddress = 1;
            }
            public ModbusRTU(SerialPort port, ModbusRTUmode mode)
            {
                this.Port = new SerialPort2(port);
                this.mode = mode;
                this.deviceAddress = 1;
            }

            public ModbusRTU(SerialPort2 port, ModbusRTUmode mode, byte deviceAddress)
            {
                this.Port = port;
                this.mode = mode;
                this.deviceAddress = deviceAddress;
            }

            /// <summary>
            /// 长时间未得到响应，可以调用这个函数
            /// </summary>
            public void Reset()
            {
                PortBufcount = 0;
                PortBufQueue.Clear();
                recieved = false;
                Buffer.Clear();
                CmdRecord.Enable = false;
            }

            #region Modbus命令
            /// <summary>
            /// 功能码03(0x03)
            /// 发送读保持寄存器(4x)的命令
            /// </summary>
            /// <param name="address">寄存器起始地址</param>
            /// <param name="length">寄存器数量</param>
            public void ReadHoldingRegisters(ushort address, ushort length)
            {
                List<byte> buf = new List<byte>();
                ushort regAddr = address;
                short tmpBigEndian;

                if (regAddr >= 40000)
                    regAddr -= 40000;
                //地址域
                buf.Add(this.deviceAddress);

                //PDU
                buf.Add(3);
                tmpBigEndian = IPAddress.HostToNetworkOrder((short)regAddr);
                buf.AddRange(BitConverter.GetBytes(tmpBigEndian));
                tmpBigEndian = IPAddress.HostToNetworkOrder((short)length);
                buf.AddRange(BitConverter.GetBytes(tmpBigEndian));

                //校验
                ushort CRCcode = this.CalcCRC16(buf.ToArray());
                buf.AddRange(BitConverter.GetBytes(CRCcode));

                CmdRecord.Enable = true;
                CmdRecord.Address = address;
                CmdRecord.FunctionCode = 3;
                CmdRecord.Length = length;
                
                this.Port.Write(buf.ToArray(), 0, buf.Count);
            }

            /// <summary>
            /// 功能码04(0x04)
            /// 发送读输入寄存器(3x)的命令
            /// </summary>
            /// <param name="address">寄存器地址</param>
            public void ReadInputRegisters(ushort address, ushort length)
            {
                List<byte> buf = new List<byte>();
                short tmpBigEndian;
                //地址域
                buf.Add(this.deviceAddress);

                //PDU
                buf.Add(4);
                tmpBigEndian = IPAddress.HostToNetworkOrder((short)address);
                buf.AddRange(BitConverter.GetBytes(tmpBigEndian));
                tmpBigEndian = IPAddress.HostToNetworkOrder((short)length);
                buf.AddRange(BitConverter.GetBytes(tmpBigEndian));

                //校验
                ushort CRCcode = this.CalcCRC16(buf.ToArray());
                buf.AddRange(BitConverter.GetBytes(CRCcode));

                CmdRecord.Enable = true;
                CmdRecord.Address = address;
                CmdRecord.FunctionCode = 4;
                CmdRecord.Length = length;

                this.Port.Write(buf.ToArray(), 0, buf.Count);
                
            }

            /// <summary>
            /// 功能码05(0x05)
            /// 发送写单个线圈(0x)的命令
            /// </summary>
            /// <param name="address">线圈地址</param>
            /// <param name="value">数值</param>
            public void WriteSingleCeil(ushort address, bool value)
            {
                List<byte> buf = new List<byte>();
                short tmpBigEndian;
                //地址域
                buf.Add(this.deviceAddress);

                //PDU
                buf.Add(5);
                tmpBigEndian = IPAddress.HostToNetworkOrder((short)address);
                buf.AddRange(BitConverter.GetBytes(tmpBigEndian));
                if (value)
                    buf.Add(0xff);
                else
                    buf.Add(0x00);
                buf.Add(0x00);

                //校验
                ushort CRCcode = this.CalcCRC16(buf.ToArray());
                buf.AddRange(BitConverter.GetBytes(CRCcode));

                CmdRecord.Enable = true;
                CmdRecord.Address = address;
                CmdRecord.FunctionCode = 5;
                if (value)
                    CmdRecord.WriteValue = new ushort[1] { 0xff00 };
                else
                    CmdRecord.WriteValue = new ushort[1] { 0x0000 };

                this.Port.Write(buf.ToArray(), 0, buf.Count);
            }

            /// <summary>
            /// 功能码06(0x06)
            /// 发送写入单个寄存器的命令
            /// </summary>
            /// <param name="address">寄存器地址</param>
            /// <param name="value">数值（高字节在前）</param>
            public void WriteSingleResiter(ushort address, ushort value)
            {
                List<byte> buf = new List<byte>();
                UInt16 regAddr = address;
                short tmpBigEndian;

                if (regAddr >= 40000)
                    regAddr -= 40000;

                //地址域
                buf.Add(this.deviceAddress);

                //PDU
                buf.Add(6);
                tmpBigEndian = IPAddress.HostToNetworkOrder((short)regAddr);
                buf.AddRange(BitConverter.GetBytes(tmpBigEndian));
                tmpBigEndian = IPAddress.HostToNetworkOrder((short)value);
                buf.AddRange(BitConverter.GetBytes(tmpBigEndian));

                //校验
                ushort CRCcode = this.CalcCRC16(buf.ToArray());
                buf.AddRange(BitConverter.GetBytes(CRCcode));
                
                CmdRecord.Enable = true;
                CmdRecord.Address = address;
                CmdRecord.FunctionCode = 6;
                CmdRecord.WriteValue = new ushort[1] { value };

                this.Port.Write(buf.ToArray(), 0, buf.Count);
            }

            /// <summary>
            /// 功能码16(0x10)
            /// 发送写入多个寄存器的命令
            /// </summary>
            /// <param name="address">寄存器起始地址</param>
            /// <param name="value">数据数组</param>
            public void WriteMulitipleRegisters(UInt16 address, UInt16[] value)
            {
                List<byte> buf = new List<byte>();
                UInt16 regAddr = address;
                short tmpBigEndian;

                if (regAddr >= 40000)
                    regAddr -= 40000;

                //地址域
                buf.Add(this.deviceAddress);

                //PDU
                buf.Add(16);
                tmpBigEndian = IPAddress.HostToNetworkOrder((short)regAddr);
                buf.AddRange(BitConverter.GetBytes(tmpBigEndian));
                tmpBigEndian = IPAddress.HostToNetworkOrder((short)value.Length);
                buf.AddRange(BitConverter.GetBytes(tmpBigEndian));
                buf.Add((byte)(value.Length << 1));
                for (int i = 0; i < value.Length; i++)
                {
                    tmpBigEndian = IPAddress.HostToNetworkOrder((short)value[i]);
                    buf.AddRange(BitConverter.GetBytes(tmpBigEndian));
                }

                //校验
                ushort CRCcode = this.CalcCRC16(buf.ToArray());
                buf.AddRange(BitConverter.GetBytes(CRCcode));

                CmdRecord.Enable = true;
                CmdRecord.FunctionCode = 16;
                CmdRecord.Address = address;
                CmdRecord.Length = (ushort)value.Length;

                this.Port.Write(buf.ToArray(), 0, buf.Count);
            }

            /// <summary>
            /// 目前支持3xxxx和4xxxx的地址
            /// </summary>
            /// <param name="address">寄存器起始地址</param>
            /// <param name="length">寄存器数量</param>
            public void Read(ushort address, ushort length)
            {
                if (address >= 30000 && address < 40000)
                {
                    this.ReadInputRegisters((ushort)(address - 30000), length);
                }
                else if (address >= 40000)
                {
                    this.ReadHoldingRegisters((ushort)(address - 40000), length);
                }
            }
            #endregion

            #region Modbus响应
            public ModbusRespeonseResult Response()
            {
                ModbusRespeonseResult result = ModbusRespeonseResult.None;

                this.PortBufcount = this.Port.BytesToRead;
                this.PortBuf = new byte[this.PortBufcount];
                Port.Read(PortBuf, 0, PortBufcount);

                recieved = false;
                if (CmdRecord.Enable)
                {                    
                    if (PortBuf.Length < 3)
                        return ModbusRespeonseResult.None;
                    if (PortBuf[0] != this.deviceAddress)  //设备地址
                        return ModbusRespeonseResult.None;
                    if (PortBuf[1] != CmdRecord.FunctionCode)  //功能码
                        return ModbusRespeonseResult.FunctionCodeError;
                    switch (PortBuf[1])
                    {
                        case 03:
                        case 04:
                            int len = PortBuf[2];
                            if ((CmdRecord.Length << 1) != len)  //字节长度
                                return ModbusRespeonseResult.LenghInconsisten;
                            if (len + 3 > PortBuf.Length)
                                return ModbusRespeonseResult.LengthError;
                            recieved = true;
                            ushort[] buffer = new ushort[len >> 1];
                            ushort tmp;
                            for (int i = 0; i < buffer.Length; i++)
                            {
                                tmp = BitConverter.ToUInt16(PortBuf, 3 + i * 2);
                                buffer[i] = (ushort)IPAddress.NetworkToHostOrder((short)tmp);
                            }
                            this.Buffer.Clear();
                            this.Buffer.AddRange(buffer);
                            recieved = true;
                            result = ModbusRespeonseResult.Recieved;
                            break;

                        case 06:
                            tmp = BitConverter.ToUInt16(PortBuf, 2); //Register Address
                            tmp = (ushort)IPAddress.NetworkToHostOrder((short)tmp);
                            if (tmp != CmdRecord.Address)
                                return ModbusRespeonseResult.RegisterAddressError;
                            
                            tmp = BitConverter.ToUInt16(PortBuf, 4); //Register Value
                            tmp = (ushort)IPAddress.NetworkToHostOrder((short)tmp);
                            if (tmp != CmdRecord.WriteValue[0])
                                return ModbusRespeonseResult.DataWritenError;   
                         
                            result = ModbusRespeonseResult.Writen;

                            break;
                        default:
                            result = ModbusRespeonseResult.FunctionCodeError;
                            break;
                    }

                    CmdRecord.Enable = false;
                }

                return result;
            }

            byte CMD_LastLoop = 0xff;

            public ModbusRespeonseResult Response(byte[] buf)
            {
                ModbusRespeonseResult result = ModbusRespeonseResult.None;

                for (int i = 0; i < buf.Length; i++)
                    PortBufQueue.Enqueue(buf[i]);

                recieved = false;
                if (CmdRecord.Enable)
                {

                    if (PortBufQueue.Count < 3)
                        return ModbusRespeonseResult.None;
                    if (PortBufQueue.Dequeue() != this.deviceAddress)  //设备地址
                        return ModbusRespeonseResult.None;
                    byte tmp_cmd = PortBufQueue.Dequeue();
                    if (tmp_cmd != CmdRecord.FunctionCode)  //功能码
                        return ModbusRespeonseResult.FunctionCodeError;

                    switch (tmp_cmd)
                    {
                        case 03:
                        case 04:
                            int len = PortBufQueue.Dequeue();
                            if ((CmdRecord.Length << 1) != len)  //字节长度
                                return ModbusRespeonseResult.LenghInconsisten;
                            CMD_LastLoop = tmp_cmd;

                            break;
                        case 05:
                            CMD_LastLoop = tmp_cmd;
                            break;
                        case 16:
                            CMD_LastLoop = tmp_cmd;
                            break;
                        default:
                            break;
                    }

                    CmdRecord.Enable = false;

                }

                if (CMD_LastLoop != 0xff)
                {
                    byte[] bytetmp = new byte[2];
                    switch (CMD_LastLoop)
                    {
                        case 03:
                        case 04:
                            if (PortBufQueue.Count < (CmdRecord.Length << 1))
                                return ModbusRespeonseResult.None;

                            recieved = true;
                            ushort[] buffer = new ushort[CmdRecord.Length];

                            ushort tmp;
                            for (int i = 0; i < buffer.Length; i++)
                            {
                                bytetmp[0] = PortBufQueue.Dequeue();
                                bytetmp[1] = PortBufQueue.Dequeue();
                                tmp = BitConverter.ToUInt16(bytetmp, 0);
                                buffer[i] = (ushort)IPAddress.NetworkToHostOrder((short)tmp);
                            }
                            this.Buffer.Clear();
                            this.Buffer.AddRange(buffer);
                            recieved = true;

                            result = ModbusRespeonseResult.Recieved;
                            CMD_LastLoop = 0xff;

                            break;
                        case 05:
                            if (4 > PortBufQueue.Count)
                                return ModbusRespeonseResult.None;

                            bytetmp[0] = PortBufQueue.Dequeue();
                            bytetmp[1] = PortBufQueue.Dequeue();
                            tmp = BitConverter.ToUInt16(bytetmp, 0);
                            tmp = (ushort)IPAddress.NetworkToHostOrder((short)tmp);
                            if (tmp != CmdRecord.Address)
                                return ModbusRespeonseResult.RegisterAddressError;
                            
                            bytetmp[0] = PortBufQueue.Dequeue();
                            bytetmp[1] = PortBufQueue.Dequeue();
                            tmp = BitConverter.ToUInt16(bytetmp, 0);
                            tmp = (ushort)IPAddress.NetworkToHostOrder((short)tmp);
                            if (tmp != CmdRecord.WriteValue[0])
                                return ModbusRespeonseResult.DataWritenError;
                           

                            result = ModbusRespeonseResult.Recieved;
                            CMD_LastLoop = 0xff;
                            break;
                        case 06:

                            tmp = BitConverter.ToUInt16(PortBuf, 2); //Register Address
                            tmp = (ushort)IPAddress.NetworkToHostOrder((short)tmp);
                            if (tmp != CmdRecord.Address - 40000)
                                return ModbusRespeonseResult.RegisterAddressError;

                            tmp = BitConverter.ToUInt16(PortBuf, 4); //Register Value
                            tmp = (ushort)IPAddress.NetworkToHostOrder((short)tmp);
                            if (tmp != CmdRecord.WriteValue[0])
                                return ModbusRespeonseResult.DataWritenError;

                            result = ModbusRespeonseResult.Writen;

                            break;
                        case 16:
                            if (PortBufQueue.Count < 4)
                                return ModbusRespeonseResult.None;

                            CMD_LastLoop = 0xff;

                            bytetmp[0] = PortBufQueue.Dequeue();
                            bytetmp[1] = PortBufQueue.Dequeue();
                            tmp = BitConverter.ToUInt16(bytetmp, 0); //Register Address
                            tmp = (ushort)IPAddress.NetworkToHostOrder((short)tmp);
                            if (tmp != CmdRecord.Address - 4000)
                                result = ModbusRespeonseResult.RegisterAddressError;

                            bytetmp[0] = PortBufQueue.Dequeue();
                            bytetmp[1] = PortBufQueue.Dequeue();
                            tmp = BitConverter.ToUInt16(bytetmp, 0); //Register Address
                            tmp = (ushort)IPAddress.NetworkToHostOrder((short)tmp);
                            if (tmp != CmdRecord.Length)
                                result = ModbusRespeonseResult.LenghInconsisten;

                            result = ModbusRespeonseResult.Writen;

                            break;
                        default:
                            result = ModbusRespeonseResult.FunctionCodeError;
                            break;
                    }

                }

                return result;
            }

            #endregion

            #region CRC-16

            private readonly ushort[] wCRCTalbeAbs = 
            {
                0x0000, 0xCC01, 0xD801, 0x1400, 0xF001, 0x3C00, 0x2800, 0xE401, 0xA001, 0x6C00, 0x7800, 0xB401, 0x5000, 0x9C01, 0x8801, 0x4400
            };
            private ushort CalcCRC16(byte[] MessageBytes)
            {
                ushort wCRC = 0xFFFF;
                int wDataLen = MessageBytes.Length;
                byte chChar;
                for (int i = 0; i < wDataLen; i++)
                {
                    chChar = MessageBytes[i];
                    wCRC = (ushort)(wCRCTalbeAbs[(chChar ^ wCRC) & 15] ^ (ushort)(wCRC >> 4));
                    wCRC = (ushort)(wCRCTalbeAbs[((chChar >> 4) ^ wCRC) & 15] ^ (ushort)(wCRC >> 4));
                }
                return wCRC;
            }

            #endregion
        }

        public class ModebusRTUResultBuffer : List<ushort>
        {
            public ModebusRTUResultBuffer() { }

            /// <summary>
            /// 字节顺序3-4-1-2
            /// </summary>
            /// <param name="index"></param>
            /// <returns></returns>
            public float ToFloat(int index)
            {
                if (this.Count == 0)
                    return 0f;
                else if (this.Count == 1)
                    return (float)this[0];
                float result = 0;
                List<byte> tmp = new List<byte>(); 
                tmp.AddRange(BitConverter.GetBytes(this[index]));
                tmp.AddRange(BitConverter.GetBytes(this[index + 1]));
                result = BitConverter.ToSingle(tmp.ToArray(), 0);
                return result;
            }

            /// <summary>
            /// 字节顺序1-2-3-4
            /// </summary>
            /// <param name="index"></param>
            /// <returns></returns>
            public float ToFloatInverse(int index)
            {
                if (this.Count == 0)
                    return 0f;
                else if (this.Count == 1)
                    return (float)this[0];
                if (index == this.Count - 1)
                    index = this.Count - 2;
                float result = 0f;
                List<byte> tmp = new List<byte>();
//                tmp.AddRange(BitConverter.GetBytes(IPAddress.HostToNetworkOrder(this[index + 1])));
//                tmp.AddRange(BitConverter.GetBytes(IPAddress.HostToNetworkOrder(this[index])));
                tmp.AddRange(BitConverter.GetBytes(this[index + 1]));
                tmp.AddRange(BitConverter.GetBytes(this[index]));
                result = BitConverter.ToSingle(tmp.ToArray(), 0);
                return result;
            }
        }

        public enum ModbusRTUmode
        {
            Master,
            Slave
        }

        public class ModbusRTUcmdRecord
        {
            public bool Enable = false;
            public byte FunctionCode;
            /// <summary>
            /// 寄存器地址
            /// </summary>
            public ushort Address;
            public ushort Length;
            public ushort[] WriteValue;

            public ModbusRTUcmdRecord() { }
        }

        /// <summary>
        /// 将TCP 伪装成 serial串口
        /// </summary>
        public class SerialPort2
        {
            Socket socketControl;
            SerialPort serialPort;

            bool IsSerialPort;

            int bytesToRead;
            public int BytesToRead
            {
                get { return bytesToRead; }
                set
                {
                    bytesToRead = value;
                }
            }

            public bool IsConnected
            {
                get 
                {
                    if (IsSerialPort)
                        return this.serialPort.IsOpen;
                    else
                        return this.socketControl.Connected; ;
                }
            }

            public SerialPort2(Socket _socketControl)
            {
                this.socketControl = _socketControl;
                IsSerialPort = false;
            }

            public SerialPort2(SerialPort serial_port)
            {
                this.serialPort = serial_port;
                IsSerialPort = true;
            }


            public void Write(byte[] buf, int offset, int count)
            {
                if(IsSerialPort)
                {
                    serialPort.Write(buf, offset, count);
                }
                else
                {
                    socketControl.Send(buf, count, 0);
                }
            }

            public void Read(byte[] buf, int offset, int count)
            {
                if(IsSerialPort)
                {
                    serialPort.Read(buf, offset, count);
                }
                else
                {
                    socketControl.Receive(buf, count, 0);
                }
            }

        }

        public enum ModbusRespeonseResult
        {
            None,
            Recieved,
            Writen,
            CRCError,
            FunctionCodeError,
            /// <summary>
            /// 收到字节数不全
            /// </summary>
            LenghInconsisten,
            /// <summary>
            /// 与请求的字节长度不一致
            /// </summary>
            LengthError,
            RegisterAddressError,
            DataWritenError
        }
    }
}
