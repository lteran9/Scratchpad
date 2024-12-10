using System;
using Algorithms.Core.Sorting;
using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests.Sorting
{
   public class InsertionSortTests : BaseSortTest
   {
      private readonly List<int> _intCollection = new List<int>() { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };
      private readonly List<char> _charCollection = new List<char>() { '4', 'B', 'R', 'T', 'X', '!' };

      [Fact]
      public void Integer_AscendingOrderTest()
      {
         BaseAscendingTest(_intCollection, InsertionSort.Sort(_intCollection));
      }

      [Fact]
      public void Integer_DescendingOrderTest()
      {
         BaseDescendingTest(_intCollection, InsertionSort.Sort(_intCollection, SortOrder.DESC));
      }

      [Fact]
      public void Character_AscendingOrderTest()
      {
         BaseAscendingTest(_charCollection, InsertionSort.Sort(_charCollection));
      }

      [Fact]
      public void Character_DescendingOrderTest()
      {
         BaseDescendingTest(_charCollection, InsertionSort.Sort(_charCollection, SortOrder.DESC));
      }
   }
}