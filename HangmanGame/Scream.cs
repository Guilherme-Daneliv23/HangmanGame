using HangmanGame.Entities;
using HangmanGame.GameLogic;
using System.Runtime.InteropServices;


namespace HangmanGame
{
    internal class Scream
    {
        public void play(HangmanMatch hangmanMatch)
        {

            printTable(hangmanMatch);

            printCorrectWord(hangmanMatch);

            printUnAndAvaliableLetters(hangmanMatch);

            Console.WriteLine();

        }
        private static void printTable(HangmanMatch hangmanMatch)
        {

            for (int i = 0; i < hangmanMatch.Tab.Lines; i++)
            {
                for (int j = 0; j < hangmanMatch.Tab.Columns; j++)
                {
                    Console.Write(hangmanMatch.Tab.Gibbet[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

        }

        private static void printCorrectWord(HangmanMatch hangmanMatch)
        {
            for(int i = 0; i < hangmanMatch.CorrectWords.Count; i++)
            {
                Console.Write(" " + hangmanMatch.CorrectWords[i] + "  ");
            }
            Console.WriteLine();
            for (int i = 0; i < hangmanMatch.CorrectWords.Count; i++)
            {
                Console.Write("--- ");
            }
            Console.WriteLine();
            Console.WriteLine();

        }

        private static void printUnAndAvaliableLetters(HangmanMatch hangmanMatch)
        {
            Console.Write("Unavliable letters: [ ");

            for(int i = 0; i < hangmanMatch.UnavaliableLetters.Count; i++)
            {
                Console.Write(hangmanMatch.UnavaliableLetters[i] + ", ");
            }
            Console.WriteLine(" ]");
            Console.WriteLine();
            Console.Write("Avaliable letters: [ ");
            for (int i = 0; i < hangmanMatch.AvaliableLetters.Count; i++)
            {
                Console.Write(hangmanMatch.AvaliableLetters[i] + ", ");
            }
            Console.WriteLine(" ]");
            Console.WriteLine();
        }

    }
}
