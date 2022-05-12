using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChooser
{
    class GuessingGame : Game
    {

        //attributes 
        private int number, guessCount, lastGuess; 
        
        //properties 
        public int GuessesLeft
        {
            get { return 10 - guessCount; }
        }
        public int Goal
        {
            get { return number; }
        }

        //constructor
        public GuessingGame()
        {
            Random r = new Random();
            number = r.Next(0, 1000);
            guessCount = 0;
            lastGuess = 0;
        }

        //methods 
        public bool CheckGuess(int guess)
        {
            //TODO: make the lastGuess now be this guess

            if(guess == number)
            {
                won = true;
                return true; 
            } else
            {
                guessCount++;
                return false;
            }
        }

        public string HighLow(int guess)
        {
            //TODO: return "high" if the guess is too high. return "low" if the guess is too low
            //this information will be used by the form to display a hint 
            throw new NotImplementedException("WRITE THE IS GUESSING GAME HIGH LOW METHOD"); //delete this line
        }

        public override bool isLost()
        {
            //TODO: if the number of possible guesses is exceeded without a correct guess, return true
            throw new NotImplementedException("WRITE THE IS GUESSING GAME IS LOST METHOD"); //delete this line
        }

        public override bool isWon()
        {
            //TODO: if the number has been correctly geussed, return true 
            throw new NotImplementedException("WRITE THE GUESSING GAME IS WON METHOD"); //delete this line
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
