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
            int[] arrayTest = ArrayInt.OneDimensionArray(5, 0, 10);
            ArrayInt.PrintArrayInt(arrayTest);
            Console.WriteLine(ArrayInt.IsSymmetrical(arrayTest));
        }
    }
}