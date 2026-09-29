using System;
using DataStructures.Core.Stacks;
using DataStructures.UseCases.Stacks;
using Xunit;

namespace DataStructures.Tests.StackTests
{
    public class StackSortTests
    {
        [Fact]
        public void GivenUnsortedStack_WhenSorted_ThenSmallestItemsAreOnTop()
        {
            var values = new Stack<int>();
            values.Push(3);
            values.Push(2);
            values.Push(5);
            values.Push(4);
            values.Push(1);

            var result = new SortStack<int>(values).Sort();

            Assert.Equal(1, result.Pop());
            Assert.Equal(2, result.Pop());
            Assert.Equal(3, result.Pop());
            Assert.Equal(4, result.Pop());
            Assert.Equal(5, result.Pop());
            Assert.True(result.IsEmpty());
        }

        [Fact]
        public void GivenDuplicateValues_WhenSorted_ThenAllValuesArePreserved()
        {
            var values = new Stack<int>();
            values.Push(2);
            values.Push(1);
            values.Push(2);
            values.Push(1);

            var result = new SortStack<int>(values).Sort();

            Assert.Equal(1, result.Pop());
            Assert.Equal(1, result.Pop());
            Assert.Equal(2, result.Pop());
            Assert.Equal(2, result.Pop());
            Assert.True(result.IsEmpty());
        }

        [Fact]
        public void GivenEmptyStack_WhenSorted_ThenResultIsEmpty()
        {
            var values = new Stack<int>();

            var result = new SortStack<int>(values).Sort();

            Assert.True(result.IsEmpty());
        }

        [Fact]
        public void GivenNullStack_WhenCreated_ThenThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new SortStack<int>(null));
        }
    }
}
