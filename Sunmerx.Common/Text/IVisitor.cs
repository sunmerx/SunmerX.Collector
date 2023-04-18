using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunmerx.Common.Text
{
    /// <summary>
    /// 用于处理字符串(例如json或xml)与实体之间的转换,读写
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IVisitor<T>
    {
        IParser<T> Parse
        {
            get;
        }
        string ToText();
        T ToObj();
        Tr Get<Tr>(string name);
        void Set<Tw>(string name , Tw v);
    }
}
