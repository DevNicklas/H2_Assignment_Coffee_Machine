using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assignment_Coffee_Machine.Models
{
    /// <summary>
    /// Represents a tea bag with a specific flavour.
    /// </summary>
    public class TeaBag
    {
        private string _flavour;
        private bool _isUsed;

        /// <summary>
        /// Initializes a new instance of the <see cref="TeaBag"/> class with the specified flavour.
        /// </summary>
        /// <param name="flavour">The flavour of the tea bag.</param>
        public TeaBag(string flavour)
        {
            _flavour = flavour;
        }

        /// <summary>
        /// Gets the flavour of the tea bag.
        /// </summary>
        public string Flavour
        {
            get { return _flavour; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the tea bag has been used.
        /// </summary>
        public bool IsUsed
        {
            get { return _isUsed; }
            set { _isUsed = value; }
        }
    }
}
