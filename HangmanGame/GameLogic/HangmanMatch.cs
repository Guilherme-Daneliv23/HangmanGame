using HangmanGame.Entities;

namespace HangmanGame.GameLogic
{
    internal class HangmanMatch
    {
        public GibbetTable Tab { get; set; }
        public GameWords Words { get; set; }
        public char[] SortedWord { get; set; }
        public List<char> AvaliableLetters { get; set; }
        public List<char> UnavaliableLetters { get; set; }
        private List<char> CorrectWord { get; set; }
        private int NErrors { get; set; }
        public bool EndMatch { get; set; }
        private bool WinStatus { get; set; }

        public HangmanMatch()
        {
            Tab = new GibbetTable(9, 11);
            Words = new GameWords();
            SortedWord = Words.SortWord();
            AvaliableLetters = ['A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
    'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'];
            UnavaliableLetters = new List<char>();
            CorrectWord = null;
            NErrors = 0;
            EndMatch = false;
            WinStatus = false;
        }

        public void turn(char letter)
        {


            if (letter >= 'A' && letter <= 'Z')
            {
                bool contain = false;
                for (int i = 0; i < SortedWord.Length; i++)
                {

                    if (letter == SortedWord[i].RemoveAssent())
                    {
                        CorrectWord[i] = SortedWord[i];
                        contain = true;

                    }
                    if (AvaliableLetters.Contains(letter))
                    {
                        AvaliableLetters.Remove(letter);
                    }
                    if (!UnavaliableLetters.Contains(letter))
                    {
                        UnavaliableLetters.Add(letter);
                    }

                }

                if (!contain)
                {
                    NErrors++;
                }
            }
            else
            {
                throw new ArgumentException("You can send only letters!");
            }
        }

        private void setInitialCorrectWord()
        {
            if (CorrectWord == null)
            {
                CorrectWord = new List<char>();
                for (int i = 0; i < SortedWord.Length; i++)
                {
                    CorrectWord.Add('?');
                }
            }
        }

        public void verifyTurn()
        {
            if (NErrors > 0)
            {
                Tab.setGibbetToError(NErrors);
            }

            if (NErrors == Tab.Errors.Length)
            {
                EndMatch = true;

            }

            if (SortedWord.CompareCharArrayWithList(CorrectWord))
            {
                EndMatch = true;
                WinStatus = true;
            }
        }

        public void status()
        {
            if(WinStatus)
            {
                Console.WriteLine("Você ganhou! Parabéns");
            } else
            {
                Console.WriteLine("Você Perdeu!");
                Console.Write("A palavra era: ");
                for (int i = 0; i < SortedWord.Length; i++)
                {
                    Console.Write(SortedWord[i]);
                }
            }
        }
    }
}
