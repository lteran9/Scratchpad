using System;
using Algorithms.Sorting;
using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests.Sorting
{
   public class InsertionSortTests
   {
      [Fact]
      public void BaseTest()
      {
         var collection = new List<int>() { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };
         var sortedCollection = InsertionSort.Sort(collection);

         Assert.Equal(-4, sortedCollection[0]);
         Assert.Equal(0, sortedCollection[1]);
         Assert.Equal(2, sortedCollection[2]);
         Assert.Equal(5, sortedCollection[3]);
         Assert.Equal(6, sortedCollection[4]);
         Assert.Equal(11, sortedCollection[5]);
         Assert.Equal(18, sortedCollection[6]);
         Assert.Equal(22, sortedCollection[7]);
         Assert.Equal(51, sortedCollection[8]);
         Assert.Equal(67, sortedCollection[9]);
      }
   }
}