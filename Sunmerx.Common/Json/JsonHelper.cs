using Newtonsoft.Json;

using System;
using Newtonsoft.Json.Converters;

namespace Sunmerx.Common
{
    public static class JsonHelper<T> where T : class
    {
        public static string ObjectToJson(T obj, params JsonConverter[] converters)
        {
            if (converters == null)
            {
                return JsonConvert.SerializeObject(obj);
            }
            return JsonConvert.SerializeObject(obj, converters);
        }

        public static T? JsonToObject(string jsonText, params JsonConverter[] converters)
        {

            if (!string.IsNullOrEmpty(jsonText))
            {
                try
                {
                    if (converters == null || converters.Length == 0)
                    {
                        return JsonConvert.DeserializeObject<T>(jsonText);
                    }
                    return JsonConvert.DeserializeObject<T>(jsonText, converters);
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return null;
        }
    }
}
