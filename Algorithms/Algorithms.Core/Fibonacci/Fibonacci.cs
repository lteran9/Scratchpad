using System;

namespace Algorithms.Core.Fibonacci
{
    public interface IFibonacci
    {
        long Compute(int position);
    }

    public class Fibonacci : IFibonacci
    {
        public long Compute(int position)
        {
            if (position <= 1)
            {
                return position;
            }

            long previousValue = 0, currentValue = 1;
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
