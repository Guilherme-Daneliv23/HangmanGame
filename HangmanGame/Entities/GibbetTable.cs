using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame.Entities
{
    internal class GibbetTable
    {
        public int Lines { get; set; }
        public int Columns { get; set; }

        public string[,] Gibbet { get; private set; }

        public string[] Errors;

        private int[][] ErrorPositions;

        public GibbetTable(int linhas, int colunas)
        {
            Lines = linhas;
            Columns = colunas;
            Gibbet = new string[Lines, Columns];
            Errors = ["O", "|", "/", "\\", "/", "\\"];
            ErrorPositions = new int[][] { new int[] {3, 9} , new int[] {4, 9 }, new int[] {4, 8}, new int[] {4, 10}, new int[] {5, 8}, new int[] {5, 10} };
        }

        public void setInitialGibbet()
        {
            Gibbet[0, 0] = " ";
            Gibbet[0, 1] = "-";
            Gibbet[0, 2] = "-";
            Gibbet[0, 3] = "-";
            Gibbet[0, 4] = "-";
            Gibbet[0, 5] = "-";
            Gibbet[0, 6] = "-";
            Gibbet[0, 7] = "-";
            Gibbet[0, 8] = "-";
            Gibbet[0, 9] = "-";
            Gibbet[0, 10] = " ";

            Gibbet[1, 0] = "|";
            Gibbet[1, 1] = " ";
            Gibbet[1, 2] = " ";
            Gibbet[1, 3] = " ";
            Gibbet[1, 4] = " ";
            Gibbet[1, 5] = " ";
            Gibbet[1, 6] = " ";
            Gibbet[1, 7] = " ";
            Gibbet[1, 8] = " ";
            Gibbet[1, 9] = "|";
            Gibbet[1, 10] = " ";

            Gibbet[2, 0] = "|";
            Gibbet[2, 1] = " ";
            Gibbet[2, 2] = " ";
            Gibbet[2, 3] = " ";
            Gibbet[2, 4] = " ";
            Gibbet[2, 5] = " ";
            Gibbet[2, 6] = " ";
            Gibbet[2, 7] = " ";
            Gibbet[2, 8] = " ";
            Gibbet[2, 9] = "|";
            Gibbet[2, 10] = " ";

            Gibbet[3, 0] = "|";
            Gibbet[3, 1] = " ";
            Gibbet[3, 2] = " ";
            Gibbet[3, 3] = " ";
            Gibbet[3, 4] = " ";
            Gibbet[3, 5] = " ";
            Gibbet[3, 6] = " ";
            Gibbet[3, 7] = " ";
            Gibbet[3, 8] = " ";
            Gibbet[3, 9] = " ";
            Gibbet[3, 10] = " ";

            Gibbet[4, 0] = "|";
            Gibbet[4, 1] = " ";
            Gibbet[4, 2] = " ";
            Gibbet[4, 3] = " ";
            Gibbet[4, 4] = " ";
            Gibbet[4, 5] = " ";
            Gibbet[4, 6] = " ";
            Gibbet[4, 7] = " ";
            Gibbet[4, 8] = " ";
            Gibbet[4, 9] = " ";
            Gibbet[4, 10] = " ";

            Gibbet[5, 0] = "|";
            Gibbet[5, 1] = " ";
            Gibbet[5, 2] = " ";
            Gibbet[5, 3] = " ";
            Gibbet[5, 4] = " ";
            Gibbet[5, 5] = " ";
            Gibbet[5, 6] = " ";
            Gibbet[5, 7] = " ";
            Gibbet[5, 8] = " ";
            Gibbet[5, 9] = " ";
            Gibbet[5, 10] = " ";

            Gibbet[6, 0] = "|";
            Gibbet[6, 1] = " ";
            Gibbet[6, 2] = " ";
            Gibbet[6, 3] = " ";
            Gibbet[6, 4] = " ";
            Gibbet[6, 5] = " ";
            Gibbet[6, 6] = " ";
            Gibbet[6, 7] = " ";
            Gibbet[6, 8] = " ";
            Gibbet[6, 9] = " ";
            Gibbet[6, 10] = " ";

            Gibbet[7, 0] = "|";
            Gibbet[7, 1] = " ";
            Gibbet[7, 2] = " ";
            Gibbet[7, 3] = " ";
            Gibbet[7, 4] = " ";
            Gibbet[7, 5] = " ";
            Gibbet[7, 6] = " ";
            Gibbet[7, 7] = " ";
            Gibbet[7, 8] = " ";
            Gibbet[7, 9] = " ";
            Gibbet[7, 10] = " ";

            Gibbet[8, 0] = "^";
            Gibbet[8, 1] = "^";
            Gibbet[8, 2] = "^";
            Gibbet[8, 3] = "^";
            Gibbet[8, 4] = "^";
            Gibbet[8, 5] = " ";
            Gibbet[8, 6] = " ";
            Gibbet[8, 7] = " ";
            Gibbet[8, 8] = " ";
            Gibbet[8, 9] = " ";
            Gibbet[8, 10] = " ";
        }

        public void setGibbetToError(int numberErrors)
        {
            int eLine = ErrorPositions[numberErrors - 1][0];
            int eColumn = ErrorPositions[numberErrors - 1][1];

            Gibbet[eLine, eColumn] = Errors[numberErrors - 1];
        }
    }
}
