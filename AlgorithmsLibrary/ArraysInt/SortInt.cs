using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsLibrary
{
    public static class SortInt
    {
        // Sort elements of vector
        public static void SortSelectionVector(int[] vector)
        {
            int length = vector.Length;

            // Iterate vector columns (elements)
            for (int counter = 0; counter < length; counter++)
            {
                // Iterate columns beyond current column
                for (int counterNext = counter+1; counterNext < length; counterNext++)
                {
                    // If current column element greater than next
                    if (Helper.GreaterThan(vector[counter], vector[counterNext]))
                    {
                        // Swap with current column element in outer loop
                        HelperSort.Swap(vector, counterNext, counter);
                    }
                }
            }
        }

        // Sort elements of matrix
        public static void SortSelectionMatrix(int[,] matrix)
        {
            // Declare vector, intialise values to those of matrix's
            int[] vectorOfMatrix = HelperSort.MatrixToVector(matrix);
            SortSelectionVector(vectorOfMatrix);

            int counter = 0;

            // Iterate rows
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                // Iterate columns
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    // Assign current element's value to vector's
                    matrix[row, col] = vectorOfMatrix[counter];
                    counter++;
                }
            }
        }

        // Sort elements in each row of matrix
        public static void SortSelectionMatrixRows(int[,] matrix)
        {
            int length = MatrixInt.CountElementsMatrix(matrix);

            // Iterate vector rows
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                // Return new vector comprised of row's elements
                int[] vectorRow = HelperSort.MatrixRowToVector(matrix, row);
                SortSelectionVector(vectorRow);
                HelperSort.OverWriteMatrixRowWithVector(matrix, vectorRow, row);
            }
        }
    }
}