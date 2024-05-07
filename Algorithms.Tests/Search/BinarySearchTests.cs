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

         Assert.False(search.HasValue(10));
      }

      [Fact]
      public void NeedleInData_Test()
      {
         // Sorted array
         var haystack = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
         // Algorithm
         var search = new BinarySearch<int>(haystack);

         Assert.True(search.HasValue(1));
         Assert.True(search.HasValue(2));
         Assert.True(search.HasValue(3));
         Assert.True(search.HasValue(4));
         Assert.True(search.HasValue(5));
         Assert.True(search.HasValue(6));
         Assert.True(search.HasValue(7));
         Assert.True(search.HasValue(8));
         Assert.True(search.HasValue(9));
      }
   }
}