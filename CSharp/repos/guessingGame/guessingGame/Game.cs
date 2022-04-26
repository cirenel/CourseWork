using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessingGame
{
    class Game
    {
        public int numGuesses, rangeLo, rangeHi, number;
        Random r;
        public Game(int rL, int rH)
        {
            rangeHi = rH;
            rangeLo = rL;
            r = new Random();
            number = r.Next(rangeLo, rangeHi);
        }

        public bool check(int guess)
        {
            return guess == number;
        }

        public void regen()
        {
            number = r.Next(rangeLo, rangeHi);
        }
    }
}
