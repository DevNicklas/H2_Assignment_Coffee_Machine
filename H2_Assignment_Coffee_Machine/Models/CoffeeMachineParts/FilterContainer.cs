﻿using H2_Assignment_Coffee_Machine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assignment_Coffee_Machine.Models.CoffeeMachineParts
{
    public class FilterContainer : IFilterContainer
    {
        private Filter _filter;

        /// <summary>
        /// Get the filter in the container
        /// </summary>
        public Filter Filter
        {
            get { return _filter; }
        }

        /// <summary>
        /// Inserts filter into filter container
        /// </summary>
        /// <param name="filter">Filter to insert</param>
        /// <exception cref="NotImplementedException">Thrown when the filter is already used</exception>
        public void InsertFilter(Filter filter)
        {
            if (filter.IsUsed)
            {
                throw new NotImplementedException("Filter is already used, and can't be inserted");
            }

            _filter = filter;
        }

        /// <summary>
        /// Disposes filter from filter container
        /// </summary>
        /// <exception cref="NotImplementedException">Thrown when filter isn't used</exception>
        public Filter DisposeFilter()
        {
            if (_filter == null)
            {
                throw new NotImplementedException("There isn't a filter in the container");
            }

            Filter disposedFilter = _filter;
            _filter = null;

            return disposedFilter;
        }
    }
}
