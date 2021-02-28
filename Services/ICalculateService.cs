using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestingAndLogging.Models;

namespace TestingAndLogging.Services
{
    public interface ICalculateService
    {
        public IEnumerable<int> CalculateFibonacci(Fibonacci model);

        //Encapsulated Method
        public void CalculatePythagoreanTheorem(Pythagorean model);

        public void ConvertInputStringToListOfDoubles(StandardDeviation model);

        //Encapsulated method
        public void CalculateStandardDeviation(StandardDeviation model);
    }
}
