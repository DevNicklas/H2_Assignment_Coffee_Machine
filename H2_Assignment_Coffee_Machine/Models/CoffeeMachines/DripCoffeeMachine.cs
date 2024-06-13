using H2_Assignment_Coffee_Machine.Interfaces;
using H2_Assignment_Coffee_Machine.Models.CoffeeMachineParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assignment_Coffee_Machine.Models.CoffeeMachines
{
    internal class DripCoffeeMachine : CoffeeMachine, IBeanGrinder, IFilterContainer
    {
        private List<Bean> _inventory;
        private int _capacity;
        private Filter _filter;

        public DripCoffeeMachine(string brandName, float width, float height, IFluidContainer waterContainer, int capacity) : base(brandName, width, height, waterContainer)
        {
            _capacity = capacity;
        }

        public int Capacity
        {
            get { return _capacity; }
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
