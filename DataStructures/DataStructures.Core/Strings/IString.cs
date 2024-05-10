using System;

namespace DataStructures.Core.Strings
{
   public interface IString : IEquatable<IString>
   {
      static IString Empty { get; }

      int Length { get; }
      char this[int index] { get; }

      char[] ToCharArray();
   }
}