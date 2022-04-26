using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TickTack
{
    public partial class TicTak : Form
    {

        Button[,] clickedG ;
        Game gameBoard;
        int buttonCount, xWin, oWin;
        public TicTak()
        {
            InitializeComponent();
            gameBoard = new Game();
            curTurn.Text = gameBoard.curPlayer;
            Button[,] clicked = { { button11, button12, button13 }, 
                                   { button21, button22, button23 }, 
                                    { button31, button32, button33 } };
            clickedG = clicked;
            buttonCount = 0;
            xWin = 0;
            oWin = 0;


        }

        private void Reset()
        {
            gameBoard = new Game();
            curTurn.Text = gameBoard.curPlayer;
            Button[,] clicked = { { button11, button12, button13 },
                                   { button21, button22, button23 },
                                    { button31, button32, button33 } };
            clickedG = clicked;
            buttonCount = 0;

            for (int i = 0; i < clickedG.GetLength(0); i++)
            {
                for (int j = 0; j < clickedG.GetLength(1); j++)
                {
                    ResetButton(clickedG[i, j]);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void curTurn_Click(object sender, EventArgs e)
        {

        }

        private void ResetButton(Button b)
        {
            b.Text = "";
            b.Enabled = true;
        }

        private void button_Click(object sender, EventArgs e)
        {
            buttonCount++;
            Button b = ((Button)sender);
            b.Text = gameBoard.curPlayer;
            b.Enabled = false;
            int row=0, col = 0;
            for(int i = 0; i < clickedG.GetLength(0); i++)
            {
                for(int j = 0; j < clickedG.GetLength(1); j++)
                {
                    if (b == clickedG[i,j])
                    {
                        row = j;
                        col = i;
                        break; 
                    }
                }
            }
            gameBoard.updateBoard(row, col);
            if (gameBoard.checkWinState())
            {
                if(gameBoard.curPlayer == "X")
                {
                    xWin++;
                    xWinTxt.Text = xWin.ToString();
                }
                else
                {
                    oWin++;
                    oWinText.Text = oWin.ToString();
                }
               if(System.Windows.Forms.DialogResult.Yes == MessageBox.Show("congrats " + gameBoard.curPlayer + "!\nYou have won!! \nPlay again?", "Game Over", MessageBoxButtons.YesNo))
               {
                    Reset();
                } 
                else
                {
                    this.Close();                
                }
            }else if (buttonCount == 9)
            {
                if (System.Windows.Forms.DialogResult.Yes == MessageBox.Show("Stalemate! \nPlay again?", "Game Over", MessageBoxButtons.YesNo))
                {
                    Reset();
                } 
                else
                {
                    this.Close();
                }
            }
            else
            {
                gameBoard.nextPlayer();
                curTurn.Text = gameBoard.curPlayer;
            }
        }

        
    }
}
