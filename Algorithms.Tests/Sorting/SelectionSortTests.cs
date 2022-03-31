using System;
using Algorithms.Sorting;
using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests.Sorting
{
   public class SelectionSortTests
   {
      [Fact]
      public void BaseTest()
      {
         var collection = new List<int>() { 14, 22, 23, 11, 45 };
         var sortedCollection = SelectionSort.Sort(collection);

         Assert.Equal(11, sortedCollection[0]);
         Assert.Equal(14, sortedCollection[1]);
         Assert.Equal(22, sortedCollection[2]);
         Assert.Equal(23, sortedCollection[3]);
         Assert.Equal(45, sortedCollection[4]);
      }
   }
}