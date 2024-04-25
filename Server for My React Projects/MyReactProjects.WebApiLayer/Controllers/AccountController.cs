using AutoMapper;
using MeetingOrganizer.BussinesLayer.Abstract;
using MeetingOrganizer.EntityLayer.Concrete;
using MeetingOrganizer.EntityLayer.Concrete.VMs.UserVM;
using MeetingOrganizer.WebApiLayer.MyExtensions.Tokens;
using Microsoft.AspNetCore.Mvc;

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
                if (user1 != null)
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
                    return Ok("Kullanıcı başarıyla kaydedildi.");
                }
                return Problem("Opss! Kayıt sırasında beklenedik bir hata meydana geldi.");
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

    }
}
