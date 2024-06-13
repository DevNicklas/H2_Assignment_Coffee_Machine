using H2_Assignment_Coffee_Machine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assignment_Coffee_Machine.Models
{
    /// <summary>
    /// Represents a container used in a coffee machine for dispensing coffee.
    /// </summary>
    public class CoffeeContainer : IFluidContainer
    {
        private float _capacity;
        private float _currentLevel = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="CoffeeContainer"/> class with the specified capacity.
        /// </summary>
        /// <param name="capacity">The capacity of the coffee container in litres.</param>
        public CoffeeContainer(float capacity)
        {
            _capacity = capacity;
        }

        /// <summary>
        /// Gets the capacity of the coffee container in litres.
        /// </summary>
        public float Capacity
        {
            get { return _capacity; }
        }

        /// <summary>
        /// Gets the current fluid level in the coffee container in litres.
        /// </summary>
        public float CurrentLevel
        {
            get { return _currentLevel; }
        }

        /// <summary>
        /// Adds the specified amount of fluid to the coffee container.
        /// </summary>
        /// <param name="litres">The amount of fluid to add, in litres.</param>
        public void AddFluid(float litres)
        {
            _currentLevel += litres;
        }

        /// <summary>
        /// Uses the specified amount of fluid from the coffee container.
        /// </summary>
        /// <param name="litres">The amount of fluid to use, in litres.</param>
        /// <exception cref="NotImplementedException">Thrown when there isn't enough fluid to use.</exception>
        public void UseFluid(float litres)
        {
            if (_currentLevel < litres)
            {
                throw new NotImplementedException("There isn't enough fluid to use.");
            }

            _currentLevel -= litres;
        }
    }

}
