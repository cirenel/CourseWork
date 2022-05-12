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
    public partial class GuessingGameForm : Form
    {
        GuessingGame game; 
        public GuessingGameForm()
        {
            InitializeComponent();
            game = new GuessingGame();
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            int guess = int.Parse(guessTextBox.Text);

            bool solved = game.CheckGuess(guess);
            string hint = game.HighLow(guess);
            replyLabel.Text = (!game.isOver()) ?String.Format("Guess again. Your guess is {1}. You have {0} guesses left.", game.GuessesLeft, hint):(game.isLost())?String.Format("You lost. The number was {0}",game.Goal):"You won!";

            if (game.isOver())
            {
                MessageBox.Show("this game is over.");
                //TODO: change the message for if win or if lost 
                //something needs to happen at this point to close the form..... 

            }

        }

      
    }
}
