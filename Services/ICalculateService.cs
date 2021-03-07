using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestingAndLogging.Models;

namespace TestingAndLogging.Services
{
    public interface ICalculateService
    {
        public List<string> CalculateFibonacci(Fibonacci model);

        
        public double CalculatePythagoreanTheorem(Pythagorean model);

        public void ConvertInputStringToListOfDoubles(StandardDeviation model);

        
        public double CalculateStandardDeviation(StandardDeviation model);
    }
}
