﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workflow
{
    public class Step
    {
        public int id { get; set; }
        public string operationName { get; set; }
        public int nextIdIfOutputIsLessThan { get; set; }
        public int nextIdIfOutputIsGreaterThan { get; set; }
        public int? nextIdIfOutsGreaterThan { get; set; }
    }
}