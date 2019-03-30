using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsLibrary;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayTest = ArrayInt.SetupOneDimension(10, 0, 100);
            Helper.PrintArrayInt(arrayTest);
        }
    }
}