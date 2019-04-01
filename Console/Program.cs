﻿using System;
using AlgorithmsLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TestPascalsTriangle();
        }

        private static void TestVector()
        {
            int[] testVector = VectorInt.VectorIntRandom(10, 0, 1000);
            Console.WriteLine("Test vector: ");
            VectorInt.PrintVectorInt(testVector);
        }

        private static void TestMatrix()
        {
            int[,] testMatrix = MatrixInt.MatrixRandom(5, 23, 0, 1000);
            Console.WriteLine("Test array");
            MatrixInt.PrintMatrix(testMatrix);
        }

        private static void TestPrintMaximalSubMatrix()
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
            int[][] testPascalsTriangle = MatrixInt.PascalsTriangle(12);
            MatrixInt.PrintMatrixTriangle(testPascalsTriangle);
        }
    }
}