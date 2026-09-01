using System;
using DataStructures.UseCases.Arrays;
using Xunit;

namespace DataStructures.Tests.ArrayTests
{
    public class MatrixRotationTests
    {
        public static object[][] InvalidMatrix =>
            [
                [
                    new int[,] { { 0, 1 } }
                ]
            ];

        public static object[][] SmallestMatrix =>
            [
                [
                    new int[,] { { 0, 1 }, { 2, 3 } }
                ]
            ];

        public static object[][] RegularMatrix =>
            [
                [
                    new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }
                ]
            ];

        [Theory]
        [MemberData(nameof(InvalidMatrix))]
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
        [MemberData(nameof(SmallestMatrix))]
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
        [MemberData(nameof(RegularMatrix))]
        public void GivenRegularMatrix_WhenRotated_CorrectResult(int[,] matrix)
        {
            // Arrange
            var matrixRotation = new MatrixRotation(matrix);

            // Act 
            var result = matrixRotation.Rotate();

            // Assert
            Assert.Equal(7, result.GetValue(0, 0));
            Assert.Equal(4, result.GetValue(0, 1));
            Assert.Equal(1, result.GetValue(0, 2));
            Assert.Equal(8, result.GetValue(1, 0));
            Assert.Equal(5, result.GetValue(1, 1));
            Assert.Equal(2, result.GetValue(1, 2));
            Assert.Equal(9, result.GetValue(2, 0));
            Assert.Equal(6, result.GetValue(2, 1));
            Assert.Equal(3, result.GetValue(2, 2));
        }
    }
}