using System;
using AlgorithmsLibrary;

/*==========================================================*
 *  Client class for AlgorithmsLibrary.                     *
 *  Contains methods for quick testing of different classes *
 *==========================================================*/
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        // Shape tests
        private static void TestVectorRandom()
        {
            Console.WriteLine("=== RANDOM VECTOR INT ===");
            int[] testVectorInt = Vectors.VectorRandom(10, 0, 100);
            Vectors.PrintVector(testVectorInt);

            Console.WriteLine($"{Environment.NewLine}=== RANDOM VECTOR LETTER ===");
            char[] testVectorChar = Vectors.VectorRandom(20, 'a', 'p');
            Vectors.PrintVector(testVectorChar);
        }

        private static void TestMatrixRandom()
        {
            Console.WriteLine("=== RANDOM MATRIX ===");
            int[,] testMatrix = Matrices.MatrixRandom(5, 5, 0, 100);
            Matrices.PrintMatrix(testMatrix);

            Console.WriteLine($"{Environment.NewLine}=== RANDOM MATRIX CHAR ===");
            char[,] testMatrixChar = Matrices.MatrixRandom(5, 5, 'a', 'z');
            Matrices.PrintMatrix(testMatrixChar);
        }

        private static void TestMaximalSubMatrix()
        {
            Console.WriteLine("=== MATRIX ===");
            int[,] testMatrix = Matrices.MatrixRandom(30, 30, 0, 1000);
            Matrices.PrintMatrix(testMatrix);

            Console.WriteLine($"{Environment.NewLine}=== MAXIMAL SUB-MATRIX ===");
            int[,] maximalMatrix = Matrices.MaximalSubMatrix(testMatrix, 2, 2);
            Matrices.PrintMatrix(maximalMatrix);

            Console.WriteLine($"{Environment.NewLine}Maximal matrix value = {Matrices.SumMatrixIntElements(maximalMatrix)}");
        }

        private static void TestPascalsTriangle()
        {
            Console.WriteLine("=== PASCAL'S TRIANGLE ===");
            int[][] testPascalsTriangle = ArrayJaggedInt.PascalsTriangle(20);
            ArrayJaggedInt.PrintTriangle(testPascalsTriangle);
            int maxElement = ArrayJaggedInt.MaxElementArrayOfArrays(testPascalsTriangle);

            Console.WriteLine($"{Environment.NewLine}Maximal value: { maxElement}");
        }


        // Manipulation tests
        private static void TestRotateMatrix()
        {
            Console.WriteLine("=== MATRIX INTEGER ===");
            int[,] testMatrix = Matrices.MatrixRandom(7,7, 1, 100);
            Matrices.PrintMatrix(testMatrix);
            Console.WriteLine($"{Environment.NewLine}=== COUNTER-CLOCKWISE ROTATED MATRIX INTEGER ===");
            int[,] testMatrixRotatedLeft = Matrices.RotateSquare(testMatrix, 0);
            Matrices.PrintMatrix(testMatrixRotatedLeft);
            Console.WriteLine($"{Environment.NewLine}=== CLOCKWISE ROTATED MATRIX INTEGER ===");
            int[,] testMatrixRotatedRight = Matrices.RotateSquare(testMatrix, 1);
            Matrices.PrintMatrix(testMatrixRotatedRight);

            Console.WriteLine($"{Environment.NewLine} === MATRIX CHARACTER ===");
            char[,] testMatrixChar = Matrices.MatrixRandom(7, 7, 'a', 'z');
            Matrices.PrintMatrix(testMatrixChar);

            Console.WriteLine($"{Environment.NewLine}=== COUNTER-CLOCKWISE ROTATED MATRIX CHARACTER ===");
            char[,] testMatrixCharLeft = Matrices.RotateSquare(testMatrixChar, 0);
            Matrices.PrintMatrix(testMatrixCharLeft);

            Console.WriteLine($"{Environment.NewLine}=== CLOCKWISE ROTATED MATRIX CHARACTER ===");
            char[,] testMatrixCharRight = Matrices.RotateSquare(testMatrixChar, 1);
            Matrices.PrintMatrix(testMatrixCharRight);
        }


        // SortCharInt tests
        private static void TestSortSelectionVector()
        {
            Console.WriteLine("=== VECTOR INTEGER===");
            int[] testVectorInt = Vectors.VectorRandom(25, 0, 1000);
            Vectors.PrintVector(testVectorInt);
            SortCharInt.SortSelectionVector(testVectorInt);
            Console.WriteLine($"{Environment.NewLine}=== SORTED VECTOR INTEGER ===");
            Vectors.PrintVector(testVectorInt);

            Console.WriteLine($"{Environment.NewLine}=== VECTOR CHARACTER===");
            char[] testVectorChar = Vectors.VectorRandom(25, 'a', 'z');
            Vectors.PrintVector(testVectorChar);
            SortCharInt.SortSelectionVector(testVectorChar);
            Console.WriteLine($"{Environment.NewLine}=== SORTED VECTOR CHARACTER ===");
            Vectors.PrintVector(testVectorChar);
        }

        private static void TestSortSelectionMatrix()
        {
            Console.WriteLine("=== MATRIX INTEGER ===");
            int[,] testMatrix = Matrices.MatrixRandom(5, 5, 0, 100);
            Matrices.PrintMatrix(testMatrix);
            Console.WriteLine($"{Environment.NewLine}=== SELECTION-SORTED MATRIX INTEGER ===");
            SortCharInt.SortSelectionMatrix(testMatrix);
            Matrices.PrintMatrix(testMatrix);

            Console.WriteLine($"{Environment.NewLine}=== MATRIX INTEGER ===");
            char[,] testMatrixChars = Matrices.MatrixRandom(5, 5, 'a', 'z');
            Matrices.PrintMatrix(testMatrixChars);
            Console.WriteLine($"{Environment.NewLine}=== SELECTION-SORTED MATRIX INTEGER ===");
            SortCharInt.SortSelectionMatrix(testMatrixChars);
            Matrices.PrintMatrix(testMatrixChars);
        }

        private static void TestSortSelectionMatrixRows()
        {
            Console.WriteLine("=== MATRIX INTEGER ===");
            int[,] testMatrix = Matrices.MatrixRandom(5, 5, 0, 1000);
            Matrices.PrintMatrix(testMatrix);
            SortCharInt.SortSelectionMatrixRows(testMatrix);
            Console.WriteLine($"{Environment.NewLine}=== SELECTION-SORTED (ROWS) MATRIX INTEGER ===");
            Matrices.PrintMatrix(testMatrix);

            Console.WriteLine($"{Environment.NewLine}=== MATRIX CHARACTER ===");
            char[,] testMatrixChar = Matrices.MatrixRandom(5, 5, 'a', 'z');
            Matrices.PrintMatrix(testMatrixChar);
            SortCharInt.SortSelectionMatrixRows(testMatrixChar);
            Console.WriteLine($"{Environment.NewLine}=== SELECTION-SORTED (ROWS) MATRIX CHARACTER ===");
            Matrices.PrintMatrix(testMatrixChar);
        }

        // User console input tests
        private static void TestUserConsoleInput()
        {
            Console.WriteLine("=== STRING INPUT, STRIPPING ===");
            string a = Input.GetString();
            string b = Input.StringLetters(a);
            string c = Input.StringNumbers(a);
            string d = Input.StringLettersPunctuationSymbols(a);
            Console.WriteLine($"String: {a}");
            Console.WriteLine($"Letters: {b}");
            Console.WriteLine($"Numbers: {c}");
            Console.WriteLine($"Letters, punctuation, symbols: {d}");

            Console.WriteLine("=== INTEGER INPUT ===");
            int e = Input.GetInteger();
            Console.WriteLine($"Integer: {e}");

            Console.WriteLine("=== CHARACTER INPUT ===");
            char f = Input.GetCharNotNumber();
            Console.WriteLine($"Non-number character: {f}");
            char g = Input.GetLetter();
            Console.WriteLine($"Letter: {g}");
            char h = Input.GetPunctuation();
            Console.WriteLine($"punctuation mark: {h}");
            char i = Input.GetSymbol();
            Console.WriteLine($"Symobl: {i}");
        }
    }
}