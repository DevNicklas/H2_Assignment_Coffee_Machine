using H2_Assignment_Coffee_Machine.Interfaces;
using H2_Assignment_Coffee_Machine.Models.CoffeeMachineParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assignment_Coffee_Machine.Models.CoffeeMachines
{
    public abstract class CoffeeMachine
    {
        private string _brandName;
        private float _width;
        private float _height;
        private bool _isTurnedOn = false;
        private IFluidContainer _waterContainer;

        protected CoffeeMachine(string brandName, float width, float height, IFluidContainer waterContainer) 
        { 
            _brandName = brandName;
            _width = width;
            _height = height;
            _waterContainer = waterContainer;
        }

        public string BrandName
        {
            get { return _brandName; }
        }

        public float Width
        {
            get { return _width; }
        }

        public float Height
        {
            get { return _height; }
        }

        public bool IsTurnedOn
        {
            get { return _isTurnedOn; }
        }

        public IFluidContainer WaterContainer
        {
            get { return _waterContainer; }
        }

        public abstract bool Brew();
    }
}
