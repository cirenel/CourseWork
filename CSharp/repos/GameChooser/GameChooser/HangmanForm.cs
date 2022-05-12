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
    public partial class HangmanForm : Form
    {
        Hangman game;
        List<string> words; 
        public HangmanForm()
        {
            InitializeComponent();

            //TODO: read in from the file words.txt
            //there is one word per line
            //add these words to the words list  
            //select a random word from the list to use in the constructor below
            
            string word = "Apple";
            game = new Hangman(word);
            gameDisplayBox.Text = game.ToString();
            goodGuessedTextBox.Text = game.GetSpacedBlanks();
            badGuessedTextBox.Text = game.GetIncorrectSpaced();
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            string guess = guessTextBox.Text;
            game.CheckLetter(guess);
            gameDisplayBox.Text = game.ToString();
            goodGuessedTextBox.Text = game.GetSpacedBlanks();
            badGuessedTextBox.Text = game.GetIncorrectSpaced();

            if (game.isOver())
            {
                MessageBox.Show("this game is over.");
                //TODO: change the message for if win or if lost 
                //something needs to happen at this point to close the form..... 

            }

        }
    }
}
