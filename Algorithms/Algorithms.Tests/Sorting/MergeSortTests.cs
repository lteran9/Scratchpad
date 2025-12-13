using System;
using Algorithms.Core.Sorting;
using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests.Sorting
{
    public class MergeSortTests : BaseSortTest
    {
        [Theory]
        [ClassData(typeof(IntegerCollectionDataClass))]
        public void GivenIntegerCollection_WhenMergeSortAscending_ThenSortedAscending(List<int> collection)
        {
            var useCase = new UseCases.Sorting.Integers.MergeSortUseCase(collection);

            BaseAscendingTest(collection, useCase.Execute());
        }

        [Theory]
        [ClassData(typeof(IntegerCollectionDataClass))]
        public void GivenIntegerCollection_WhenMergeSortDescending_ThenSortedDescending(List<int> collection)
        {
            var useCase = new UseCases.Sorting.Integers.MergeSortUseCase(collection, SortOrder.DESC);

            BaseDescendingTest(collection, useCase.Execute());
        }

        [Theory]
        [ClassData(typeof(CharacterCollectionDataClass))]
        public void GivenCharacterCollection_WhenMergeSortAscending_ThenSortedAscending(List<char> collection)
        {
            var useCase = new UseCases.Sorting.Characters.MergeSortUseCase(collection);

            BaseAscendingTest(collection, useCase.Execute());
        }

        [Theory]
        [ClassData(typeof(CharacterCollectionDataClass))]
        public void GivenCharacterCollection_WhenMergeSortDescending_ThenSortedDescending(List<char> collection)
        {
            var useCase = new UseCases.Sorting.Characters.MergeSortUseCase(collection, SortOrder.DESC);

            BaseDescendingTest(collection, useCase.Execute());
        }
    }
}