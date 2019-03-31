using System;

namespace AlgorithmsLibrary
{
    public static class ArrayInt
    {
        /* Matrices */

        // Generate multiDimension array with numCols colums, numRows rows
        // Elements assigned random values between eleMin, eleMax inclusive
        public static int[,] MatrixIntRandom
        (int numRows, int numCols, int eleMin, int eleMax)
        {
            // initialise and declare matrix
            int[,] matrix = new int[numRows, numCols];

            // iterate rows
            for (int counterRows = 0; counterRows < numRows; counterRows++)
            {   // iterate colums in colums
                for (int counterCols = 0; counterCols < numCols; counterCols++)
                {
                    // assign element value
                    matrix[counterRows, counterCols] =
                    Helper.RandomInt(eleMin, eleMax + 1);
                }
            }

            return matrix;
        }

        public static void PrintMatrixInt(int[,] array)
        {
            int numRows = array.GetLength(0);
            int numCols = array.GetLength(1);

            // iterate rows
            for (int counterRows = 0; counterRows < numRows; counterRows++)
            {
                // iterate columns, print elements
                for (int counterCols = 0; counterCols < numCols; counterCols++)
                {
                    Console.Write($"{array[counterRows, counterCols]} ");
                }
                // set to print on next line for next row
                Console.WriteLine();
            }
        }


        /* Vectors */

        // Generate singleDimension array with numElements number of elements
        // Elements assigned random values between eleMin, eleMax inclusive
        public static int[] VectorIntRandom 
        (int numEles, int eleMin, int eleMax)
        {
            // Declare vector
            int[] vector = new int[numEles];

            // iterate elements 
            for (int counter = 0; counter < numEles; counter++)
            {
                // Initialise elements
                vector[counter] = Helper.RandomInt(eleMin, eleMax+1);
            }

            return vector;
        }

        // Check vector for symmetry; return true if symmetrical, false if not
        // if length is odd number, middle number excluded
        public static bool IsSymmetricalVectorInt(int[] array)
        {
            bool isSymmetrical = false;
            int length = array.Length;

            // iterate half elements
            for (int counter = 0; counter < length/2; counter++)
            {
                if (array[counter] != array[length -1 -counter])
                {
                    return isSymmetrical;
                }
            }

            isSymmetrical = true;
            return isSymmetrical;
        }

        // Print elements' values to console
        public static void PrintVectorInt(int[] array)
        {
            int length = array.Length;

            // iterate elements
            for (int i = 0; i < length; i++)
            {
                // print element, space
                Console.Write($"{array[i]} ");
            }
            // go to new line in case printing later to console
            Console.WriteLine();
        }
    }
}