using CarRentalClean.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CarRentalClean.Controllers
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
            


            if (User.IsInRole("Customer"))
            {
                return RedirectToAction("Landing");
            }
            else if (User.IsInRole("Admin") || User.IsInRole("Staff"))
            {
                return RedirectToAction("AdminDashboard");
            }
            else
            {
                return RedirectToAction("Landing");
            }
        }

        public IActionResult Landing()
        {
            return View();
        }
        public IActionResult AdminDashboard()
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