using System;
using Algorithms.Core.Sorting;

namespace Algorithms.UseCases.Sorting.Strings
{
    public class SelectionSortUseCase : IUseCase<List<string>>
    {
        private readonly SortOrder _order;
        private readonly List<string> _collection;

        public SelectionSortUseCase(List<string> collection, SortOrder order = SortOrder.ASC)
        {
            _collection = collection;
            _order = order;
        }

        public List<string> Execute()
        {
            return SelectionSort.Sort(_collection, _order);
        }
    }
}
