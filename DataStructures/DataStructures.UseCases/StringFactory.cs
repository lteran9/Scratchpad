using System;
using DataStructures.Core.Strings;

namespace DataStructures.UseCases
{
   public class StringFactory
   {
      #region Node String Implementation 

      public IString CreateNodeString(string value)
      {
         return new NodeString(value);
      }

      #endregion

      #region Array String Implementation

      public IString CreateArrayString(string value)
      {
         return new ArrayString(value);
      }

      #endregion 
   }
}