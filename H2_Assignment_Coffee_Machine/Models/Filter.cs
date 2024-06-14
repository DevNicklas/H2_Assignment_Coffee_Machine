using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assignment_Coffee_Machine.Models.CoffeeMachineParts
{

    /// <summary>
    /// Represents a filter that can be used in coffee machines.
    /// </summary>
    public class Filter
    {
        private bool _isUsed;

        /// <summary>
        /// Gets or sets a value indicating whether the filter used or not.
        /// </summary>
        public bool IsUsed
        {
            get { return _isUsed; }
            set { _isUsed = value; }
        }
    }

}
