using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guessingGame
{
    public partial class Form1 : Form
    {
        int guessCount;
        Game g;
        public int lo, hi, numGuess;

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            Settings s = new Settings(lo, hi, numGuess);
            s.ShowDialog();
            lo = s.lo;
            hi = s.hi;
            numGuess = s.guess;
            g.rangeHi = hi;
            g.rangeLo = lo;
            g.numGuesses = numGuess;
            g.regen();
        }

        public Form1()
        {
            InitializeComponent();
            guessCount = 0;
            lo = 0;
            hi = 10;

            g = new Game(lo, hi);
            numGuess = 5; 
        }

        private void buttonGuess_Click(object sender, EventArgs e)
        {
            if (guessCount < numGuess)
            {
                if (guessText.Text != "" && g.check(Convert.ToInt32(guessText.Text)))
                {
                    MessageBox.Show("YAY! you got it!!!");
                }
                else if (guessText.Text != "" && !g.check(Convert.ToInt32(guessText.Text)))
                {
                    MessageBox.Show("Incorrect. try again.");
                    guessText.Text = "";
                    guessCount++;
                }
                else
                {
                    MessageBox.Show("Please enter a number.");
                }
            } else
            {
                MessageBox.Show("You have failed. \n The number was "+g.number);
            }
        }
    }
}
