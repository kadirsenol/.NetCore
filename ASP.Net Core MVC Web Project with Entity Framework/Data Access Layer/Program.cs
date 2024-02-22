using Data_Access_Layer.DBContexts;
using Data_Access_Layer.Repositories.Concrete;
using Entity_Layer.Entities.Concrete;
namespace Data_Access_Layer
{
    //Bu projeyi console uygulaması açmamım sebebi veri tabanına verilerimi buradan yüklemek için.
    internal class Program
    {

        static void Main(string[] args)
        {
            //Veritabanında benim veri ekleyeceğim tablolarım için repolar. Bir unity conteynıra da eklenebilirdi.
            Repository<SqlDbContext, Urun, int> urunrepo = new Repository<SqlDbContext, Urun, int>();
            Repository<SqlDbContext, Kategori, int> katerepo = new Repository<SqlDbContext, Kategori, int>();
            Repository<SqlDbContext, Konut, int> konutrepo = new Repository<SqlDbContext, Konut, int>();







        }
    }
}
