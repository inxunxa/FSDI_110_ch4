using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CarRental.Models;

namespace CarRental.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            System.Console.WriteLine("The user wants the Index view");
            return View();

        }

        public IActionResult Hello()
        {
            System.Console.WriteLine("The user wants the Hello view");
            return View();
        }

        public IActionResult Privacy()
        {
            System.Console.WriteLine("The user wants the Privacy view");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
