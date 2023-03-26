using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HslCommunication.Profinet.Siemens;

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
    }
}
