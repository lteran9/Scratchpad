using System;
using System.Collections.Generic;
using Xunit;
using Algorithms.UseCases;

namespace Algorithms.Tests.Sorting
{
   public class QuickSortTests : BaseSortTest
   {
      private readonly List<int> _intCollection = new List<int>() { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6, 100 };
      private readonly List<char> _charCollection = new List<char>() { 'F', 'C', 'D', 'A', 'G', '0', 'N' };

      [Fact]
      public void Integer_AscendingOrderTest()
      {
         var integerSort = new IntCollection(_intCollection);

         BaseAscendingTest(_intCollection, integerSort.QuickSort);
      }

      [Fact]
      public void Integer_DescendingOrderTest()
      {
         var integerSort = new IntCollection(_intCollection, Core.Sorting.SortOrder.DESC);

         BaseDescendingTest(_intCollection, integerSort.QuickSort);
      }
   }
}