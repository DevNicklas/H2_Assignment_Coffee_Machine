using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assignment_Coffee_Machine.Models.CoffeeMachineParts
{

    public class Filter
    {
        private bool _isUsed;

        public bool IsUsed
        {
            get { return _isUsed; }
            set { _isUsed = value; }
        }
    }
}
