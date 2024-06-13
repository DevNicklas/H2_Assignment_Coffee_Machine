using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assignment_Coffee_Machine.Interfaces
{
    public interface IFluidContainer
    {
        float Capacity { get; }
        float CurrentLevel { get; }

        void AddFluid(float litres);

        void UseFluid(float litres);
    }
}
