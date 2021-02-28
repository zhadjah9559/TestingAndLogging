using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestingAndLogging.Models;

namespace TestingAndLogging.Services
{
    public class CalculateService : ICalculateService
    {
        public async Task<IEnumerable<int>> CalculateFibonacciAsync(Fibonacci model)
        {
            List<int> returnList = new List<int>(model.Input);
            int num1 = 0;
            int num2 = 1;
            int num3;

            //Put the first two numbers of the fib series into the array
            returnList.Add(num1);
            returnList.Add(num2);

            //Get the subsequent numbers after the first two numbers in the series and put 
            //them into a List of ints 
            for (int i = 2; i < model.Input; i++)
            {
                num3 = num1 + num2;
                
                num1 = num2;
                num2 = num3;

                if(i >= 3)
                {
                    returnList.Add(num3);
                }
            }
            return returnList;
        }

        public Task<int> CalculatePythagoreanTheoremAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<double>> CalculateStandardDeviationAsync()
        {
            throw new NotImplementedException();
        }
    }
}
