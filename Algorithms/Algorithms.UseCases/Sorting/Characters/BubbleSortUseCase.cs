using System;
using Algorithms.Core.Sorting;

namespace Algorithms.UseCases.Sorting.Characters
{
    /// <summary>
    /// Sorts a character list using the bubble sort algorithm.
    /// </summary>
    public class BubbleSortUseCase : IUseCase<List<char>>
    {
        private readonly SortOrder _order;
        private readonly List<char> _collection;

        public BubbleSortUseCase(List<char> collection, SortOrder order = SortOrder.ASC)
        {
            _collection = collection;
            _order = order;
        }

        public List<char> Execute()
        {
            return BubbleSort.Sort(_collection, _order);
        }
    }
}