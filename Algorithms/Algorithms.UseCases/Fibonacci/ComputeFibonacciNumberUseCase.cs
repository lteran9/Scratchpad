using System;
using Algorithms.UseCases;

namespace Algorithms.Core.Fibonacci
{
    /// <summary>
    /// Computes a Fibonacci number for the requested sequence position.
    /// </summary>
    public class ComputeFibonacciNumberUseCase : IUseCase<long>
    {
        private readonly int _position;
        private readonly IFibonacci _fibonacci;

        public ComputeFibonacciNumberUseCase(int position)
        {
            _position = position;
            _fibonacci = new Fibonacci();
        }

        public long Execute()
        {
            return _fibonacci.Compute(_position);
        }

    }
}
