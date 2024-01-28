using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Algorithms.Tests.Sorting
{
   public abstract class BaseSortTest
   {
      protected void BaseAscendingTest<T>(IEnumerable<T> original, IEnumerable<T> sorted) where T : IComparable
      {
         // Sort original using Linq
         original = original.OrderBy(x => x);

         Assert.True(original.Count() == sorted.Count());
         for (int i = 0; i < original.Count(); i++)
         {
            Assert.Equal(original.ElementAt(i), sorted.ElementAt(i));
         }
      }

      protected void BaseDescendingTest<T>(IEnumerable<T> original, IEnumerable<T> sorted) where T : IComparable
      {
         // Sort original using Linq
         original = original.OrderByDescending(x => x);

         Assert.True(original.Count() == sorted.Count());
         for (int i = 0; i < original.Count(); i++)
         {
            Assert.Equal(original.ElementAt(i), sorted.ElementAt(i));
         }
      }
   }
}