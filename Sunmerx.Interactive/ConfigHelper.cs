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
using Sunmerx.Common;
using Sunmerx.Common.Extensions;
using Sunmerx.Common.TypeConvert;
using Newtonsoft.Json;
using System.Collections;
using Sunmerx.Interactive.Abstract;

namespace Sunmerx.Interactive
{
    public static class ConfigHelper
    {
        public static IClient GetClient(this XmlNodeDevice devicenode)
        {
            //throw new NotImplementedException();
            IReadWriteNet result;
            switch ( devicenode.DeviceType )
            {
                case SR.DeviceTypes.Siemens:
                    var config = devicenode.GetConfigByJson<SiemensConfig>();
                    result = new SiemensS7Net(config.PlcType , config.IPAddress);
                    //config.BuilderAction?.Invoke(result);
                    break;
                default:
                    break;
            }
            return null;
        }
        public static T GetConfigByJson<T>(this XmlNodeDevice devicenode) where T:class
        {
            DeviceType devicetype = Enum.Parse<DeviceType>(devicenode.DeviceType , true);
            return JsonHelper<T>.JsonToObject(devicenode.NodeSettingJson);
        }
        public static T GetConfigBySettings<T>(this XmlNodeDevice devicenode) where T:class
        {
            DeviceType devicetype = Enum.Parse<DeviceType>(devicenode.DeviceType , true);
            return devicenode.Settings.Items.MapTo<SettingItem,T>((items,str)=> 
            {
                var dict = items.ToDictionary<SettingItem,string>(item=>item.Key);
                if ( dict.TryGetValue(str , out var result) )
                    return result;
                else
                    return null;
            } , obj =>
            {
                return obj.Value;
            });
        }
        

    }
}
