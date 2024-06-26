﻿using H2_Assignment_Coffee_Machine.Interfaces;
using H2_Assignment_Coffee_Machine.Models.CoffeeMachineParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assignment_Coffee_Machine.Models.CoffeeMachines
{
    /// <summary>
    /// Represents an brewer machine with basic properties and functionality.
    /// </summary>
    public abstract class BrewerMachine
    {
        private string _brandName;
        private float _width;
        private float _height;
        private bool _isTurnedOn = false;
        private IFluidContainer _waterContainer;

        /// <summary>
        /// Initializes a new instance of the <see cref="BrewerMachine"/> class with the specified details.
        /// </summary>
        /// <param name="brandName">The brand name of the brewer machine.</param>
        /// <param name="width">The width of the brewer machine.</param>
        /// <param name="height">The height of the brewer machine.</param>
        /// <param name="waterContainer">The water container used by the brewer machine.</param>
        protected BrewerMachine(string brandName, float width, float height, IFluidContainer waterContainer)
        {
            _brandName = brandName;
            _width = width;
            _height = height;
            _waterContainer = waterContainer;
        }

        /// <summary>
        /// Gets the brand name of the brewer machine.
        /// </summary>
        public string BrandName
        {
            get { return _brandName; }
        }

        /// <summary>
        /// Gets the width of the brewer machine.
        /// </summary>
        public float Width
        {
            get { return _width; }
        }

        /// <summary>
        /// Gets the height of the brewer machine.
        /// </summary>
        public float Height
        {
            get { return _height; }
        }

        /// <summary>
        /// Gets a boolean indicating whether the brewer machine is turned on.
        /// </summary>
        public bool IsTurnedOn
        {
            get { return _isTurnedOn; }
        }

        /// <summary>
        /// Gets the water container used by the brewer machine.
        /// </summary>
        public IFluidContainer WaterContainer
        {
            get { return _waterContainer; }
        }

        /// <summary>
        /// Toggles the power of the brewer machine
        /// </summary>
        public void TogglePower()
        {
            _isTurnedOn = !_isTurnedOn;
        }

        /// <summary>
        /// Dispenses fluid into the specified fluid container.
        /// </summary>
        /// <param name="fluidContainer">The fluid container into which the fluid is dispensed.</param>
        public void DispenseFluid(IFluidContainer fluidContainer)
        {
            fluidContainer.AddFluid(0.236588f);
        }

        /// <summary>
        /// Brews something, could be coffee.
        /// </summary>
        /// <returns>True if the brewing process was successful, otherwise false.</returns>
        public abstract bool Brew();
    }

}
