﻿using H2_Assignment_Coffee_Machine.Models.CoffeeMachineParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assignment_Coffee_Machine.Interfaces
{
    internal interface IFilterContainer
    {
        Filter Filter { get; set; }
    }
}
