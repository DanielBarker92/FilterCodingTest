using System;
using System.Collections.Generic;
using System.Linq;
using FilterCodingTest.Sort.Interfaces;

namespace FilterCodingTest.Sort.BubbleSort
{
    public class BubbleSort : ISort
    {
        /// <summary>
        ///     Applies a bubble sort on the passed in list of integers
        /// </summary>
        /// <param name="listToSort"> List of integers to sort </param>
        /// <returns> Sorted list of integers (ascending) </returns>
        public IEnumerable<int> OrderBy(IEnumerable<int> listToSort)
        {
            var orderedList = listToSort.ToArray();

            // Temp discard for swapping positions in array
            var _ = 0;

            // Loops over each number in the list
            for (int iterations = 0; iterations < orderedList.Length; iterations++)
            {
                // Loop over comparing each pair and swap if right-hand side is larger than left-hand side
                for (int comparisonPointer = 0; comparisonPointer < orderedList.Length - 1; comparisonPointer++)
                {
                    if (orderedList[comparisonPointer] > orderedList[comparisonPointer + 1])
                    {
                        _ = orderedList[comparisonPointer + 1];
                        orderedList[comparisonPointer + 1] = orderedList[comparisonPointer];
                        orderedList[comparisonPointer] = _;
                    }
                }
            }

            return orderedList;
        }
    }
}
