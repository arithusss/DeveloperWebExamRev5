using Newtonsoft.Json;
using System;
using System.Xml;

namespace Test.Sol_4
{
    class Program
    {
        static void Main(string[] args) {

            string xmlText = string.Empty;
            xmlText += "<?xml version=\"1.0\" encoding=\"UTF-8\"?>";
            xmlText += Environment.NewLine;
            xmlText += "<RootData>";
            xmlText += Environment.NewLine;
            xmlText += "  <Data>";
            xmlText += Environment.NewLine;
            xmlText += "    <MyValue>5</MyValue>";
            xmlText += Environment.NewLine;
            xmlText += "  </Data>";
            xmlText += Environment.NewLine;
            xmlText += "  <Data>";
            xmlText += Environment.NewLine;
            xmlText += "    <MyValue>12</MyValue>";
            xmlText += Environment.NewLine;
            xmlText += "  </Data>";
            xmlText += Environment.NewLine;
            xmlText += "  <Data>";
            xmlText += Environment.NewLine;
            xmlText += "    <MyValue>1</MyValue>";
            xmlText += Environment.NewLine;
            xmlText += "  </Data>";
            xmlText += Environment.NewLine;
            xmlText += "  <Name>testData</Name>";
            xmlText += Environment.NewLine;
            xmlText += "</RootData>";

            Console.WriteLine("Result before convert XML to JSON");
            Console.WriteLine(xmlText);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlText);

            string jsonText = JsonConvert.SerializeXmlNode(doc, Newtonsoft.Json.Formatting.Indented);
            Console.WriteLine("Result after convert XML to JSON");
            Console.WriteLine(jsonText);
        }
    }
}
