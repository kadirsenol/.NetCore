using AutoMapper;
using MeetingOrganizer.BussinesLayer.Abstract;
using MeetingOrganizer.EntityLayer.Concrete;
using MeetingOrganizer.WebApiLayer.Models.VMs.UserVM;
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
            if (ModelState.IsValid)
            {
                try
                {
                    User user = mapper.Map<User>(userLoginVm);
                    User user1 = await userManager.ChackUserLogin(user);
                    if (user1 != null)
                    {
                        TokenManager tokenManager = new TokenManager();
                        User userwithToken = await tokenManager.CreateToken(user1, configuration);
                        await userManager.update(userwithToken);
                        return Ok(userwithToken.AccessToken);
                    }

                }
                catch (Exception ex)
                {

                    return Problem(ex.Message);
                }

            }
            var errorMessage = ModelState.Values.SelectMany(p => p.Errors.Select(e => e.ErrorMessage));
            return BadRequest(errorMessage);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Register(UserRegisterVm userRegisterVm) // IActionResult olarak dönüp return kisminda Ok(userWithToken.AccessToke) olarak donebilirsin. Else kısmına da Problem("Kullanici adi sifre hatali")
        {

            if (ModelState.IsValid)
            {
                try
                {
                    User user = mapper.Map<User>(userRegisterVm);
                    bool result = await userManager.ChackUserRegister(user);
                    if (result)
                    {
                        user.Rol = "Üye";
                        await userManager.Insert(user);
                        return Ok();
                    }
                }
                catch (Exception ex)
                {

                    return Problem(ex.Message);
                }

            }
            var errorMessage = ModelState.Values.SelectMany(p => p.Errors.Select(e => e.ErrorMessage));
            return BadRequest(errorMessage);
        }

    }
}
