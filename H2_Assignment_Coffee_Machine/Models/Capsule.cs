using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assignment_Coffee_Machine.Models
{
    /// <summary>
    /// Represents a coffee capsule with a name and usage status.
    /// </summary>
    public class Capsule
    {
        private string _name;
        private bool _isUsed = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="Capsule"/> class with the specified name.
        /// </summary>
        /// <param name="name">The name of the capsule.</param>
        public Capsule(string name)
        {
            _name = name;
        }

        /// <summary>
        /// Gets the name of the capsule.
        /// </summary>
        public string Name
        {
            get { return _name; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the capsule has been used.
        /// </summary>
        public bool IsUsed
        {
            get { return _isUsed; }
            set { _isUsed = value; }
        }
    }

}
