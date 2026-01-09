using System;
using System.Collections.Generic;
using DataStructures.UseCases.Arrays;
using Xunit;

namespace DataStructures.Tests.ArrayTests
{
    // TODO: Still need to add more test cases and improve on algorithm
    public class MergeAndSortIntervalsTests
    {
        [Fact]
        public void GivenSimpleTimeInterval_WhenMergedSorted_ThenSuccess()
        {
            // Arrange
            var input = new List<int[]>() { new int[] { 1, 3 }, new int[] { 2, 6 }, new int[] { 8, 10 }, new int[] { 15, 18 } };
            var useCase = new MergeAndSortIntervals(input);

            // Act
            var result = useCase.Execute();

            // Assert
            Assert.True(result.Count > 0);
            Assert.Equal(1, result[0][0]);
            Assert.Equal(6, result[0][1]);
            Assert.Equal(8, result[1][0]);
            Assert.Equal(10, result[1][1]);
            Assert.Equal(15, result[2][0]);
            Assert.Equal(18, result[2][1]);
        }
    }
}