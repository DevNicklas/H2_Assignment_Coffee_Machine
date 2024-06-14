using H2_Assignment_Coffee_Machine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assignment_Coffee_Machine.Models.CoffeeMachines
{
    internal class TeaMachine : BrewerMachine
    {
        private const float WATER_FOR_ONE_CUP_TEA = 0.237f;
        private IInfuser _infuser;

        public TeaMachine(string brandName, float width, float height, IFluidContainer waterContainer, IInfuser infuser) : base(brandName, width, height, waterContainer)
        {
            _infuser = infuser;
        }

        public IInfuser Infuser
        {
            get { return _infuser; }
        }

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
