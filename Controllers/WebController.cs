using System;
using Microsoft.AspNetCore.Mvc;

namespace Webapp.Controllers {
    public class WebController : Controller {

        [HttpGet]
        public ActionResult SquareRoot () {
            return View ();
        }

        [HttpPost]
        public IActionResult SquareRoot (string FirstNumber, string SecondNumber) {
            try {
                if (int.Parse (FirstNumber) < 0 || int.Parse (SecondNumber) < 0) {
                    ViewBag.NegNumError = "Please input a Postive Value";
                }
                double numberOne = double.Parse (FirstNumber);
                double numberTwo = double.Parse (SecondNumber);

                double result1 = Math.Sqrt (numberOne);
                double result2 = Math.Sqrt (numberTwo);

                ViewBag.one = numberOne;
                ViewBag.two = numberTwo;
                ViewBag.first = result1;
                ViewBag.second = result2;

            } catch (FormatException ex) {
                string alphabetError = ex.Message;
                ViewBag.alphaError = "please input numbers only, try again";
            } catch (ArgumentException ex) {
                string emptyValueError = ex.Message;
                ViewBag.errorMessageEmpty = "Please input a number and try again";
            }
            return View ();
        }
    }
}