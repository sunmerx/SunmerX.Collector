using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunmerx.Interactive.Config
{
    public class SerialConfig:ConfigBase
    {
        public string PortName
        {
            get; set;
        }
        public int BaudRate
        {
            get; set;
        }
        public StopBits StopBits
        {
            get; set;
        }
        public Parity Parity
        {
            get; set;
        }
        public Endianness Endianness
        {
            get; set;
        }
    }
    public enum Endianness:byte
    {
        ABCD,
        BADC,
        DCBA,
        CDAB
    }
}
