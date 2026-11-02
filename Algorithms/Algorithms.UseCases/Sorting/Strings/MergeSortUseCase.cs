using System;
using Algorithms.Core.Sorting;

namespace Algorithms.UseCases.Sorting.Strings
{
    /// <summary>
    /// Sorts a string list using the merge sort algorithm.
    /// </summary>
    public class MergeSortUseCase : IUseCase<List<string>>
    {
        private readonly SortOrder _order;
        private readonly List<string> _collection;

        public MergeSortUseCase(List<string> collection, SortOrder order = SortOrder.ASC)
        {
            _collection = collection;
            _order = order;
        }

        public List<string> Execute()
        {
            return MergeSort.Sort(_collection, _order);
        }
    }
}
