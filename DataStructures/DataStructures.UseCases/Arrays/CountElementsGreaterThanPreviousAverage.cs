using System;

namespace DataStructures.UseCases.Arrays
{
    public class CountElementsGreaterThanPreviousAverage : IUseCase<int>
    {
        /// <summary>
        /// Input array of integers n (0 <= n <= 1000)
        /// </summary>
        private readonly int[] _input;

        public CountElementsGreaterThanPreviousAverage(int[] input)
        {
            _input = input ?? throw new ArgumentException("Input array cannot be null.");
        }

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