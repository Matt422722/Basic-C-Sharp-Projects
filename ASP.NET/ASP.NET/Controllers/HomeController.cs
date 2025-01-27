using Microsoft.AspNetCore.Mvc;
using System;

namespace ASP.NET.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Get the current server time and pass it to the view
            ViewBag.ServerTime = DateTime.Now.ToString("F"); // Full DateTime Format
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}

