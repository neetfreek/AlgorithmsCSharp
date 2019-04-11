/*======================================================================================*
*  Sort CHARACTER, INTEGER arrays1D, arrays2D from lowest to highest.                   *
*  Array converted to list for sorting, back to array for return.                       *
*  Tests call efficiency information (comparisons, swaps) for INTEGER Vector sorts      *
*===================================================================================    *
* 1. Selection Sort: Compare each element's value to all successive elements' values    .
*    If greater than, swap.                                                             *
*   a. Comaprisons independent of collection's initial order.                           *
*   b. Comparisons = ~(length^2)/2, SwapsMin = 0, SwapsMax = ~(length^2)/2              *
* 2. Inserion Sort: Compare each element's value to all prior elements' values.         *
*    Swap with previous until not smaller than previous element's value or at index 0   *
*   a. Comparisons dependent on collection's initial order.                             *
*   b. Comparisons = ~(length^2/4), Swaps = ~(length^2/4)                               *
*=======================================================================================*/
using System;
using System.Collections.Generic;

namespace AlgorithmsLibrary
{
    public class Sort
    {
        /*==================================================================*
        *  Efficiency information; reset and counted in vector INTEGER swap *
        *  methods. Printed by  Test[NAME_SORT_METHOD]Vector()s in Program  *
        *===================================================================*/
        private static int comparisons;
        public static int Comparisons
        {
            get { return comparisons; }
        }
        private static int swaps;
        public static int Swaps
        {
            get { return swaps; }
        }

        /*==============================================*
        *  1. Selection Sort CHARACTER, INTEGER array   *
        *===============================================*/
        public static int[] SortSelection(int[] vector)
        {
            // reset efficiency information
            comparisons = 0;
            swaps = 0;

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
                        // Swap with current column element in outer loop
                        HelperSort.Swap(list, counterNext, counter);
                        swaps++;
                        //Vectors.PrintVector(list.ToArray());
                    }
                }
            }

            int[] vectorSorted = list.ToArray();

            return vectorSorted;
        }
        public static char[] SortSelection(char[] vector)
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
        public static int[,] SortSelection(int[,] matrix)
        {
            // efficiency informaiton

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // Declare vector, intialise values to those of matrix's
            List<int> list = new List<int>(SortSelection(HelperSort.MatrixToVector(matrix)));
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
        public static char[,] SortSelection(char[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // Declare vector, intialise values to those of matrix's
            List<char> list = new List<char>(SortSelection(HelperSort.MatrixToVector(matrix)));
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
        public static int[,] SortSelectionRows(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[,] matrixSortedRows = new int[rows, cols];

            // Iterate vector rows
            for (int row = 0; row < rows; row++)
            {
                // Return new vector comprised of row's elements
                int[] vectorRow = HelperSort.MatrixRowToVector(matrix, row);
                int[] vectorRowSorted = SortSelection(vectorRow);
                HelperSort.OverWriteMatrixRowWithVector(matrixSortedRows, vectorRowSorted, row);
            }

            return matrixSortedRows;
        }
        public static char[,] SortSelectionRows(char[,] matrix)
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
                char[] vectorRowSorted = SortSelection(vectorRow);
                HelperSort.OverWriteMatrixRowWithVector(matrixSortedRows, vectorRowSorted, row);
            }

            return matrixSortedRows;
        }

        /*==============================================*
        *  2. Insertion Sort CHARACTER, INTEGER array   *
        *===============================================*/
        public static int[] SortInsertion(int[] vector)
        {
            // reset efficiency information
            comparisons = 0;
            swaps = 0;

            int length = vector.Length;
            List<int> list = new List<int>(vector);

            // intialise counter to 1 as compare with prior elements' values
            for (int counter = 1; counter < length; counter++)
            {
                comparisons++;

                for (int counterPrior = counter;
                    counterPrior > 0 && Helper.GreaterThan(list[counterPrior-1], list[counterPrior]);
                    counterPrior--)
                {
                    HelperSort.Swap(list, counterPrior - 1,counterPrior);
                    comparisons++;
                    swaps++;
                    //Vectors.PrintVector(list.ToArray());
                }
            }
            int[] vectorSorted = list.ToArray();

            return vectorSorted;
        }
        public static char[] SortInsertion(char[] vector)
        {
            int length = vector.Length;
            List<char> list = new List<char>(vector);

            // intialise counter to 1 as compare with prior elements' values
            for (int counter = 1; counter < length; counter++)
            {

                for (int counterPrior = counter;
                    counterPrior > 0 && Helper.GreaterThan(list[counterPrior - 1], list[counterPrior]);
                    counterPrior--)
                {
                    HelperSort.Swap(list, counterPrior - 1, counterPrior);
                }
            }
            char[] vectorSorted = list.ToArray();

            return vectorSorted;
        }

    }
}