using ATI.WEB.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ATI.WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contacto()
        {
            return View();
        }

        // GET: Personal
        public IActionResult Gallery()
        {
            return View();
        }

        public IActionResult ObjetivosHSEQ()
        {
            return View();
        }

        public IActionResult QuienesSomos()
        {
            return View();
        }

        public IActionResult PoliticaProhibida()
        {
            return View();
        }

        public IActionResult PoliticaHSEQ()
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