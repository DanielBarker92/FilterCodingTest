using System;
using Xunit;
using System.Collections.Generic;
using FluentAssertions;
using FilterCodingTest.Filter.Core.Extensions;

namespace FilterCodingTest.UnitTests
{
    public class RemovePrimeNumberFilterTests
    {
        [Fact]
        public void IsPrime_Input0_ShouldBeFalse()
        {
            //Arrange

            //Act
            var actualResults = 0.IsPrime();

            //Assert
            actualResults.Should().BeFalse();
        }

        [Fact]
        public void IsPrime_Input1_ShouldBeFalse()
        {
            //Arrange

            //Act
            var actualResults = 1.IsPrime();

            //Assert
            actualResults.Should().BeFalse();
        }

        [Fact]
        public void IsPrime_InputNegative_ShouldBeFalse()
        {
            //Arrange

            //Act
            var actualResults = (-34).IsPrime();

            //Assert
            actualResults.Should().BeFalse();
        }

        [Fact]
        public void IsPrime_InputPrime_ShouldBeTrue()
        {
            //Arrange

            //Act
            var actualResults = 5.IsPrime();

            //Assert
            actualResults.Should().BeTrue();
        }

        [Fact]
        public void IsPrime_InputNotPrime_ShouldBeFalse()
        {
            //Arrange

            //Act
            var actualResults = 4.IsPrime();

            //Assert
            actualResults.Should().BeFalse();
        }
    }
}
