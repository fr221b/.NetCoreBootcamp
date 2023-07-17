using Microsoft.AspNetCore.Mvc;
using MVCSample01.Models;
using System.Diagnostics;

namespace MVCSample01.Controllers
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

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Products()
        {
            return View();
        }

        public IActionResult Laptop()
        {
            return View();
        }

        public IActionResult Computer()
        {
            return View();
        }
    }
}