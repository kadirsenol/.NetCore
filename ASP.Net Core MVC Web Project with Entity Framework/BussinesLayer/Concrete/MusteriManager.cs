using BussinesLayer.Abstract;
using Data_Access_Layer.Repositories.Abstract;
using Entity_Layer.Entities.Concrete;

namespace BussinesLayer.Concrete
{
    public class MusteriManager : IMusteriManager
    {
        private readonly IRepository<Musteri, int> _musrepo;
        public MusteriManager(IRepository<Musteri, int> musrepo)
        {
            _musrepo = musrepo;
        }


        //CRUD VE QUERY KURALLARINI OLUSTUR

    }
}
