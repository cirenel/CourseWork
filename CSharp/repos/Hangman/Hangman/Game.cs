using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman
{
    class Game
    {
        private string word, blanks, incorrect;
        private int numGuesses; 
        
        public int NumGuesses
        {
            get { return numGuesses; }
        }
        public string Word
        {
            get { return word; }
        }

        public Game(string w)
        {
            word = w.ToUpper();
            incorrect = "";
            blanks = "";
            for (int i = 0; i < word.Length; i++) {
                blanks += "_";
            }
            numGuesses = 0;
            
        }

        public void Guess(char letter)
        {
            Console.Clear();
            letter = letter.ToString().ToUpper().ToCharArray()[0];
            if (word.Contains(letter) && !blanks.Contains(letter))
            {
                string newBlank = "";
                for(int i = 0; i < word.Length; i++)
                {
                    int index = word.Substring(i).IndexOf(letter)+i ;
                  //  Console.WriteLine("INDEX: {0} \nI:{1}", index, i);
                    if (index == i)
                    {
                        newBlank += letter; 
                    } else
                    {
                        newBlank += blanks[i];
                    }
                }
                blanks = newBlank;
            } else if (incorrect.Contains(letter) || blanks.Contains(letter))
            {
                Console.WriteLine("You have already guessed this letter. ");
            } else 
            {
                incorrect += letter + " ";
                numGuesses++;
            }
        }

        public bool Over()
        {
            return Won() || Lost();
        }

        public bool Won()
        {
            return blanks.Equals(word);
        }
        public bool Lost()
        {
            return numGuesses == 7;
        }

        public override string ToString()
        {
            Math.Floor(9.3);
            string ret = "\n";
            if (!Over())
            {
                //draw man 
                ret += " ___________\n";
                ret += "|   _______|\n";
                ret += "|  |//    |\n";
                ret += "|  |/     |\n";
                ret += "|  |      " + ((numGuesses >= 1) ? "O" : "") + " \n";
                ret += "|  |     " + ((numGuesses >= 3) ? "/" : " ") + "" + ((numGuesses >= 2) ? "H" : "") + "" + ((numGuesses >= 4) ? "\\" : " ") + "\n";
                ret += "|  |     " + ((numGuesses >= 5) ? "/" : " ") + " " + ((numGuesses >= 6) ? "\\" : " ") + "\n";
                ret += "TTTTTTTTTTTTTTT\n";
                ret += "|||||||||||||||\n";
                

                //add blanks
                ret += "Guess:";
                for (int i = 0; i < blanks.Length; i++)
                {
                    ret += blanks[i] + " ";
                }
                ret += "\n";

                //show bad guesses
                ret += "Incorrect: " + incorrect;
            } else if (Won()){
                ret += " ___________\n";
                ret += "|   _______|\n";
                ret += "|  |//    |\n";
                ret += "|  |/      \n";
                ret += "|  |      O/\n";
                ret += "|  |     /H \n";
                ret += "|  |     / \\\n";
                ret += "TTTTTTTTTTTTTTT\n";
                ret += "|||||||||||||||\n";
            } else if (Lost())
            {
                ret += " ___________\n";
                ret += "|   _______|\n";
                ret += "|  |//    |\n";
                ret += "|  |/     |\n";
                ret += "|  |      |\n";
                ret += "|  |      O\n";
                ret += "|  |     /H\\\n";
                ret += "TTTTTTT   M  TT\n";
                ret += "|||||||      ||\n";
                
            }
            return ret+"\n\n"; 
        }

        


    }
}
