using System;

namespace AlgorithmsLibrary
{
    public static class VectorInt
    {
        // Return vector with numElements elements
        // Initialise elements to random values between eleMin, eleMax inclusive
        public static int[] VectorRandom 
        (int numEles, int eleMin, int eleMax)
        {
            // Declare vector
            int[] vector = new int[numEles];

            // Iterate elements 
            for (int counter = 0; counter < numEles; counter++)
            {
                // Initialise elements
                vector[counter] = Helper.RandomInt(eleMin, eleMax+1);
            }

            return vector;
        }

        // Return true if vector == symmetrical, false if != symmetrical
        // Exclude middle number from check (matches itself, alwasy symmetrical)
        public static bool IsSymmetrical(int[] array)
        {
            bool isSymmetrical = false;
            int length = array.Length;

            // Iterate half elements
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

        // Print vector
        public static void PrintVector(int[] vectorToPrint)
        {
            int length = vectorToPrint.Length;

            // Iterate elements
            for (int i = 0; i < length; i++)
            {
                // Print element with space
                Console.Write($"{vectorToPrint[i]} ");
            }
            // 
            Console.Write(Environment.NewLine);
        }
    }
}