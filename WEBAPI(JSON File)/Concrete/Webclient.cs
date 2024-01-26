using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WEBAPI_JSON_File_.Abstract;
using WEBAPI_JSON_File_.Concrete.Jsonfile;

namespace WEBAPI_JSON_File_.Concrete
{
    public class Webclient : IWebclient
    {
        public Customers customerss { get; set; }
        public void Wc(string url)
        {
            WebClient wc = new WebClient();
            wc.Encoding = Encoding.Default;
            string data= wc.DownloadString(url);
            customerss = new Customers();
            customerss = JsonSerializer.Deserialize<Customers>(data);
            Console.WriteLine("Dosya başarılı şekilde çekildi. !");

        }
    }
}
