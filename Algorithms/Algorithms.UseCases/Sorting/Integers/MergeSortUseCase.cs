using System;
using Algorithms.Core.Sorting;

namespace Algorithms.UseCases.Sorting.Integers
{
    /// <summary>
    /// Sorts an integer list using the merge sort algorithm.
    /// </summary>
    public class MergeSortUseCase : IUseCase<List<int>>
    {
        private readonly SortOrder _order;
        private readonly List<int> _collection;

        public MergeSortUseCase(List<int> collection, SortOrder order = SortOrder.ASC)
        {
            _collection = collection;
            _order = order;
        }

        public List<int> Execute()
        {
            return MergeSort.Sort(_collection, _order);
        }
    }
}