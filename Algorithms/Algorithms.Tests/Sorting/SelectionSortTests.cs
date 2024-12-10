using System;
using Algorithms.Core.Sorting;
using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests.Sorting
{
   public class SelectionSortTests : BaseSortTest
   {
      private readonly List<int> _intCollection = new List<int>() { 14, 22, 23, 11, 45, 91, 2 };

      [Fact]
      public void Integer_AscendingOrderTest()
      {
         BaseAscendingTest(_intCollection, SelectionSort.Sort(_intCollection));
      }

      [Fact]
      public void Integer_DescendingOrderTest()
      {
         BaseDescendingTest(_intCollection, SelectionSort.Sort(_intCollection, SortOrder.DESC));
      }
   }
}