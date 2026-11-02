using System;
using Algorithms.Core.Sorting;

namespace Algorithms.UseCases.Sorting.Strings
{
    /// <summary>
    /// Sorts a string list using the bubble sort algorithm.
    /// </summary>
    public class BubbleSortUseCase : IUseCase<List<string>>
    {
        private readonly SortOrder _order;
        private readonly List<string> _collection;

        public BubbleSortUseCase(List<string> collection, SortOrder order = SortOrder.ASC)
        {
            _collection = collection;
            _order = order;
        }

        public List<string> Execute()
        {
            return BubbleSort.Sort(_collection, _order);
        }
    }
}
