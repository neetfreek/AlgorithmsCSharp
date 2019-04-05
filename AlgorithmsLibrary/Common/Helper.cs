using System;
using System.Text;

namespace AlgorithmsLibrary
{
    public static class Helper
    {
        private static Random random = new Random();

        // Returns whether first > second
        public static bool GreaterThan(int first, int second)
        {
            return first.CompareTo(second) > 0;
        }

        // Return number of digits in integer
        public static int DigitsInInt(int intToCount)
        {
            int numCharsInInt = intToCount.ToString().Length;
            return numCharsInInt;
        }

        // Return random int between intMin, intMax inclusive
        public static int RandomInt(int intMin, int intMax)
        {
            int intRandom = random.Next(intMin, intMax);

            return intRandom;
        }

        // Return random letter between intMin, intMax inclusive
        public static char RandomLetter(char min, char max)
        {
            char minFixed = char.ToUpper(min);
            char maxFixed = char.ToUpper(max);
            string charSetTotal = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int indexStart = charSetTotal.IndexOf(minFixed);
            int indexEnd = charSetTotal.IndexOf(maxFixed);

            if (indexStart == -1 | indexEnd == -1)
            {
                Console.WriteLine("Aborting. Entered character(s) not letters.");
                return ('\0');
            }
            string charSet = charSetTotal.Substring(indexStart, indexEnd);
            char charToInsert = charSet[RandomInt(0, charSet.Length)];             

            return charToInsert;
        }

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
    }
}