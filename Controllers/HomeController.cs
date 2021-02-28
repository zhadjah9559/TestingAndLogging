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
            
            return View();
        }

        public IActionResult Fibonacci() 
        {
            var model = new Fibonacci();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Fibonacci(Fibonacci model)
        {
            model.Output = (List<int>)await _calculateService.CalculateFibonacciAsync(model);
            return View(model);
        }

        public IActionResult Pythagorean()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Pythagorean(Pythagorean model)
        {
            return View(model);
        }

        public IActionResult StandardDeviation()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> StandardDeviation(StandardDeviation model)
        {
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
