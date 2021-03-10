using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TestingAndLogging.Models;
using TestingAndLogging.Services;

namespace TestingAndLogging.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICalculateService _calculateService;

        public HomeController(ILogger<HomeController> logger, ICalculateService calculateService)
        {
            _logger = logger;
            _calculateService = calculateService;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("BEGINNING PROGRAM");

            return View();
        }

        public IActionResult Fibonacci() 
        {
            var model = new Fibonacci();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Fibonacci(Fibonacci model)
        {
            model.Output = (List<string>) _calculateService.CalculateFibonacci(model);
            return View(model);
        }

        public IActionResult Pythagorean()
        {
            var model = new Pythagorean();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Pythagorean(Pythagorean model)
        {
            model.OutputC = _calculateService.CalculatePythagoreanTheorem(model);
            return View(model);
        }

        public IActionResult StandardDeviation()
        {
            var model = new StandardDeviation();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult StandardDeviation(StandardDeviation model)
        {
            _calculateService.ConvertInputStringToListOfDoubles(model);
            model.Output = _calculateService.CalculateStandardDeviation(model);
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
