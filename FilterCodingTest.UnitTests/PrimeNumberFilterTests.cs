using System;
using Xunit;
using FilterNumberCodingTest.PrimeNumberFilterService;
using System.Collections.Generic;
using FluentAssertions;

namespace FilterCodingTest.UnitTests
{
    public class RemovePrimeNumberFilterTests
    {
        [Fact]
        public void ApplyFilter_InputContains0_ShouldRemove0()
        {
            //Arrange
            var removePrimeNumberFilter = new RemovePrimeNumberFilter();
            var inputList = new[] { 6, 12, 0, 16 };

            //Act
            var actualResults = removePrimeNumberFilter.ApplyFilter(inputList);

            //Assert
            actualResults.Should().Equal(new[] { 6, 12, 16 });
        }

        [Fact]
        public void ApplyFilter_InputContains1_ShouldRemove1()
        {
            //Arrange
            var removePrimeNumberFilter = new RemovePrimeNumberFilter();
            var inputList = new[] { 1 }; 

            //Act
            var actualResults = removePrimeNumberFilter.ApplyFilter(inputList);

            //Assert
            actualResults.Should().Equal(new[] { 1 });
        }

        [Fact]
        public void ApplyFilter_InputContainsNegatives_ShouldRemoveNegatives()
        {
            //Arrange
            var removePrimeNumberFilter = new RemovePrimeNumberFilter();
            var inputList = new[] { -16, -3, 4, 12 };

            //Act
            var actualResults = removePrimeNumberFilter.ApplyFilter(inputList);

            //Assert
            actualResults.Should().Equal(new[] { 4, 12 });
        }

        [Fact]
        public void ApplyFilter_InputEmpty_ShouldReturnEmpty()
        {
            //Arrange
            var removePrimeNumberFilter = new RemovePrimeNumberFilter();
            var inputList = new List<int>();

            //Act
            var actualResults = removePrimeNumberFilter.ApplyFilter(inputList);

            //Assert
            actualResults.Should().BeEmpty();
        }

        [Fact]
        public void ApplyFilter_ContainsMultiplePrimeNumbers_ShouldReturnNonPrime()
        {
            //Arrange
            var removePrimeNumberFilter = new RemovePrimeNumberFilter();
            var inputList = new[] { 43, 57, 3, 7, 60, 99, 96, 97 };

            //Act
            var actualResults = removePrimeNumberFilter.ApplyFilter(inputList);

            //Assert
            actualResults.Should().Equal(new[] { 57, 60, 99, 96 });
        }
    }
}
