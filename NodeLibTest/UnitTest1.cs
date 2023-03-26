using Sunmerx.Common;
using Sunmerx.Node.Config.Xml;

namespace NodeLibTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            XmlNodeRoot root = new XmlNodeRoot()
            {
                Catalogs = new List<XmlNodeCatalog>()
                {
                    new XmlNodeCatalog()
                    {
                        Name="Devices",
                        Description="说明",
                        Nodes = new List<XmlNodeArea>()
                        {
                            new XmlNodeArea()
                            {
                                Name="分厂一",
                                Description="说明",
                                Nodes = new List<XmlNodeLine>()
                                {
                                    new XmlNodeLine()
                                    {
                                        Name="产线一",
                                        Description="说明",
                                        Nodes=new List<XmlNodeDevice>()
                                        {
                                            new XmlNodeDevice()
                                            {
                                                Name="设备1",
                                                Description="说明",
                                                Settings = new XmlNodeSettings()
                                                {
                                                    Items = new List<SettingItem>()
                                                    {
                                                        new SettingItem()
                                                        {
                                                            Key="IP",
                                                            Value="127.0.0.1"
                                                        }
                                                    }
                                                },
                                                DataGroups = new List<XmlDataGroup>()
                                                {
                                                    new XmlDataGroup()
                                                    {
                                                        Name="分组1",
                                                        Description="说明",
                                                        DataItems = new List<XmlDataItem>()
                                                        {
                                                            new XmlDataItem()
                                                            {
                                                                Name="变量1",
                                                                Address="D100"
                                                            }
                                                        }
                                                    }
                                                }

                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            };
            XmlReadWrite.WriteToXml("settings.xml" , root);
            var obj = XmlReadWrite.ReadFromXml<XmlNodeRoot>("settings.xml");
            Assert.Pass();
        }
    }
}