/*==================================================================*
*  Methods for sorting Vectors (1D arrays) and matrices (2D arrays) *
*  Methods overloaded for CHARACTER, INTEGER arrays                 *
*  Arrays are cast into lists for sorting operations and re-cast    *
*   into array for return                                           *
* 1. Selection Sort: compare each index position's value to all     *
*   successive index positions' values. If greater than, swap. Once *
*   compared to all in collection, iterate to next index. Repeat    *
*   until end of collection.                                        *
*===================================================================*/
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
            int length = vector.Length;
            List<int> list = new List<int>(vector);

            // Iterate vector columns (elements)
            for (int counter = 0; counter < length; counter++)
            {
                // Iterate columns beyond current column
                for (int counterNext = counter+1; counterNext < length; counterNext++)
                {
                    // If current column element greater than next
                    if (Helper.GreaterThan(list[counter], list[counterNext]))
                    {
                        // Swap with current column element in outer loop
                        HelperSort.Swap(list, counterNext, counter);
                    }
                }
            }
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
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // Declare vector, intialise values to those of matrix's
            int[] vectorOfMatrix = HelperSort.MatrixToVector(matrix);
            //SortSelectionVector(vectorOfMatrix);
            List<int> list = new List<int>(SortSelectionVector(vectorOfMatrix));
            int[,] matrixSorted = new int[rows, cols];
            int counter = 0;

            // Iterate rows
            for (int row = 0; row < rows; row++)
            {
                // Iterate columns
                for (int col = 0; col < cols; col++)
                {
                    System.Console.WriteLine($"iterating list: {counter} = {list[counter]}");
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
            char[] vectorOfMatrix = HelperSort.MatrixToVector(matrix);
            //SortSelectionVector(vectorOfMatrix);
            List<char> list = new List<char>(SortSelectionVector(vectorOfMatrix));
            char[,] matrixSorted = new char[rows, cols];

            int counter = 0;

            // Iterate rows
            for (int row = 0; row < rows; row++)
            {
                // Iterate columns
                for (int col = 0; col < cols; col++)
                {
                    // Assign current element's value to vector's
                    matrixSorted[row, col] = vectorOfMatrix[counter];
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
            int length = Matrices.CountElementsMatrix(matrix);

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