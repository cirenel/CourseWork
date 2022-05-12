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
    public partial class GameChooser : Form
    {
        int numWins, numLosses; 
        public GameChooser()
        {
            InitializeComponent();
            numLosses = 0;
            lossLabel.Text = numLosses + "";
            numWins = 0;
            winLabel.Text = numWins + "";
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            string selectedGame = gameChoice.SelectedItem.ToString();
            //possible values of selectedGame --> "Tic-Tac-Toe" , "Hangman" or "Guessing Game"

            //TODO: 
            //based on selectedGame's value, create a new form of that type (hint: switch or if) 
            //after the form is closed
            //get if or if not the game was won using the abstract class methods you have implemented 
            //update the win and loss counter labels accordingly 
            //wrap up form usage and free up memory 



        }
    }
}
