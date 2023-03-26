using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Sunmerx.Node.Config.Xml
{
    public class XmlDataGroup : XmlNodeBase
    {
        /// <summary>
        /// 读取方式 如果等于false,则成组读取,然后解析数据 如果等于true,则直接循环DataItems中的变量,逐个读取
        /// </summary>
        [XmlAttribute]
        public bool IsRandomRead
        {
            get; set;
        } = false;
        [XmlAttribute]
        public string DataArea
        {
            get; set;
        }
        [XmlAttribute]
        public string StartAddress
        {
            get; set;
        }
        [XmlAttribute]
        public int Length
        {
            get;
            set;
        }
        [XmlAttribute]
        public int ByteLength
        {
            get; set;
        }
        [XmlAttribute]
        public UnitDataLength UnitDataLength
        {
            get; set;
        }
        [XmlElement]
        public List<XmlDataItem> DataItems
        {
            get; set;
        }
    }
}
