using System;
using System.Collections.Generic;
using Xunit;
using Algorithms.Core.Sorting;

namespace Algorithms.Tests.Sorting
{
    public class BubbleSortTests : BaseSortTest
    {
        [Theory]
        [ClassData(typeof(IntegerCollectionDataClass))]
        public void GivenIntegerCollection_WhenBubbleSortAscending_ThenSortedAscending(List<int> collection)
        {
            var useCase = new UseCases.Sorting.Integers.BubbleSortUseCase(collection);

            BaseAscendingTest(collection, useCase.Execute());
        }

        [Theory]
        [ClassData(typeof(IntegerCollectionDataClass))]
        public void GivenIntegerCollection_WhenBubbleSortDescending_ThenSortedDescending(List<int> collection)
        {
            var useCase = new UseCases.Sorting.Integers.BubbleSortUseCase(collection, SortOrder.DESC);

            BaseDescendingTest(collection, useCase.Execute());
        }

        [Theory]
        [ClassData(typeof(CharacterCollectionDataClass))]
        public void GivenCharacterCollection_WhenBubbleSortAscending_ThenSortedAscending(List<char> collection)
        {
            var useCase = new UseCases.Sorting.Characters.BubbleSortUseCase(collection);

            BaseAscendingTest(collection, useCase.Execute());
        }

        [Theory]
        [ClassData(typeof(CharacterCollectionDataClass))]
        public void GivenCharacterCollection_WhenBubbleSortDescending_ThenSortedDescending(
            List<char> collection)
        {
            var useCase = new UseCases.Sorting.Characters.BubbleSortUseCase(collection, SortOrder.DESC);

            BaseDescendingTest(collection, useCase.Execute());
        }
    }
}