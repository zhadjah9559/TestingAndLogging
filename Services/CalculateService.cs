using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestingAndLogging.Models;

namespace TestingAndLogging.Services
{
    public class CalculateService : ICalculateService
    {
        public IEnumerable<int> CalculateFibonacci(Fibonacci model)
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

                returnList.Add(num3);
            }
            return returnList;
        }

        public void CalculatePythagoreanTheorem(Pythagorean model)
        {
            model.InputA = Convert.ToDouble(model.InputA);
            model.InputB = Convert.ToDouble(model.InputB);

            double cSquared = model.InputA * model.InputA + model.InputB * model.InputB;

            model.OutputC = Math.Sqrt(cSquared);
        }

        public void ConvertInputStringToListOfDoubles(StandardDeviation model)
        {
            string[] doubles = model.InputString.Split(',');

            foreach(var double in doubles)
            {
                
            }

            model.InputNumbers.AddRange(model.InputString.Split(',').ToList());
        }

        public void CalculateStandardDeviation(StandardDeviation model)
        {
            double avg = model.InputNumbers.Average();
            double sum = model.InputNumbers.Sum(v => (v - avg) * (v - avg));
            double denominator = model.InputNumbers.Count - 1;
            model.Output = denominator > 0.0 ? Math.Sqrt(sum / denominator) : -1;
        }
    }
}
