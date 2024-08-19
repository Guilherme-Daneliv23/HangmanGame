using System;

namespace HangmanGame.Entities
{

    internal class GameWords
    {
        private string Words = @"C:\Users\User\OneDrive\Área de Trabalho\C#\JogoForca\HangmanGame\palavras.txt";


        public char[] SortWord()
        {
            string tokens = @"C:\Users\User\OneDrive\Área de Trabalho\C#\JogoForca\HangmanGame\palavras.txt";

            using (StreamReader sr = File.OpenText(tokens))
            {
                string[] words = sr.ReadToEnd().Split(';');

                Random random = new Random();

                int randonWord = random.Next(0, words.Length);

                char[] chosenWord = words[randonWord].ToUpper().ToCharArray();


                return chosenWord;
            }

        }
    }
}
