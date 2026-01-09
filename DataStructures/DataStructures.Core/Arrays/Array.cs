using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Text;

namespace DataStructures.Core.Arrays
{
    /// <summary>
    /// An array is a data structure used to store a collection of elements of the same type in a 
    /// fixed, ordered sequence, where each element can be accessed by its index (position). Key 
    /// characteristics of an array: 
    /// - same data type (typically)
    /// - indexed
    /// - fixed size
    /// - fast access
    /// </summary>
    public readonly struct Array<T>
    {
        private readonly T[] values;

        public Array(int size)
        {
            values = new T[size];
        }

        public Array(params T[] arr)
        {
            if (arr == null)
            {
                throw new ArgumentException("Array value cannot be null!");
            }

            values = arr;
        }

        public T this[Index index]
        {
            get => values[index];
            set => values[index] = value;
        }

        public int Length
        {
            get => values?.Length ?? 0;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            for (int i = 0; i < values.Length; i++)
            {
                sb.Append($"{values[i]}, ");
            }

            return sb.ToString()
               .TrimEnd(' ')
               .TrimEnd(',');
        }
    }
}