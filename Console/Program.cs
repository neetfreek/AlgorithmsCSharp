using System;
using AlgorithmsLibrary;

/*==========================================================*
 *  Client class for AlgorithmsLibrary.                     *
 *  Contains methods for quick testing of different classes *
 *==========================================================*/
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call test methods here
        }

        // Shape tests
        private static void TestVectorRandom()
        {
            Console.WriteLine("=== RANDOM VECTOR INT ===");
            int[] testVectorInt = Vectors.VectorRandom(10, 0, 100);
            Vectors.PrintVector(testVectorInt);

            Console.WriteLine($"{Environment.NewLine}=== RANDOM VECTOR LETTER ===");
            char[] testVectorChar = Vectors.VectorRandom(20, 'a', 'p');
            Vectors.PrintVector(testVectorChar);
        }

        private static void TestMatrixRandom()
        {
            Console.WriteLine("=== RANDOM MATRIX ===");
            int[,] testMatrix = Matrices.MatrixRandom(5, 5, 0, 100);
            Matrices.PrintMatrix(testMatrix);

            Console.WriteLine($"{Environment.NewLine}=== RANDOM MATRIX CHAR ===");
            char[,] testMatrixChar = Matrices.MatrixRandom(5, 5, 'a', 'z');
            Matrices.PrintMatrix(testMatrixChar);
        }

        private static void TestMaximalSubMatrix()
        {
            Console.WriteLine("=== MATRIX ===");
            int[,] testMatrix = Matrices.MatrixRandom(30, 30, 0, 1000);
            Matrices.PrintMatrix(testMatrix);

            Console.WriteLine($"{Environment.NewLine}=== MAXIMAL SUB-MATRIX ===");
            int[,] maximalMatrix = Matrices.MaximalSubMatrix(testMatrix, 2, 2);
            Matrices.PrintMatrix(maximalMatrix);

            Console.WriteLine($"{Environment.NewLine}Maximal matrix value = {Matrices.SumMatrixIntElements(maximalMatrix)}");
        }

        private static void TestPascalsTriangle()
        {
            Console.WriteLine("=== PASCAL'S TRIANGLE ===");
            int[][] testPascalsTriangle = ArrayJaggedInt.PascalsTriangle(20);
            ArrayJaggedInt.PrintTriangle(testPascalsTriangle);
            int maxElement = ArrayJaggedInt.MaxElementArrayOfArrays(testPascalsTriangle);

            Console.WriteLine($"{Environment.NewLine}Maximal value: { maxElement}");
        }


        // Manipulation tests
        private static void TestRotateMatrix()
        {
            Console.WriteLine("=== MATRIX ===");
            int[,] testMatrix = Matrices.MatrixRandom(7,7, 1, 100);
            Matrices.PrintMatrix(testMatrix);

            Console.WriteLine($"{Environment.NewLine}=== COUNTER-CLOCKWISE ROTATED MATRIX ===");
            int[,] testMatrixRotatedLeft = Matrices.RotateSquare(testMatrix, 0);
            Matrices.PrintMatrix(testMatrixRotatedLeft);

            Console.WriteLine($"{Environment.NewLine}=== CLOCKWISE ROTATED MATRIX ===");
            int[,] testMatrixRotatedRight = Matrices.RotateSquare(testMatrix, 1);
            Matrices.PrintMatrix(testMatrixRotatedRight);
        }


        // SortCharInt tests
        private static void TestSortSelectionVector()
        {
            Console.WriteLine("=== VECTOR ===");
            int[] testVectorInt = Vectors.VectorRandom(100, 0, 1000);
            Vectors.PrintVector(testVectorInt);
            SortCharInt.SortSelectionVector(testVectorInt);

            Console.WriteLine($"{Environment.NewLine}=== SORTED VECTOR INTEGERS ===");
            Vectors.PrintVector(testVectorInt);
        }

        private static void TestSortSelectionMatrix()
        {
            Console.WriteLine("=== MATRIX INTEGERS ===");
            int[,] testMatrix = Matrices.MatrixRandom(5, 5, 0, 100);
            Matrices.PrintMatrix(testMatrix);

            Console.WriteLine($"{Environment.NewLine}=== SELECTION-SORTED MATRIX ===");
            SortCharInt.SortSelectionMatrix(testMatrix);
            Matrices.PrintMatrix(testMatrix);
        }

        private static void TestSortSelectionMatrixRows()
        {
            Console.WriteLine("=== MATRIX INTEGERS ===");
            int[,] testMatrix = Matrices.MatrixRandom(5, 5, 0, 1000);
            Matrices.PrintMatrix(testMatrix);
            SortCharInt.SortSelectionMatrixRows(testMatrix);

            Console.WriteLine($"{Environment.NewLine}=== SELECTION-SORTED (ROWS) MATRIX INTEGERS ===");
            Matrices.PrintMatrix(testMatrix);
        }
    }
}