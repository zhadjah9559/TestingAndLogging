using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestingAndLogging.Models;

namespace TestingAndLogging.Services
{
    public interface ICalculateService
    {
        public Task<IEnumerable<int>> CalculateFibonacciAsync(Fibonacci model);

        public Task<int> CalculatePythagoreanTheoremAsync();     

        public Task<IEnumerable<double>> CalculateStandardDeviationAsync();
    }
}
