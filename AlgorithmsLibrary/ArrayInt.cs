using System;

namespace AlgorithmsLibrary
{
    public static class ArrayInt
    {
        // Generate new array, elements between eleMin,eleMax, inclusive 
        public static int[] SetupOneDimension(int numEles, int eleMin, int eleMax)
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
    }
}