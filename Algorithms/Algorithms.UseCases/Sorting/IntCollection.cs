using System;
using Algorithms.Core.Sorting;

namespace Algorithms.UseCases
{
   public class IntCollection
   {
      private readonly SortOrder _order;
      private readonly List<int> _collection;

      public List<int> BubbleSort
      {
         get
         {
            return Core.Sorting.BubbleSort.Sort(_collection, _order);
         }
      }

      public List<int> InsertionSort
      {
         get
         {
            return Core.Sorting.InsertionSort.Sort(_collection, _order);
         }
      }

      public List<int> MergeSort
      {
         get
         {
            return Core.Sorting.MergeSort.Sort(_collection, _order);
         }
      }

      public List<int> QuickSort
      {
         get
         {
            return Core.Sorting.QuickSort.Sort(_collection, _order);
         }
      }

      public List<int> SelectionSort
      {
         get
         {
            return Core.Sorting.SelectionSort.Sort(_collection, _order);
         }
      }

      public IntCollection(int[] collection, SortOrder order = SortOrder.ASC)
      {
         _order = order;
         _collection = collection.ToList();
      }

      public IntCollection(List<int> collection, SortOrder order = SortOrder.ASC)
      {
         _order = order;
         _collection = collection;
      }
   }
}