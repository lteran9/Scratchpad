using System;
using Algorithms.Core.Sorting;

namespace Algorithms.UseCases.Sorting.Integers
{
    public class QuickSortUseCase : IUseCase<List<int>>
    {
        private readonly SortOrder _order;
        private readonly List<int> _collection;

        public QuickSortUseCase(List<int> collection, SortOrder order = SortOrder.ASC)
        {
            _collection = collection;
            _order = order;
        }

        public List<int> Execute()
        {
            return QuickSort.Sort(_collection, _order);
        }
    }
}