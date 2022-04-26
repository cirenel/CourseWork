using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace TickTack
{
    class Game
    {
        public string curPlayer;
        public string[,] board; 
        public Game()
        {
            curPlayer = "X";
            board = new string[3, 3];

        }


    public void nextPlayer()
        {
            curPlayer = (curPlayer == "X")? "O" : "X";
            /*
            if(curPlayer == "X")
            {
                curPlayer = "O";
            } else
            {
                curPlayer = "X";
            }*/
        }


        public void updateBoard(int i, int j)
        {
            if (board[i, j] == null)
            {
                board[i, j] = curPlayer;
            } 
        }

        public bool checkWinState()
        {
            bool rowWin = ((board[0, 0] == board[0, 1]) && (board[0, 1] == board[0, 2]) && curPlayer == board[0, 2]) ||
               ((board[1, 0] == board[1, 1]) && (board[1, 1] == board[1, 2]) && curPlayer == board[1,1]) || 
               ((board[2, 0] == board[2, 1]) && (board[2, 1] == board[2, 2]) && curPlayer == board[2,2]);

            bool colWin = ((board[0, 0] == board[1,0]) && (board[1,0] == board[2,0]) && curPlayer == board[0,0]) ||
               ((board[0,1] == board[1, 1]) && (board[1, 1] == board[2,1]) && board[1,1] == curPlayer) ||
               ((board[0,2] == board[1,2]) && (board[1,2] == board[2, 2]) && curPlayer == board[2,2]);

            bool diagWin =  ((board[0, 0] == board[1, 1]) && (board[1, 1] == board[2, 2]) && board[1, 1] == curPlayer) ||
               ((board[2, 0] == board[1, 1]) && (board[1, 1] == board[0,2]) && board[1, 1] == curPlayer);

            bool winState = rowWin || colWin || diagWin;


            return winState; 
        }

        public string getBoard()
        {
            string ret = "";
            ret += (board[0, 0] + " " + board[1,0] + " " + board[2,0] + "\n");
            ret += (board[0,1] + " " + board[1, 1] + " " + board[2,1] + "\n");
            ret += (board[0,2] + " " + board[1,2] + " " + board[2, 2] + "\n");
            return ret; 
        }

    }

}
