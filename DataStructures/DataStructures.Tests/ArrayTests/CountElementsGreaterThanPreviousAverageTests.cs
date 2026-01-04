using System;
using DataStructures.UseCases.Arrays;
using Xunit;

namespace DataStructures.Tests.ArrayTests
{
    public class CountElementsGreaterThanPreviousAverageTests
    {
        [Theory]
        [InlineData(new int[] { 100, 200, 150, 300, 50 })]
        public void GivenArray_WhenCountingAverages_ThenCorrectResult(int[] input)
        {
            // Arrange
            var useCase = new CountElementsGreaterThanPreviousAverage(input);

            // Act
            var result = useCase.Execute();

            // Assert
            Assert.Equal(2, result);
        }

        [Theory]
        [InlineData(new int[] { })]
        public void GivenEmptyArray_WhenCountingAverage_ReturnsZero(int[] input)
        {
            // Arrange
            var useCase = new CountElementsGreaterThanPreviousAverage(input);

            // Act
            var result = useCase.Execute();

            // Assert
            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData(new int[] { 1000, 900, 800, 700, 600, 500, 400, 300, 200, 100, 0 })]
        public void GivenDescendingArray_WhenCountingAverage_ReturnsZero(int[] input)
        {
            // Arrange
            var useCase = new CountElementsGreaterThanPreviousAverage(input);

            // Act
            var result = useCase.Execute();

            // Assert
            Assert.Equal(0, result);
        }
    }
}