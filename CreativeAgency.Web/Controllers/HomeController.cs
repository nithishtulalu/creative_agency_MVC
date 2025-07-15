using System.Diagnostics;
using CreativeAgency.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace CreativeAgency.Web.Controllers
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

        public IActionResult Services()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        
    }
}
