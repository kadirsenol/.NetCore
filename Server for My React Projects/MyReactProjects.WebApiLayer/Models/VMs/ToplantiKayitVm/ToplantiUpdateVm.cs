namespace MeetingOrganizer.WebApiLayer.Models.VMs.ToplantiKayitVm
{
    public class ToplantiUpdateVm
    {
        public int Id { get; set; }

        public string? Konu { get; set; }

        public DateOnly? Tarih { get; set; }

        public TimeOnly? BaslamaSaati { get; set; }

        public TimeOnly? BitisSaati { get; set; }

        public string? Katilimcilar { get; set; }
    }
}
