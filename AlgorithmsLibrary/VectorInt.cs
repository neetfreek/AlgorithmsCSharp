using System;

namespace AlgorithmsLibrary
{
    public static class VectorInt
    {
        // Return vector with numElements number of elements
        // Elements assigned random values between eleMin, eleMax inclusive
        public static int[] VectorIntRandom 
        (int numEles, int eleMin, int eleMax)
        {
            // Declare vector
            int[] vector = new int[numEles];

            // iterate elements 
            for (int counter = 0; counter < numEles; counter++)
            {
                // Initialise elements
                vector[counter] = Helper.RandomInt(eleMin, eleMax+1);
            }

            return vector;
        }

        // Check vector for symmetry; return true if symmetrical, false if not
        // if length is odd number, middle number excluded
        public static bool IsSymmetricalVectorInt(int[] array)
        {
            bool isSymmetrical = false;
            int length = array.Length;

            // iterate half elements
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
        public static void PrintVectorInt(int[] vectorToPrint)
        {
            int length = vectorToPrint.Length;

            // iterate elements
            for (int i = 0; i < length; i++)
            {
                // print element, space
                Console.Write($"{vectorToPrint[i]} ");
            }
            // go to new line in case printing later to console
            Console.WriteLine();
        }
    }
}