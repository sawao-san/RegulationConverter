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
        public IXML()
        {

        }
        public static void XMLtoStream()
        {

            //https://www.fenet.jp/dotnet/column/language/4511/
            Task t = readXMLtest("E:\\Work\\CFR-1998-title14-vol1-part23.xml");
            Task.WaitAll(t);
           
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

        static async Task readXMLtest(string filename)
        {
            //http://blog.livedoor.jp/tkarasuma/archives/1036991193.html
            XmlReaderSettings setting = new XmlReaderSettings();
            setting.ConformanceLevel = ConformanceLevel.Document;

            XmlReader reader = XmlReader.Create(filename, setting);
            while(reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    Console.Write("NodeType = \"{0}\"\tLocalName = \"{1}\" ,\t Depth=\"{2}\"\t,Value=\"{3}\"",
                        reader.NodeType, reader.LocalName,
                        reader.Depth, reader.Value);
                    //File.AppendAllText("C:\\temp\\testXML.txt", $"NodeType = {reader.NodeType}, \tLocalName = {reader.LocalName} ,\t Depth={reader.Depth}, \tValue={reader.Value}\n");
                    
                    if (reader.HasAttributes)
                    {
                        for (int i = 0; i < reader.AttributeCount; i++)
                        {
                            reader.MoveToAttribute(i);
                            Console.Write("\"Name\"={0},\tValue=\"{1}\"", reader.Name, reader.Value);

                        }
                        reader.MoveToElement();
                    }
                }
                else if (reader.NodeType == XmlNodeType.EndElement)
                {
                    Console.Write("NodeType = \"{0}\"\tLocalName = \"{1}\" ,\t Depth=\"{2}\"\t,Value=\"{3}\"",
                        reader.NodeType, reader.LocalName,
                        reader.Depth, reader.Value);
                    //File.AppendAllText("C:\\temp\\testXML.txt", $"NodeType = {reader.NodeType}, \tLocalName = {reader.LocalName} ,\t Depth={reader.Depth}, \t,Value={reader.Value}\n");

                }
                else
                {
                    Console.Write("NodeType = \"{0}\"\tLocalName = \"{1}\" ,\t Depth=\"{2}\"\t,Value=\"{3}\"",
                        reader.NodeType, reader.LocalName,
                        reader.Depth, reader.Value.Replace("\n", "改行↓"));
                    File.AppendAllText("C:\\temp\\testXML.txt", $"NodeType = {reader.NodeType}, \tLocalName = {reader.LocalName} ,\t Depth={reader.Depth}, \t,Value={reader.Value.Replace("\n", "改行↓")}\n");

                }
                Console.WriteLine();
            }
            reader.Close();


            await Task.Delay(1000);
        }
    }
    
}
