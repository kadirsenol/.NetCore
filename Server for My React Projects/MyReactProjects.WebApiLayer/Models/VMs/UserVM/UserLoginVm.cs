using System.ComponentModel.DataAnnotations;

namespace MeetingOrganizer.WebApiLayer.Models.VMs.UserVM
{
    public class UserLoginVm
    {
        //Goruntu olmadigi icin valid atribute eklemedim

        [Required(ErrorMessage = "Email Alanı Boş Bırakılamaz.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password Alanı Boş Bırakılamaz.")]
        public string Password { get; set; }
    }
}
