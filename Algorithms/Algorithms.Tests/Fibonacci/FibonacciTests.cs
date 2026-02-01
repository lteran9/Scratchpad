using System;
using Xunit;
using Algorithms.Core.Fibonacci;

namespace Algorithms.Tests.Fibonacci
{
    public class FibonacciTests
    {
        [Theory]
        [InlineData(0, 0L)]
        [InlineData(1, 1L)]
        [InlineData(2, 1L)]
        [InlineData(3, 2L)]
        [InlineData(10, 55L)]
        [InlineData(50, 12586269025L)]
        [InlineData(-5, -5L)]
        public void GivenPosition_WhenComputeFibonacci_ThenReturnExpected(int position, long expected)
        {
            var useCase = new ComputeFibonacciNumberUseCase(position);

            var result = useCase.Execute();

            Assert.Equal(expected, result);
        }
    }
}
