using System;
using System.Collections.Generic;
using System.Text;

namespace FilterCodingTest.Sort.Interfaces
{
    public interface ISort
    {
        /// <summary>
        ///     Applies a sort on the passed in list of integers
        /// </summary>
        /// <param name="listToSort"> List of integers to sort </param>
        /// <returns> Sorted list of integers (ascending) </returns>
        public IEnumerable<int> OrderBy(IEnumerable<int> listToSort);
    }
}
