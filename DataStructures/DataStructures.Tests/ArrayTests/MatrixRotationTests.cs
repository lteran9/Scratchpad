using System;
using DataStructures.UseCases.Arrays;
using Xunit;

namespace DataStructures.Tests.ArrayTests
{
    public class MatrixRotationTests
    {
        public static object[][] InvalidNxYMatrix =>
            [
                [
                    // This matrix is 2 x 4, not N x N, because its row and column counts differ.
                    new int[,] { { 0, 1, 2, 4 }, { 4, 5, 6, 7 } }
                ]
            ];

        public static object[][] SmallestNxNMatrix =>
            [
                [
                    // This 2 x 2 matrix is the smallest possible N x N matrix for **rotation**.
                    new int[,] { { 0, 1 }, { 2, 3 } }
                ]
            ];

        public static object[][] RegularNxNMatrix =>
            [
                [
                    // This 4 x 4 matrix covers all possible edge cases for rotation operations.
                    new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } }
                ]
            ];

        public static object[][] OddMatrixWithNegativeAndDuplicateValues =>
            [
                [
                    new int[,] { { -1, 2, 2 }, { 3, 0, 4 }, { 5, 6, -7 } }
                ]
            ];

        public static object[][] MatrixForIndependenceCheck =>
            [
                [
                    new int[,] { { 1, 2 }, { 3, 4 } }
                ]
            ];

        [Fact]
        public void GivenEmptyMatrix_WhenRotated_ArgumentExceptionRaised()
        {
            // Arrange
            var matrixRotation = new MatrixRotation(new int[0, 0]);

            // Act
            var expression = () => matrixRotation.Rotate();

            // Assert
            Assert.Throws<ArgumentException>(expression);
        }

        [Fact]
        public void GivenNullMatrix_WhenCreated_ArgumentNullExceptionRaised()
        {
            // Arrange 
            int[,] nullMatrix = null!;

            // Act
            var expression = () => new MatrixRotation(nullMatrix);

            // Assert
            Assert.Throws<ArgumentNullException>(expression);
        }

        [Fact]
        public void GivenOneByOneMatrix_WhenRotated_CorrectResult()
        {
            // Arrange
            var matrixRotation = new MatrixRotation(new int[,] { { 42 } });

            // Act
            var result = matrixRotation.Rotate();

            // Assert
            Assert.Equal(42, result.GetValue(0, 0));
        }

        [Theory]
        [MemberData(nameof(InvalidNxYMatrix))]
        public void GivenInvalidMatrix_WhenRotated_ArgumentExceptionRaised(int[,] matrix)
        {
            // Arrange
            var matrixRotation = new MatrixRotation(matrix);

            // Act
            var expression = () => matrixRotation.Rotate();

            // Assert
            Assert.Throws<ArgumentException>(expression);
        }

        [Theory]
        [MemberData(nameof(SmallestNxNMatrix))]
        public void GivenSmallestMatrix_WhenRotated_CorrectResult(int[,] matrix)
        {
            // Arrange
            var matrixRotation = new MatrixRotation(matrix);

            // Act
            var result = matrixRotation.Rotate();

            // Assert
            Assert.Equal(2, result.GetValue(0, 0));
            Assert.Equal(0, result.GetValue(0, 1));
            Assert.Equal(3, result.GetValue(1, 0));
            Assert.Equal(1, result.GetValue(1, 1));
        }

        [Theory]
        [MemberData(nameof(OddMatrixWithNegativeAndDuplicateValues))]
        public void GivenOddMatrixWithNegativeAndDuplicateValues_WhenRotated_CorrectResult(int[,] matrix)
        {
            // Arrange
            var matrixRotation = new MatrixRotation(matrix);

            // Act
            var result = matrixRotation.Rotate();

            // Assert
            Assert.Equal(5, result.GetValue(0, 0));
            Assert.Equal(3, result.GetValue(0, 1));
            Assert.Equal(-1, result.GetValue(0, 2));
            Assert.Equal(6, result.GetValue(1, 0));
            Assert.Equal(0, result.GetValue(1, 1));
            Assert.Equal(2, result.GetValue(1, 2));
            Assert.Equal(-7, result.GetValue(2, 0));
            Assert.Equal(4, result.GetValue(2, 1));
            Assert.Equal(2, result.GetValue(2, 2));
        }

        [Theory]
        [MemberData(nameof(MatrixForIndependenceCheck))]
        public void GivenMatrix_WhenRotated_SourceIsUnchangedAndResultIsIndependent(int[,] matrix)
        {
            // Arrange
            var matrixRotation = new MatrixRotation(matrix);

            // Act
            var result = matrixRotation.Rotate();
            result[0, 0] = 99;

            // Assert
            Assert.NotSame(matrix, result);
            Assert.Equal(1, matrix.GetValue(0, 0));
            Assert.Equal(2, matrix.GetValue(0, 1));
            Assert.Equal(3, matrix.GetValue(1, 0));
            Assert.Equal(4, matrix.GetValue(1, 1));
        }

        [Theory]
        [MemberData(nameof(RegularNxNMatrix))]
        public void GivenRegularMatrix_WhenRotated_CorrectResult(int[,] matrix)
        {
            // Arrange
            var matrixRotation = new MatrixRotation(matrix);

            // Act 
            var result = matrixRotation.Rotate();

            // Assert
            Assert.Equal(13, result.GetValue(0, 0));
            Assert.Equal(9, result.GetValue(0, 1));
            Assert.Equal(5, result.GetValue(0, 2));
            Assert.Equal(1, result.GetValue(0, 3));
            Assert.Equal(14, result.GetValue(1, 0));
            Assert.Equal(10, result.GetValue(1, 1));
            Assert.Equal(6, result.GetValue(1, 2));
            Assert.Equal(2, result.GetValue(1, 3));
            Assert.Equal(15, result.GetValue(2, 0));
            Assert.Equal(11, result.GetValue(2, 1));
            Assert.Equal(7, result.GetValue(2, 2));
            Assert.Equal(3, result.GetValue(2, 3));
            Assert.Equal(16, result.GetValue(3, 0));
            Assert.Equal(12, result.GetValue(3, 1));
            Assert.Equal(8, result.GetValue(3, 2));
            Assert.Equal(4, result.GetValue(3, 3));
        }
    }
}