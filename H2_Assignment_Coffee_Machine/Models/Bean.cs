using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assignment_Coffee_Machine.Models
{
    /// <summary>
    /// Represents a Bean with a name and weight.
    /// </summary>
    public class Bean
    {
        private string _name;

        private float _weight;

        /// <summary>
        /// Initializes a new instance of the <see cref="Bean"/> class with the specified details.
        /// </summary>
        /// <param name="name">The name of the bean.</param>
        /// <param name="weight">The weight of the bean.</param>
        public Bean(string name, float weight)
        {
            _name = name;
            _weight = weight;
        }

        /// <summary>
        /// Gets the name of the bean.
        /// </summary>
        public string Name
        {
            get { return _name; }
        }

        /// <summary>
        /// Gets the weight of the bean.
        /// </summary>
        public float Weight
        {
            get { return _weight; }
        }
    }
}
