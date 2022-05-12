using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChooser
{
    class Hangman : Game
    {
        //attributes 
        private int numGuesses;
        private string word, blanks, incorrect; 
        //properties 

        //constructor
        public Hangman(string w)
        {
            word = w.ToUpper();
            incorrect = "";
            blanks = "";
            for (int i = 0; i < word.Length; i++)
            {
                blanks += "_";
            }
            numGuesses = 0;

        }
        //methods 
        public string GetSpacedBlanks()
        {
            string ret = "";
            for (int i = 0; i < blanks.Length; i++)
            {
                ret += blanks[i] + " ";
            }
            return ret;
        }

        public string GetIncorrectSpaced()
        {
            string ret = "";
            for (int i = 0; i < incorrect.Length; i++)
            {
                ret += incorrect[i] + " ";
            }
            return ret;
        }

        public bool CheckLetter(string letter)
        {
            letter = letter.ToUpper();
            if (letter.Equals("") || letter.Equals(" ") || incorrect.Contains(letter) || blanks.Contains(letter))
            {
                return false;
            }

            if (word.Contains(letter) && !blanks.Contains(letter))
            {
                string newBlank = "";
                for (int i = 0; i < word.Length; i++)
                {
                    int index = word.Substring(i).IndexOf(letter) + i;
                    if (index == i)
                    {
                        newBlank += letter;
                    }
                    else
                    {
                        newBlank += blanks[i];
                    }
                }
                blanks = newBlank;
            }

            else
            {
                incorrect += letter + " ";
                numGuesses++;
            }
            return true;
        }
        public override bool isLost()
        {
            //TODO: if the number of guesses has exceeded that which is allowed, return true
            //otherwise return false 
            throw new NotImplementedException("WRITE THE HANGMAN IS LOST METHOD");
        }

        

        public override bool isWon()
        {
            //TODO: if the guessed word builder has completed and is the goal word, return true
            //otherwise return false 
            throw new NotImplementedException("WRITE THE HANGMAN IS WON METHOD");
        }

        public override string ToString()
        {
            string ret = "\n";
            if (!isOver())
            {
                
                ret += "   ___________\n";
                ret += "  |   _______|\n";
                ret += "  |  |//    |\n";
                ret += "  |  |/     |\n";
                ret += "  |  |      " + ((numGuesses >= 1) ? "O" : "") + " \n";
                ret += "  |  |     " + ((numGuesses >= 3) ? "/" : " ") + "" + ((numGuesses >= 2) ? "H" : "") + "" + ((numGuesses >= 4) ? "\\" : " ") + "\n";
                ret += "  |  |     " + ((numGuesses >= 5) ? "/" : " ") + " " + ((numGuesses >= 6) ? "\\" : " ") + "\n";
                ret += "  TTTTTTTTTTTTTTT\n";
                ret += "  |||||||||||||||\n";


            }
            else if (isWon())
            {
                ret += "   ___________\n";
                ret += "  |   _______|\n";
                ret += "  |  |//    |\n";
                ret += "  |  |/      \n";
                ret += "  |  |      O/\n";
                ret += "  |  |     /H \n";
                ret += "  |  |     / \\\n";
                ret += "  TTTTTTTTTTTTTTT\n";
                ret += "  |||||||||||||||\n";
            }
            else if (isLost())
            {
                ret += "   ___________\n";
                ret += "  |   _______|\n";
                ret += "  |  |//    |\n";
                ret += "  |  |/     |\n";
                ret += "  |  |      |\n";
                ret += "  |  |      O\n";
                ret += "  |  |     /H\\\n";
                ret += "  TTTTTTT   M  TT\n";
                ret += "  |||||||      ||\n";

            }
            return ret + "\n\n";
        }
    }
    
}
