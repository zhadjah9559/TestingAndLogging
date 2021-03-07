using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestingAndLogging.Models;

namespace TestingAndLogging.Services
{
    public class CalculateService : ICalculateService
    {
        public List<string> CalculateFibonacci(Fibonacci model)
        {
            List<string> returnList = new List<string>();
            int num1 = 0;
            int num2 = 1;
            int num3;

            //Put the first two numbers of the fib series into the array
            returnList.Add($"{num1}");
            returnList.Add($"{num2}");

            //Get the subsequent numbers after the first two numbers in the series and put 
            //them into a List of ints 
            for (int i = 2; i < model.Input; i++)
            {
                num3 = num1 + num2;
                
                num1 = num2;
                num2 = num3;

                returnList.Add($"{num3}");
            }
            return returnList;
        }

        public double CalculatePythagoreanTheorem(Pythagorean model)
        {
            model.InputA = Convert.ToDouble(model.InputA);
            model.InputB = Convert.ToDouble(model.InputB);

            double cSquared = model.InputA * model.InputA + model.InputB * model.InputB;
            double output = Math.Round(Math.Sqrt(cSquared), 2);

            //model.OutputC = Math.Round( Math.Sqrt(cSquared), 2 );
            return output;
        }

        public void ConvertInputStringToListOfDoubles(StandardDeviation model)
        {
            string[] doubles = model.InputString.Split(',');

            foreach(var item in doubles)
            {
                model.InputNumbers.Add(Double.Parse(item));
            }
        }

        public double CalculateStandardDeviation(StandardDeviation model)
        {
            double avg = Math.Round(model.InputNumbers.Average(), 2);
            double sum = Math.Round(model.InputNumbers.Sum(v => (v - avg) * (v - avg)), 2);
            double denominator = model.InputNumbers.Count - 1;
            double output = Math.Round(denominator > 0.0 ? Math.Sqrt(sum / denominator) : -1, 2);

            //As long as the denominator does equal zero, perform sum/denominator and square root it
            return output;
                
        }
    }
}
