using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assignment_Coffee_Machine.Models
{
    public class Capsule
    {
        private string _name;
        private bool _isUsed = false;

        public Capsule(string name)
        {
            _name = name;
        }

        public string Name
        {
            get { return _name; }
        }

        public bool IsUsed
        {
            get { return _isUsed; }
            set { _isUsed = value; }
        }
    }
}
