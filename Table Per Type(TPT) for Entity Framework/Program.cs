namespace Table_Per_Type_TPT__for_Entity_Framework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SqlDbContext context = new SqlDbContext();
            context.Students.Add(new Student { Name = "a", School = "b" });
            context.Teachers.Add(new Teacher { Name = "c", School = "b" });
            context.SaveChanges();

            //Inherit veren ata sinifinin primary keyini inherit alan siniflar kullanir
            //Alt tablolara girilen veriler, inherit alınan tablolara da otomatik atanmış olur.
            //Yukarida goruldugu gibi ApplicationUser tablosuna veri girisi yapilmamasina ragmen bu sinifin
            //inherit verdigi siniflara yapilan veri girisi ata sinifa da register edilmis olur.
            //Bunun nedeni veri girilen tablonun field i inherit aldığı ata sinifindan kazanılmış bir kolondur
            //ve senkron olarak ata sinifina da ilgili veriler register edilir.

            Console.WriteLine("Hello, World!");
        }
    }
}
