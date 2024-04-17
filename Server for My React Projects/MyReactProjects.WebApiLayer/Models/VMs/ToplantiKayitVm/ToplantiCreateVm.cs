using System.ComponentModel.DataAnnotations;

namespace MeetingOrganizer.WebApiLayer.Models.VMs.ToplantiKayitVm
{
    public class ToplantiCreateVm
    {
        [Required(ErrorMessage = "Konu Alanı Boş Geçilemez")]
        public string? Konu { get; set; }


        [Required(ErrorMessage = "Lütfen yy-mm-dd formatında tarih giriniz.")]
        public DateOnly? Tarih { get; set; } = new DateOnly();


        [Required(ErrorMessage = "Lütfen başlangıç saatini sa:dk:sn formatında giriniz.")]
        public TimeOnly? BaslamaSaati { get; set; } = new TimeOnly();


        [Required(ErrorMessage = "Lütfen bitiş saatini sa:dk:sn formatında giriniz.")]
        public TimeOnly? BitisSaati { get; set; } = new TimeOnly();

        [Required(ErrorMessage = "Lütfen katılımcıları giriniz.")]
        public string? Katilimcilar { get; set; }
    }
}
