using System;
using System.Runtime.InteropServices;

namespace DataStructures.Core.Arrays
{
   public readonly struct Array<T>
   {
      private readonly T[] values;

      public Array(int size)
      {
         values = new T[size];
      }

      public Array(T[] arr)
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
         get => values.Length;
      }
   }
}