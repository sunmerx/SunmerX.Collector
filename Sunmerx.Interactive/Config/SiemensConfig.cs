using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using HslCommunication;
using HslCommunication.Core;
using HslCommunication.Profinet.Siemens;
using Sunmerx.Node;

namespace Sunmerx.Interactive.Config
{
    public class SiemensConfig:ConfigBase
    {
        public SiemensPLCS PlcType
        {
            get;set;
        }
        
        public string IPAddress
        {
            get; set;
        }
        public int Port
        {
            get; set;
        }
        /// <summary>
        /// 机架号
        /// </summary>
        public byte Rack
        {
            get; set;
        }
        public byte Slot
        {
            get; set;
        }
        public int ConnectTimeOut
        {
            get; set;
        }
        public int MyProperty
        {
            get; set;
        }
        public int ReceiveTimeOut
        {
            get; set;
        }
        public byte ConnectionType
        {
            get; set;
        } = NM.Siemens.ConnectionType_PG;
        public int LocalTSAP
        {
            get; set;
        } = 258;

    }
}
