using System;
using Microsoft.AspNetCore.Mvc;

namespace Webapp.Controllers {
    public class WebController : Controller {

        [HttpGet]
        public ActionResult SquareRoot () {
            return View ();
        }

        [HttpPost]
        public ActionResult SquareRoot (string firstNumber, string secondNumber) {
            double numberOne = double.Parse (firstNumber);
            double numberTwo = double.Parse (secondNumber);

            double result1 = Math.Sqrt (double.Parse (firstNumber));
            double result2 = Math.Sqrt (double.Parse (secondNumber));

            ViewBag.first = result1;
            ViewBag.second = result2;
            ViewBag.one = numberOne;
            ViewBag.two = numberTwo;
            return View ();
        }
    }
}