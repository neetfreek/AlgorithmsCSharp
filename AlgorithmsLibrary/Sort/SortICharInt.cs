/*==================================================================*
*  Methods for sorting Vectors (1D arrays) and matrices (2D arrays) *
*  Methods overloaded for CHARACTER, INTEGER arrays                 *
*                                                                   *
* 1. Selection Sort: compare each index position's value to all     *
*   successive index positions' values. If greater than, swap. Once *
*   compared to all in collection, iterate to next index. Repeat    *
*   until end of collection.                                        *
*===================================================================*/

namespace AlgorithmsLibrary
{
    public static class SortCharInt
    {
        /*======================================================*
        *  Selection Sort CHARACTER, INTEGER vector             *
        *  Vector elements sorted from lowest to highest value  *  
        *=======================================================*/
        public static void SortSelectionVector(int[] vector)
        {
            int length = vector.Length;

            // Iterate vector columns (elements)
            for (int counter = 0; counter < length; counter++)
            {
                // Iterate columns beyond current column
                for (int counterNext = counter+1; counterNext < length; counterNext++)
                {
                    System.Console.WriteLine($"Checking: {vector[counter]} > {vector[counterNext]}?");
                    // If current column element greater than next
                    if (Helper.GreaterThan(vector[counter], vector[counterNext]))
                    {
                        System.Console.WriteLine($"Y: Switching");
                        // Swap with current column element in outer loop
                        HelperSort.Swap(vector, counterNext, counter);
                    }
                    else
                    {
                        System.Console.WriteLine($"N: Not switching");                    
                    }
                    Vectors.PrintVector(vector);
                }
            }
        }
        public static void SortSelectionVector(char[] vector)
        {
            int length = vector.Length;

            // Iterate vector columns (elements)
            for (int counter = 0; counter < length; counter++)
            {
                // Iterate columns beyond current column
                for (int counterNext = counter + 1; counterNext < length; counterNext++)
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

        /*======================================================*
        *  Selection Sort CHARACTER, INTEGER matrix             *
        *  Matrix elements sorted from lowest to highest value  *
        *=======================================================*/
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
        public static void SortSelectionMatrix(char[,] matrix)
        {
            // Declare vector, intialise values to those of matrix's
            char[] vectorOfMatrix = HelperSort.MatrixToVector(matrix);
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

        /*==============================================================*
        *  Selection Sort CHARACTER, INTEGER matrix's rows              *
        *  Matrix rows' elements sorted from lowest to highest value    *
        *===============================================================*/
        public static void SortSelectionMatrixRows(int[,] matrix)
        {
            int length = Matrices.CountElementsMatrix(matrix);

            // Iterate vector rows
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                // Return new vector comprised of row's elements
                int[] vectorRow = HelperSort.MatrixRowToVector(matrix, row);
                SortSelectionVector(vectorRow);
                HelperSort.OverWriteMatrixRowWithVector(matrix, vectorRow, row);
            }
        }
        public static void SortSelectionMatrixRows(char[,] matrix)
        {
            int length = Matrices.CountElementsMatrix(matrix);

            // Iterate vector rows
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                // Return new vector comprised of row's elements
                char[] vectorRow = HelperSort.MatrixRowToVector(matrix, row);
                SortSelectionVector(vectorRow);
                HelperSort.OverWriteMatrixRowWithVector(matrix, vectorRow, row);
            }
        }
    }
}