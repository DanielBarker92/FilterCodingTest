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

        public IEnumerable<int> ApplyFilter(IEnumerable<int> numbers)
            => numbers.Where(s => !s.IsPrime());
    }
}
