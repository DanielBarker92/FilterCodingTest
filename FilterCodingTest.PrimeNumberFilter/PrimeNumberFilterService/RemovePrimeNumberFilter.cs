using FilterNumberCodingTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FilterNumberCodingTest.PrimeNumberFilterService
{
    public class RemovePrimeNumberFilter : INumberFilter
    {

        public IEnumerable<int> ApplyFilter(IEnumerable<int> numbers)
        {
            var nonPrimeNumbers = new List<int>();

            foreach(var number in numbers)
            {
                if (number == 0)
                    continue;

                if (number == 1)
                {
                    nonPrimeNumbers.Add(number);
                    continue;
                }

                var middle = Math.Floor((double)number / 2);

                var isNotPrime = false;
                for (int i = 2; i <= middle; i++)
                {
                    if (isNotPrime)
                        continue;

                    if (number % i == 0)
                    {
                        nonPrimeNumbers.Add(number);
                        isNotPrime = true;
                    }
                }
            }

            return nonPrimeNumbers;
        }
    }
}
