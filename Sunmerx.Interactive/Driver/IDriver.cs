using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunmerx.Interactive.Driver
{
    public interface IDriver:IDisposable
    {
        short id
        {
            get; set;
        }
        string Name
        {
            get;set;
        }
        string Description
        {
            get;set;
        }
    }
}
