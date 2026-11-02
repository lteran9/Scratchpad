using System;

namespace Algorithms.Core.Fibonacci
{
    /// <summary>
    /// Defines an operation for computing a Fibonacci number.
    /// </summary>
    public interface IFibonacci
    {
        /// <summary>
        /// Computes the Fibonacci number at the specified zero-based position.
        /// </summary>
        /// <param name="position">The zero-based position in the Fibonacci sequence.</param>
        /// <returns>The Fibonacci number at <paramref name="position"/>.</returns>
        long Compute(int position);
    }

    /// <summary>
    /// Computes Fibonacci numbers iteratively using constant extra space.
    /// </summary>
    public class Fibonacci : IFibonacci
    {
        /// <inheritdoc />
        public long Compute(int position)
        {
            if (position <= 1)
            {
                return position;
            }

            long previousValue = 0, currentValue = 1;
            // Advance the pair of consecutive Fibonacci values up to the requested position.
            for (int i = 2; i <= position; i++)
            {
                long temp = previousValue + currentValue;
                previousValue = currentValue;
                currentValue = temp;
            }

            return currentValue;
        }
    }
}
