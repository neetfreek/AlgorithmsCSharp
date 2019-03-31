using System;
using AlgorithmsLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TestVector();
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
            int[,] testMatrix = MatrixInt.MatrixRandom(5, 5, 0, 100);
            MatrixInt.PrintMatrix(testMatrix);
            MatrixInt.PrintMaximalSubMatrix(testMatrix, 2, 3);
        }
    }
}