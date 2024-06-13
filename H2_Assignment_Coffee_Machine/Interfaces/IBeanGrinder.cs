using H2_Assignment_Coffee_Machine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assignment_Coffee_Machine.Interfaces
{
    internal interface IBeanGrinder
    {
        List<Bean> Inventory { get; }
        int Capacity { get; }

        void InsertBeans(List<Bean> beans);

        void Grind();
    }
}
