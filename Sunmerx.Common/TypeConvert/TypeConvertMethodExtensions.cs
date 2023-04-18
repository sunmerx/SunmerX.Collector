using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunmerx.Common.TypeConvert
{
    public static class TypeConvertMethodExtensions
    {
        public static object? ConvertTo(this string str , Type t)
        {
            if ( t == typeof(string) )
            {
                return str;
            }
            if ( t == typeof(bool) )
            {
                var flag = Boolean.TryParse(str , out var val);
                if ( flag )
                    return val;
                return null;
            }
            if ( t == typeof(byte) )
            {
                var flag = Byte.TryParse(str , out var val);
                if ( flag )
                    return val;
                return null;
            }
            if ( t == typeof(UInt16) )
            {
                var flag = UInt16.TryParse(str , out var val);
                if ( flag )
                    return val;
                return null;
            }
            if ( t == typeof(Int16) )
            {
                var flag = Int16.TryParse(str , out var val);
                if ( flag )
                    return val;
                return null;
            }
            if ( t == typeof(UInt32) )
            {
                var flag = UInt16.TryParse(str , out var val);
                if ( flag )
                    return val;
                return null;
            }
            if ( t == typeof(Int32) )
            {
                var flag = UInt16.TryParse(str , out var val);
                if ( flag )
                    return val;
                return null;
            }
            if ( t == typeof(UInt64) )
            {
                var flag = UInt16.TryParse(str , out var val);
                if ( flag )
                    return val;
                return null;
            }
            if ( t == typeof(Int64) )
            {
                var flag = UInt16.TryParse(str , out var val);
                if ( flag )
                    return val;
                return null;
            }
            if ( t == typeof(float) )
            {
                var flag = UInt16.TryParse(str , out var val);
                if ( flag )
                    return val;
                return null;
            }
            if ( t == typeof(double) )
            {
                var flag = UInt16.TryParse(str , out var val);
                if ( flag )
                    return val;
                return null;
            }
            if ( t.IsEnum )
            {
                var flag = Enum.TryParse(t , str , out var val);
                if ( flag )
                    return val;
                return null;
            }
            if ( t.IsArray )
            {
                var split = str.Split(',');
                var type = t.MakeArrayType();
                var array = Array.CreateInstance(type , split.Length);
                for ( int i = 0 ; i < split.Length ; i++ )
                {
                    var value = ConvertTo(split[i] , type);
                    array.SetValue(value , i);
                }
                return array;
            }
            return null;
        }
    }
}
