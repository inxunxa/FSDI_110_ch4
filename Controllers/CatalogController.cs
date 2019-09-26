using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CarRental.Models;

namespace CarRental.Controllers
{

    public class CatalogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Register()
        {
            return View();
        }


        [HttpGet]
        // Endpoint to get the list of cars to show on catalog page
        public IActionResult GetCatalog()
        {
            List<Car> cars = new List<Car>();

            Car c1 = new Car();
            c1.Id = 1;
            c1.Color = "Red";
            c1.Cyls = 8;
            c1.DailyPrice = 57.98m;
            c1.Description = "Super conffy and reliable car on a cheap price";
            c1.Doors = 2;
            c1.HP = 495;
            c1.ImageURL = "https://www.popsci.com/resizer/m-PYL9ERA2YASYR2tXzwE87Pw-E=/1015x1280/arc-anglerfish-arc2-prod-bonnier.s3.amazonaws.com/public/6GOP7VYO3DO5KHYK7RCRXVLQRU.jpg";
            c1.Make = "Chevy";
            c1.Mileage = 29;
            c1.Model = "Corvette";
            c1.Seats = 2;
            c1.Year = 2020;

            cars.Add(c1);


            return Json(cars);
        }

    }

}