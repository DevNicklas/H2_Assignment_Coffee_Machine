using H2_Assignment_Coffee_Machine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assignment_Coffee_Machine.Interfaces
{
    /// <summary>
    /// Interface representing an infuser that contains a tea bag.
    /// </summary>
    public interface IInfuser
    {
        /// <summary>
        /// Gets the currently inserted tea bag.
        /// </summary>
        TeaBag TeaBag { get; }

        /// <summary>
        /// Inserts a tea bag into the infuser.
        /// </summary>
        /// <param name="teaBag">The tea bag to insert.</param>
        void InsertTeaBag(TeaBag teaBag);

        /// <summary>
        /// Disposes of the currently inserted tea bag and returns it.
        /// </summary>
        /// <returns>The disposed tea bag.</returns>
        TeaBag DisposeTeaBag();
    }
}
