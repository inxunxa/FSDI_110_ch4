using System;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{

    public class CatalogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        // Endpoint to get the list of cars to show on catalog page
        public IActionResult GetCatalog()
        {
            string test = "JSON Working";

            return Json(test);
        }

    }

}