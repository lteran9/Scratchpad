using System;

namespace DataStructures.UseCases.Arrays
{
    /// <summary>
    /// Counts elements that are greater than the average of all elements before them.
    /// </summary>
    /// <remarks>
    /// The first element is not counted because it has no preceding elements. Each average is
    /// calculated using integer division, which truncates toward zero.
    /// </remarks>
    public class CountElementsGreaterThanPreviousAverage : IUseCase<int>
    {
        private readonly int[] _input;

        /// <summary>
        /// Creates a use case for counting elements above their preceding-elements average.
        /// </summary>
        /// <param name="input">The array to examine. The array is retained by reference, not copied.</param>
        /// <exception cref="ArgumentException"><paramref name="input"/> is <see langword="null"/>.</exception>
        public CountElementsGreaterThanPreviousAverage(int[] input)
        {
            _input = input ?? throw new ArgumentException("Input array cannot be null.");
        }

        /// <summary>
        /// Counts each element, except the first, that is greater than the integer average of
        /// all elements before it.
        /// </summary>
        /// <returns>The number of qualifying elements, or zero when the input is empty or has one element.</returns>
        /// <remarks>
        /// Runs in O(n) time and uses O(1) additional space, where n is the array length.
        /// The input array is not modified.
        /// </remarks>
        public int Execute()
        {
            int count = 0;
            if (_input.Length > 0)
            {
                int sumOfPrevious = 0;
                for (int i = 1; i < _input.Length; i++)
                {
                    sumOfPrevious += _input[i - 1];
                    int average = sumOfPrevious / i;

                    if (_input[i] > average)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}