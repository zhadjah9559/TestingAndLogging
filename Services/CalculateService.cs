using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestingAndLogging.Models;

namespace TestingAndLogging.Services
{
    public class CalculateService : ICalculateService
    {
        private readonly ILogger<CalculateService> _logger;

        //default ctor
        public CalculateService()
        {

        }

        //overloaded ctor
        public CalculateService(ILogger<CalculateService> logger)
        {
            _logger = logger;
        }

        public List<string> CalculateFibonacci(Fibonacci model)
        {
            //Keep track of 
            _logger.LogInformation("***Beginning Fibonacci Info***");
            _logger.LogInformation($"The number of entries the user entered is: {model.Input}");

            List<string> returnList = new List<string>();
            int num1 = 0;
            int num2 = 1;
            int num3;

            //Put the first two numbers of the fib series into the array
            returnList.Add($"{num1}");
            returnList.Add($"{num2}");
                      
            if (model.Input == 1)
            {
                returnList.RemoveAt(1);
            }

            //Get the subsequent numbers after the first two numbers in the series and put 
            //them into a List of ints 
            else if (model.Input > 2)
            {
                for (int i = 2; i < model.Input; i++)
                {
                    num3 = num1 + num2;

                    num1 = num2;
                    num2 = num3;

                    returnList.Add($"{num3}");
                }

                _logger.LogInformation("List of numbers were calculated without exceptions.");
            }          

            _logger.LogInformation("All the numbers inside the Fibonacci List");

            foreach(var number in returnList)
            {
                _logger.LogInformation($"{number}");
            }

            _logger.LogInformation("***Ending Fibonacci Info***");
            return returnList;
        }

        public double CalculatePythagoreanTheorem(Pythagorean model)
        {
            _logger.LogInformation("***Beginning Pythagorean Theorem Info***");
            _logger.LogInformation($"Input A = {model.InputA}");
            _logger.LogInformation($"Input B = {model.InputB}");

            model.InputA = Math.Round(model.InputA, 2);
            model.InputB = Math.Round(model.InputB, 2);

            double cSquared = model.InputA * model.InputA + model.InputB * model.InputB;
            double output = Math.Round(Math.Sqrt(cSquared), 2);

            _logger.LogInformation($"Output C = {model.OutputC}");
            _logger.LogInformation($"***Ending Pythagorean Theorem Info***");
                                    
            return output;
        }

        public void ConvertInputStringToListOfDoubles(StandardDeviation model)
        {
            string[] doubles = model.InputString.Split(',');
                        
            foreach (var item in doubles)
            {
                model.InputNumbers.Add(Double.Parse(item));
                _logger.LogInformation($"{item}");
            }
            _logger.LogInformation("All the numbers entered by the user:");
        }

        public double CalculateStandardDeviation(StandardDeviation model)
        {
            _logger.LogInformation("***Beginning Standard Deviation Calculation***");

            double avg = Math.Round(model.InputNumbers.Average(), 2);
            double sum = Math.Round(model.InputNumbers.Sum(v => (v - avg) * (v - avg)), 2);
            double denominator = model.InputNumbers.Count - 1;
            double output = Math.Round(denominator > 0.0 ? Math.Sqrt(sum / denominator) : -1, 2);

            _logger.LogInformation($"Output = {output}");
            _logger.LogInformation($"***Ending Standard Deviation Calculation***");

            //As long as the denominator does equal zero, perform sum/denominator and square root it
            return output;                
        }
    }
}
