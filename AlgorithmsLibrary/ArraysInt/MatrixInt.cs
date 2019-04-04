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
                    // Assign element to random value
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

            // Declare maximal matrix, intialise with default (0) values
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
        
        // Return rotated copy of provided square (equal rows, columns) matrix
        // Direction for rotation accepted as 0 == left, 1 == right
        // Aborts if matrix is not a square or direction incorrectly passed
        public static int[,] RotateSquare(int[,] matrix, int direction)
        {
            // Declare, initialise values used in iteration of matrix
            int rowsMatrix = matrix.GetLength(0);
            int colsMatrix = matrix.GetLength(1);
            int rowsMid = (matrix.GetLength(0) / 2);
            int colMid = (matrix.GetLength(1) / 2);

            // Left == 0; right == 1
            int direct = direction;

            // Initialise matrixRotated with default (0) values
            int[,] matrixRotated = new int[rowsMatrix, colsMatrix];

            // ensure direction correctly specified
            if (direct != 0 && direct != 1)
            {
                Console.WriteLine("Aborting: Incorrectly specified direction: clockwise == 0, counter-clockwise == 1");
                return matrixRotated;
            }
            // Ensure matrix is a square 
            if (rowsMatrix != colsMatrix)
            {
                Console.WriteLine("Aborting: Matrix is not a square.");
                return matrixRotated;
            }

            int passesTotal = 0;

            // Iterate matrix
            while (passesTotal < matrix.GetLength(0))
            {
                // Iterate outer top row
                for (int row = passesTotal; row < passesTotal + 1; row++)
                {
                    // Iterate columns
                    for (int col = colsMatrix - 1 - passesTotal; col > passesTotal; col--)
                    {                        
                        if (direct == 0)
                        {
                            // Move column left
                            matrixRotated[row, col - 1] = matrix[row, col];
                        } else
                        {
                            // Move column right
                            matrixRotated[row, col] = matrix[row, col - 1];
                        }
                    }
                }

                // Iterate rows in col passesLeft (LEFT ROW)
                for (int col = passesTotal; col < passesTotal + 1; col++)
                {
                    // Iterate rows
                    for (int row = 0 + passesTotal; row < rowsMatrix - 1 - passesTotal; row++)
                    {                        
                        if (direct == 0)
                        {
                            // Move row down
                            matrixRotated[row + 1, col] = matrix[row, col];
                        }
                        else
                        {
                            // move row up
                            matrixRotated[row, col] = matrix[row + 1, col];
                        }
                    }
                }

                // Iterate cols in row rowsMatrix (BOTTOM ROW)
                for (int row = rowsMatrix - 1 - passesTotal; row < rowsMatrix - passesTotal; row++)
                {
                    // Iterate columns
                    for (int col = 0 + passesTotal; col < colsMatrix - 1 - passesTotal; col++)
                    {                        
                        if (direct == 0)
                        {
                            // Move column right
                            matrixRotated[row, col + 1] = matrix[row, col];
                        }
                        else
                        {
                            // move column left
                            matrixRotated[row, col] = matrix[row, col + 1];
                        }
                    }
                }

                // Iterate rows in col colsMatrix (RIGHT ROW)
                for (int col = colsMatrix - 1 - passesTotal; col < colsMatrix - passesTotal; col++)
                {
                    // Iterate rows
                    for (int row = rowsMatrix - 1 - passesTotal; row > passesTotal; row--)
                    {                        
                        if (direct == 0)
                        {
                            // Move col up
                            matrixRotated[row - 1, col] = matrix[row, col];
                        }
                        else
                        {
                            // Move col down
                            matrixRotated[row, col] = matrix[row - 1, col];
                        }
                    }
                }
                passesTotal++;
            }

            // Determine mid-point
            int midRow = rowsMatrix / 2;
            int midCol = colsMatrix / 2;
            // if mid-point exists
            if (midRow % 2 != 0 | midCol % 2 != 0)
            {
                // Assign mid-point in rotated matrix to mid-point of matrix
                matrixRotated[midRow, midCol] = matrix[midRow, midCol];
            }

            return matrixRotated;
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

        public static int CountElementsMatrix(int[,] matrix)
        {
            int count = 0;

            foreach (int element in matrix)
            {
                count++;
            }

            return count;
        }

        // SortInt matrix elements in ascending order
        //public static void SortSelectionMatrixRows(int[,] matrix)
        //{
        //    int length = MatrixInt.CountElementsMatrix(matrix);

        //    // Iterate vector columns (elements)
        //    for (int row = 0; row < matrix.GetLength(0); row++)
        //    {
        //        int[] vectorRow = 
        //        SortSelectionVector(matrix[row]);
        //    }
        //}

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