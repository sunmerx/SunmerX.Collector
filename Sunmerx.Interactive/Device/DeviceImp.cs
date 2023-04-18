using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HslCommunication.Core;
using Sunmerx.Interactive.Abstract;
using Sunmerx.Node.Config.Xml;

namespace Sunmerx.Interactive.Device
{
    public class DeviceImp
    {
        public XmlNodeDevice Source;
        public IClient Client
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
            DeviceImp deviceimp = new DeviceImp();
            deviceimp.Client = device.GetClient();
            return deviceimp;
        }
    }
}
