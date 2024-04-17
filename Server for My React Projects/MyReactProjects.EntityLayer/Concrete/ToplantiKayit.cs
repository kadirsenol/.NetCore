using MeetingOrganizer.EntityLayer.Abstract;

namespace MeetingOrganizer.EntityLayer.Concrete
{
    public class ToplantiKayit : BaseEntity<int>
    {
        public string Konu { get; set; }
        public DateOnly? Tarih { get; set; }
        public TimeOnly? BaslamaSaati { get; set; }
        public TimeOnly? BitisSaati { get; set; }
        public string Katilimcilar { get; set; }
    }
}
