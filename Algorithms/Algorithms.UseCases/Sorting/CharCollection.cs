using System;
using Algorithms.Core.Sorting;

namespace Algorithms.UseCases.Sorting
{
   public class CharCollection
   {
      private readonly SortOrder _order;
      private readonly List<char> _collection;

      public List<char> BubbleSort
      {
         get
         {
            return Core.Sorting.BubbleSort.Sort(_collection, _order);
         }
      }

      public List<char> InsertionSort
      {
         get
         {
            return Core.Sorting.InsertionSort.Sort(_collection, _order);
         }
      }

      public List<char> MergeSort
      {
         get
         {
            return Core.Sorting.MergeSort.Sort(_collection, _order);
         }
      }

      public List<char> QuickSort
      {
         get
         {
            return Core.Sorting.QuickSort.Sort(_collection, _order);
         }
      }

      public List<char> SelectionSort
      {
         get
         {
            return Core.Sorting.SelectionSort.Sort(_collection, _order);
         }
      }

      public CharCollection(char[] collection, SortOrder order = SortOrder.ASC)
      {
         _order = order;
         _collection = collection.ToList();
      }

      public CharCollection(List<char> collection, SortOrder order = SortOrder.ASC)
      {
         _order = order;
         _collection = collection;
      }
   }
}