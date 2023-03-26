using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Sunmerx.Common
{
    public class XmlReadWrite
    {
        public static void WriteToXml<TXmlRoot>( string filePath , TXmlRoot equipments )
        {
            XmlSerializer serializer = new XmlSerializer(typeof(TXmlRoot));
            using( TextWriter writer = new StreamWriter(filePath) )
            {
                serializer.Serialize(writer , equipments);
            }
        }
        //var writer = XmlWriter.Create("equipments.xml" , settings)
        public static void WriteToXmlWithSettings<TXmlRoot>( string filePath , TXmlRoot equipments , [NotNull]XmlWriterSettings settings , XmlSerializerNamespaces ns = null)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(TXmlRoot));
            using( var writer = XmlWriter.Create(filePath , settings) )
            {
                if(ns == null )
                {
                    serializer.Serialize(writer , equipments);
                }
                else
                {
                    serializer.Serialize(writer , equipments , ns);
                }

            }
        }
        public static TXmlRoot ReadFromXml<TXmlRoot>( string filePath )
        {
            XmlSerializer serializer = new XmlSerializer(typeof(TXmlRoot));
            using( TextReader reader = new StreamReader(filePath) )
            {
                return (TXmlRoot) serializer.Deserialize(reader);
            }
        }
        public static TXmlRoot ReadFromXmlWithSettings<TXmlRoot>(string filePath , [NotNull] XmlReaderSettings settings )
        {
            XmlSerializer serializer = new XmlSerializer(typeof(TXmlRoot));
            using( XmlReader reader = XmlReader.Create(filePath , settings) )
            {
                return (TXmlRoot) serializer.Deserialize(reader);
            }
        }
        public static XmlWriterSettings CreateDefaultWriteSettings()
        {
            var settings = new XmlWriterSettings
            {
                Indent = true ,
                IndentChars = "    " ,
                NamespaceHandling = NamespaceHandling.Default
            };
            return settings;
        }
        public static XmlReaderSettings CreateDefaultReadSettings()
        {
            var settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            return settings;
        }
        public static XmlSerializerNamespaces CreateXmlSerializerNameSpace(Dictionary<string,string> namespaces = null)
        {
            var ns = new XmlSerializerNamespaces();
            if(namespaces == null || namespaces.Count == 0)
            {
                ns.Add("" , "");
                return ns;
            }

            foreach( var kv in namespaces )
            {
                ns.Add(kv.Key, kv.Value );
            }   
            return ns;
        }

    }
}
