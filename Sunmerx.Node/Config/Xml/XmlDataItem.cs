using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Sunmerx.Node.Config.Xml
{
    public class XmlDataItem : XmlNodeBase
    {
        [XmlAttribute]
        public bool ReadOnly
        {
            get; set;
        } = false;
        [XmlAttribute]
        public short ID
        {
            get; set;
        }
        [XmlAttribute]
        public string Address
        {
            get; set;
        }
        [XmlAttribute]
        public string DataType
        {
            get; set;
        }
        /// <summary>
        /// Signal:信号 Measure:测量值 Range:阈值 有上限 下限 上上限 下下限 
        /// AlarmBit:报警位 AlarmCode:报警代码 FaultBit:故障位 FaultCode:故障代码 
        /// ErrBit:错误位 ErrCode:错误代码 Mapping:映射 Custom:自定义
        /// </summary>
        [XmlAttribute]
        public string DataFlag
        {
            get; set;
        }
        [XmlAttribute]
        public string DefaultValue
        {
            get; set;
        }
    }
}
