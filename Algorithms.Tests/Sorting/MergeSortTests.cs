using System;
using Algorithms.Sorting;
using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests.Sorting
{
   public class MergeSortTests : BaseSortTest
   {
      private readonly List<int> _intCollection = new List<int>() { 32, 11, 857, 23, 9, 0, 333 };

      [Fact]
      public void Integer_AscendingOrderTest()
      {
         BaseAscendingTest(_intCollection, MergeSort.Sort(_intCollection));
      }

      [Fact]
      public void Integer_DescendingOrderTest()
      {
         BaseDescendingTest(_intCollection, MergeSort.Sort(_intCollection));
      }
   }
}