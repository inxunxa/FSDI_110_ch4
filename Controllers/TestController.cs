

using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{

    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult HomeWork2()
        {
            // practice LISTs

            /*
            List<string> names = new List<string>();

            names.Add("Sergio");
            names.Add("Chris");
            names.Add("Kleibert");
            names.Add("Miguel");

            for(int i=0; i< names.Count; i++){
                System.Console.WriteLine( names[i] );
            }
            */

            int num = 12;
            List<int> dividers = new List<int>();

            // your code here


            return Json(dividers);
        }

        private int CountAndPrintOdds(int[] numbers)
        {
            int count = 0;

            // print the odd numbers inside the array
            for (int i = 0; i < numbers.Length; i++)
            {
                int num = numbers[i]; // get each number

                // decide if num is an odd number
                if (num % 2 != 0)
                {
                    // is odd
                    System.Console.WriteLine(num);
                    count += 1;
                }
            }

            return count;
        }

        public IActionResult HomeWork()
        {

            int[] numbers = new int[200];
            for (int i = 0; i < 200; i++)
            {
                numbers[i] = i + 1;
            }

            int howMany = CountAndPrintOdds(numbers);
            System.Console.WriteLine(howMany);



            System.Console.WriteLine("************");



            System.Console.WriteLine("************");

            return Content("123");
        }
    }

}