using System;

namespace DataStructures.Core.Strings
{
   interface IString
   {
      static IString Empty { get; }

      int Length { get; }
      char this[int index] { get; }

      char[] ToCharArray();
   }
}