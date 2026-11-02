using System;
using Algorithms.Core.Sorting;

namespace Algorithms.UseCases.Sorting.Integers
{
    /// <summary>
    /// Sorts an integer list using the bubble sort algorithm.
    /// </summary>
    public class BubbleSortUseCase : IUseCase<List<int>>
    {
        private readonly SortOrder _order;
        private readonly List<int> _collection;

        public BubbleSortUseCase(List<int> collection, SortOrder order = SortOrder.ASC)
        {
            _collection = collection;
            _order = order;
        }

        public List<int> Execute()
        {
            return BubbleSort.Sort(_collection, _order);
        }
    }
}