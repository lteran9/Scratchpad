using System;

namespace DataStructures.Core.Strings
{
   /// <summary>
   /// Custom implementation of a string data type as a character array.
   /// </summary>
   public class ArrayString : IString
   {
      public static IString Empty = new ArrayString();

      public int Length { get; private set; }

      public char this[int index]
      {
         get
         {
            return new char();
         }
      }

      private int defaultSize = 100;
      private char[] stringArr;

      public ArrayString()
      {
         // Allocate enough space for a string of 100 characters when size unknown
         stringArr = new char[defaultSize];
      }

      public ArrayString(string value)
      {
         // Create the space for the array
         stringArr = new char[value.Length];

         // Explicitly assigning internal data structure
         for (int i = 0; i < value.Length; i++)
         {
            stringArr[i] = value[i];
            Length++;
         }
      }

      /// <summary>
      /// Returns the character array representation of this IString.
      /// </summary>
      /// <returns></returns>
      public char[] ToCharArray()
      {
         return stringArr;
      }

      /// <summary>
      /// Determines if this IString is equivalent to other IString.
      /// </summary>
      /// <param name="other"></param>
      /// <returns></returns>
      public bool Equals(IString other)
      {
         return false;
      }
   }
}