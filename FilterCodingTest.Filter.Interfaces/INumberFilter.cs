using System;
using System.Collections.Generic;
using System.Text;

namespace FilterCodingTest.Filter.Interfaces
{
    public interface INumberFilter
    {
        /// <summary>
        ///     Applies a filter against a given list of number and returns the list
        /// </summary>
        /// <param name="numbers"> numbers to filter on </param>
        /// <returns> Filtered List </returns>
        IEnumerable<int> ApplyFilter(IEnumerable<int> numbers);
    }
}
