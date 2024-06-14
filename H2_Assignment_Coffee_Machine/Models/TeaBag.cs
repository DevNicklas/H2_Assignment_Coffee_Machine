using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assignment_Coffee_Machine.Models
{
    public class TeaBag
    {
        private string _flavour;
        private bool _isUsed;

        public TeaBag(string flavour)
        {
            _flavour = flavour;
        }

        public string Flavour
        {
            get { return _flavour; }
        }

        public bool IsUsed
        {
            get { return _isUsed; }
            set { _isUsed = value; }
        }
    }
}
