using H2_Assignment_Coffee_Machine.Interfaces;
using H2_Assignment_Coffee_Machine.Models.CoffeeMachineParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assignment_Coffee_Machine.Models.CoffeeMachines
{
    public class CapsuleCoffeeMachine : CoffeeMachine, ICapsuleDispenser
    {
        private Capsule _capsule;

        public CapsuleCoffeeMachine(string brandName, float width, float height, IFluidContainer waterContainer) : base(brandName, width, height, waterContainer)
        {

        }

        public Capsule Capsule
        {
            get { return _capsule; }
        }

        public void InsertCapsule(Capsule capsule)
        {
            if(_capsule == null)
            {
                _capsule = capsule;
            }
            else
            {
                Console.WriteLine("A capsule is already inserted");
            }
        }

        public Capsule DisposeCapsule()
        {
            if( _capsule != null )
            {
                Capsule disposedCapsule = _capsule;
                _capsule = null;
                return disposedCapsule;
            }
            else
            {
                Console.WriteLine("There aren't a capsule in the dispenser");
                return null;
            }
        }

        public override bool Brew()
        {
            if(!IsTurnedOn)
            {
                return false;
            }

            if(_capsule == null)
            {
                return false;
            }

            const float WATER_FOR_CAPSULE = 0.03f;

            if(this.WaterContainer.CurrentLevel < WATER_FOR_CAPSULE)
            {
                return false;
            }

            _capsule.IsUsed = true;
            this.WaterContainer.UseFluid(WATER_FOR_CAPSULE);
            return true;
        }
    }
}
