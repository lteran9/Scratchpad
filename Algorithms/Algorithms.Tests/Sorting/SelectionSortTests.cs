using System;
using Algorithms.Core.Sorting;
using System.Collections.Generic;
using Xunit;
using Algorithms.UseCases.Sorting;

namespace Algorithms.Tests.Sorting
{
    public class SelectionSortTests : BaseSortTest
    {
        [Theory]
        [ClassData(typeof(IntegerCollectionDataClass))]
        public void GivenIntegerCollection_WhenSelectionSortAscending_ThenSortedAscending(List<int> collection)
        {
            var useCase = new UseCases.Sorting.Integers.SelectionSortUseCase(collection);

            BaseAscendingTest(collection, useCase.Execute());
        }

        [Theory]
        [ClassData(typeof(IntegerCollectionDataClass))]
        public void GivenIntegerCollection_WhenSelectionSortDescending_ThenSortedDescending(List<int> collection)
        {
            var useCase = new UseCases.Sorting.Integers.SelectionSortUseCase(collection, SortOrder.DESC);

            BaseDescendingTest(collection, useCase.Execute());
        }

        [Theory]
        [ClassData(typeof(CharacterCollectionDataClass))]
        public void GivenCharacterCollection_WhenSelectionSortAscending_ThenSortedAscending(List<char> collection)
        {
            var useCase = new UseCases.Sorting.Characters.SelectionSortUseCase(collection);

            BaseAscendingTest(collection, useCase.Execute());
        }

        [Theory]
        [ClassData(typeof(CharacterCollectionDataClass))]
        public void GivenCharacterCollection_WhenSelectionSortDescending_ThenSortedDescending(List<char> collection)
        {
            var useCase = new UseCases.Sorting.Characters.SelectionSortUseCase(collection, SortOrder.DESC);

            BaseDescendingTest(collection, useCase.Execute());
        }
    }
}