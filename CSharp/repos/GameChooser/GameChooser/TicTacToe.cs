using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChooser
{
    //TODO: complete this class
    //iswon and islost methods need to be completed 
    //the canplay method needs to be completed 
    class TicTacToe : Game
    {
        //attributes 
        string[,] board;
        Random AI; 
        //properties 

        //constructor
        public TicTacToe()
        {
            board = new string[3,3];
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++) {
                    board[i, j] = " ";
                    }
            }
            AI = new Random();
        }
        //methods 

        public bool canPlay(int y, int x)
        {

            //TODO: this method needs to check if a move is valid
            //if the x, y space is clear on the board, return true
            //else return false 
            throw new NotImplementedException("WRITE THE TIC TAC TOE CAN PLAY METHOD"); //delete this line
        }

        public void placeX(int y, int x)
        {
            board[x, y] = "X";
            if (!base.isOver())
            {
                placeO();
            }
        }

        public void placeO()
        {
            int x;
            int y;
            do
            {
                 x = AI.Next(3);
                 y = AI.Next(3);
            } while (!canPlay(y,x));
            board[x,y] = "O";
        }

        public override bool isLost()
        {
            //TODO: replace this throw with code to check is the O has won
            //return true if O wins. false if there is no winner/X wins  
            throw new NotImplementedException("WRITE THE TIC TAC TOE IS LOST METHOD"); //delete this line
        }

        public override bool isWon()
        {
            //TODO: replace this throw with code to check if the X has won
            //return true if X wins, false if there is no winner/O wins
            throw new NotImplementedException("WRITE THE TIC TAC TOE IS WON METHOD"); //delete this line
        }

        public override string ToString()
        {
            string ret = "\n";

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    ret += "  " + board[i, j] + "  ";
                    ret += (j<2) ?"|":"";
                }
                ret += (i<2)? "\n----------------\n":"\n";
            }

            return ret; 
        }
    }
}
