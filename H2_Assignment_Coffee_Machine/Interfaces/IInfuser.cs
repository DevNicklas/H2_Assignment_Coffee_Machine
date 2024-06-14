using H2_Assignment_Coffee_Machine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assignment_Coffee_Machine.Interfaces
{
    public interface IInfuser
    {
        TeaBag TeaBag { get; }

        void InsertTeaBag(TeaBag teaBag);

        TeaBag DisposeTeaBag();
    }
}
