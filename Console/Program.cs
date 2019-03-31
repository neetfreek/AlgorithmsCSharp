using System;
using AlgorithmsLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testVector = VectorInt.VectorIntRandom(10, 0, 999);
            int[,] testMatrix = MatrixInt.MatrixRandom(5, 23, 0, 1000);
            Console.WriteLine("Test vector: ");
            VectorInt.PrintVectorInt(testVector);
            Console.WriteLine("Test array");
            MatrixInt.PrintMatrix(testMatrix);
        }
    }
}