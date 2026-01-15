using System;
using Xunit;
using DataStructures.Core.HashMaps;

namespace DataStructures.Tests.HashMapTests
{
    public class OpenAddressingMapTests
    {
        #region Count
        [Fact]
        public void GivenEmptyHashMap_WhenSized_CountIsZero()
        {
            // Arrange
            var hashMap = new OpenAddressingMap<int, string>();

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
            var hashMap = new OpenAddressingMap<int, string>();

            // Act
            hashMap.Insert(1234, "The quick brown fox jumped over the lazy dog.");

            // Assert
            Assert.Equal(1, hashMap.Size());
        }

        [Fact]
        public void GivenHashMap_WhenInsertMultipleValues_SizeIsCorrect()
        {
            // Arrange
            var hashMap = new OpenAddressingMap<int, string>();

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
            var hashMap = new OpenAddressingMap<int, string>();

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
            var hashMap = new OpenAddressingMap<int, string>();
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
    }
}
