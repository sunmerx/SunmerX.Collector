using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HslCommunication.Core;
using Sunmerx.Node.Config.Xml;

namespace Sunmerx.Interactive.Device
{
    public class DeviceImp
    {
        public XmlNodeDevice Source;
        public IReadWriteNet Client
        {
            get; set;
        }
        public virtual bool Connect()
        {
            
        }
        public static implicit operator XmlNodeDevice(DeviceImp device)
        {
            return device.Source;
        }
        public static explicit operator DeviceImp(XmlNodeDevice device)
        {
            
        }
    }
}
