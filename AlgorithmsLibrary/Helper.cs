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
    }
}