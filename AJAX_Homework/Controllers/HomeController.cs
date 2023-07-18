using AJAX_Homework.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace AJAX_Homework.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly DemoContext _context;
        private readonly IWebHostEnvironment _host;
        public HomeController(ILogger<HomeController> logger, DemoContext context, IWebHostEnvironment host)
        {
            _logger = logger;
            _context = context;
            _host = host;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult First()
        {
            return View();
        }

        public IActionResult Second()
        {
            return View();
        }

        public IActionResult Third()
        {
            return View();
        }

        public IActionResult Fourth()
        {
            return View();
        }

        public IActionResult Fifth()
        {
            return View();
        }

        public IActionResult Sixth()
        {
            return View();
        }

        public IActionResult Seventh()
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