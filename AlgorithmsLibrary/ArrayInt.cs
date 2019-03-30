using System;

namespace AlgorithmsLibrary
{
    public static class ArrayInt
    {
        // Generate new array with numElements number of elements
        // Elements assigned random values between eleMin, eleMax inclusive
        public static int[] OneDimensionArray
        (int numEles, int eleMin, int eleMax)
        {
            // Initialise and declare array
            int[] array = new int[numEles];

            // Initialise elements of array
            for (int counter = 0; counter < numEles; counter++)
            {
                array[counter] = Helper.RandomInt(eleMin, eleMax);
            }
            return array;
        }

        // Check array for symmetry; return true if symmetrical, false if not
        // if length is odd number, middle number excluded
        public static bool IsSymmetrical(int[] array)
        {
            bool isSymmetrical = false;
            int length = array.Length;

            for (int counter = 0; counter < length/2; counter++)
            {
                if (array[counter] != array[length -1 -counter])
                {
                    return isSymmetrical;
                }
            }

            isSymmetrical = true;
            return isSymmetrical;
        }

        // Print elements' values to console
        public static void PrintArrayInt(int[] array)
        {
            int length = array.Length;

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"Element {i} is {array[i]}");
            }
        }
    }
}