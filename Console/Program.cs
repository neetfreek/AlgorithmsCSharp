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
            Helper helper = new Helper();
            ArrayInt arrayInt = new ArrayInt();

            int[] arrayTest = arrayInt.SetupOneDimension(10, 0, 100);
            helper.PrintArrayInt(arrayTest);
        }
    }
}