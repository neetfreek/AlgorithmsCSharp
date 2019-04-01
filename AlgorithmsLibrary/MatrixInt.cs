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

        // Return maxmimal sub-matrix (highest sum of elements) of given matrix
        // Return first maximal sub-matrix if multiple have same total
        // Return null if sub-matrix dimensions exceed matrix
        // Sub-matrix size set by subMatrixRows, subMatrixCols
        public static int[,] MaximalSubMatrix
        (int[,] matrix, int subMatrixRows, int subMatrixCols)
        {
            // Print message, break if sub-matrix dimensions exceed matrix dimensions
            if (subMatrixRows > matrix.GetLength(0)
            | subMatrixCols > matrix.GetLength(1))
            {
                Console.WriteLine("Aboring: sub-matrix dimnesions exceed matrix dimensions.");
                return null;
            }
            // Row, column stop indiciese
            int indexRowStop = matrix.GetLength(0) - subMatrixRows + 1;
            int indexColStop = matrix.GetLength(1) - subMatrixCols + 1;
            // Used to set start element of sub-matrix
            int indexMaximalRow = 0;
            int indexMaximalCol = 0;
            // Used to compare totals of each sub-matrix in matrix
            int valueCurent = 0;
            int valueMaximal = 0;

            // Iterate matrix's sub-matrix start elements
            // Iterate possible rows
            for (int counterRows = 0; counterRows < indexRowStop; counterRows++)
            {
                // Iterate possible columns
                for (int counterCols = 0; counterCols < indexColStop; counterCols++)
                {              
                    // Iterate current sub-matrix's elements
                    // Iterate sub-matrix rows
                    for (int counterSubRows = counterRows; counterSubRows < subMatrixRows + counterRows; counterSubRows++)
                    {
                        // Iterate sub-matrix columns
                        for (int counterSubCols = counterCols; counterSubCols < subMatrixCols + counterCols; counterSubCols++)
                        {
                            // Sum elements of current sub-matrix
                            valueCurent += matrix[counterSubRows, counterSubCols];
                        }
                    }
                    // Assign current maximal value, start maximal matrix's start element
                    if (valueCurent > valueMaximal)
                    {
                        valueMaximal = valueCurent;

                        indexMaximalRow = counterRows;
                        indexMaximalCol = counterCols;
                    }
                    valueCurent = 0;
                }
            }

            // Declare maximal matrix
            int[,] maximalMatrix = new int[subMatrixRows, subMatrixCols];

            // Iterate maximal matrix rows
            for (int counterMaxRow = 0; counterMaxRow < subMatrixRows; counterMaxRow++)
            {
                // Iterate maximal matrix cols
                for (int counterMaxCol = 0; counterMaxCol < subMatrixCols; counterMaxCol++)
                {
                    // Initilaise matrix elements' values
                    maximalMatrix[counterMaxRow, counterMaxCol] = matrix[indexMaximalRow + counterMaxRow, indexMaximalCol + counterMaxCol];
                }
            }
            return maximalMatrix;
        }

        // Return sum of all matrix elements
        public static int SumMatrixIntElements(int[,] matrix)
        {
            int total = 0;

            foreach (int element in matrix)
            {
                total += element;
            }

            return total;
        }
    }
}