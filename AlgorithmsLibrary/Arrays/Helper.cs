using System;
using System.Text;

namespace AlgorithmsLibrary
{
    public static class Helper
    {
        private static Random random = new Random();

        // Return specifiednumber of blank spaces (" ")
        public static string Padding(int numSpaces)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int counter = 0; counter < numSpaces; counter++)
            {
                stringBuilder.Append(" ");
            }

            string gapAlignment = stringBuilder.ToString();

            return gapAlignment;
        }

        // Return random int between intMin, intMax inclusive
        public static int RandomInt(int intMin, int intMax)
        {
            int intRandom = random.Next(intMin, intMax);

            return intRandom;
        }

        // Return number of digits in integer
        public static int DigitsInInt(int intToCount)
        {
            int numCharsInInt = intToCount.ToString().Length;
            return numCharsInInt;
        }
    }
}