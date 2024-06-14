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
    /// Represents an espresso coffee machine that grinds beans and brews coffee.
    /// </summary>
    public class EspressoCoffeeMachine : BrewerMachine, IBeanGrinder
    {
        private List<Bean> _inventory;
        private int _capacity;

        private IFilterContainer _filterContainer;

        private const byte ONE_CUP_OF_BEANS = 80;
        private const float WATER_FOR_BEANS = 1.36f;

        /// <summary>
        /// Initializes a new instance of the <see cref="EspressoCoffeeMachine"/> class with the specified details.
        /// </summary>
        /// <param name="brandName">The brand name of the coffee machine.</param>
        /// <param name="width">The width of the coffee machine.</param>
        /// <param name="height">The height of the coffee machine.</param>
        /// <param name="waterContainer">The water container used by the coffee machine.</param>
        /// <param name="capacity">The maximum number of beans the machine can hold.</param>
        /// <param name="filterContainer">The filter container used by the coffee machine</param>
        public EspressoCoffeeMachine(string brandName, float width, float height, IFluidContainer waterContainer, IFilterContainer filterContainer, int capacity): base(brandName, width, height, waterContainer)
        {
            _capacity = capacity;
            _inventory = new List<Bean>();
            _filterContainer = filterContainer;
        }

        /// <summary>
        /// Gets the inventory of beans in the coffee machine.
        /// </summary>
        public List<Bean> Inventory
        {
            get { return _inventory; }
        }

        /// <summary>
        /// Gets the maximum capacity of beans the coffee machine can hold.
        /// </summary>
        public int Capacity
        {
            get { return _capacity; }
        }

        /// <summary>
        /// Get the filter container of the coffee machine.
        /// </summary>
        public IFilterContainer FilterContainer
        {
            get { return _filterContainer; }
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
                throw new NotImplementedException($"There aren't enough beans, you need {ONE_CUP_OF_BEANS} for one cup");
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

            if (_inventory.Count < ONE_CUP_OF_BEANS)
            {
                return false;
            }

            if (this.WaterContainer.CurrentLevel < WATER_FOR_BEANS)
            {
                return false;
            }

            if(_filterContainer.Filter == null)
            {
                return false;
            }

            Grind();
            this.WaterContainer.UseFluid(WATER_FOR_BEANS);

            return true;
        }
    }

}
