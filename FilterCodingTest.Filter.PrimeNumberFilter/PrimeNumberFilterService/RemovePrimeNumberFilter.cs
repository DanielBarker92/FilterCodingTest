using FilterCodingTest.Filter.Core.Extensions;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using FilterCodingTest.Filter.Interfaces;

namespace FilterCodingTest.Filter.PrimeNumberFilterService
{
    public class RemovePrimeNumberFilter : INumberFilter
    {
        /// <summary>
        ///     Removes all prime numbers from a given list of number and returns everything else
        /// </summary>
        /// <param name="numbers"> numbers to remove primes from </param>
        /// <returns> List of non-prime numbers </returns>
        public IEnumerable<int> ApplyFilter(IEnumerable<int> numbers)
            => numbers.Where(s => !s.IsPrime());
    }
}
