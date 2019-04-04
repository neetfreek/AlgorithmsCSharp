using System;
using AlgorithmsLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TestSortSelectionMatrix();
        }

        // Shape tests
        private static void TestVectorRandom()
        {
            int[] testVector = VectorInt.VectorRandom(10, 0, 1000);
            Console.WriteLine("Test vector: ");
            VectorInt.PrintVector(testVector);
        }

        private static void TestMatrixRandom()
        {
            int[,] testMatrix = MatrixInt.MatrixRandom(5, 23, 0, 1000);
            Console.WriteLine("Test array");
            MatrixInt.PrintMatrix(testMatrix);
        }

        private static void TestMaximalSubMatrix()
        {
            Console.WriteLine("Test maximal sub-matrix");
            int[,] testMatrix = MatrixInt.MatrixRandom(30, 30, 0, 1000);
            MatrixInt.PrintMatrix(testMatrix);

            int[,]maximalMatrix = MatrixInt.MaximalSubMatrix(testMatrix, 2, 2);
            Console.WriteLine($"Maximal matrix value = {MatrixInt.SumMatrixIntElements(maximalMatrix)}");
            MatrixInt.PrintMatrix(maximalMatrix);
        }

        private static void TestPascalsTriangle()
        {
            int[][] testPascalsTriangle = ArrayJaggedInt.PascalsTriangle(12);
            ArrayJaggedInt.PrintTriangle(testPascalsTriangle);
            int maxElement = ArrayJaggedInt.MaxElementTriangle(testPascalsTriangle);
            Console.WriteLine("MAX ELEMENT IS " + maxElement);
        }


        // Manipulation tests
        private static void TestRotateMatrix()
        {
            int[,] testMatrix = MatrixInt.MatrixRandom(5,5, 1, 100);
            int[,] testMatrixRotatedLeft = MatrixInt.RotateSquare(testMatrix, 0);
            int[,] testMatrixRotatedRight = MatrixInt.RotateSquare(testMatrix, 1);
            Console.WriteLine("=== ORIGINAL MATRIX ===");
            MatrixInt.PrintMatrix(testMatrix);
            Console.WriteLine();
            Console.WriteLine("=== LEFT ROTATED MATRIX ===");
            MatrixInt.PrintMatrix(testMatrixRotatedLeft);
            Console.WriteLine();
            Console.WriteLine("=== RIGHT ROTATED MATRIX ===");
            MatrixInt.PrintMatrix(testMatrixRotatedRight);
        }


        // SortInt tests
        private static void TestSortSelectionVector()
        {
            int[] testVector = VectorInt.VectorRandom(100, 0, 1000);
            Console.WriteLine("=== ORIGINAL VECTOR ===");
            VectorInt.PrintVector(testVector);
            SortInt.SortSelectionVector(testVector);
            Console.WriteLine("=== SORTED VECTOR ===");
            VectorInt.PrintVector(testVector);
        }

        private static void TestSortSelectionMatrix()
        {
            int[,] testMatrix = MatrixInt.MatrixRandom(5, 5, 0, 1000);
            Console.WriteLine("=== ORIGINAL MATRIX ===");
            MatrixInt.PrintMatrix(testMatrix);
            SortInt.SortSelectionMatrix(testMatrix);
            Console.WriteLine("=== SELECTION-SORTED MATRIX ===");
            MatrixInt.PrintMatrix(testMatrix);
        }


        private static void TestSortSelectionMatrixRows()
        {
            int[,] testMatrix = MatrixInt.MatrixRandom(5, 5, 0, 1000);
            Console.WriteLine("=== ORIGINAL MATRIX ===");
            MatrixInt.PrintMatrix(testMatrix);
            SortInt.SortSelectionMatrixRows(testMatrix);
            Console.WriteLine();
            Console.WriteLine("=== SELECTION-SORTED (ROWS) MATRIX ===");
            MatrixInt.PrintMatrix(testMatrix);
        }
    }
}