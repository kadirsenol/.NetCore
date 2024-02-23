using Table_Per_Type_TPT__for_Entity_Framework;

namespace Table_Per_Hierarchy__TPH__for_Entity_Framework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Table Per Hierarchy yöntemi database içerisinde birbirleri ile hiyararsi iliskisi bulunan tablolari
            //tek bir tablo icerisinde gosterecektir.
            //Olusan bu tablo, bütün entitylerin propertylerine karsilik birer kolon ve verinin hangi entity
            //tarafından geldiği bilgisini tutacak olan bir adet Discriminator adinda kolon icerir.
            //Ortak tabloda ki field adında propertye sahip olmayan entityler null degeri alacaktır. Yani;
            //(Car icin racingclass, Motorcycle icin TrunkSizeInCm3, Vehicle icin her ikisi null olacaktir)

            SqlDbContext context = new SqlDbContext();
            context.Cars.Add(new Car { Make = "a", TrunkSizeInCm3 = 2 });
            context.Vehicles.Add(new Vehicle { Make = "b" });
            context.Motorcycles.Add(new Motorcycle { Make = "c", RacingClass = RacingClass.cc125 });
            context.SaveChanges();

            Console.WriteLine("Hello, World!");
        }
    }
}
