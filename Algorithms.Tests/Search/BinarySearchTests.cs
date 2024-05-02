using System;
using System.Collections.Generic;
using Algorithms.Search;
using Xunit;

namespace Algorithms.Tests.Search
{

   public class BinarySearchTests
   {
      [Fact]
      public void NeedleNotInData_Test()
      {
         // Sorted array
         var haystack = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
         // Algorithm
         var search = new BinarySearch<int>(haystack);

         Assert.False(search.Find(0));
      }

      [Fact]
      public void NeedleInData_Test()
      {
         // Sorted array
         var haystack = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
         // Algorithm
         var search = new BinarySearch<int>(haystack);

         Assert.True(search.Find(1));
         Assert.True(search.Find(2));
         Assert.True(search.Find(3));
         Assert.True(search.Find(4));
         Assert.True(search.Find(5));
         Assert.True(search.Find(6));
         Assert.True(search.Find(7));
         Assert.True(search.Find(8));
         Assert.True(search.Find(9));
      }
   }
}