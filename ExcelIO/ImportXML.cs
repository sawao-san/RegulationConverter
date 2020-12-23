using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace ExcelIO
{
    class IXML
    {
        private string xmlFilePath;
        public  string XMLFilePath
        {
            set
            {
                xmlFilePath = value;
            }
            get
            {
                return xmlFilePath;
            }
        }
        private bool readSwitch;
        public bool ReadSwith
        {
            get
            {
                return this.readSwitch;
            }
            set
            {
                this.readSwitch = value;
            }
        }

        public IXML(string str)
        {
            this.xmlFilePath =str ;
            readSwitch = false;
        }

        public void XMLImportTest()
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(XMLFilePath);
            XmlNode PART_EXTRACT = xml.SelectSingleNode("CFRGRANULE/PART");
            string str;
            StreamWriter writer = new StreamWriter(@"E:\temp/test.txt", true);
            int count = 1;
            
            foreach (XmlNode test in PART_EXTRACT)
            {
                str = test.SelectSingleNode("EXTRACT/HD").InnerText;
                Console.WriteLine(str);
                Console.WriteLine(count.ToString());
                writer.WriteLine(str);
                count++;
            }


        }

        public void XMLtoStream()
        {

            //https://www.fenet.jp/dotnet/column/language/4511/
            Task t = readXMLtest(this.XMLFilePath);
            Task.WaitAll(t);

        }

        async Task readXMLtest(string filename)
        {
            //http://blog.livedoor.jp/tkarasuma/archives/1036991193.html
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ConformanceLevel = ConformanceLevel.Document;
            StreamWriter writer = new StreamWriter(@"E:\temp\test4.txt");

            XmlReader reader = XmlReader.Create(filename, settings);
            while (reader.Read())
            {
                //https://docs.microsoft.com/ja-jp/dotnet/api/system.xml.xmlnodetype?view=net-5.0
                /*要素 (例: <item>)の場合。*/
                if (reader.NodeType == XmlNodeType.Element)
                {
                    if(reader.LocalName == "EXTRACT")
                    {
                        Console.Write("NodeType = \"{0}\"\tLocalName = \"{1}\" ,\t Depth=\"{2}\"\t,Value=\"{3}\"",
                        reader.NodeType, reader.LocalName,
                        reader.Depth, reader.Value);
                        ReadSwith = true;
                        Console.WriteLine();
                    }
                    else
                    {

                    }
                    
                    /*if (reader.HasAttributes)
                    {
                        for (int i = 0; i < reader.AttributeCount; i++)
                        {
                            reader.MoveToAttribute(i);
                            Console.Write("\"Name\"={0},\tValue=\"{1}\"", reader.Name, reader.Value);
                        }
                        reader.MoveToElement();
                    }*/
                }
                /*終了要素タグ (例: </item>)の場合。*/
                else if (reader.NodeType == XmlNodeType.EndElement)
                {
                    /*Console.Write("NodeType = \"{0}\"\tLocalName = \"{1}\" ,\t Depth=\"{2}\"\t,Value=\"{3}\"",
                        reader.NodeType, reader.LocalName,
                        reader.Depth, reader.Value);*/
                        if(reader.LocalName == "EXTRACT")
                    {
                        Console.Write("NodeType = \"{0}\"\tLocalName = \"{1}\" ,\t Depth=\"{2}\"\t,Value=\"{3}\"",
                        reader.NodeType, reader.LocalName,
                        reader.Depth, reader.Value);
                        ReadSwith = false;
                        Console.WriteLine();
                    }
                }
                else if(reader.NodeType == XmlNodeType.Text && readSwitch)
                {
                    Console.Write("\"文章\"={0}", reader.Value);
                    writer.WriteLine(reader.Value);
                    Console.WriteLine();
                }
                else
                {
                    /*Console.Write("NodeType = \"{0}\"\tLocalName = \"{1}\" ,\t Depth=\"{2}\"\t,Value=\"{3}\"",
                        reader.NodeType, reader.LocalName,
                        reader.Depth, reader.Value.Replace("\n", "改行↓"));*/
                }
                
            }
            reader.Close();



            await Task.Delay(1000);
        }

        /*static async Task readXMLtest(Stream stream)
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.Async = true;

            using (XmlReader reader = XmlReader.Create(stream, settings))
            {
                while (await reader.ReadAsync())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:
                            Console.WriteLine("Start Element {0}", reader.Name);
                            break;
                        case XmlNodeType.Text:
                            Console.WriteLine("Text Node: {0}",
                                     await reader.GetValueAsync());
                            break;
                        case XmlNodeType.EndElement:
                            Console.WriteLine("End Element {0}", reader.Name);
                            break;
                        default:
                            Console.WriteLine("Other node {0} with value {1}",
                                            reader.NodeType, reader.Value);
                            break;
                    }
                }
            }
        }
        */

    }

}
