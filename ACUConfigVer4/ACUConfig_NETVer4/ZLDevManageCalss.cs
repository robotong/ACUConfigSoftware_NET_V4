using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.InteropServices;

namespace ZLDevManage
{
    class ZLDM
    {
        public const int PARAM_SET_TO_DEFAULT = 0;
        public const int PARAM_DEV_EXIST_IN_SUBNET = 1;
        public const int PARAM_DEV_LOCAL_IP = 2;
        public const int PARAM_DEV_LOCAL_PORT = 3;
        public const int PARAM_DEV_OUTER_IP = 4;
        public const int PARAM_ALL_SUBNET_ID = 5;
        public const int PARAM_SIMULATE_PORT = 6;
        public const int PARAM_P2P_STATUS_CODE = 7;
        public const int PARAM_P2P_STATUS_CHS = 8;
        public const int PARAM_P2P_STATUS_EN = 9;
        public const int PARAM_WORK_MODE = 256;
        public const int PARAM_IP_MODE = 257;
        public const int PARAM_FLOW_CONTROL = 258;
        public const int PARAM_DEST_MODE = 259;
        public const int PARAM_APP_PROTOCOL = 260;
        public const int PARAM_STOP_BIT = 261;
        public const int PARAM_PARITY = 262;
        public const int PARAM_DATA_BITS = 263;
        public const int PARAM_BAUNDRATE = 264;
        public const int PARAM_DNS_SERVER_IP = 265;
        public const int PARAM_UDP_GROUP_IP = 266;
        public const int PARAM_NET_MASK = 268;
        public const int PARAM_GATEWAY = 269;
        public const int PARAM_RECONNECT_TIME = 270;
        public const int PARAM_KEEP_ALIVE_TIME = 271;
        public const int PARAM_WEB_PORT = 272;
        public const int PARAM_DEV_VER = 273;
        public const int PARAM_DEST_PORT = 275;
        public const int PARAM_DEV_NAME = 276;
        public const int PARAM_DEST_IP = 277;
        public const int PARAM_GAP_TIME = 278;
        public const int PARAM_PACKING_LEN = 279;
        public const int PARAM_LINK_STATUS = 280;
        public const int PARAM_RESOURCE_IP = 281;
        public const int PARAM_RESOURCE_PORT = 282;

        [DllImport("ZLDevManage.dll", EntryPoint = "ZLDM_GetVer")]
        public static extern int GetVer();
        [DllImport("ZLDevManage.dll", EntryPoint = "ZLDM_Init")]
        public static extern int Init(int ServerPort);
        [DllImport("ZLDevManage.dll", EntryPoint = "ZLDM_Exit")]
        public static extern int Exit();
        [DllImport("ZLDevManage.dll", EntryPoint = "ZLDM_StartSearchDev")]
        public static extern int StartSearchDev();
        [DllImport("ZLDevManage.dll", EntryPoint = "ZLDM_GetDevID")]
        public static extern string GetDevID(int Dev_Index);
        [DllImport("ZLDevManage.dll", EntryPoint = "ZLDM_GetDevParamString")]
        public static extern string GetDevParamString(string id, int ParamType);
        [DllImport("ZLDevManage.dll", EntryPoint = "ZLDM_GetDevParamInt")]
        public static extern int GetDevParamInt(string id, int ParamType);
        [DllImport("ZLDevManage.dll", EntryPoint = "ZLDM_SetDevParamString")]
        public static extern int SetDevParamString(string id, string NewParam, int ParamType);
        [DllImport("ZLDevManage.dll", EntryPoint = "ZLDM_SetDevParamInt")]
        public static extern int SetDevParamInt(string id, int NewParam, int ParamType);
        [DllImport("ZLDevManage.dll", EntryPoint = "ZLDM_SetDevParamExcute")]
        public static extern int SetDevParamExcute(string id);
    }

    /// <summary>
    /// 枚举 设备是否在内网中
    /// </summary>
    enum ParamDevExitInSubnet 
    {
        未找到 = -1,
        不是内网 = 0,
        内网 = 1,
        内网但不同网段 = 2
    }

    /// <summary>
    /// 枚举 工作模式
    /// </summary>
    enum ParamWorkMode
    {
        TCP服务器 = 0,
        TCP客户端 = 1,
        UDP = 2,
        UDP组播 = 3
    }

    enum ParamLinkStatus
    {
        未建立 = 0,
        已连接 = 1
    }
}
