using H2_Assignment_Coffee_Machine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assignment_Coffee_Machine.Models.CoffeeMachineParts
{
    /// <summary>
    /// Represents a water container
    /// </summary>
    public class WaterContainer : IFluidContainer
    {
        private float _capacity;
        private float _currentLevel = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="WaterContainer"/> class with the specified capacity.
        /// </summary>
        /// <param name="capacity">The maximum capacity of the water container.</param>
        public WaterContainer(float capacity)
        {
            _capacity = capacity;
        }

        /// <summary>
        /// Gets the capacity of the water container.
        /// </summary>
        public float Capacity
        {
            get { return _capacity; }
        }

        /// <summary>
        /// Gets the current fluid level in the water container.
        /// </summary>
        public float CurrentLevel
        {
            get { return _currentLevel; }
        }

        /// <summary>
        /// Adds fluid to the water container.
        /// </summary>
        /// <param name="litres">The amount of fluid to add in liters.</param>
        /// <exception cref="NotImplementedException">Thrown if too much fluid is attempting to be added.</exception>
        public void AddFluid(float litres)
        {
            float newLevel = _currentLevel + litres;

            if (newLevel > _capacity)
            {
                throw new NotImplementedException("Too much fluid is trying to be added");
            }

            _currentLevel = newLevel;
        }

        /// <summary>
        /// Uses fluid from the water container.
        /// </summary>
        /// <param name="litres">The amount of fluid to use in liters.</param>
        /// <exception cref="NotImplementedException">Thrown if there isn't enough fluid to use.</exception>
        public void UseFluid(float litres)
        {
            if (_currentLevel < litres)
            {
                throw new NotImplementedException("There isn't enough fluid to use");
            }

            _currentLevel -= litres;
        }
    }

}
