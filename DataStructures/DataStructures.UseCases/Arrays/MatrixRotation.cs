using System;

namespace DataStructures.UseCases.Arrays
{
    /// <summary>
    /// Rotates a non-empty square matrix 90 degrees clockwise.
    /// </summary>
    /// <remarks>
    /// The input matrix is retained by reference, not copied. Rotation creates a separate result
    /// and does not modify the input matrix.
    /// </remarks>
    public class MatrixRotation
    {
        private readonly int[,] _matrix;

        /// <summary>
        /// Creates a use case for rotating the specified matrix.
        /// </summary>
        /// <param name="matrix">The matrix to rotate.</param>
        /// <exception cref="ArgumentNullException"><paramref name="matrix"/> is <see langword="null"/>.</exception>
        public MatrixRotation(int[,] matrix)
        {
            ArgumentNullException.ThrowIfNull(matrix);
            _matrix = matrix;
        }

        /// <summary>
        /// Rotates the input matrix 90 degrees clockwise.
        /// </summary>
        /// <returns>A new matrix containing the rotated values.</returns>
        /// <remarks>Runs in O(n²) time and uses O(n²) additional space for an n-by-n matrix.</remarks>
        /// <exception cref="ArgumentException">The input matrix is empty or is not square.</exception>
        public int[,] Rotate()
        {
            // Make sure we have a NxN matrix
            if (_matrix.GetLength(0) > 0 && _matrix.GetLength(0) == _matrix.GetLength(1))
            {
                var size = _matrix.GetLength(0);
                var newMatrix = new int[size, size];
                var upperIndex = size - 1;

                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        var currValue = _matrix[i, j];
                        newMatrix[i + (j - i), upperIndex - i] = currValue;
                    }
                }

                return newMatrix;
            }

            throw new ArgumentException("Invalid matrix provided to class.");
        }
    }
}