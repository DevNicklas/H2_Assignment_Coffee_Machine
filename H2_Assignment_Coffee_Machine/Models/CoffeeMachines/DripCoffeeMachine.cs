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
    /// Represents a drip coffee machine that grinds beans and brews coffee.
    /// </summary>
    public class DripCoffeeMachine : CoffeeMachine, IBeanGrinder, IFilterContainer
    {
        private List<Bean> _inventory;
        private int _capacity;
        private Filter _filter;
        private const int ONE_CUP_OF_BEANS = 70;
        private const float WATER_FOR_BEANS = 1.26f;

        /// <summary>
        /// Initializes a new instance of the <see cref="DripCoffeeMachine"/> class with the specified details.
        /// </summary>
        /// <param name="brandName">The brand name of the coffee machine.</param>
        /// <param name="width">The width of the coffee machine.</param>
        /// <param name="height">The height of the coffee machine.</param>
        /// <param name="waterContainer">The water container used by the coffee machine.</param>
        /// <param name="capacity">The maximum number of beans the machine can hold.</param>
        public DripCoffeeMachine(string brandName, float width, float height, WaterContainer waterContainer, int capacity): base(brandName, width, height, waterContainer)
        {
            _capacity = capacity;
            _inventory = new List<Bean>();
        }

        /// <summary>
        /// Gets the maximum capacity of beans the coffee machine can hold.
        /// </summary>
        public int Capacity
        {
            get { return _capacity; }
        }

        /// <summary>
        /// Gets the inventory of beans in the coffee machine.
        /// </summary>
        public List<Bean> Inventory
        {
            get { return _inventory; }
        }

        /// <summary>
        /// Gets or sets the filter in the coffee machine.
        /// </summary>
        public Filter Filter
        {
            get { return _filter; }
            set { _filter = value; }
        }

        /// <summary>
        /// Inserts beans into the coffee machine.
        /// </summary>
        /// <param name="beans">The beans to be inserted.</param>
        /// <exception cref="NotImplementedException">Thrown when there is no more space for beans.</exception>
        public void InsertBeans(List<Bean> beans)
        {
            int newBeansAmount = _inventory.Count + beans.Count;

            if (newBeansAmount > _capacity)
            {
                throw new NotImplementedException("No more space for beans");
            }

            _inventory.AddRange(beans);
        }

        /// <summary>
        /// Grinds the beans in the coffee machine.
        /// </summary>
        /// <exception cref="NotImplementedException">Thrown when there are not enough beans to grind.</exception>
        public void Grind()
        {
            if (_inventory.Count < ONE_CUP_OF_BEANS)
            {
                throw new NotImplementedException("There aren't enough beans, you need at least 70 for one cup");
            }

            _inventory.RemoveRange(0, ONE_CUP_OF_BEANS);
        }

        /// <summary>
        /// Brews coffee using some of the current beans.
        /// </summary>
        /// <returns>True if the brewing process was successful, otherwise false.</returns>
        public override bool Brew()
        {
            if (!IsTurnedOn)
            {
                return false;
            }

            if (_inventory.Count <= ONE_CUP_OF_BEANS)
            {
                return false;
            }

            if (this.WaterContainer.CurrentLevel < WATER_FOR_BEANS)
            {
                return false;
            }

            Grind();
            this.WaterContainer.UseFluid(WATER_FOR_BEANS);

            return true;
        }
    }

}
