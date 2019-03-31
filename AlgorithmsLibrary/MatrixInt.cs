using System;

namespace AlgorithmsLibrary
{
    public static class MatrixInt
    {
        // Return matrix with numCols colums, numRows rows
        // Elements assigned random values between eleMin, eleMax inclusive
        public static int[,] MatrixRandom
        (int numRows, int numCols, int eleMin, int eleMax)
        {
            // Declare matrix
            int[,] matrix = new int[numRows, numCols];

            // Iterate rows
            for (int counterRows = 0; counterRows < numRows; counterRows++)
            {   // Iterate colums in row
                for (int counterCols = 0; counterCols < numCols; counterCols++)
                {
                    // Initialise element
                    matrix[counterRows, counterCols] =
                    Helper.RandomInt(eleMin, eleMax + 1);
                }
            }

            return matrix;
        }

        // Return max element in matrix
        public static int MaxElement(int[,] matrix)
        {
            int eleMax = 0;

            foreach (int ele in matrix)
            {
                if (ele > eleMax)
                {
                    eleMax = ele;
                }
            }
            return eleMax;
        }

        // Print matrix to console
        // Apply padding to align elements
        public static void PrintMatrix(int[,] matrixToPrint)
        {
            int numRows = matrixToPrint.GetLength(0);
            int numCols = matrixToPrint.GetLength(1);

            // number of digits in largest element
            int digitsMax = Helper.DigitsInInt(MaxElement(matrixToPrint));
            // padding prepended to number to align elements printed
            string padding = "";

            // iterate rows
            for (int counterRows = 0; counterRows < numRows; counterRows++)
            {
                // iterate columns, print elements
                for (int counterCols = 0; counterCols < numCols; counterCols++)
                {
                    // padding = (max digits - current digits) * spaces  
                    padding = Helper.Padding
                    (digitsMax - 
                        Helper.DigitsInInt
                    (matrixToPrint[counterRows, counterCols]));

                    Console.Write($"{padding}" +
                    	$"{matrixToPrint[counterRows, counterCols]} ");
                }
                // move to next line to print next row
                Console.WriteLine();
            }
        }

        public static void PrintMaximalSubMatrix
        (int[,] matrix, int subMatrixRows, int subMatrixCols)
        {
            // if subMatrix size exceeds matrix, print warning, break
            if (subMatrixRows > matrix.GetLength(0) 
            | subMatrixCols > matrix.GetLength(1))
            {
                Console.WriteLine("SubMatrix exceeds size of matrix!");
                return;
            }

            // row, column stop indicies
            // subMatrixSize assumes equal dimensions matrix for test; to change
            int indexRowStop = matrix.GetLength(0) - subMatrixRows +1;
            int indexColStop = matrix.GetLength(1) - subMatrixCols +1;
            int testHighestIndex = 0;

            // get subMatrix stop index 
            for (int counterRows = 0; counterRows < indexRowStop; counterRows ++)
            {
                for (int counterCols = 0; counterCols < indexColStop; counterCols ++)
                {

                    // if highest total value so far assign
                    testHighestIndex = matrix[counterRows, counterCols];
                }
            }
            Console.WriteLine($"testValueIndexStop: {testHighestIndex}");
        }
    }
}