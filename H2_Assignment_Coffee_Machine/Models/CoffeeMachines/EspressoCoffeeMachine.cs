using H2_Assignment_Coffee_Machine.Interfaces;
using H2_Assignment_Coffee_Machine.Models.CoffeeMachineParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assignment_Coffee_Machine.Models.CoffeeMachines
{
    public class EspressoCoffeeMachine : CoffeeMachine, IBeanGrinder, IFilterContainer
    {
        private List<Bean> _inventory;
        private Filter _filter;

        public EspressoCoffeeMachine(string brandName, float width, float height, IFluidContainer waterContainer) : base(brandName, width, height, waterContainer)
        {

        }

        public List<Bean> Inventory
        {
            get { return _inventory; }
            set { _inventory = value; }
        }

        public Filter Filter
        {
            get { return _filter; }
            set { _filter = value; }
        }

        public void InsertBeans(List<Bean> beans)
        {

        }

        public void Grind()
        {

        }

        public override bool Brew()
        {
            return false;
        }

    }
}
