using H2_Assignment_Coffee_Machine.Models.CoffeeMachineParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assignment_Coffee_Machine.Interfaces
{
    /// <summary>
    /// Interface representing a container that holds a filter.
    /// </summary>
    internal interface IFilterContainer
    {
        /// <summary>
        /// Gets or sets the filter contained within the container.
        /// </summary>
        Filter Filter { get; set; }
    }

}
