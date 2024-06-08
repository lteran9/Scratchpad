using System;
using Xunit;
using DataStructures.Core.Strings;
using DataStructures.UseCases.Strings;
using DataStructures.UseCases.Factory;

namespace DataStructures.Core.Tests.StringTests
{
   /// Common Interview Questions for Strings
   public class InterviewQuestions
   {
      private readonly StringFactory stringFactory = new StringFactory();

      #region Implement an algorithm to determine if a string has all unique characters.

      [Fact]
      public void Basic_UniqueTests_NodeString()
      {
         IString empty = NodeString.Empty;
         IString nullString = null;

         #region Easy
         // An empty string is unique by definition
         Assert.True(StringManipulation.HasAllUniqueCharacters(empty));
         // A null string cannot be unique because it does not have or represent a value
         Assert.False(StringManipulation.HasAllUniqueCharacters(nullString));
         #endregion

         #region Medium
         // An empty string is unique by definition
         Assert.True(StringManipulation.HasAllUniqueCharacters_ASCII(empty));
         // A null string cannot be unique because it does not have or represent a value
         Assert.False(StringManipulation.HasAllUniqueCharacters_ASCII(nullString));
         #endregion

         #region Hard
         // An empty string is unique by definition
         Assert.True(StringManipulation.HasAllUniqueCharacters_Linq(empty));
         // A null string cannot be unique because it does not have or represent a value
         Assert.False(StringManipulation.HasAllUniqueCharacters_Linq(nullString));
         #endregion
      }

      [Fact]
      public void IsUnique_Easy_NodeString()
      {
         IString nonUnique = stringFactory.CreateNodeString("aáabbcc");
         IString nonUnique2 = stringFactory.CreateNodeString("1abc1");
         IString unique = stringFactory.CreateNodeString("ábcdéfgh");
         IString unique2 = stringFactory.CreateNodeString("123456");

         Assert.True(StringManipulation.HasAllUniqueCharacters(unique));
         Assert.True(StringManipulation.HasAllUniqueCharacters(unique2));
         Assert.False(StringManipulation.HasAllUniqueCharacters(nonUnique));
         Assert.False(StringManipulation.HasAllUniqueCharacters(nonUnique2));
      }

      [Fact]
      public void IsUnique_Medium_NodeString()
      {
         IString nonUnique = stringFactory.CreateNodeString("aabbcc");
         IString nonUnique2 = stringFactory.CreateNodeString("1abc1");
         IString unique = stringFactory.CreateNodeString("abcdefgh");
         IString unique2 = stringFactory.CreateNodeString("123456");

         Assert.True(StringManipulation.HasAllUniqueCharacters_ASCII(unique));
         Assert.True(StringManipulation.HasAllUniqueCharacters_ASCII(unique2));
         Assert.False(StringManipulation.HasAllUniqueCharacters_ASCII(nonUnique));
         Assert.False(StringManipulation.HasAllUniqueCharacters_ASCII(nonUnique2));
      }

      [Fact]
      public void IsUnique_Hard_NodeString()
      {
         IString nonUnique = stringFactory.CreateNodeString("aabbcc");
         IString nonUnique2 = stringFactory.CreateNodeString("1abc1");
         IString unique = stringFactory.CreateNodeString("abcdefgh");
         IString unique2 = stringFactory.CreateNodeString("123456");

         Assert.False(StringManipulation.HasAllUniqueCharacters_Linq(nonUnique));
         Assert.False(StringManipulation.HasAllUniqueCharacters_Linq(nonUnique2));
         Assert.True(StringManipulation.HasAllUniqueCharacters_Linq(unique));
         Assert.True(StringManipulation.HasAllUniqueCharacters_Linq(unique2));
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
         Assert.True(StringManipulation.CheckPermutation(empty, empty));
         // Null set cannot have permutations
         Assert.False(StringManipulation.CheckPermutation(nullString, nullString));
         Assert.False(StringManipulation.CheckPermutation(empty, nullString));
         Assert.False(StringManipulation.CheckPermutation(nullString, empty));
         #endregion 

         #region Medium
         // Empty set can be a permutation of empty set
         Assert.True(StringManipulation.CheckPermutation_HashSet(empty, empty));
         // Null set cannot have permutations
         Assert.False(StringManipulation.CheckPermutation_HashSet(nullString, nullString));
         Assert.False(StringManipulation.CheckPermutation_HashSet(empty, nullString));
         Assert.False(StringManipulation.CheckPermutation_HashSet(nullString, empty));
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

         Assert.False(StringManipulation.CheckPermutation(original, almost));
         Assert.True(StringManipulation.CheckPermutation(original, permutationOne));
         Assert.True(StringManipulation.CheckPermutation(original, permutationTwo));
         Assert.False(StringManipulation.CheckPermutation(original, irrelevant));
      }

      [Fact]
      public void IsPermutation_Medium()
      {
         string original = "abcd";
         string permutationOne = "ddcbbaa";
         string permutationTwo = "bdc";
         string permutationThree = "dacb";

         // The sets we are working with do not require unique elements, therefore duplicates can be found within
         Assert.False(StringManipulation.CheckPermutation_HashSet(original, permutationOne));
         // permutationTwo does not have character 'a' therefore it is not considered a permutation of the original string
         Assert.False(StringManipulation.CheckPermutation_HashSet(original, permutationTwo));

         Assert.True(StringManipulation.CheckPermutation_HashSet(original, permutationThree));
         Assert.True(StringManipulation.CheckPermutation_HashSet(permutationThree, original));
      }

      [Fact]
      public void IsPermutation_Hard()
      {
         string original = "xyz";
         string permutationOne = "zyx";
         string permutationTwo = "yzx";
         string notPermutation = "xxyyzz";

         Assert.True(StringManipulation.CheckPermutation_Linq(original, permutationOne));
         Assert.True(StringManipulation.CheckPermutation_Linq(original, permutationTwo));

         Assert.False(StringManipulation.CheckPermutation_Linq(original, string.Empty));
         Assert.False(StringManipulation.CheckPermutation_Linq(original, notPermutation));
      }

      #endregion

      #region 

      #endregion
   }
}