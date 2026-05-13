using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Test_2.Models;

namespace Test_2.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult TestView()
        {
            return View();
        }

        public IActionResult Devoured()
        {
            return View();
        }

        public IActionResult Browse()
        {
            return View();
        }

        public IActionResult Toplists()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult ExampleUserListOfReviews()
        {
            return View();
        }

        public IActionResult ExUserList()
        {
            return View();
        }

        public IActionResult ProductPage()
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
