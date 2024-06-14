using H2_Assignment_Coffee_Machine.Models;
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
    public interface IFilterContainer
    {
        /// <summary>
        /// Gets the filter contained within the container.
        /// </summary>
        Filter Filter { get; }

        /// <summary>
        /// Inserts filter into filter container
        /// </summary>
        /// <param name="filter">Filter to insert</param>
        void InsertFilter(Filter filter);

        /// <summary>
        /// Disposes filter from filter container
        /// </summary>
        Filter DisposeFilter();
    }

}
