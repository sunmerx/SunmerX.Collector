using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunmerx.Common.Text
{
    public interface IParser<T>
    {
        T Parse(string text);
        string Parse(T t);
    }
}
