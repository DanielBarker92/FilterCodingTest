using FilterCodingTest.Core.Extensions;
using FilterNumberCodingTest.Interfaces;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace FilterNumberCodingTest.PrimeNumberFilterService
{
    public class RemovePrimeNumberFilter : INumberFilter
    {

        public IEnumerable<int> ApplyFilter(IEnumerable<int> numbers)
            => numbers.Where(s => !s.IsPrime());
    }
}
