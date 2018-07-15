using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Security;
using System.Security.Cryptography;

namespace LiuCommoncodes
{
    #region 以二进制形式存储在磁盘和从磁盘读取的方法

    /// <summary>
    /// 以二进制形式存储在磁盘和从磁盘读取的方法
    /// </summary>
    /// <typeparam name="T">子类的类型</typeparam>
    [Serializable]
    static class SaveFileHexFunction<T> where T : class,new()
    {
        public static void Save(string PathAndName, object obj)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(StringOperation.GetPath(PathAndName));
                if (!dir.Exists)
                    dir.Create();
                IFormatter serializer = new BinaryFormatter();
                FileStream SaveFile = new FileStream(PathAndName, FileMode.Create, FileAccess.ReadWrite);
                serializer.Serialize(SaveFile, obj);
                SaveFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public static T Load(string PathAndName)
        {
            try
            {
                FileStream LoadFile = new FileStream(PathAndName, FileMode.Open, FileAccess.Read);
                IFormatter serializer = new BinaryFormatter();
                T result;
                try
                {
                    result = serializer.Deserialize(LoadFile) as T;
                }
                catch (Exception ex)
                {
                    result = new T();
                }
                LoadFile.Close();
                return result;
            }
            catch (FileNotFoundException) { return new T(); }
            catch (DirectoryNotFoundException) { return new T(); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return new T();
            }
        }
    }

    /// <summary>
    /// 以二进制形式存储在磁盘和从磁盘读取的方法
    /// </summary>
    /// <typeparam name="T">子类的类型</typeparam>
    [Serializable]
    class SaveFileHexClass<T> where T : class,new()
    {
        public readonly string FileExc;

        public SaveFileHexClass(string fileexc)
        {
            FileExc = fileexc;
        }

        public void Save(string PathAndName)
        {
            SaveFileHexFunction<T>.Save(PathAndName, this);
        }

        public static T Load(string PathAndName)
        {
            return SaveFileHexFunction<T>.Load(PathAndName);
        }
    }
    #endregion

    #region 新的list<>
    /// <summary>
    /// 含有以二进制形式存储在磁盘和从磁盘读取的方法
    /// 含有与ListBox控件交互的方法
    /// </summary>
    /// <typeparam name="T1">元素的类型</typeparam>
    /// <typeparam name="T2">子类的类型</typeparam>
    [Serializable]
    class NewList<T1, T2> : List<T1> where T2 : class,new()
    {
        public readonly string FileExc;
        public object listBox;

        public NewList(string fileexc)
        {
            FileExc = fileexc;
            listBox = null;
        }

        #region 以二进制形式存入磁盘
        public void Save(string PathAndName)
        {
            ListBox tmp = (ListBox)this.listBox;
            this.listBox = null;
            SaveFileHexFunction<T2>.Save(PathAndName, this);
            this.listBox = tmp;
        }
        public static T2 Load(string PathAndName)
        {
            return SaveFileHexFunction<T2>.Load(PathAndName);
        }
        #endregion

        #region ListBox中的添加、删除、插入、上移、下移
        /// <summary>
        /// 将所有项显示在LisBox控件里，必要时元素的类里需要重写ToString()方法
        /// </summary>
        public void ShowInListBox()
        {
            ((ListBox)this.listBox).Items.Clear();
            for (int i = 0; i < this.Count; i++)
                ((ListBox)this.listBox).Items.Add(this[i].ToString());
        }

        /// <summary>
        /// 添加一个新项，
        /// 如果关联了ListBox控件，会显示在ListBox控件上
        /// </summary>
        /// <param name="item"></param>
        public new void Add(T1 item)
        {
            base.Add(item);
            if (this.listBox != null)
            {
                this.ShowInListBox();
                ((ListBox)this.listBox).SelectedIndex = this.Count - 1;
            }
        }

