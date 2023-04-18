using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HslCommunication;
using HslCommunication.Core;

namespace Sunmerx.Interactive.Config
{
    public class ConfigBase
    {
        public ConfigBase()
        {

        }
        public virtual Func<IReadWriteNet> BuilderFunc
        {
            get; 
        }
        public virtual OperateResult Connect()
        {
            return OperateResult.CreateSuccessResult();
        }
        public string Name
        {
            get;set;
        }
    }
}
