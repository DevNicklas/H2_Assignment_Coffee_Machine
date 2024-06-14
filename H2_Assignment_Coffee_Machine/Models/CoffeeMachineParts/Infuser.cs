using H2_Assignment_Coffee_Machine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assignment_Coffee_Machine.Models.CoffeeMachineParts
{
    public class Infuser : IInfuser
    {
        private TeaBag _teaBag;

        public TeaBag TeaBag
        {
            get { return _teaBag; }
        }

        public void InsertTeaBag(TeaBag teaBag)
        {
            if (teaBag.IsUsed)
            {
                throw new NotImplementedException("Teabag is already used, and can't be inserted");
            }

            _teaBag = teaBag;
        }

        public TeaBag DisposeTeaBag()
        {
            if (_teaBag == null)
            {
                throw new NotImplementedException("There isn't a tea bag in the container");
            }

            TeaBag disposedTeaBag = _teaBag;
            _teaBag = null;

            return disposedTeaBag;
        }
    }
}
