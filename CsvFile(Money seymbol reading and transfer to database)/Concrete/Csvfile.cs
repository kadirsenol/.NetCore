using CSV_file_reading_and_transfer_to_database_.Abstract;
using CSV_file_reading_and_transfer_to_database_.Concrete.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_file_reading_and_transfer_to_database_.Concrete
{
    public class Csvfile : IReadFile, ISplit
    {
        public Currencys currencys { get; set; }
        Currency currency;
        
        List<string> data = new List<string>(); 
        public void Readfile()
        {
           data.AddRange(File.ReadAllLines($@"../../../currency.csv"));
        }

        public void Split()
        {
            currencys = new Currencys();
            foreach (string satir in data)
            {
                currency = new Currency();
                var kelime= satir.Split(',');
                currency.Code = kelime[0];
                currency.Symbol = kelime[1];
                currency.Name = kelime[2];
                currencys.currencys.Add(currency);  
            }
        }
    }
}
