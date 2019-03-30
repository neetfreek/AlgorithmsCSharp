using System;
namespace AlgorithmsLibrary
{
    public static class Helper
    {
        private static Random random = new Random();

        // Generate random int between intMin, intMax, inclusive
        public static int RandomInt(int intMin, int intMax)
        {
            int intRandom = random.Next(intMin, intMax);

            return intRandom;
        }

        // print elements' values out to console
        public static void PrintArrayInt(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Element {i} is {array[i]}");
            }
            Console.ReadLine();
        }
    }
}