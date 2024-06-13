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
        private int _capacity;
        private Filter _filter;

        public EspressoCoffeeMachine(string brandName, float width, float height, IFluidContainer waterContainer, int capacity) : base(brandName, width, height, waterContainer)
        {
            _capacity = capacity;
        }

        public List<Bean> Inventory
        {
            get { return _inventory; }
            set { _inventory = value; }
        }

        public int Capacity
        {
            get { return _capacity; }
        }

        public Filter Filter
        {
            get { return _filter; }
            set { _filter = value; }
        }

        public void InsertBeans(List<Bean> beans)
        {
            int newBeansAmount = _inventory.Count + beans.Count;

            if(newBeansAmount > _capacity)
            {
                throw new NotImplementedException("No more space for beans");
            }

            _inventory.AddRange(beans);
        }

        public void Grind()
        {
            const int ONE_CUP_OF_BEANS = 70;
            if(_inventory.Count < ONE_CUP_OF_BEANS)
            {
                throw new NotImplementedException("There aren't enough beans, you need at least 70 for one cup");
            }

            _inventory.RemoveRange(0, ONE_CUP_OF_BEANS);
        }

        public override bool Brew()
        {
            return false;
        }

    }
}
