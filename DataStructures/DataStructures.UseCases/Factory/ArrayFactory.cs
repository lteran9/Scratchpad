using System;

namespace DataStructures.UseCases.Factory
{
   public class ArrayFactory
   {
      public static Core.Arrays.Array<T> CreateArray<T>(int size)
      {
         return new Core.Arrays.Array<T>(size);
      }

      public static Core.Arrays.Array<T> CreateArray<T>(T[] array)
      {
         return new Core.Arrays.Array<T>(array);
      }
   }
}