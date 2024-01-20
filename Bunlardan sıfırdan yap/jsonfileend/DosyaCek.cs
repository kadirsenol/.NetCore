using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace jsonfileend
{
    public class DosyaCek
    {
        public List<customer> resultlist { get; set; }
        
        public void dosyacek()
        {
            WebClient wc = new WebClient();
            wc.Encoding = Encoding.Default;
            string data=  wc.DownloadString($@"https://northwind.netcore.io/customers.json");

            jsonmodel jsondos = new jsonmodel();

            jsondos = JsonSerializer.Deserialize<jsonmodel>(data);

            resultlist =jsondos.results;
            Console.WriteLine($@"{jsondos.results[0].contactName}");
            
        

        }
    }
}
