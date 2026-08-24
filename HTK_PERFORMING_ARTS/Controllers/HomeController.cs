using HTK_PERFORMING_ARTS.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HTK_PERFORMING_ARTS.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Modelling()
        {
            return View();
        }

        public IActionResult Acting()
        {
            return View();
        }

        public IActionResult Dancing()
        {
            return View();
        }

        public IActionResult Music()
        {
            return View();
        }

        public IActionResult Poetry()
        {
            return View();
        }




        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(
            Duration = 0,
            Location = ResponseCacheLocation.None,
            NoStore = true)]
        public IActionResult Error()
        {
            return View(
                new ErrorViewModel
                {
                    RequestId = Activity.Current?.Id
                        ?? HttpContext.TraceIdentifier
                });
        }
    }
}