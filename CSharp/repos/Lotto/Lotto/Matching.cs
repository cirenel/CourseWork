using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchingGame
{
    class Matching
    {
        char[,] board;
 
        List<char> symbols;
        Random r; 
        public Matching()
        {
            r = new Random();
            symbols = new List<char>();
            board = new char[4,4]
                   { { ' ',' ',' ',' '},
                     { ' ',' ',' ',' '},
                     { ' ',' ',' ',' '},
                     { ' ',' ',' ',' '} };

            for (int i = 0; i < 8; i++)
            {
                char c = ((char)(r.Next(33, 79)));
                do
                {
                    c = ((char)(r.Next(33, 79)));
                    symbols.Add(c);
                } while (!symbols.Contains(c));

                int x1 = 0;
                int y1 = 0;
                while (board[x1,y1] != ' ') {
                    x1= r.Next(0, 4);
                    y1 = r.Next(0, 4);
                }
                board[x1, y1] = c;

                int x2 = 0;
                int y2 = 0;
                while (board[x2, y2] != ' ')
                {
                    x2 = r.Next(0, 4);
                    y2 = r.Next(0, 4);
                }
                board[x2, y2] = c;

            }

        }

        public char getChar(int x, int y)
        {
            return board[x, y];
        }
        public string showBoard()
        {
            string s = "";
            for(int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++) 
                {
                    s += board[i, j];
                    s += " ";
                }
                s += '\n';
            }
            return s;
        }

    }
}
