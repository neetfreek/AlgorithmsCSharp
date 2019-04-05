using System;
using AlgorithmsLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TestMatrixRandom();
        }

        // Shape tests
        private static void TestVectorRandom()
        {
            Console.WriteLine("=== RANDOM VECTOR INT ===");

            int[] testVectorInt = Vectors.VectorRandom(10, 0, 100);
            Vectors.PrintVector(testVectorInt);

            Console.WriteLine("=== RANDOM VECTOR LETTER ===");
            char[] testVectorChar = Vectors.VectorRandom(20, 'a', 'p');
            Vectors.PrintVector(testVectorChar);
        }

        private static void TestMatrixRandom()
        {
            Console.WriteLine("=== RANDOM MATRIX ===");
            int[,] testMatrix = MatrixInt.MatrixRandom(5, 5, 0, 23);
            MatrixInt.PrintMatrix(testMatrix);
            Console.WriteLine("=== RANDOM MATRIX CHAR ===");
            char[,] testMatrixChar = MatrixInt.MatrixRandom(5, 5, 'a', 'z');
            MatrixInt.PrintMatrix(testMatrixChar);
        }

        private static void TestMaximalSubMatrix()
        {
            Console.WriteLine("=== MATRIX ===");

            int[,] testMatrix = MatrixInt.MatrixRandom(30, 30, 0, 1000);
            MatrixInt.PrintMatrix(testMatrix);
            int[,]maximalMatrix = MatrixInt.MaximalSubMatrix(testMatrix, 2, 2);
            Console.WriteLine("=== MAXIMAL SUB-MATRIX ===");
            MatrixInt.PrintMatrix(maximalMatrix);
            Console.WriteLine($"{Environment.NewLine}Maximal matrix value = {MatrixInt.SumMatrixIntElements(maximalMatrix)}");
        }

        private static void TestPascalsTriangle()
        {
            Console.WriteLine("=== PASCAL'S TRIANGLE ===");
            int[][] testPascalsTriangle = ArrayJaggedInt.PascalsTriangle(12);
            ArrayJaggedInt.PrintTriangle(testPascalsTriangle);
            int maxElement = ArrayJaggedInt.MaxElementTriangle(testPascalsTriangle);
            Console.WriteLine($"{Environment.NewLine}Maximal value: { maxElement}");
        }


        // Manipulation tests
        private static void TestRotateMatrix()
        {
            Console.WriteLine("=== MATRIX ===");

            int[,] testMatrix = MatrixInt.MatrixRandom(7,7, 1, 100);
            int[,] testMatrixRotatedLeft = MatrixInt.RotateSquare(testMatrix, 0);
            int[,] testMatrixRotatedRight = MatrixInt.RotateSquare(testMatrix, 1);
            MatrixInt.PrintMatrix(testMatrix);
            Console.WriteLine();
            Console.WriteLine("=== COUNTER-CLOCKWISE ROTATED MATRIX ===");
            MatrixInt.PrintMatrix(testMatrixRotatedLeft);
            Console.WriteLine();
            Console.WriteLine("=== CLOCKWISE ROTATED MATRIX ===");
            MatrixInt.PrintMatrix(testMatrixRotatedRight);
        }


        // SortInt tests
        private static void TestSortSelectionVector()
        {
            Console.WriteLine("=== VECTOR ===");
            int[] testVector = Vectors.VectorRandom(100, 0, 1000);
            Vectors.PrintVector(testVector);
            SortInt.SortSelectionVector(testVector);
            Console.WriteLine("=== SORTED VECTOR ===");
            Vectors.PrintVector(testVector);
        }

        private static void TestSortSelectionMatrix()
        {
            Console.WriteLine("=== MATRIX ===");
            int[,] testMatrix = MatrixInt.MatrixRandom(5, 5, 0, 1000);
            MatrixInt.PrintMatrix(testMatrix);
            SortInt.SortSelectionMatrix(testMatrix);
            Console.WriteLine("=== SELECTION-SORTED MATRIX ===");
            MatrixInt.PrintMatrix(testMatrix);
        }


        private static void TestSortSelectionMatrixRows()
        {
            Console.WriteLine("=== MATRIX ===");
            int[,] testMatrix = MatrixInt.MatrixRandom(5, 5, 0, 1000);
            MatrixInt.PrintMatrix(testMatrix);
            SortInt.SortSelectionMatrixRows(testMatrix);
            Console.WriteLine();
            Console.WriteLine("=== SELECTION-SORTED (ROWS) MATRIX ===");
            MatrixInt.PrintMatrix(testMatrix);
        }
    }
}