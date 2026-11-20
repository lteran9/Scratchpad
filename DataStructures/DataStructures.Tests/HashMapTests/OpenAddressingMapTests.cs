using System;
using Xunit;
using DataStructures.Core.HashMaps;

namespace DataStructures.Tests.HashMapTests
{
    /// <summary>
    /// Tests hash map behavior using open addressing.
    /// </summary>
    public class OpenAddressingMapTests
    {
        #region Count
        [Fact]
        public void GivenEmptyHashMap_WhenSized_CountIsZero()
        {
            // Arrange
            var hashMap = new ClosedAddressingMap<int, string>();

            // Act
            var size = hashMap.Size();

            // Assert
            Assert.Equal(0, size);
        }
        #endregion

        #region Insert
        [Fact]
        public void GivenHashMap_WhenInsertValue_UpdatesCount()
        {
            // Arrange
            var hashMap = new ClosedAddressingMap<int, string>();

            // Act
            hashMap.Insert(1234, "The quick brown fox jumped over the lazy dog.");

            // Assert
            Assert.Equal(1, hashMap.Size());
        }

        [Fact]
        public void GivenHashMap_WhenInsertMultipleValues_SizeIsCorrect()
        {
            // Arrange
            var hashMap = new ClosedAddressingMap<int, string>();

            // Act
            hashMap.Insert(1234, "The quick brown fox jumped over the lazy dog.");
            hashMap.Insert(9874, "Lorem ipsum dolor sit amet, consectetur adipiscing elit.");
            hashMap.Insert(5661, ""); // Empty string

            // Assert
            Assert.Equal(3, hashMap.Size());
        }
        #endregion

        #region Delete
        [Fact]
        public void GivenHashMap_WhenDeleteAValue_ReturnsAccurateCount()
        {
            // Arrange
            var hashMap = new ClosedAddressingMap<int, string>();

            // Act
            hashMap.Insert(1234, "The quick brown fox jumped over the lazy dog.");
            hashMap.Insert(9874, "Lorem ipsum dolor sit amet, consectetur adipiscing elit.");
            hashMap.Insert(5661, ""); // Empty string
            hashMap.Delete(1234);

            // Assert
            Assert.Equal(2, hashMap.Size());
        }
        #endregion

        #region Lookup
        [Fact]
        public void GivenHashMap_WhenValueInserted_LookupReturnsValue()
        {
            // Arrange
            var hashMap = new ClosedAddressingMap<int, string>();
            hashMap.Insert(1234, "The quick brown fox jumped over the lazy dog.");
            hashMap.Insert(9874, "Lorem ipsum dolor sit amet, consectetur adipiscing elit.");
            hashMap.Insert(5661, ""); // Empty string

            // Act
            hashMap.Lookup(1234, out string lookupResult);

            // Assert
            Assert.NotNull(lookupResult);
            Assert.NotEmpty(lookupResult);
            Assert.Equal("The quick brown fox jumped over the lazy dog.", lookupResult);
        }
        #endregion

        [Fact]
        public void GivenCollidingKeys_WhenLookingUpOrMissingKey_TraversesBucket()
        {
            var hashMap = new ClosedAddressingMap<int, string>(3);
            hashMap.Insert(1, "one");
            hashMap.Insert(4, "four");
            hashMap.Insert(7, "seven");

            Assert.True(hashMap.Lookup(7, out var lookupResult));
            Assert.Equal("seven", lookupResult);
            Assert.True(hashMap.Contains(4));
            Assert.False(hashMap.Lookup(10, out var missingValue));
            Assert.Null(missingValue);
        }

        [Fact]
        public void GivenCollidingKeys_WhenUpdatingExistingAndMissingKeys_PreservesEntries()
        {
            var hashMap = new ClosedAddressingMap<int, string>(3);
            hashMap.Insert(1, "one");
            hashMap.Insert(4, "four");
            hashMap.Insert(7, "seven");

            hashMap.Update(4, "updated");
            hashMap.Update(10, "missing");

            Assert.True(hashMap.Lookup(4, out var updatedValue));
            Assert.Equal("updated", updatedValue);
            Assert.True(hashMap.Lookup(7, out var otherValue));
            Assert.Equal("seven", otherValue);
            Assert.Equal(3, hashMap.Size());
        }

        [Fact]
        public void GivenCollidingKeys_WhenDeletingHeadMiddleTailAndMissingKey_UpdatesBucket()
        {
            var hashMap = new ClosedAddressingMap<int, string>(3);
            hashMap.Insert(1, "one");
            hashMap.Insert(4, "four");
            hashMap.Insert(7, "seven");

            hashMap.Delete(4);
            Assert.False(hashMap.Contains(4));
            Assert.True(hashMap.Contains(1));
            Assert.True(hashMap.Contains(7));
            Assert.Equal(2, hashMap.Size());

            hashMap.Delete(1);
            hashMap.Delete(10);
            Assert.False(hashMap.Contains(1));
            Assert.True(hashMap.Contains(7));
            Assert.Equal(1, hashMap.Size());

            hashMap.Delete(7);
            Assert.Equal(0, hashMap.Size());
        }

        [Fact]
        public void GivenHashMap_WhenCleared_RemovesAllEntries()
        {
            var hashMap = new ClosedAddressingMap<int, string>();
            hashMap.Insert(1, "one");

            hashMap.Clear();

            Assert.Equal(0, hashMap.Size());
            Assert.False(hashMap.Lookup(1, out _));
        }
    }
}
