using System.Net;
using System.Xml;

namespace WEBAPI_XmlFile_for_TCMB_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDoc = new XmlDocument();
            string url = $@"https://www.tcmb.gov.tr/kurlar/today.xml";
            WebClient wc = new WebClient();
            string data=wc.DownloadString(url);
            xmlDoc.LoadXml(data);




            Console.WriteLine("Hello, World!");
        }
    }
}
