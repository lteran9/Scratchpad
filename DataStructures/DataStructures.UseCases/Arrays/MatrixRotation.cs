using System;

namespace DataStructures.UseCases.Arrays
{
    public class MatrixRotation
    {
        private readonly int[,] _matrix;

        public MatrixRotation(int[,] matrix)
        {
            _matrix = matrix;
        }

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