using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("arrayTest:");
            int[] arrayTest = ArrayInt.VectorIntRandom(10, 0, 1);
            ArrayInt.PrintVectorInt(arrayTest);

            Console.WriteLine("matrixTest:");
            int[,] matrixTest = ArrayInt.MatrixIntRandom(3, 3, 0, 100);
            ArrayInt.PrintMatrixInt(matrixTest);
        }
    }
}