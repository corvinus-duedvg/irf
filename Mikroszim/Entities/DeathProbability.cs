﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mikroszim.Entities
{
    public class DeathProbability
    {
        public int age { get; set; }
        public Gender Gender { get; set; }
        public double P { get; set; }
    }
}
