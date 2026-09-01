using System;
using System.Collections.Generic;

namespace Algorithms.Core.Search
{
    public class BinarySearch<T>
    {
        /// <summary>
        /// Sorted array of data values;
        /// </summary>
        private T[] Data;
        private Comparer<T> Comparer = Comparer<T>.Default;

        public BinarySearch(T[] data)
        {
            Data = data;
        }

        public bool HasValue(T value)
        {
            return TryFind(value, out _);
        }

        /// <summary>
        /// Attempts to find a value in the sorted data array.
        /// </summary>
        /// <param name="needle"></param>
        /// <param name="value">The matching value when found; otherwise the default value for <typeparamref name="T"/>.</param>
        /// <returns><see langword="true"/> when the value is found; otherwise <see langword="false"/>.</returns>
        public bool TryFind(T needle, out T? value)
        {
            int low = 0;
            int high = Data.Length - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                int comparison = Comparer.Compare(needle, Data[mid]);

                if (comparison < 0)
                {
                    high = mid - 1;
                }
                else if (comparison > 0)
                {
                    low = mid + 1;
                }
                else
                {
                    value = Data[mid];
                    return true;
                }
            }

            value = default;
            return false;
        }

        /// <summary>
        /// Returns the matching value, or the default value when no match exists.
        /// Use <see cref="TryFind"/> when absence must be distinguished from a default-valued match.
        /// </summary>
        public T? Find(T needle)
        {
            TryFind(needle, out T? value);
            return value;
        }
    }
}
