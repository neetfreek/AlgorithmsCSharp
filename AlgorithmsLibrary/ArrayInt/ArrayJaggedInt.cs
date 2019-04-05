using System;

/*==================================*
 *  Methods accept only INTEGERS    *
 *==================================*/

namespace AlgorithmsLibrary
{
    public static class ArrayJaggedInt
    {
        /*==================================================*
        *  Generate, return Pascal's Trialge.               *
        *  Assign first rows's column (element) to 1        *   
        *  proceeding rows' columns assigned by by:         *
        *   1) Assign same column index to same as current  *
        *   2) Assigning next column index                  *
        *===================================================*/
        public static int[][] PascalsTriangle(int rows)
        {
            int[][] triangle = TriangleEquilateralEmpty(rows);

            // Assign first row's column's value to 1
            triangle[0][0] = 1;
            // Iterate each row except last (modifying proceeding rows)
            for (int row = 0; row < rows - 1; row++)
            {
                // Iterate each row's column
                for (int col = 0; col <= row; col++)
                {
                    // Add current column value to next row's same index column
                    triangle[row + 1][col] += triangle[row][col];
                    // Add current column value to next row's next index column
                    triangle[row + 1][col + 1] += triangle[row][col];
                }
            }
            return triangle;
        }

        public static int[][] TriangleEquilateralEmpty(int rows)
        {
            // Declare, initialise with default (0) values, triangle (array of arrays)
            int[][] triangle = new int[rows][];

            // Iterate rows in triangle (array)
            for (int row = 0; row < rows; row++)
            {
                // Assign row's elements to default (0) value
                triangle[row] = new int[row + 1];
            }

            return triangle;
        }

        public static int MaxElementTriangle(int[][] triangle)
        {
            int elementMax = 0;

            for (int row = 0; row < triangle.GetLength(0); row++)
            {
                for (int col = 0; col < triangle[row].GetLength(0); col++)
                {
                    if (triangle[row][col] > elementMax)
                    {
                        elementMax = triangle[row][col];
                    }
                }
            }
            return elementMax;
        }

        /*======================================================================*
        *  Print triangle to console                                            *
        *  Apply padding between elements, effective up to console window size  *
        *=======================================================================*/
        public static void PrintTriangle(int[][] triangle)
        {
            int rows = triangle.GetLength(0);
            // Iterate rows
            for (int row = 0; row < rows; row++)
            {
                // Pad row by incrementally less based on row length (for triangle shape)
                Console.Write("".PadRight((rows - row) * 2));
                // Iterate columns (elements)
                for (int col = 0; col <= row; col++)
                {
                    Console.Write("{0,3} ", triangle[row][col]);
                }
                Console.WriteLine();
            }
        }
    }
}
