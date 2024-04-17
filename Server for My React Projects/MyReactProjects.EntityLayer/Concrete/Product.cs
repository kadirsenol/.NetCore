using MeetingOrganizer.EntityLayer.Abstract;

namespace MeetingOrganizer.EntityLayer.Concrete
{
    public class Product : BaseEntity<int>
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public string Image { get; set; }

    }
}
