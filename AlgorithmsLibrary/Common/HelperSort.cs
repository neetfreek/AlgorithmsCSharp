using System;

/*======================================================*
*  Common helper methods for AlgorithmsLibrary sorting  *
*=======================================================*/
namespace AlgorithmsLibrary
{
    public static class HelperSort
    {
        /*==============================================================*
        *  Return variables of matrix row in CHARACTER, INTEGER vector  *
        *===============================================================*/
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
        public static char[] MatrixRowToVector(char[,] matrix, int row)
        {
            // Set vector length to number of columns
            char[] vector = new char[matrix.GetLength(1)];

            // Iterate columns
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                vector[col] = matrix[row, col];
            }
            return vector;
        }

        /*==============================================================================*
        *  Replace specified row in CHARACTER, INTEGER matrix with  vector              *
        *  Return, print warning, if row doesn't contain same number elements as vector *
        *===============================================================================*/
        public static void OverWriteMatrixRowWithVector(int[,] matrix, int[] vector, int row)
        {
            // ensure number of matrix row elements and vector elements match
            if (matrix.GetLength(1) != vector.Length)
            {
                Console.WriteLine("Aborting: number of elements in matrix row and vector don't match.");
                return;
            }

            for (int col = 0; col < vector.Length; col++)
            {
                matrix[row, col] = vector[col];
            }
        }
        public static void OverWriteMatrixRowWithVector(char[,] matrix, char[] vector, int row)
        {
            // ensure number of matrix row elements and vector elements match
            if (matrix.GetLength(1) != vector.Length)
            {
                Console.WriteLine("Aborting: number of elements in matrix row and vector don't match.");
                return;
            }

            for (int col = 0; col < vector.Length; col++)
            {
                matrix[row, col] = vector[col];
            }
        }

        /*==============================================*
        *  Return CHARACTER, INTEGER matrix as vector   *
        *===============================================*/
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
        public static char[] MatrixToVector(char[,] matrix)
        {
            // Declare, initialise vector with default (0) values
            char[] vector = new char[matrix.Length];

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

        /*==========================================*
        *  Swap CHARACTER, INTEGER values in vector *
        *===========================================*/
        public static void Swap(int[] array, int indexFirst, int indexSecond)
        {
            //Console.WriteLine($"{array[indexFirst]}, swapping with with {array[indexSecond]})");
            int temp = array[indexFirst];
            array[indexFirst] = array[indexSecond];
            array[indexSecond] = temp;
        }
        internal static void Swap(char[] array, int indexFirst, int indexSecond)
        {
            //Console.WriteLine($"{array[indexFirst]}, swapping with with {array[indexSecond]})");
            char temp = array[indexFirst];
            array[indexFirst] = array[indexSecond];
            array[indexSecond] = temp;
        }
    }
}
