
using BussinesLayer.Abstract;
using Data_Access_Layer.Repositories.Abstract;
using Entity_Layer.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using My_Blog_and_IoT_Automation.Models;
using System.Diagnostics;

namespace My_Blog_and_IoT_Automation.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        /**************************************************************/

        private readonly IMusteriManager _musmanager;
        private readonly IRepository<Urun, int> _urunrepo;
        public HomeController(IRepository<Urun, int> urunrepo, IMusteriManager musmanager)
        {
            _musmanager = musmanager;
            _urunrepo = urunrepo;
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
