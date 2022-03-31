using System;
using Algorithms.Sorting;
using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests.Sorting
{
   public class MergeSortTests
   {
      [Fact]
      public void BaseTest()
      {
         var collection = new List<int>() { 32, 11, 857, 23, 9, 0, 333 };
         var sortedList = MergeSort.Sort(collection);

         Assert.Equal(0, sortedList[0]);
         Assert.Equal(9, sortedList[1]);
         Assert.Equal(11, sortedList[2]);
         Assert.Equal(23, sortedList[3]);
         Assert.Equal(32, sortedList[4]);
         Assert.Equal(333, sortedList[5]);
         Assert.Equal(857, sortedList[6]);
      }
   }
}