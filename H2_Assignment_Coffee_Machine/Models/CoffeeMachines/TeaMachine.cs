using H2_Assignment_Coffee_Machine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assignment_Coffee_Machine.Models.CoffeeMachines
{
    /// <summary>
    /// Represents a tea machine that brews tea using an infuser and a fluid container.
    /// </summary>
    public class TeaMachine : BrewerMachine
    {
        private const float WATER_FOR_ONE_CUP_TEA = 0.237f;
        private IInfuser _infuser;

        /// <summary>
        /// Initializes a new instance of the <see cref="TeaMachine"/> class with the specified details.
        /// </summary>
        /// <param name="brandName">The brand name of the tea machine.</param>
        /// <param name="width">The width of the tea machine.</param>
        /// <param name="height">The height of the tea machine.</param>
        /// <param name="waterContainer">The water container used by the tea machine.</param>
        /// <param name="infuser">The infuser used by the tea machine.</param>
        public TeaMachine(string brandName, float width, float height, IFluidContainer waterContainer, IInfuser infuser)
            : base(brandName, width, height, waterContainer)
        {
            _infuser = infuser;
        }

        /// <summary>
        /// Gets the infuser used by the tea machine.
        /// </summary>
        public IInfuser Infuser
        {
            get { return _infuser; }
        }

        /// <summary>
        /// Brews tea using the infuser and the water container.
        /// </summary>
        /// <returns><c>true</c> if the brewing is successful; otherwise, <c>false</c>.</returns>
        public override bool Brew()
        {
            if (!IsTurnedOn)
            {
                return false;
            }

            if (_infuser.TeaBag == null)
            {
                return false;
            }

            if (this.WaterContainer.CurrentLevel < WATER_FOR_ONE_CUP_TEA)
            {
                return false;
            }

            _infuser.TeaBag.IsUsed = true;
            this.WaterContainer.UseFluid(WATER_FOR_ONE_CUP_TEA);

            return true;
        }
    }
}
