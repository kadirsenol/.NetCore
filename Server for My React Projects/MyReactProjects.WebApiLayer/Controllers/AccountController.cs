using AutoMapper;
using MeetingOrganizer.BussinesLayer.Abstract;
using MeetingOrganizer.EntityLayer.Concrete;
using MeetingOrganizer.EntityLayer.Concrete.VMs.UserVM;
using MeetingOrganizer.WebApiLayer.MyExtensions.Tokens;
using Microsoft.AspNetCore.Mvc;
using MyReactProjects.WebApiLayer.MyExtensions.Email;
using System.Text;

namespace MeetingOrganizer.WebApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IUserManager userManager;
        private readonly IMapper mapper;
        private readonly IConfiguration configuration;

        public AccountController(IUserManager userManager, IMapper mapper, IConfiguration configuration) // Key degerini secrets dosyasina gecebilmek adini IConfigi istedik
        {
            this.userManager = userManager;
            this.mapper = mapper;
            this.configuration = configuration;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Login(UserLoginVm userLoginVm) // IActionResult olarak dönüp return kisminda Ok(userWithToken.AccessToke) olarak donebilirsin. Else kısmına da Problem("Kullanici adi sifre hatali")
        {
            if (!ModelState.IsValid)
            {
                var errorMessage = ModelState.Values.SelectMany(p => p.Errors.Select(e => e.ErrorMessage));
                return BadRequest(errorMessage);
            }
            try
            {
                User user = mapper.Map<User>(userLoginVm);
                User user1 = await userManager.ChackUserLogin(user);
                bool chackMailConfirm = await userManager.ChackUserEmailConfirm(user1);
                if (user1 != null && chackMailConfirm)
                {
                    TokenManager tokenManager = new TokenManager();
                    User userwithToken = await tokenManager.CreateToken(user1, configuration);
                    await userManager.update(userwithToken);
                    return Ok(new { accessToken = userwithToken.AccessToken, message = $"Hoşgeldin {(userwithToken.Ad).ToUpper()} !" });
                }
                return Problem("Opss! Giriş sırasında beklenedik bir hata meydana geldi.");
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }

        }


        [HttpPost("[action]")]
        public async Task<IActionResult> Register(UserRegisterVm userRegisterVm = null) // IActionResult olarak dönüp return kisminda Ok(userWithToken.AccessToke) olarak donebilirsin. Else kısmına da Problem("Kullanici adi sifre hatali")
        {

            if (!ModelState.IsValid) // Eger browserde js kapatilmissa buraya takilip yine validleri gonderecek.
            {
                var errorMessage = ModelState.Values.SelectMany(p => p.Errors.Select(e => e.ErrorMessage));
                return BadRequest(errorMessage);
            }
            try
            {
                User user = mapper.Map<User>(userRegisterVm);
                bool result = await userManager.ChackUserRegister(user);
                bool result1 = await userManager.ChackConfirmPassword(userRegisterVm);
                bool result2 = await userManager.ChackTcNo(userRegisterVm);
                if (result && result1 && result2)
                {
                    user.Rol = "Üye";

                    await userManager.Insert(user);
                    User withiduser = await userManager.GetByEmailUser(user.Email);
                    string code = await userManager.CreateEmailConfirmGuidCode(withiduser);

                    StringBuilder message = new();
                    message.AppendLine("<html>");
                    message.AppendLine("<head>")
                        .AppendLine("<meta charset='UTF-8'")
                        .AppendLine("</head>");
                    message.AppendLine($"<p> Merhaba {userRegisterVm.Ad} </p> <br>");
                    message.AppendLine("<p> Üyeliğini tamamlamak için aşşağıda ki linke tıklaman yeterli olucak. </p>");
                    message.AppendLine($"<a href='http://localhost:5051/api/Account/ConfirmEmail?uid={withiduser.Id}&code={code}'> Tıklayın. </a>");
                    message.AppendLine("</body>");
                    message.AppendLine("</html>");

                    EmailHelper emailHelper = new EmailHelper();
                    bool sonuc = await emailHelper.SendEmail(user.Email, message.ToString());
                    if (sonuc)
                    {
                        return Ok($"{user.Email} adresine bir doğrulama linki gönderdik, üyeliğinin tamamlanması için mail içerisinde ki linke tıklamalısın.");
                    }
                    else
                    {
                        throw new Exception("Mail gönderimi sırasında bir hata oluştu. Lütfen tekrar deneyin.");
                    }
                }
                else
                {
                    return Problem("Opss! Kayıt sırasında beklenedik bir hata meydana geldi.");
                }

            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }


        //[ValidateAntiForgeryToken] bu tokeni ben mi gönderdim diye kontrol ediyor
        //[Route("ConfirmEmail")]
        [HttpGet("[action]")]
        public async Task<IActionResult> ConfirmEmail(string uid, string code)
        {

            if (!string.IsNullOrEmpty(uid) && !string.IsNullOrEmpty(code))
            {
                var result = await userManager.ConfirmEmailAsync(uid, code);

                if (result)
                {
                    return Redirect("http://localhost:3000/Login");
                }
                else
                {
                    return Problem("Mail onaylama işlemi başarısız, lütfen tekrar deneyin. !");
                }
            }
            else
            {
                return Problem("Mail onaylama sırasında bir hata oluştu, lütfen tekrar deneyiniz. !");
            }
        }

    }
}
