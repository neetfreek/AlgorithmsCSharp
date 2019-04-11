/*==========================================================================*
*  Sort CHARACTER, INTEGER arrays1D, arrays2D from lowest to highest.       *
*  Array converted to list for sorting, back to array for return.           *
*  Print comparisons, swaps for INTEGER vesion of each sort method          *
*===========================================================================*
* 1. Selection Sort: Iterate, compare each collection's index's value to    *
*   all successive indecies' values. If greater than, swap.                 *
*   ~(length^2)/2 comparisons and n swaps                                   *
* 2. Inserion Sort:
*===========================================================================*/
using System;
using System.Collections.Generic;

namespace AlgorithmsLibrary
{
    public static class Sort
    {
        /*======================================================*
        *  Selection Sort CHARACTER, INTEGER vector             *
        *  Vector elements sorted from lowest to highest value  *  
        *=======================================================*/
        public static int[] SortSelectionVector(int[] vector)
        {
            // efficiency inforation
            int comparisons = 0;
            int swaps = 0;

            int length = vector.Length;
            List<int> list = new List<int>(vector);

            // Iterate vector columns (elements)
            for (int counter = 0; counter < length; counter++)
            {
                // Iterate columns beyond current column
                for (int counterNext = counter+1; counterNext < length; counterNext++)
                {
                    comparisons++;
                    // If current column element greater than next
                    if (Helper.GreaterThan(list[counter], list[counterNext]))
                    {
                        swaps++;
                        // Swap with current column element in outer loop
                        HelperSort.Swap(list, counterNext, counter);
                    }
                }
            }
            System.Console.WriteLine($"Comparisons: {comparisons}, swaps: {swaps}{Environment.NewLine}");

            int[] vectorSorted = list.ToArray();

            return vectorSorted;
        }
        public static char[] SortSelectionVector(char[] vector)
        {
            int length = vector.Length;
            List<char> list = new List<char>(vector);

            // Iterate vector columns (elements)
            for (int counter = 0; counter < length; counter++)
            {
                // Iterate columns beyond current column
                for (int counterNext = counter + 1; counterNext < length; counterNext++)
                {
                    // If current column element greater than next
                    if (Helper.GreaterThan(list[counter], list[counterNext]))
                    {
                        // Swap with current column element in outer loop
                        HelperSort.Swap(list, counterNext, counter);
                    }
                }
            }
            char[] vectorSorted = list.ToArray();

            return vectorSorted;
        }

        /*======================================================*
        *  Selection Sort CHARACTER, INTEGER matrix             *
        *  Matrix elements sorted from lowest to highest value  *
        *=======================================================*/
        public static int[,] SortSelectionMatrix(int[,] matrix)
        {
            // efficiency informaiton

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // Declare vector, intialise values to those of matrix's
            List<int> list = new List<int>(SortSelectionVector(HelperSort.MatrixToVector(matrix)));
            int[,] matrixSorted = new int[rows, cols];

            int counter = 0;
            // Iterate rows
            for (int row = 0; row < rows; row++)
            {
                // Iterate columns
                for (int col = 0; col < cols; col++)
                {
                    // Assign current element's value to vector's
                    matrixSorted[row, col] = list[counter];
                    counter++;
                }
            }

            return matrixSorted;
        }
        public static char[,] SortSelectionMatrix(char[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // Declare vector, intialise values to those of matrix's
            List<char> list = new List<char>(SortSelectionVector(HelperSort.MatrixToVector(matrix)));
            char[,] matrixSorted = new char[rows, cols];

            int counter = 0;
            // Iterate rows
            for (int row = 0; row < rows; row++)
            {
                // Iterate columns
                for (int col = 0; col < cols; col++)
                {
                    // Assign current element's value to vector's
                    matrixSorted[row, col] = list[counter];
                    counter++;
                }
            }

            return matrixSorted;
        }

        /*==============================================================*
        *  Selection Sort CHARACTER, INTEGER matrix's rows              *
        *  Matrix rows' elements sorted from lowest to highest value    *
        *===============================================================*/
        public static int[,] SortSelectionMatrixRows(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[,] matrixSortedRows = new int[rows, cols];

            // Iterate vector rows
            for (int row = 0; row < rows; row++)
            {
                // Return new vector comprised of row's elements
                int[] vectorRow = HelperSort.MatrixRowToVector(matrix, row);
                int[] vectorRowSorted = SortSelectionVector(vectorRow);
                HelperSort.OverWriteMatrixRowWithVector(matrixSortedRows, vectorRowSorted, row);
            }

            return matrixSortedRows;
        }
        public static char[,] SortSelectionMatrixRows(char[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int length = Matrices.CountElementsMatrix(matrix);

            char[,] matrixSortedRows = new char[rows, cols];

            // Iterate vector rows
            for (int row = 0; row < rows; row++)
            {
                // Return new vector comprised of row's elements
                char[] vectorRow = HelperSort.MatrixRowToVector(matrix, row);
                char[] vectorRowSorted = SortSelectionVector(vectorRow);
                HelperSort.OverWriteMatrixRowWithVector(matrixSortedRows, vectorRowSorted, row);
            }

            return matrixSortedRows;
        }
    }
}