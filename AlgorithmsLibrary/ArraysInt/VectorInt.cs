using System;

namespace AlgorithmsLibrary
{
    public static class VectorInt
    {
        // Return vector with numElements elements
        // Assign elements to random values between eleMin, eleMax inclusive
        public static int[] VectorRandom 
        (int numEles, int eleMin, int eleMax)
        {
            // Declare, initialise vector with default (0) values
            int[] vector = new int[numEles];

            // Iterate elements 
            for (int counter = 0; counter < numEles; counter++)
            {
                // Assign elements
                vector[counter] = Helper.RandomInt(eleMin, eleMax+1);
            }

            return vector;
        }

        // Return true if vector == symmetrical, false if != symmetrical
        // Exclude middle number from check (matches itself, always symmetrical)
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

        // SortInt vector elements into ascending order
        public static void SortSelectionVector(int[] vector)
        {
            int length = vector.Length;

            // Iterate vector columns (elements)
            for (int counter = 0; counter < length; counter++)
            {
                // Iterate columns beyond current column
                for (int counterNext = counter + 1; counterNext < length; counterNext++)
                {
                    // If current column element greater than next
                    if (Helper.GreaterThan(vector[counter], vector[counterNext]))
                    {
                        // Swap with current column element in outer loop
                        HelperSort.Swap(vector, counterNext, counter);
                    }
                }
            }
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