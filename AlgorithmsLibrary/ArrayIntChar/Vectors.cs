using System;

/*======================================================================*
 *  Methods in class overloaded to accept both CHARACTERS and INTEGERS  *
 *======================================================================*/

namespace AlgorithmsLibrary
{
    public static class Vectors
    {
        /*==================================================*
        *  Generate, return vectors.                        *
        *  Vector contains numEles number of elements       *   
        *  Vector's elements between eleMin, Max, inclusive *
        *  Character vectors return letters A-Z             *
        *===================================================*/
        public static int[] VectorRandom (int numEles, int eleMin, int eleMax)
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
        public static char[] VectorRandom(int numEles, char eleMin, char eleMax)
        {
            // Declare, initialise vector with default (0) values
            char[] vector = new char[numEles];

            // Ensure min, max elements correctly given
            if (eleMin > eleMax)
            {
                Console.WriteLine("Aborting: minimum element exceeds maximum element.");
                return vector;
            }

            // Iterate elements 
            for (int counter = 0; counter < numEles; counter++)
            {
                // Assign elements                
                vector[counter] = Helper.RandomLetter(eleMin, eleMax);
            }

            return vector;
        }

        /*==================================================================*
        *  Return whether vector is symmetrical                             *
        *  Middle elements are excluded from check as always equals itself  *
        *===================================================================*/
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
        public static bool IsSymmetrical(char[] array)
        {
            bool isSymmetrical = false;
            int length = array.Length;

            // Iterate half elements
            for (int counter = 0; counter < length / 2; counter++)
            {
                if (array[counter] != array[length - 1 - counter])
                {
                    return isSymmetrical;
                }
            }
            isSymmetrical = true;

            return isSymmetrical;
        }

        /*==========================*
        *  Print vector to console  *
        *===========================*/
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
        public static void PrintVector(char[] vectorToPrint)
        {
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
}