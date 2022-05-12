using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameChooser
{
    public partial class TicTacToeForm : Form
    {
        TicTacToe game ;
        public TicTacToeForm()
        {
            InitializeComponent();
            game = new TicTacToe();
            gameBoardText.Text = game.ToString();
        }

        private void play_Click(object sender, EventArgs e)
        {
            int col = 0; //TODO: where do we get the value for the col?
            int row = 0; //TODO: where do we get the value for the row?


            if (game.canPlay(col, row))
            {
                game.placeX(col, row);
                gameBoardText.Text = game.ToString();
            } else
            {
                MessageBox.Show("Invalid Move", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            colTextBox.Text = "";
            rowTextBox.Text = "";
            if (game.isOver())
            {
                MessageBox.Show("this game is over.");
                //TODO: change the message for if win or if lost 
                //something needs to happen at this point to close the form..... 

            }

        }
    }
}
