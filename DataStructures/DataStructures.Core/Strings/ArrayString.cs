using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures.Core.Strings
{
   /// <summary>
   /// Be aware this class hides the .NET framework String implementation. Only reference this object through it's namespace.
   /// </summary>
   public class ArrayString : IString
   {
      public static ArrayString Empty = new ArrayString();

      public int Length { get; private set; }

      public char this[int index]
      {
         get
         {
            return new char();
         }
      }

      public ArrayString() { }

      public ArrayString(string value)
      {
         Length = value.Length;
      }

      public char[] ToCharArray()
      {
         return new char[0];
      }
   }
}