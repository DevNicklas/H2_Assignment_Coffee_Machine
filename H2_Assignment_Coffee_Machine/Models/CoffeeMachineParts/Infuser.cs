using H2_Assignment_Coffee_Machine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assignment_Coffee_Machine.Models.CoffeeMachineParts
{
    /// <summary>
    /// Represents an infuser that can contain a tea bag.
    /// </summary>
    public class Infuser : IInfuser
    {
        private TeaBag _teaBag;

        /// <summary>
        /// Gets the currently inserted tea bag.
        /// </summary>
        public TeaBag TeaBag
        {
            get { return _teaBag; }
        }

        /// <summary>
        /// Inserts a tea bag into the infuser.
        /// </summary>
        /// <param name="teaBag">The tea bag to insert.</param>
        /// <exception cref="NotImplementedException">Thrown if the tea bag is already used.</exception>
        public void InsertTeaBag(TeaBag teaBag)
        {
            if (teaBag.IsUsed)
            {
                throw new NotImplementedException("Tea bag is already used and cannot be inserted");
            }

            _teaBag = teaBag;
        }

        /// <summary>
        /// Disposes of the currently inserted tea bag and returns it.
        /// </summary>
        /// <returns>The disposed tea bag.</returns>
        /// <exception cref="NotImplementedException">Thrown if there is no tea bag in the infuser.</exception>
        public TeaBag DisposeTeaBag()
        {
            if (_teaBag == null)
            {
                throw new NotImplementedException("There is no tea bag in the infuser");
            }

            TeaBag disposedTeaBag = _teaBag;
            _teaBag = null;

            return disposedTeaBag;
        }
    }

}
