using System;
using HangmanGame.Entities;
using HangmanGame.GameLogic;

namespace HangmanGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                HangmanMatch hangmanMatch = new HangmanMatch();
                Scream scream = new Scream();
                hangmanMatch.setInitialCorrectWord();
                hangmanMatch.Tab.setInitialGibbet();
                scream.play(hangmanMatch);

                while (!hangmanMatch.EndMatch)
                {
                    try
                    {
                        Console.Write("Send a letter to try complete the word: ");


                        char letter = char.Parse(Console.ReadLine().ToUpper());
                        hangmanMatch.turn(letter);
                        hangmanMatch.verifyTurn();

                        Console.Clear();
                        scream.play(hangmanMatch);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("ERRO: " + ex.Message);
                        Console.ReadKey();
                    }

                }
                hangmanMatch.status();
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: " + e.Message);
            }
            
        }
    }
}