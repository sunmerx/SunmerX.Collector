using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Sunmerx.Node.Config.Xml
{
    public class XmlNodeBase
    {
        [XmlAttribute]
        public string Name
        {
            get; set;
        }
        [XmlAttribute]
        public bool IsActive
        {
            get; set;
        }
        [XmlAttribute]
        public string Description
        {
            get; set;
        }
        [XmlElement]
        public XmlNodeSettings Settings
        {
            get; set;
        }
    }
}
