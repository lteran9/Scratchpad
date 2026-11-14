using System;
using System.Collections.Generic;
using DataStructures.UseCases.Arrays;
using Xunit;

namespace DataStructures.Tests.ArrayTests
{
    /// <summary>
    /// Tests merging and sorting intervals.
    /// </summary>
    public class MergeAndSortIntervalsTests
    {
        public static IEnumerable<object[]> IntervalCases()
        {
            yield return new object[]
            {
                new int[][] { new[] { 5, 8 }, new[] { 1, 3 }, new[] { 2, 6 } },
                new int[][] { new[] { 1, 8 } }
            };
            yield return new object[]
            {
                new int[][] { new[] { 1, 3 }, new[] { 2, 4 }, new[] { 1, 10 }, new[] { 1, 10 } },
                new int[][] { new[] { 1, 10 } }
            };
            yield return new object[]
            {
                new int[][] { new[] { 3, 5 }, new[] { 1, 3 }, new[] { 5, 5 } },
                new int[][] { new[] { 1, 5 } }
            };
            yield return new object[]
            {
                new int[][] { new[] { 8, int.MaxValue }, new[] { int.MinValue, -1 }, new[] { 2, 6 } },
                new int[][] { new[] { int.MinValue, -1 }, new[] { 2, 6 }, new[] { 8, int.MaxValue } }
            };
            yield return new object[] { Array.Empty<int[]>(), Array.Empty<int[]>() };
            yield return new object[]
            {
                new int[][] { new[] { 2, 2 } },
                new int[][] { new[] { 2, 2 } }
            };
        }

        [Fact]
        public void GivenNullList_WhenConstructed_ThenThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new MergeAndSortIntervals(null));
        }

        [Fact]
        public void GivenSimpleTimeInterval_WhenMergedSorted_ThenSuccess()
        {
            // Arrange
            var input = new List<int[]>() { new int[] { 1, 3 }, new int[] { 2, 6 }, new int[] { 8, 10 }, new int[] { 15, 18 } };
            var useCase = new MergeAndSortIntervals(input);

            // Act
            var result = useCase.Execute();

            // Assert
            Assert.Equal(3, result.Count);
            Assert.Equal(1, result[0][0]);
            Assert.Equal(6, result[0][1]);
            Assert.Equal(8, result[1][0]);
            Assert.Equal(10, result[1][1]);
            Assert.Equal(15, result[2][0]);
            Assert.Equal(18, result[2][1]);
        }

        [Fact]
        public void GivenIntervals_WhenMergedSorted_ThenInputIsUnchangedAndResultIsIndependent()
        {
            var disjoint = new[] { 8, 10 };
            var first = new[] { 1, 3 };
            var overlapping = new[] { 2, 6 };
            var input = new List<int[]> { disjoint, first, overlapping };

            var result = new MergeAndSortIntervals(input).Execute();

            Assert.Equal(3, input.Count);
            Assert.Same(disjoint, input[0]);
            Assert.Same(first, input[1]);
            Assert.Same(overlapping, input[2]);
            Assert.Equal(new[] { 8, 10 }, disjoint);
            Assert.Equal(new[] { 1, 3 }, first);
            Assert.Equal(new[] { 2, 6 }, overlapping);

            result[0][1] = 100;
            result[1][0] = 0;

            Assert.Equal(new[] { 1, 3 }, first);
            Assert.Equal(new[] { 2, 6 }, overlapping);
            Assert.Equal(new[] { 8, 10 }, disjoint);
        }


        [Theory]
        [MemberData(nameof(IntervalCases))]
        public void GivenIntervals_WhenMergedSorted_ThenAllRangesAreMerged(int[][] input, int[][] expected)
        {
            var result = new MergeAndSortIntervals(new List<int[]>(input)).Execute();

            Assert.Equal(expected.Length, result.Count);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], result[i]);
            }
        }

        [Theory]
        [InlineData(null)]
        [InlineData(new int[] { })]
        [InlineData(new int[] { 1 })]
        [InlineData(new int[] { 3, 1 })]
        public void GivenInvalidInterval_WhenExecuted_ThenThrowsArgumentException(int[] interval)
        {
            var useCase = new MergeAndSortIntervals(new List<int[]> { interval });

            Assert.Throws<ArgumentException>(() => useCase.Execute());
        }
    }
}