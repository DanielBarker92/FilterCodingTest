using System;
using System.Collections.Generic;
using System.Text;

namespace FilterCodingTest.Filter.Core.Extensions
{
    public static class IntExtensions
    {
        public static bool IsPrime(this int number)
        {
            if (number <= 1)
                return false;

            var middle = Math.Floor((double)number / 2);

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