        /// <summary>
        /// 删除ListBox里被选择的项
        /// </summary>
        public void Remove()
        {
            if (this.listBox != null)
            {
                int index = ((ListBox)this.listBox).SelectedIndex;
                if (index >= 0)
                {
                    base.RemoveAt(index);
                    this.ShowInListBox();
                }
                else
                    MessageBox.Show("未选择任何项", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 删除所有项，并在ListBox里显示
        /// </summary>
        public new void RemoveAll()
        {
            this.Clear();
            if (this.listBox != null)
                this.ShowInListBox();
        }

        /// <summary>
        /// 在ListBox选中处插入新项
        /// </summary>
        /// <param name="item">新的项</param>
        public void Insert(T1 item)
        {
            if (this.listBox != null)
            {
                int index = ((ListBox)this.listBox).SelectedIndex;
                if (index >= 0)
                {
                    base.Insert(index, item);
                    this.ShowInListBox();
                    ((ListBox)this.listBox).SelectedIndex = index;
                }
                else
                    MessageBox.Show("未选择任何项", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 更新ListBox的选中项，用形参item代替选中的项
        /// </summary>
        /// <param name="item">新的项</param>
        public void Renew(T1 item)
        {
            if (this.listBox != null)
            {
                int index = ((ListBox)this.listBox).SelectedIndex;
                if (index >= 0)
                {
                    base.RemoveAt(index);
                    base.Insert(index, item);
                    this.ShowInListBox();
                    ((ListBox)this.listBox).SelectedIndex = index;
                }
                else
                    MessageBox.Show("未选择任何项", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 将ListBox中的选中项上移
        /// </summary>
        public void Up()
        {
            if (this.listBox != null)
            {
                int index = ((ListBox)this.listBox).SelectedIndex;
                if (index > 0)
                {
                    T1 tmp = this[index];
                    base.RemoveAt(index);
                    base.Insert(index - 1, tmp);
                    this.ShowInListBox();
                    ((ListBox)this.listBox).SelectedIndex = index - 1;
                }
                else if (index == 0)
                    MessageBox.Show("已经在最顶端", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("未选择任何项", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Down()
        {
            if (this.listBox != null)
            {
                int index = ((ListBox)this.listBox).SelectedIndex;
                if (index < 0)
                    MessageBox.Show("未选择任何项", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (index >= this.Count - 1)
                    MessageBox.Show("已经在最底端", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    T1 tmp = this[index];
                    base.RemoveAt(index);
                    base.Insert(index + 1, tmp);
                    this.ShowInListBox();
                    ((ListBox)this.listBox).SelectedIndex = index + 1;
                }
            }
        }
        #endregion

    }
    #endregion

    #region 实用的字符串操作
    /// <summary>
    /// 实用字符串常用操作（2016-3-29更新）
    /// </summary>
    static public class StringOperation
    {
        /// <summary>
        /// 从路完整径字符串中分离出路径
        /// （暂无异常处理，请自觉按规范使用）
        /// </summary>
        /// <param name="FullName">包括文件名的完整路径</param>
        /// <returns></returns>
        public static string GetPath(string FullName)
        {
            return FullName.Substring(0, FullName.LastIndexOf("\\") + 1);
        }
        /// <summary>
        /// 从完整路径中分离出文件名（不含扩展名）。
        /// （暂无异常处理，请自觉按规范使用）
        /// </summary>
        /// <param name="FullName">包括文件名的完整路径</param>
        /// <returns></returns>
        public static string GetFileName(string FullName)
        {
            return FullName.Substring(FullName.LastIndexOf("\\") + 1, FullName.LastIndexOf(".") - (FullName.LastIndexOf("\\") + 1));
        }
        public static string GetFileexc(string FullName)
        {
            return FullName.Substring(FullName.LastIndexOf(".") + 1, FullName.Length - FullName.LastIndexOf(".") - 1);
        }

        public static byte[] HexstringToHexBytes(string hexstring)
        {
            hexstring = hexstring.Replace(" ", "");
            if (hexstring.Length % 2 != 0)
                hexstring += "0";
            byte[] result = new byte[hexstring.Length / 2];
            for (int i = 0; i < result.Length; ++i)
                result[i] = Convert.ToByte(hexstring.Substring(i * 2, 2), 16);
            return result;
        }
        public static string BytesToHexString(byte[] bytes)
        {
            string result = "";
            for (int i = 0; i < bytes.Length; ++i)
                result += bytes[i].ToString("X2");
            return result;
        }
        /// <summary>
        /// 将字节数组转换为16进制字符串
        /// </summary>
        /// <param name="bytes"></param>
        /// <param name="length">字节数组的长度</param>
        /// <returns></returns>
        public static string BytesToHexString(byte[] bytes, int length)
        {
            string result = "";
            try
            {
                for (int i = 0; i < length; ++i)
                    result += bytes[i].ToString("X2");
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            return result;
        }

        /// <summary>
        /// 从字符串中提取第一个浮点数。
        /// 如从 "X1.24 Y2.78" 中提取到浮点型的1.24
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static float GetFirtFloatInString(string str)
        {
            string sfloat = "";
            int index;
            for (index = 0; index < str.Length; index++)
            {
                if (char.IsNumber(str, index))
                    break;
            }

            for (; index < str.Length; index++)
            {
                if (char.IsNumber(str[index]) || str[index] == '.')
                {
                    sfloat += str[index];
                }
                else
                    break;
            }
            return float.Parse(sfloat);
        }

        /// <summary>
        /// 判断字符串是否为0-9的数字组成
        /// </summary>
        /// <param name="str">待检测的字符串</param>
        /// <returns></returns>
        public static bool IsNumber(string str)
        {
            if (str == null)
                return false;
            return System.Text.RegularExpressions.Regex.IsMatch(str, @"^[0-9]*$") && str != "";
        }

        /// <summary>
        /// 判断字符串是否可以转换为浮点数
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsFloat(string str)
        {
            float result;
            return float.TryParse(str, out result);
        }

        /// <summary>
        /// 判断是否为IP地址格式
        /// </summary>
        /// <param name="ip">IP地址字符串，如 "192.1.0.1"</param>
        /// <returns></returns>
        public static bool IsIP(string ip)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(ip, @"^((2[0-4]\d|25[0-5]|[01]?\d\d?)\.){3}(2[0-4]\d|25[0-5]|[01]?\d\d?)$");
        }

        /// <summary>
        /// 不明白和上一个的区别
        /// </summary>
        /// <param name="ip"></param>
        /// <returns></returns>
        public static bool IsIPSect(string ip)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(ip, @"^((2[0-4]\d|25[0-5]|[01]?\d\d?)\.){2}((2[0-4]\d|25[0-5]|[01]?\d\d?|\*)\.)(2[0-4]\d|25[0-5]|[01]?\d\d?|\*)$");
        }
    }

    #endregion

    #region 软件注册
    /// <summary>
    /// 需要添加System.Management的引用（添加引用-.NET-System.Management）
    /// </summary>
    class SoftRegister
    {
        //需要添加System.Management的引用

        static private string getCpu()
        {
            string strCpu = null;
            System.Management.ManagementClass myCpu = new System.Management.ManagementClass("win32_Processor");
            System.Management.ManagementObjectCollection myCpuConnection = myCpu.GetInstances();

            foreach (System.Management.ManagementObject myObject in myCpuConnection)
            {
                strCpu = myObject.Properties["Processorid"].Value.ToString();
                break;
            }

            return strCpu;
        }
        static private string GetDiskVolumeSerialNumber()
        {
            System.Management.ManagementClass mc = new System.Management.ManagementClass("win32_NetWorkAdapterConfiguration");
            System.Management.ManagementObject disk = new System.Management.ManagementObject("win32_logicaldisk.deviceid=\"d:\"");

            disk.Get();
            return disk.GetPropertyValue("VolumeSerialNumber").ToString();
        }
        static public string getMNum()
        {
            string strMNum = "您没有赋予软件读取CPU和硬盘序列号的权限，读取失败";
            try
            {
                string strNum = getCpu() + GetDiskVolumeSerialNumber();
                strMNum = strNum.Substring(0, 24);
            }
            catch (SecurityException ex) { MessageBox.Show("您没有赋予软件读取CPU和硬盘序列号的权限，读取失败。详细错误如下\r\n\r\n" + ex.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (Exception ex) { MessageBox.Show("读取机器码失败。详细错误如下\r\n\r\n" + ex.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            return strMNum;
        }

        static public string GetNetCardMacAddress()
        {
            string str = "您没有赋予软件读取网卡MAC地址的权限，读取失败"; //用于存储网卡序列号
            try
            {
                System.Management.ManagementClass mc = new System.Management.ManagementClass("Win32_NetworkAdapterConfiguration"); //创建 ManagementClass 对象
                System.Management.ManagementObjectCollection moc = mc.GetInstances(); //创建 ManagementObjectCollection 对象
                foreach (System.Management.ManagementObject mo in moc) //遍历得到的集合
                {
                    if ((bool)mo["IPEnabled"] == true) //判断 IPEnabled 属性是否为 true
                        str = mo["MacAddress"].ToString(); //获取网卡序列号
                }
            }
            catch (SecurityException ex) { MessageBox.Show("您没有赋予软件读取网卡MAC地址的权限，读取失败。详细错误如下\r\n\r\n" + ex.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (Exception ex) { MessageBox.Show("读取网卡MAC地址失败。详细错误如下\r\n\r\n" + ex.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            return str;
        }

        static public string getRNum_md5(string mNum)
        {
            string rNum = "";
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] palindata = Encoding.Default.GetBytes(mNum);  //将需要加密的字符串转换为字节数组
            byte[] encryptdata = md5.ComputeHash(palindata);  //将字符串加密后也转换为字符数组
            rNum = Convert.ToBase64String(encryptdata);
            return rNum;
        }

        byte[] RandArr2 = new byte[]
        {
        0x50,0x23,0x1B,0x4A,0x07,0x36,0x18,0x0A,
        0x30,0x0D,0x41,0x35,0x04,0x37,0x1D,0x48,
        0x44,0x0C,0x47,0x57,0x2F,0x05,0x2C,0x14,
        0x27,0x09,0x40,0x02,0x2D,0x1C,0x55,0x26,
        0x4E,0x4C,0x2A,0x20,0x43,0x16,0x46,0x56,
        0x3C,0x3B,0x5A,0x42,0x31,0x4B,0x25,0x11,
        0x54,0x24,0x34,0x17,0x4D,0x3D,0x49,0x51,
        0x06,0x45,0x38,0x0E,0x3A,0x32,0x3F,0x15,
        0x33,0x10,0x03,0x39,0x2E,0x59,0x19,0x3E,
        0x58,0x4F,0x29,0x1A,0x0B,0x2B,0x21,0x5B,
        0x5C,0x12,0x53,0x08,0x00,0x28,0x13,0x5D,
        0x22,0x52,0x0F,0x1F,0x01,0x1E,
        };
        byte[] RandArr1 = new byte[]
        {
        0x2A,0x7C,0x3B,0x55,0x43,0x62,0x29,0x6F,
        0x59,0x37,0x58,0x60,0x33,0x23,0x2F,0x34,
        0x64,0x65,0x22,0x39,0x4C,0x36,0x2E,0x4A,
        0x4D,0x49,0x66,0x3F,0x5C,0x6C,0x30,0x7D,
        0x4B,0x51,0x38,0x76,0x21,0x42,0x5B,0x3D,
        0x72,0x5F,0x73,0x4E,0x50,0x57,0x6A,0x67,
        0x2C,0x7E,0x48,0x77,0x3A,0x41,0x40,0x35,
        0x2D,0x61,0x52,0x2B,0x78,0x32,0x70,0x24,
        0x7B,0x5A,0x27,0x45,0x4F,0x69,0x74,0x5E,
        0x5D,0x6E,0x71,0x46,0x44,0x31,0x79,0x26,
        0x6B,0x6D,0x7A,0x3E,0x53,0x47,0x63,0x3C,
        0x54,0x56,0x25,0x28,0x68,0x75,
        };

        public string Enigma1(string word,string str)
        {
            string result = "";

            if (word.Length > 2)
                word = word.Substring(0, 2);
            else if (word.Length < 2)
                for (int i = word.Length; i < 2; i++)
                    word += "L";

            int p1 = word[0] - '!'; ;
            int p2 = word[1] - '!';
            List<byte> resultBytes = new List<byte>();
            for (int i = 0; i < str.Length; i++)
            {
                int index2 = p2 + str[i] - '!';
                index2 %= RandArr2.Length;
                int index1 = p1 + RandArr2[index2];
                index1 %= RandArr1.Length;
                resultBytes.Add(RandArr1[index1]);
                p1++;
                if (p1 >= RandArr1.Length)
                {
                    p1 = 0;
                    p2++;
                    if (p2 >= RandArr2.Length)
                        p2 = 0;
                }
            }
            result = ASCIIEncoding.ASCII.GetString(resultBytes.ToArray());
            
            return result;
        }

    }
    #endregion

}
