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

        private float _weightInGrams;

        /// <summary>
        /// Initializes a new instance of the <see cref="Bean"/> class with the specified details.
        /// </summary>
        /// <param name="name">The name of the bean.</param>
        /// <param name="weightInGrams">The weight of the bean.</param>
        public Bean(string name, float weightInGrams)
        {
            _name = name;
            _weightInGrams = weightInGrams;
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
        public float WeightInGrams
        {
            get { return _weightInGrams; }
        }
    }
}
