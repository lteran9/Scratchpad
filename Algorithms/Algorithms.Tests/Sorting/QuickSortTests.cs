using System;
using System.Collections.Generic;
using Xunit;
using Algorithms.Core.Sorting;

namespace Algorithms.Tests.Sorting
{
    public class QuickSortTests : BaseSortTest
    {
        [Theory]
        [ClassData(typeof(IntegerCollectionDataClass))]
        public void GivenIntegerCollection_WhenQuickSortAscending_ThenSortedAscending(List<int> collection)
        {
            var useCase = new UseCases.Sorting.Integers.QuickSortUseCase(collection);

            BaseAscendingTest(collection, useCase.Execute());
        }

        [Theory]
        [ClassData(typeof(IntegerCollectionDataClass))]
        public void GivenIntegerCollection_WhenQuickSortDescending_ThenSortedDescending(List<int> collection)
        {
            var useCase = new UseCases.Sorting.Integers.QuickSortUseCase(collection, SortOrder.DESC);

            BaseDescendingTest(collection, useCase.Execute());
        }

        [Theory]
        [ClassData(typeof(CharacterCollectionDataClass))]
        public void GivenCharacterCollection_WhenQuickSortAscending_ThenSortedAscending(List<char> collection)
        {
            var useCase = new UseCases.Sorting.Characters.QuickSortUseCase(collection);

            BaseAscendingTest(collection, useCase.Execute());
        }

        [Theory]
        [ClassData(typeof(CharacterCollectionDataClass))]
        public void GivenCharacterCollection_WhenQuickSortDescending_ThenSortedDescending(List<char> collection)
        {
            var useCase = new UseCases.Sorting.Characters.QuickSortUseCase(collection, SortOrder.DESC);

            BaseDescendingTest(collection, useCase.Execute());
        }
    }
}