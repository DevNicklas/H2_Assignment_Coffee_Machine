using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assignment_Coffee_Machine.Models
{
    public class Bean
    {
        private string _name;
        private float _weight;

        public Bean(string name, float weight)
        {
            _name = name;
            _weight = weight;
        }

        public string Name
        {
            get { return _name; }
        }

        public float Weight
        {
            get { return _weight; }
        }
    }
}
