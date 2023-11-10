using H4_2C.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace H4_2C.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        public IActionResult IlkIstek() 
        {
            ViewBag.msj1 = "ViewBag Mesajı";
            //ViewBag.oogr = ogr;
            ViewData["msj2"] = "ViewData Mesajı";
            TempData["msj3"] = "TempData Mesajı";
           TempData["sayi"] = 15;

            //  return View(); 
            return RedirectToAction("IkinciIstek");
        }
        public IActionResult IkinciIstek()
        {
            int say=Convert.ToInt32(TempData["sayi"]);
            return View();
        }

        public IActionResult RazorOrn()
        {
            TempData["sayi"] = 150;
            return View();
        }
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

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