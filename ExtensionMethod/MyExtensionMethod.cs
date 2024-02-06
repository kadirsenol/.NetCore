using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    //Main icerisinde direkt ulasılabilmesi adına static class ve static metod icerisinde olusturulur.
    //Olusturulan extencion metodun uygulanacagı nesne türleri, kabul ettiği parametrenin basına this operatoru koyularak tanimlanir.
    //this type kelime => type ifadesi uygulandigi nesnenin tipini ifade ederken, kelime ise uygulanılan nesneyi temsil eder.
    //this type kelime, type abc seklinde uygulandigi nesne haric icerisine ilaveten type tipinde abc adinda parametre istenebilir.
    public static class MyExtensionMethod
    {
        /// <summary>
        /// Lutfen turkce karakterlerin silinmesini istediginiz kelimeye uygulayın.
        /// </summary>
        /// <param name="kelime"></param>
        /// <returns></returns>
        public static string NonTurkishChar(this string kelime)
        {
            if (!string.IsNullOrEmpty(kelime))
            {
                if (kelime.Contains("ı"))
                {
                    kelime = kelime.Replace('ı', 'i');
                }
                if (kelime.Contains("ğ"))
                {
                    kelime = kelime.Replace('ğ', 'g');
                }
                if (kelime.Contains("ü"))
                {
                    kelime = kelime.Replace('ü', 'u');
                }
                if (kelime.Contains("ş"))
                {
                    kelime = kelime.Replace('ş', 's');
                }
                if (kelime.Contains("ö"))
                {
                    kelime = kelime.Replace('ö', 'o');
                }
                if (kelime.Contains("ç"))
                {
                    kelime = kelime.Replace('ç', 'c');
                }
                return kelime;
            }
            else
            {
                return kelime;
            }
        }
    }
}
