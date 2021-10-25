using System;
using System.Collections.Generic;
using System.Text;

namespace FilterCodingTest.Filter.Core.Extensions
{
    public static class IntExtensions
    {
        /// <summary>
        ///     Returns true/false for whether the given number is a prime number or not
        /// </summary>
        /// <param name="number"> Number to compare against </param>
        /// <returns> True if Prime, False if not </returns>
        public static bool IsPrime(this int number)
        {
            if (number <= 1)
                return false;

            // Find floored half of the number. We don't need to iterate over every number
            var middle = Math.Floor((double)number / 2);

            // Check each number between 2 and the middle number to see if any number left over when divided.
            for (int i = 2; i <= middle; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
