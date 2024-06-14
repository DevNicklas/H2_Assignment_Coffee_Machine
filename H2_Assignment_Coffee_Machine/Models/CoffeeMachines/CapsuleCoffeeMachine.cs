using H2_Assignment_Coffee_Machine.Interfaces;
using H2_Assignment_Coffee_Machine.Models.CoffeeMachineParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assignment_Coffee_Machine.Models.CoffeeMachines
{
    /// <summary>
    /// Represents a coffee machine that uses capsules to brew coffee.
    /// </summary>
    public class CapsuleCoffeeMachine : CoffeeMachine, ICapsuleDispenser
    {
        private Capsule _capsule;
        const float WATER_FOR_CAPSULE = 0.03f;

        /// <summary>
        /// Initializes a new instance of the <see cref="CapsuleCoffeeMachine"/> class with the specified details.
        /// </summary>
        /// <param name="brandName">The brand name of the coffee machine.</param>
        /// <param name="width">The width of the coffee machine.</param>
        /// <param name="height">The height of the coffee machine.</param>
        /// <param name="waterContainer">The water container used by the coffee machine.</param>
        public CapsuleCoffeeMachine(string brandName, float width, float height, IFluidContainer waterContainer): base(brandName, width, height, waterContainer)
        {

        }

        /// <summary>
        /// Gets the current capsule in the coffee machine.
        /// </summary>
        public Capsule Capsule
        {
            get { return _capsule; }
        }

        /// <summary>
        /// Inserts a new capsule into the coffee machine.
        /// </summary>
        /// <param name="capsule">The capsule to be inserted.</param>
        /// <exception cref="NotImplementedException">Thrown when a capsule is already inserted.</exception>
        public void InsertCapsule(Capsule capsule)
        {
            if (_capsule == null)
            {
                _capsule = capsule;
            }
            else
            {
                throw new NotImplementedException("A capsule is already inserted");
            }
        }

        /// <summary>
        /// Disposes of the current capsule from the coffee machine.
        /// </summary>
        /// <returns>The disposed capsule.</returns>
        /// <exception cref="NotImplementedException">Thrown when there is no capsule to dispose of.</exception>
        public Capsule DisposeCapsule()
        {
            if (_capsule != null)
            {
                Capsule disposedCapsule = _capsule;
                _capsule = null;
                return disposedCapsule;
            }
            else
            {
                throw new NotImplementedException("There isn't a capsule in the dispenser");
            }
        }

        /// <summary>
        /// Brews coffee using the current capsule.
        /// </summary>
        /// <returns>True if the brewing process was successful, otherwise false.</returns>
        public override bool Brew()
        {
            if (!IsTurnedOn)
            {
                return false;
            }

            if (_capsule == null)
            {
                return false;
            }

            if (this.WaterContainer.CurrentLevel < WATER_FOR_CAPSULE)
            {
                return false;
            }

            _capsule.IsUsed = true;
            this.WaterContainer.UseFluid(WATER_FOR_CAPSULE);

            return true;
        }
    }

}
