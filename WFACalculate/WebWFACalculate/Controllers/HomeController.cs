using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WFACalculate.OperationTwoArguments;

namespace WebWFACalculate.Controllers
{
    public class HomeController : Controller
    {
        private List<SelectListItem> operations = new List<SelectListItem>()
        {
            new SelectListItem()
            {
                Text = "+",
                Value = "Addition"
            },
            new SelectListItem()
            {
                Text = "-",
                Value = "Subtraction"
            },
            new SelectListItem()
            {
                Text = "*",
                Value = "Multiplication"
            },
            new SelectListItem()
            {
                Text = "/",
                Value = "Division"
            },
            new SelectListItem()
            {
                Text = "x^y",
                Value = "Powerxy"
            },
        };

        [HttpPost]
        public ActionResult Index(double firstNumber, double secondNumber, string operation)
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator(operation);
            ViewBag.result = calculator.Calculate(firstNumber, secondNumber);
            ViewBag.operations = operations;
            return View();
        }

        public ActionResult Index()
        {
            ViewBag.operations = operations;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}