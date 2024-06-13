using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assignment_Coffee_Machine.Interfaces
{
    /// <summary>
    /// Interface representing a fluid container that can manage fluid levels.
    /// </summary>
    public interface IFluidContainer
    {
        /// <summary>
        /// Gets the capacity of the fluid container in liters.
        /// </summary>
        float Capacity { get; }

        /// <summary>
        /// Gets the current fluid level in the container in liters.
        /// </summary>
        float CurrentLevel { get; }

        /// <summary>
        /// Adds a specified amount of fluid to the container.
        /// </summary>
        /// <param name="litres">The amount of fluid to add in liters.</param>
        void AddFluid(float litres);

        /// <summary>
        /// Uses a specified amount of fluid from the container.
        /// </summary>
        /// <param name="litres">The amount of fluid to use in liters.</param>
        void UseFluid(float litres);
    }

}
