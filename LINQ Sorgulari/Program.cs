using LINQ_Sorgulari.Entities;
using Microsoft.EntityFrameworkCore;

namespace LINQ_Sorgulari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NorthwindContext db = new NorthwindContext();

            #region EF Core CRUD

            #region Insert
            db.Shippers.Add(new Shipper { CompanyName = "MNG", Phone = "444 3 444" });
            db.SaveChanges();
            #endregion
            #region Update
            Shipper shipper = db.Shippers.Find(1);
            shipper.Phone = "444 2 444 ";
            db.Shippers.Update(shipper);
            db.SaveChanges();
            #endregion
            #region Delete
            Shipper shipper2 = db.Shippers.Find(1);
            db.Shippers.Remove(shipper2);
            db.SaveChanges();
            #endregion


            #endregion

            #region EF Core QUERY

            #region Get

            #region Metod Syntx
            db.Shippers.ToList();
            #endregion

            #region Query Syntx
            var a = from kargo in db.Shippers select kargo; //IQueriable dondugu icin IEnumerableye dondurulmesi gerek.
            #endregion

            #endregion

            #region Select

            #region Metod Syntx
            db.Shippers.Select(p => p.CompanyName); //Goruldugu uzere sorgulanmak uzere hazir bir IQueriable donus yapacaktir
                                                    //Suan veritabanina sorgu gonderilmeyecek veriler istenildiginde gonderilecektir.

            db.Shippers.Select(p => p.CompanyName).ToList(); // IEnumerable veri tipinde geri donus saglandigi icin
                                                             // veritabanina direk sorguyu gonderip geridonus saglayacaktir. 

            db.Shippers.Select(p => new { p.CompanyName, p.Phone }); // Birden fazla field
            #endregion

            #region QuerySyntx
            var b = from kargo in db.Shippers select kargo.CompanyName;
            var c = from kargo in db.Shippers select new { field1 = kargo.Id, field2 = kargo.CompanyName }; // Birden fazla field
            #endregion

            #endregion

            #region Where

            #region Metod Syntx
            db.Shippers.Where(p => p.Id == 1).ToList();
            #endregion

            #region Query Syntx
            var query = (from kargo in db.Shippers where kargo.Id == 1 select kargo).ToList();

            #endregion

            #endregion

            #region Find
            //Primary key kolonuna gore arama yapar
            db.Shippers.Find(1);
            db.Shippers.Find(1, 2); //Birden fazla primary key var ise

            #endregion

            #region First & FirstOrDefault

            db.Shippers.Where(p => p.CompanyName == "MNG").First(); // Sonucun birincisini dondurur, sonuc yoksa hata veir.
            db.Shippers.FirstOrDefault(p => p.CompanyName == "MNG"); //Sonuc yoksa null dondurur hata vermez

            #endregion

            #region Last
            db.Shippers.ToList().Last(); //Listenin en sonuncusunu getir.
            db.Shippers.Last(p => p.CompanyName == "MNG"); //Adı mng olanların en sonuncusunu getir
            #endregion

            #region Single & SingleOrDefault

            db.Shippers.Where(p => p.CompanyName == "MNG").Single();//Sonuc 1 tane ise dondurur, birden fazla veya 0 ise hata verir.
            db.Shippers.Where(p => p.Phone == "444 4 444").SingleOrDefault();//Sonuc 1 tane ise dondurur, birden fazla veya 0 ise null dondurur.

            #endregion

            #region Count

            db.Shippers.ToList().Count();
            db.Shippers.ToList().Count(p => p.CompanyName == "MNG");

            #endregion

            #region Any

            db.Products.Where(p => p.UnitPrice > 50).Any(); //Sorgu sonucunda veri gelip gelmedigi bilgisini bool geri doner

            #endregion

            #region Min & Max

            db.Products.Min(p => p.UnitPrice);
            db.Products.Max(p => p.UnitPrice);

            db.Products.AsEnumerable().MinBy(p => p.UnitPrice);//Sarta gore en dusuk entitiyi getirir. Queriableye degil Enumerableye uygulanmalidir.
            db.Products.AsEnumerable().MaxBy(p => p.UnitPrice);//Sarta gore en buyuk entitiyi getirir.

            #endregion

            #region Sum

            db.Products.Where(p => p.CategoryId == 2).Sum(p => p.UnitPrice);
            // Kategori id 2 olanlarin fiyatlari toplami

            #endregion

            #region Average

            db.Products.Where(p => p.CategoryId == 2).Average(p => p.UnitPrice);
            //Kategori id 2 olanlarin fiyat ortalamasi

            #endregion

            #region Distinct

            db.Products.Where(p => p.CategoryId == 1).Select(p => p.ProductName).Distinct();
            db.Products.DistinctBy(p => p.CategoryId == 1).Select(p => p.ProductName);
            //Kategori id 1 olan sonuclari tekillestirip getirir.

            #endregion

            #region Group By

            db.Products.GroupBy(p => p.CategoryId).Select(p => new { Id = p.Key, Adet = p.Count() }).ToList();
            //Urunlerin id lerine gore adetleri
            db.Products.GroupBy(p => p.CategoryId).Select(p => new { Id = p.Key, TotalTutar = p.Sum(p => p.UnitPrice) }).ToList();
            //Urunlerin id lerine gore toplam stok fiyatlari
            #endregion

            #region Join

            db.Products.Include(p => p.Category).Where(p => p.UnitsInStock > 10).Select(p => new { p.ProductName, p.Category.CategoryName });

            db.Orders.Include(p => p.Employee).Where(p => p.OrderDate.Value.Year == 1997).GroupBy(p => p.EmployeeId).Select(p => new { MusteriId = p.Key, SiparisAdet = p.Count() });
            //Calisanlarin 1997 yilinda aldıgi siparislerin toplam sayisi.

            #endregion

            #endregion

            Console.WriteLine("Hello, World!");
        }
    }
}
