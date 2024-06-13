using H2_Assignment_Coffee_Machine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assignment_Coffee_Machine.Models.CoffeeDispensingUnits
{
    public abstract class CoffeeDispensingUnit : IFluidContainer
    {
        private float _capacity;
        private float _currentLevel = 0;

        public CoffeeDispensingUnit(float maxCapacity)
        {
            _capacity = maxCapacity;
        }

        public float Capacity
        {
            get { return _capacity; }
        }

        public float CurrentLevel
        {
            get { return _currentLevel; }
        }

        public void AddFluid(float litres)
        {
            _currentLevel += litres;
        }

        public void UseFluid(float litres)
        {

            if (_currentLevel < litres)
            {
                throw new NotImplementedException("There aren't enough fluid to use");
            }

            _currentLevel -= litres;
        }
    }
}
