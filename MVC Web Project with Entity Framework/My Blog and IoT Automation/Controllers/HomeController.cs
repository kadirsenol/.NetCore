using Data_Access_Layer.Repositories.Abstract;
using Entity_Layer.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using My_Blog_and_IoT_Automation.Models;
using System.Diagnostics;

namespace My_Blog_and_IoT_Automation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        /**************************************************************/

        private readonly IRepository<AkilliKlima, int> _klimarepo;
        public HomeController(IRepository<AkilliKlima, int> klimarepo)
        {
            _klimarepo = klimarepo;
        }

        /***************************************************************/

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
