using DataStructures.Core.Strings;
using System;
using Xunit;

namespace DataStructures.Core.Tests.StringTests
{
   /// Common Interview Questions for Strings
   public class InterviewQuestions
   {
      #region Implement an algorithm to determine if a string has all unique characters.

      [Fact]
      public void Basic_UniqueTests()
      {
         string empty = string.Empty;
         string nullString = null;

         #region Easy
         // An empty string is unique by definition
         Assert.True(DataStructures.Core.Strings.String.HasAllUniqueCharacters(empty));
         // A null string cannot be unique because it does not have or represent a value
         Assert.False(DataStructures.Core.Strings.String.HasAllUniqueCharacters(nullString));
         #endregion

         #region Medium
         // An empty string is unique by definition
         Assert.True(DataStructures.Core.Strings.String.HasAllUniqueCharacters_ASCII(empty));
         // A null string cannot be unique because it does not have or represent a value
         Assert.False(DataStructures.Core.Strings.String.HasAllUniqueCharacters_ASCII(nullString));
         #endregion

         #region Hard
         // An empty string is unique by definition
         Assert.True(DataStructures.Core.Strings.String.HasAllUniqueCharacters_Linq(empty));
         // A null string cannot be unique because it does not have or represent a value
         Assert.False(DataStructures.Core.Strings.String.HasAllUniqueCharacters_Linq(nullString));
         #endregion
      }

      [Fact]
      public void IsUnique_Easy()
      {
         string nonUnique = "aabbcc";
         string nonUnique2 = "1abc1";
         string unique = "abcdefgh";
         string unique2 = "123456";

         Assert.True(DataStructures.Core.Strings.String.HasAllUniqueCharacters(unique));
         Assert.True(DataStructures.Core.Strings.String.HasAllUniqueCharacters(unique2));
         Assert.False(DataStructures.Core.Strings.String.HasAllUniqueCharacters(nonUnique));
         Assert.False(DataStructures.Core.Strings.String.HasAllUniqueCharacters(nonUnique2));
      }

      [Fact]
      public void IsUnique_Medium()
      {
         string nonUnique = "aabbcc";
         string nonUnique2 = "1abc1";
         string unique = "abcdefgh";
         string unique2 = "123456";

         Assert.True(DataStructures.Core.Strings.String.HasAllUniqueCharacters_ASCII(unique));
         Assert.True(DataStructures.Core.Strings.String.HasAllUniqueCharacters_ASCII(unique2));
         Assert.False(DataStructures.Core.Strings.String.HasAllUniqueCharacters_ASCII(nonUnique));
         Assert.False(DataStructures.Core.Strings.String.HasAllUniqueCharacters_ASCII(nonUnique2));
      }

      [Fact]
      public void IsUnique_Hard()
      {
         string nonUnique = "aabbcc";
         string nonUnique2 = "1abc1";
         string unique = "abcdefgh";
         string unique2 = "123456";

         Assert.True(DataStructures.Core.Strings.String.HasAllUniqueCharacters_Linq(unique));
         Assert.True(DataStructures.Core.Strings.String.HasAllUniqueCharacters_Linq(unique2));
         Assert.False(DataStructures.Core.Strings.String.HasAllUniqueCharacters_Linq(nonUnique));
         Assert.False(DataStructures.Core.Strings.String.HasAllUniqueCharacters_Linq(nonUnique2));
      }

      #endregion

      #region Given two strings, write a method to decide if one is a permutation of the other. 

      [Fact]
      public void Basic_PermutationTests()
      {
         string empty = string.Empty;
         string nullString = null;

         #region Easy
         // Empty set can be a permutation of empty set
         Assert.True(DataStructures.Core.Strings.String.CheckPermutation(empty, empty));
         // Null set cannot have permutations
         Assert.False(DataStructures.Core.Strings.String.CheckPermutation(nullString, nullString));
         Assert.False(DataStructures.Core.Strings.String.CheckPermutation(empty, nullString));
         Assert.False(DataStructures.Core.Strings.String.CheckPermutation(nullString, empty));
         #endregion 

         #region Medium
         // Empty set can be a permutation of empty set
         Assert.True(DataStructures.Core.Strings.String.CheckPermutation_HashSet(empty, empty));
         // Null set cannot have permutations
         Assert.False(DataStructures.Core.Strings.String.CheckPermutation_HashSet(nullString, nullString));
         Assert.False(DataStructures.Core.Strings.String.CheckPermutation_HashSet(empty, nullString));
         Assert.False(DataStructures.Core.Strings.String.CheckPermutation_HashSet(nullString, empty));
         #endregion
      }

      [Fact]
      public void IsPermutation_Easy()
      {
         string original = "abc";
         string permutationOne = "cab";
         string permutationTwo = "bca";
         string almost = "bc";
         string irrelevant = "dfg";

         Assert.False(DataStructures.Core.Strings.String.CheckPermutation(original, almost));
         Assert.True(DataStructures.Core.Strings.String.CheckPermutation(original, permutationOne));
         Assert.True(DataStructures.Core.Strings.String.CheckPermutation(original, permutationTwo));
         Assert.False(DataStructures.Core.Strings.String.CheckPermutation(original, irrelevant));
      }

      [Fact]
      public void IsPermutation_Medium()
      {
         string original = "abcd";
         string permutationOne = "ddcbbaa";
         string permutationTwo = "bdc";
         string permutationThree = "dacb";

         // The sets we are working with do not require unique elements, therefore duplicates can be found within
         Assert.False(DataStructures.Core.Strings.String.CheckPermutation_HashSet(original, permutationOne));
         // permutationTwo does not have character 'a' therefore it is not considered a permutation of the original string
         Assert.False(DataStructures.Core.Strings.String.CheckPermutation_HashSet(original, permutationTwo));

         Assert.True(DataStructures.Core.Strings.String.CheckPermutation_HashSet(original, permutationThree));
         Assert.True(DataStructures.Core.Strings.String.CheckPermutation_HashSet(permutationThree, original));
      }

      [Fact]
      public void IsPermutation_Hard()
      {
         string original = "xyz";
         string permutationOne = "zyx";
         string permutationTwo = "yzx";
         string notPermutation = "xxyyzz";

         Assert.True(DataStructures.Core.Strings.String.CheckPermutation_Linq(original, permutationOne));
         Assert.True(DataStructures.Core.Strings.String.CheckPermutation_Linq(original, permutationTwo));

         Assert.False(DataStructures.Core.Strings.String.CheckPermutation_Linq(original, string.Empty));
         Assert.False(DataStructures.Core.Strings.String.CheckPermutation_Linq(original, notPermutation));
      }

      #endregion

      #region 

      #endregion
   }
}