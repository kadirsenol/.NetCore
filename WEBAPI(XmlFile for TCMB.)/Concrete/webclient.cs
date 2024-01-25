using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using WEBAPI_XmlFile_for_TCMB._.Abstract;
using WEBAPI_XmlFile_for_TCMB_.Models;

namespace WEBAPI_XmlFile_for_TCMB._.Concrete
{
    public class webclient : IWebClient
    {
        public XmlDocument Xmldoc { get; set; }
        public Dovizler Dovizler { get; set; }
        public void WC()
        {
            Dovizler dovizler = new Dovizler();
            XmlDocument xmldoc = new XmlDocument();
            string url = $@"https://www.tcmb.gov.tr/kurlar/today.xml";
            WebClient wc = new WebClient();

            wc.Encoding = Encoding.Default;
            string data = wc.DownloadString(url);
            xmldoc.LoadXml(data);
            XmlNodeList xmllist = xmldoc.DocumentElement.ChildNodes;

            foreach (XmlNode xmlnode in xmllist)
            {

                Doviz doviz = new Doviz()
                {
                    Currency = xmlnode.ChildNodes[1].InnerText,
                    ForexBuying = xmlnode.ChildNodes[3].InnerText,
                    ForexSelling =xmlnode.ChildNodes[4].InnerText
                };
                dovizler.dovizler.Add(doviz);
            }
            Xmldoc = xmldoc;
            Dovizler = dovizler;
        }
    }
}
