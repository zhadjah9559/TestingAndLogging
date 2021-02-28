using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingAndLogging.Models
{
    public class StandardDeviation
    {
        public string InputString { get; set; }
        public List<double> InputNumbers { get; set; }

        public double Output { get; set; }
    }
}
