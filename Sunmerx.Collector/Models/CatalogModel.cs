using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;
using Sunmerx.Node.Config.Xml;

namespace Sunmerx.Collector.Models
{
    internal class CatalogDTO:BindableBase
    {
        public XmlNodeCatalog source;
        public CatalogDTO()
        {

        }
        public static implicit operator XmlNodeCatalog(CatalogDTO catalog)
        {
            return catalog.source;
        }
        public static explicit operator CatalogDTO(XmlNodeCatalog catalog)
        {
            return new CatalogDTO() { source = catalog };
        }
    }
}
