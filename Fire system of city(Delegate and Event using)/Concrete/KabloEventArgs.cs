using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_system_of_city_Delegate_and_Event_using_.Concrete
{
    public class KabloEventArgs : EventArgs //Kablonun yanma olayı gerçekleştiğinde belirli argümanları tetiklenen class a ile
    {                                       //tebilmek amacıyla temel argumanları içeren EventArgs sınıfından türetilen bir
                                            //sınıf oluşturulur. Bu şekilde tetiklenen sınıf ile tetikleyen sınıf arasında ile
                                            //tişim sağlanmış olur. Bu proplar Kablo sınıfına eklenip kablo sınıf örneği üzerin
                                            //den erişim sağlabilirdi fakat SOLID prensiplerine aykırı hareket etmiş olurduk
                                            //Çünkü kabloyu fişe takan kişinin adı ile kablo arasında birincil bir ilişki yoktur
        public string KabloyuTakanAd { get; set; }       
        public string KabloyuTakanSoyad { get; set; }
        public string KabloyuTakanYas { get; set; }

        public KabloEventArgs(string Kabloyutakanad)
        {
            KabloyuTakanAd = Kabloyutakanad;
        }
    }
}
