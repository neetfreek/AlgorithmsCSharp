using System;

namespace AlgorithmsLibrary
{
    public class ArrayInt
    {
        // Generate new array, elements between eleMin,eleMax, inclusive 
        public int[] SetupOneDimension(int numEles, int eleMin, int eleMax)
        {
            // Instantiate helper class to generate random int values
            Helper helper = new Helper();

            // Initialise and declare array
            int[] array = new int[numEles];

            // Initialise elements of array
            for (int counter = 0; counter < numEles; counter++)
            {
                array[counter] = helper.RandomInt(eleMin, eleMax);
            }
            return array;
        }
    }
}