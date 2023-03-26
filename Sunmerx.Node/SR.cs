using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HslCommunication.Core;
using HslCommunication.Profinet.Melsec.Helper;

namespace Sunmerx.Node
{
    public class SR
    {
        public class DeviceTypes
        {
            public const string Siemens = "Siemens";
            public const string Melsec = "Melsec";
            public const string Omron = "Omron";
            public const string Panasonic = "Panasonic";
            public const string Inovance = "Inovance";
            public const string LSis = "LSis";
            public const string Keyence = "Keyence";
            public const string AllenBrandly = "AllenBrandly";
            public const string Backhoff = "Backhoff";
            public const string GE = "GE";
            public const string Yaskawa = "Yaskawa";
            public const string Yamatake = "Yamatake";
            public const string RKC = "RKC";
            public const string Fatek = "Fatek";
            public const string Vigor = "Vigor";
            public const string Fuji = "Fuji";
            public const string XinJE = "XinJE";
            public const string Yokogawa = "Yokogawa";
            public const string Delta = "Delta";
        }
        public class CommunicationTypes
        {
            public const string Redis = "Redis";
            public const string MQTT = "MQTT";
            public const string WebSocket = "WebSocket";
            public const string Http = "Http";
            public const string SECS = "SECS";
        }
        public class DatabaseTypes
        {
            public const string SQLServer = "SQLServer";
            public const string Oracle = "Oracle";
            public const string MYSQL = "MYSQL";
            public const string PGSQL = "PGSQL";
            public const string SQLite = "SQLite";
        }
    }
}
