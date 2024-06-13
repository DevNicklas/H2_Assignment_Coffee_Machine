using H2_Assignment_Coffee_Machine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assignment_Coffee_Machine.Interfaces
{
    /// <summary>
    /// Interface representing a bean grinder.
    /// </summary>
    internal interface IBeanGrinder
    {
        /// <summary>
        /// Gets the inventory of beans available for grinding.
        /// </summary>
        List<Bean> Inventory { get; }

        /// <summary>
        /// Gets the capacity of the bean grinder.
        /// </summary>
        int Capacity { get; }

        /// <summary>
        /// Inserts a list of beans into the bean grinder.
        /// </summary>
        /// <param name="beans">The list of beans to insert.</param>
        void InsertBeans(List<Bean> beans);

        /// <summary>
        /// Grinds the beans in the grinder.
        /// </summary>
        void Grind();
    }

}
