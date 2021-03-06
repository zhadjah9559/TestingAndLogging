﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingAndLogging.Models
{
    public class StandardDeviation
    {

        //^\s*[\+-]?(\d*\.?\d{2}?)

        public string InputString { get; set; }
        public List<double> InputNumbers { get; set; } = new List<double>();

        public double Output { get; set; }
    }
}
