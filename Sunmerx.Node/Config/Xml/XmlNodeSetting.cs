using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Sunmerx.Node.Config.Xml
{
    public class XmlNodeSettings
    {
        [XmlElement("Settings")]
        public List<SettingItem> Items
        {
            get; set;
        }

    }
    public class SettingItem
    {
        [XmlAttribute]
        public string Key
        {
            get; set;
        }
        [XmlAttribute]
        public string Type
        {
            get; set;
        }
        [XmlAttribute]
        public string Value
        {
            get;
            set;
        }
    }
}
