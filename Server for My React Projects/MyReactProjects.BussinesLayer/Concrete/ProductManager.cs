using MeetingOrganizer.BussinesLayer.Abstract;
using MeetingOrganizer.EntityLayer.Concrete;

namespace MeetingOrganizer.BussinesLayer.Concrete
{
    public class ProductManager : Manager<Product, int>, IProductManager
    {
    }
}
