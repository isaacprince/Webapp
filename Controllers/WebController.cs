using System;
using Microsoft.AspNetCore.Mvc;

namespace Webapp.Controllers {
    public class WebController : Controller {

        [HttpGet]
        public ActionResult SquareRoot () {
            return View ();
        }

        [HttpPost]
        public IActionResult SquareRoot (string firstNumber, string secondNumber) {
            double numberOne = double.Parse (firstNumber);
            double numberTwo = double.Parse (secondNumber);

            double result1 = Math.Sqrt (double.Parse (firstNumber));
            double result2 = Math.Sqrt (double.Parse (secondNumber));

            ViewBag.first = result1;
            ViewBag.second = result2;
            ViewBag.one = numberOne;
            ViewBag.two = numberTwo;

            if (ViewBag.first != null && ViewBag.second != null) {

                try {
                    if (ViewBag.first > ViewBag.second) {

                        Console.WriteLine ($"The number {ViewBag.one} with Square root {ViewBag.result1} has a higher square root than {ViewBag.two} with square root {ViewBag.result2}");

                    } else if (ViewBag.second > ViewBag.first) {

                        Console.WriteLine ($"The number {ViewBag.two} with Square root {ViewBag.result2} has a higher square root than {ViewBag.one} with square root {ViewBag.result1}");

                    } else if (ViewBag.first == ViewBag.Second && ViewBag.second == ViewBag.one) {

                        Console.WriteLine ($"The number { ViewBag.one } with Square root { ViewBag.result1 } has the same Value with { ViewBag.two } with square root {ViewBag.result2} PLEASE ENTER DIFFERENT VALUES");
                    }
                } catch (FormatException) {
                    Console.WriteLine ($"WRONG INPUT PLEASE ENTER A POSITIVE VALUE!!");
                }

            }

            return View ();
        }
    }
}