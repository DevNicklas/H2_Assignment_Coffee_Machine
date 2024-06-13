using H2_Assignment_Coffee_Machine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assignment_Coffee_Machine.Interfaces
{
    /// <summary>
    /// Interface representing a capsule dispenser.
    /// </summary>
    public interface ICapsuleDispenser
    {
        /// <summary>
        /// Gets the currently inserted capsule.
        /// </summary>
        Capsule Capsule { get; }

        /// <summary>
        /// Inserts a capsule into the dispenser.
        /// </summary>
        /// <param name="capsule">The capsule to insert.</param>
        void InsertCapsule(Capsule capsule);

        /// <summary>
        /// Disposes of the currently inserted capsule and returns it.
        /// </summary>
        /// <returns>The disposed capsule.</returns>
        Capsule DisposeCapsule();
    }

}
