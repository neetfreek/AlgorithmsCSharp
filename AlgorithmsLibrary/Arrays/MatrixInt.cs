using System;

namespace AlgorithmsLibrary
{
    public static class MatrixInt
    {
        // Return matrix with numCols colums, numRows rows
        // Elements assigned random values between eleMin, eleMax inclusive
        public static int[,] MatrixRandom (int numRows, int numCols, int eleMin, int eleMax)
        {
            // Declare matrix, initialise with default (0) values
            int[,] matrix = new int[numRows, numCols];

            // Iterate rows
            for (int counterRows = 0; counterRows < numRows; counterRows++)
            {   // Iterate colums in row
                for (int counterCols = 0; counterCols < numCols; counterCols++)
                {
                    // Initialise element to random value
                    matrix[counterRows, counterCols] =
                    Helper.RandomInt(eleMin, eleMax + 1);
                }
            }

            return matrix;
        }

        // Return maxmimal sub-matrix (highest sum of elements) of given matrix
        // Return first maximal sub-matrix if multiple have same total
        // Return null if sub-matrix dimensions exceed matrix
        // Sub-matrix size set by subMatrixRows, subMatrixCols
        public static int[,] MaximalSubMatrix(int[,] matrix, int subMatrixRows, int subMatrixCols)
        {
            // Print message, break if sub-matrix dimensions exceed matrix dimensions
            if (subMatrixRows > matrix.GetLength(0)
            | subMatrixCols > matrix.GetLength(1))
            {
                Console.WriteLine("Aboring: sub-matrix dimnesions exceeds matrix dimensions.");
                return null;
            }
            
            // Row, column stop indiciese
            int indexRowStop = matrix.GetLength(0) - subMatrixRows + 1;
            int indexColStop = matrix.GetLength(1) - subMatrixCols + 1;
            // Use to track start position of maxmial array
            int indexMaximalRow = 0;
            int indexMaximalCol = 0;
            // Use to compare totals of each sub-matrix in matrix
            int valueCurent = 0;
            int valueMaximal = 0;

            // Iterate matrix
            // Iterate possible rows
            for (int counterRows = 0; counterRows < indexRowStop; counterRows++)
            {
                // Iterate possible columns
                for (int counterCols = 0; counterCols < indexColStop; counterCols++)
                {
                    // Iterate sub-matrix
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
                // Iterate maximal matrix columns
                for (int counterMaxCol = 0; counterMaxCol < subMatrixCols; counterMaxCol++)
                {
                    // Initilaise elements to matching rows, columns in array
                    maximalMatrix[counterMaxRow, counterMaxCol] = matrix[indexMaximalRow + counterMaxRow, indexMaximalCol + counterMaxCol];
                }
            }
            return maximalMatrix;
        }

        // Return highest value matrix element
        public static int MaxElementMatrix(int[,] matrix)
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

        // Return sum total of all matrix elements
        public static int SumMatrixIntElements(int[,] matrix)
        {
            int total = 0;

            foreach (int element in matrix)
            {
                total += element;
            }

            return total;
        }

        // Print matrix to console
        // Apply padding to align elements (effective up to max console window size)
        public static void PrintMatrix(int[,] matrixToPrint)
        {
            int numRows = matrixToPrint.GetLength(0);
            int numCols = matrixToPrint.GetLength(1);

            // number of digits in largest element
            int digitsMax = Helper.DigitsInInt(MaxElementMatrix(matrixToPrint));
            // padding prepended to number to align elements printed
            string padding = "";

            // iterate rows
            for (int counterRows = 0; counterRows < numRows; counterRows++)
            {
                // iterate columns, print elements
                for (int counterCols = 0; counterCols < numCols; counterCols++)
                {
                    // padding = (max digits - current digits) * spaces  
                    padding = Helper.Padding(digitsMax -Helper.DigitsInInt(matrixToPrint[counterRows, counterCols]));

                    // old padding
                    Console.Write($"{padding}{matrixToPrint[counterRows, counterCols]} ");
                }
                // move to next line to print next row
                Console.WriteLine();
            }
        }    
    }
}