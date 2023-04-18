using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sunmerx.Common.TypeConvert;

namespace Sunmerx.Common.Extensions
{
    /// <summary>
    /// 集合的扩展方法
    /// </summary>
    public static class CollectionMethodExtensions
    {
        /// <summary>
        /// 将集合的值映射给指定对象的属性
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="collection"></param>
        /// <param name="filter"></param>
        /// <param name="get"></param>
        /// <returns></returns>
        public static TResult MapTo<T, TResult>(this IEnumerable<T> collection , Func<IEnumerable<T> , string , T> filter , Func<T , string> get) where TResult : class
        {
            Type t = typeof(T);

            TResult result = Activator.CreateInstance<TResult>();
            foreach ( var prop in t.GetProperties() )
            {
                var obj = filter(collection , prop.Name);
                if ( obj == null )
                    continue;
                var str = get(obj);
                if ( string.IsNullOrEmpty(str) )
                    continue;
                var val = str.ConvertTo(prop.PropertyType);
                if ( val != null )
                    prop.SetValue(result , val);
            }
            return result;
        }
    }
}
