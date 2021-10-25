using System;
using Xunit;
using System.Collections.Generic;
using FluentAssertions;
using FilterCodingTest.Filter.Core.Extensions;
using FilterCodingTest.Sort.BubbleSort;

namespace FilterCodingTest.UnitTests
{
    public class BubbleSortTests
    {
        [Fact]
        public void OrderByDescending_EmptyList_ShouldBeEmpty()
        {
            //Arrange
            var bubbleSort = new BubbleSort();
            var listToSort = new List<int>();

            //Act
            var actualResults = bubbleSort.OrderBy(listToSort);

            //Assert
            actualResults.Should().BeEmpty();
        }

        [Fact]
        public void OrderByDescending_NonEmptyList_ShouldOrderLowestToHighest()
        {
            //Arrange
            var bubbleSort = new BubbleSort();
            var listToSort = new[] { 10, 4, 55, 12, 1, 78, 44 };

            //Act
            var actualResults = bubbleSort.OrderBy(listToSort);

            //Assert
            actualResults.Should().BeEquivalentTo(new[] { 1, 4, 10, 12, 44, 55, 78 }, options => options.WithStrictOrdering());
        }
    }
}
