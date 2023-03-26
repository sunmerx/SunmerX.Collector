using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using HslCommunication.Core;
using HslCommunication.Profinet.Siemens;
using Newbe.ObjectVisitor;
using Sunmerx.Interactive.Config;
using Sunmerx.Node;
using Sunmerx.Node.Config.Xml;

namespace Sunmerx.Interactive
{
    public static class ConfigHelper
    {
        public static IReadWriteNet GetClient(this XmlNodeDevice devicenode)
        {
            throw new NotImplementedException();
            //IReadWriteNet result;
            //switch ( devicenode.DeviceType )
            //{
            //    case SR.DeviceTypes.Siemens:
            //        result = new SiemensS7Net()
            //        break;
            //    default:
            //        break;
            //}
        }
        public static ConfigBase GetConfig(this XmlNodeDevice devicenode)
        {
            DeviceType devicetype = Enum.Parse<DeviceType>(devicenode.DeviceType , true);
            switch ( devicetype )
            {
                case DeviceType.Siemens:
                    return devicenode.Settings.To<SiemensConfig>();
                default:
                    break;
            }
        }
        public static T To<T>(this XmlNodeSettings settings) where T:ConfigBase,new()
        {
            Type t = typeof(T);
            T result = new();
            foreach ( var prop in t.GetProperties() )
            {
                int index = settings.Items.FindIndex(a => a.Key == prop.Name);
                if ( index > -1 )
                {
                    string str = settings.Items[index].Value;
                    var val = ConvertTo(str , prop.PropertyType);
                    if(val != null)
                        prop.SetValue(result , val);
                }
            }
            return result;
        }
        public static object? ConvertTo(this string str,Type t)
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
                var flag = Enum.TryParse(t,str , out var val);
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
