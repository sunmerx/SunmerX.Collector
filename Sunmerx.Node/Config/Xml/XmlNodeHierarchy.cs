using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Sunmerx.Node.Config.Xml
{
    /*
     *                      
     * 
     * 
     * 
     * 
     * 
     * 
     */
    
    [XmlRoot("Configuration")]
    public class XmlNodeRoot
    {
        [XmlElement("Catalogs")]
        public List<XmlNodeCatalog> Catalogs
        {
            get; set; 
        }
    }
    public class XmlNodeCatalog: XmlNodeBase
    {
        [XmlElement("XmlNodeClass")]
        public List<XmlNodeArea> Nodes { get; set; }

    }
    public class XmlNodeArea: XmlNodeBase
    {
        [XmlElement("XmlNodeClass")]
        public virtual List<XmlNodeLine> Nodes
        {
            get; set;
        }
    }
    public class XmlNodeLine : XmlNodeBase
    {
        [XmlElement("XmlNodeClass")]
        public virtual List<XmlNodeDevice> Nodes
        {
            get; set;
        }
    }
    public class XmlNodeDevice: XmlNodeBase
    {
        [XmlAttribute]
        public string DeviceType
        {
            get; set;
        }
        [XmlAttribute]
        public string Protocol
        {
            get;set;
        }

        [XmlElement]
        public List<XmlDataGroup> DataGroups
        {
            get; set;
        }
    }
    
   
    [Flags]
    public enum UnitDataLength:byte
    {
        BIT=1,
        BYTE=8,
        WORD=16,
        DWORD=32,
        QWORD=64
    }
   
}
