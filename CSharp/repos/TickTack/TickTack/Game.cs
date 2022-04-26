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
            //TODO
            //construct the current player to start at X
            //construct the board to be a 3X3 array of strings 

        }


    public void nextPlayer()
        {
            //TODO
            //change the current play from X to O or from O to X
        }


        public void updateBoard(int i, int j)
        {
            //TODO
            //if the board loaction i-j is free
            //make the value at i-j the current player 
        }

        public bool checkWinState()
        {
            //TODO
            //are there 3 of the current play in a row? return true if so
            //are there 3 of the current player in a col? return true if so
            //are there 3 of the current player on a diag? return true if so
            //return false otherwise 
            return false; 
           }

        //a utility to draw the boardstate 
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
