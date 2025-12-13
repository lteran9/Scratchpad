using System;
using System.Collections.Generic;

namespace Algorithms.Core.Sorting
{
    public static class QuickSort
    {
        private static SortOrder sortOrder = SortOrder.ASC;

        public static List<T> Sort<T>(List<T> collection, SortOrder order = SortOrder.ASC) where T : IComparable<T>
        {
            sortOrder = order;

            if (collection.Count > 0)
            {
                return Sort(collection, 0, collection.Count - 1);
            }
            else
            {
                return collection;
            }
        }

        private static List<T> Sort<T>(List<T> collection, int leftIndex, int rightIndex) where T : IComparable<T>
        {
            var i = leftIndex;
            var j = rightIndex;
            T pivot = collection[(leftIndex + rightIndex) / 2];

            while (i <= j)
            {
                while (
                   (collection[i].CompareTo(pivot) < 0 && sortOrder == SortOrder.ASC)
                   ||
                   (collection[i].CompareTo(pivot) > 0 && sortOrder == SortOrder.DESC)
                )
                {
                    i++;
                }

                while (
                   (collection[j].CompareTo(pivot) > 0 && sortOrder == SortOrder.ASC)
                   ||
                   (collection[j].CompareTo(pivot) < 0 && sortOrder == SortOrder.DESC)
                )
                {
                    j--;
                }

                if (i <= j)
                {
                    T temp = collection[i];
                    collection[i] = collection[j];
                    collection[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
            {
                Sort(collection, leftIndex, j);
            }

            if (i < rightIndex)
            {
                Sort(collection, i, rightIndex);
            }

            return collection;
        }
    }
}