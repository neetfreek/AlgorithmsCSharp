using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsLibrary
{
    public static class HelperSort
    {
        // Convert matrix row to vector, zero-based row index
        public static int[] MatrixRowToVector(int[,] matrix, int row)
        {
            // Set vector length to number of columns
            int[] vector = new int[matrix.GetLength(1)];

            // Iterate columns
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                vector[col] = matrix[row, col];
            }
            return vector;
        }

        public static void OverWriteMatrixRowWithVector(int[,] matrix, int[] vector, int row)
        {
            for (int col = 0; col < vector.Length; col++)
            {
                matrix[row, col] = vector[col];
            }
        }

        public static int[] MatrixToVector(int[,] matrix)
        {
            // Declare, initialise vector with default (0) values
            int[] vector = new int[matrix.Length];

            int counter = 0;

            // Iterate rows
            for (int row = 0; row < matrix.GetLength(0); row++)
            {   // Iterate columns (elements)
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    // Assign col value to vector
                    vector[counter] = matrix[row, col];
                    counter++;
                }
            }

            return vector;
        }

        // Swaps the values in array at indecies indexFirst, indexSecond
        public static void Swap(int[] array, int indexFirst, int indexSecond)
        {
            //Console.WriteLine($"{array[indexFirst]}, swapping with with {array[indexSecond]})");
            int temp = array[indexFirst];
            array[indexFirst] = array[indexSecond];
            array[indexSecond] = temp;
        }
    }
}
