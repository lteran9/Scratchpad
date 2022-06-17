using DataStructures.Strings;
using System;
using Xunit;

namespace DataStructures.Tests.StringTests
{
   /// Common Interview Questions for Strings
   public class InterviewQuestions
   {
      #region Implement an algorithm to determine if a string has all unique characters.
      [Fact]
      public void IsUnique_Easy()
      {
         string nonUnique = "aabbcc";
         string nonUnique2 = "1abc1";
         string unique = "abcdefgh";
         string unique2 = "123456";

         Assert.True(DataStructures.Strings.String.HasAllUniqueCharacters_Linq(unique));
         Assert.True(DataStructures.Strings.String.HasAllUniqueCharacters_Linq(unique2));
         Assert.False(DataStructures.Strings.String.HasAllUniqueCharacters_Linq(nonUnique));
         Assert.False(DataStructures.Strings.String.HasAllUniqueCharacters_Linq(nonUnique2));
      }

      [Fact]
      public void IsUnique_Medium()
      {
         string nonUnique = "aabbcc";
         string nonUnique2 = "1abc1";
         string unique = "abcdefgh";
         string unique2 = "123456";

         Assert.True(DataStructures.Strings.String.HasAllUniqueCharacters(unique));
         Assert.True(DataStructures.Strings.String.HasAllUniqueCharacters(unique2));
         Assert.False(DataStructures.Strings.String.HasAllUniqueCharacters(nonUnique));
         Assert.False(DataStructures.Strings.String.HasAllUniqueCharacters(nonUnique2));
      }
      #endregion
   }
}