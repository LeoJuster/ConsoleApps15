using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApps.Models;
using ConsoleAppProject.App02;

namespace WebApps.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DistanceConverter()
        {
            return View();
        }

        [HttpGet]
        public IActionResult BMI()
        {
            return View();
        }

        [HttpPost]
        public IActionResult BMI(BMI bmi)
        {
            if (bmi.HeightInMetres > 14)
            {
                bmi.MetricFormula();
            }
            else if (bmi.HeightInFeet > 4 && bmi.WeightInStones > 6)
            {
                bmi.ImperialFormula();
            }
                return View();


        }

        public IActionResult StudentGrades()
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
