using System;
using Algorithms.Core.Sorting;
using Xunit;
using System.Collections.Generic;

namespace Algorithms.Tests.Sorting
{
    public class InsertionSortTests : BaseSortTest
    {
        [Theory]
        [ClassData(typeof(IntegerCollectionDataClass))]
        public void GivenIntegerCollection_WhenInsertionSortAscending_ThenSortedAscending(List<int> collection)
        {
            var useCase = new UseCases.Sorting.Integers.InsertionSortUseCase(collection);

            BaseAscendingTest(collection, useCase.Execute());
        }

        [Theory]
        [ClassData(typeof(IntegerCollectionDataClass))]
        public void GivenIntegerCollection_WhenInsertionSortDescending_ThenSortedDescending(List<int> collection)
        {
            var useCase = new UseCases.Sorting.Integers.InsertionSortUseCase(collection, SortOrder.DESC);

            BaseDescendingTest(collection, useCase.Execute());
        }

        [Theory]
        [ClassData(typeof(CharacterCollectionDataClass))]
        public void GivenCharacterCollection_WhenInsertionSortAscending_ThenSortedAscending(List<char> collection)
        {
            var useCase = new UseCases.Sorting.Characters.InsertionSortUseCase(collection);

            BaseAscendingTest(collection, useCase.Execute());
        }

        [Theory]
        [ClassData(typeof(CharacterCollectionDataClass))]
        public void GivenCharacterCollection_WhenInsertionSortDescending_ThenSortedDescending(List<char> collection)
        {
            var useCase = new UseCases.Sorting.Characters.InsertionSortUseCase(collection, SortOrder.DESC);

            BaseDescendingTest(collection, useCase.Execute());
        }
    }
}