using System;
using Algorithms.Core.Sorting;
using System.Collections.Generic;
using Xunit;

namespace Algorithms.Core.Tests.Sorting
{
   public class MergeSortTests : BaseSortTest
   {
      private readonly List<int> _intCollection = new List<int>() { 32, 11, 857, 23, 9, 0, 333 };
      private readonly List<char> _charCollection = new List<char>() { 'Q', 'P', '<', '.', '1', 'T', '+' };

      [Fact]
      public void Integer_AscendingOrderTest()
      {
         BaseAscendingTest(_intCollection, MergeSort.Sort(_intCollection));
      }

      [Fact]
      public void Integer_DescendingOrderTest()
      {
         BaseDescendingTest(_intCollection, MergeSort.Sort(_intCollection, SortOrder.DESC));
      }

      [Fact]
      public void Character_AscendingOrderTest()
      {
         BaseAscendingTest(_charCollection, MergeSort.Sort(_charCollection));
      }

      [Fact]
      public void Character_DescendingOrderTest()
      {
         BaseDescendingTest(_charCollection, MergeSort.Sort(_charCollection, SortOrder.DESC));
      }
   }
}