using System;

/*==========================*
 *  INTEGER functionality   *
 *==========================*/
namespace AlgorithmsLibrary
{
    public static class ArrayJaggedInt
    {
        /*==================================================*
        *  Return INTEGER Pascal's Trialge array of arrays  *
        *  Assign first rows's column (element) to 1        *   
        *  proceeding rows' columns assigned by by:         *
        *   1) Assign same column index to same as current  *
        *   2) Assigning next column index                  *
        *===================================================*/
        public static int[][] PascalsTriangle(int rows)
        {
            // Declare, initialise with null (0) values triangle
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

        /*======================================================================*
        *  Return INTEGER array of arrays triangle                              *
        *  Elements assigned default (0) values                                 *
        *  Apply padding between elements, effective up rows = 13, still legible*
        *=======================================================================*/
        public static int[][] TriangleEquilateralEmpty(int rows)
        {
            if (rows > int.MaxValue)
            {
                Console.WriteLine("Aborting: too many rows!");
                return null;
            }
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

        /*======================================================================*
        *  Return the highest value element of INTEGER array of arrays          *
        *=======================================================================*/
        public static int MaxElementArrayOfArrays(int[][] triangle)
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
        *  Print INTEGER array of arrays triangle to console                    *
        *  Apply padding between elements, effective up rows = 13, still legible*
        *=======================================================================*/
        public static void PrintTriangle(int[][] triangle)
        {
            int rows = triangle.GetLength(0);
            // Iterate rows
            for (int row = 0; row < rows; row++)
            {
                // Pad row from (rows-row)*2 - row per iteration for center
                Console.Write("".PadLeft((rows - row) * 2));
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
