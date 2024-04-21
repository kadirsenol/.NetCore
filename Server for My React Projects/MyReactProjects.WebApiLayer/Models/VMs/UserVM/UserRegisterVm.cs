using System.ComponentModel.DataAnnotations;

namespace MeetingOrganizer.WebApiLayer.Models.VMs.UserVM
{
    public class UserRegisterVm
    {
        [Required(ErrorMessage = "İsim Alanı Boş Geçilemez")]
        public string Ad { get; set; }

        [Required(ErrorMessage = "Email Alanı Boş Geçilemez")]
        [RegularExpression(@"^$|^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Geçersiz e-posta adresi.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "TcNo Alanı Boş Geçilemez")]
        public string TcNo { get; set; }

        [Required(ErrorMessage = "Parola Alanı Boş Geçilemez")]
        public string Password { get; set; }
    }
}
