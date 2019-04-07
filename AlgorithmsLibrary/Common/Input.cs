using System;
using System.Text.RegularExpressions;

/*==========================================================*
*  Common helper methods getting user input from console    *
*===========================================================*/
namespace AlgorithmsLibrary
{
    public static class Input
    {
        /*==========================================================*
        *  Return INTEGER user input from console                   *
        *  Print warning, ask for input again if input not INTEGER  *
        *===========================================================*/
        static public int GetInteger()
        {
            bool inputValid = false;
            int inputInt = 0;

            while (!inputValid)
            {
                Console.Write($"Enter an integer: ");
                string input = Console.ReadLine();

                try
                {
                    int inputParse = int.Parse(input);
                    inputInt = inputParse;
                    inputValid = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine($"'{input}' is not an integer.");
                }
            }
            return inputInt;
        } // DONE


        /*======================================================*
        *  Return non-number CHAR user input from console       *
        *  Print warning, ask for input again if input number   *
        *=======================================================*/
        static public char GetCharNotNumber()
        {
            bool inputValid = false;
            char output = '\0';

            while (!inputValid)
            {
                Console.Write("Enter a letter, punctuation mark, or symbol: ");
                char input = Console.ReadKey().KeyChar;
                Console.Write($"{Environment.NewLine}");

                if (!char.IsNumber(input))
                {
                    inputValid = true;
                    output = input;
                }
                else
                {
                    Console.WriteLine($"'{input}' is not a letter, punctuation mark, or symbol.");
                }
            }
            return output;
        }

        /*==========================================================*
        *  Return letter CHAR user input from console               *
        *  Print warning, ask for input again if input non-letter   *
        *===========================================================*/
        static public char GetLetter()
        {
            bool inputValid = false;
            char output = '\0';

            while (!inputValid)
            {
                Console.Write("Enter a letter: ");
                char input = Console.ReadKey().KeyChar;
                Console.Write($"{Environment.NewLine}");

                if (!char.IsNumber(input) && !char.IsPunctuation(input) && !char.IsSymbol(input))
                {
                    inputValid = true;
                    output = input;
                }
                else
                {
                    Console.WriteLine($"'{input}' is not a letter.");
                }
            }
            return output;
        } // DONE

        /*==============================================================*
        *  Return punctuation CHAR user input from console              *
        *  Print warning, ask for input again if input non-punctuation  *
        *===============================================================*/
        static public char GetPunctuation()
        {
            bool inputValid = false;
            char output = '\0';

            while (!inputValid)
            {
                Console.Write("Enter a punctuation mark: ");
                char input = Console.ReadKey().KeyChar;
                Console.Write($"{Environment.NewLine}");

                if (!char.IsLetter(input) && !char.IsNumber(input) && !char.IsSymbol(input))
                {
                    inputValid = true;
                    output = input;
                }
                else
                {
                    Console.WriteLine($"'{input}' is not a letter or punctuation mark.");
                }
            }
            return output;
        } // DONE

        /*==========================================================*
        *  Return symbol CHAR user input from console               *
        *  Print warning, ask for input again if input non-symbol   *
        *===========================================================*/
        static public char GetSymbol()
        {
            bool inputValid = false;
            char output = '\0';

            while (!inputValid)
            {
                Console.Write("Enter a symbol: ");
                char input = Console.ReadKey().KeyChar;
                Console.Write($"{Environment.NewLine}");

                if (!char.IsLetter(input) && !char.IsNumber(input) && !char.IsPunctuation(input))
                {
                    inputValid = true;
                    output = input;
                }
                else
                {
                    Console.WriteLine($"'{input}' is not a symbol.");
                }
            }
            return output;
        } // DONE


        /*======================================================*
        *  Return STRING user input from console                *
        *  Print warning, ask for input again if input length 0 *
        *=======================================================*/
        static public string GetString()
        {
            bool inputValid = false;
            string output = "";

            while (!inputValid)
            {
                Console.Write($"Enter a string: ");
                string input = Console.ReadLine();
                if (input.Length > 0)
                {
                    output = input;
                    inputValid = true;
                }
                else
                {
                    Console.WriteLine($"'{input}' is not long enough.");
                }
            }
            return output;
        } // DONE

        /*======================================================*
        *  Return copy of STRING of with non-letters removed    *
        *  Remove numbers, punctuation, symbols from STRING     *
        *=======================================================*/
        static public string StringLetters(string word)
        {
            string wordOriginal = word;
            string wordFixed = Regex.Replace(wordOriginal, "[^a-zA-Z ;]", "");
            return wordFixed;
        }

        /*======================================================*
        *  Return copy of STRING of with non-numbers removed    *
        *  Remove letters, punctuation, symbols from STRING     *
        *=======================================================*/
        static public string StringNumbers(string word)
        {
            string wordOriginal = word;

            string wordFixed = Regex.Replace(wordOriginal, "[^0-9;]", string.Empty);

            return wordFixed;
        } // 

        /*======================================================*
        *  Return copy of STRING of with numbers removed        *
        *  Remove numbers from STRING                           *
        *=======================================================*/
        static public string StringLettersPunctuationSymbols(string word)
        {
            string wordOriginal = word;

            string wordFixed = Regex.Replace(wordOriginal, "[0-9;]", "");

            return wordFixed;
        }
    }
}