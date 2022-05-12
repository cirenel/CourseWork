using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChooser
{
    abstract class Game 
    {
        protected bool won;

        protected Game()
        {
            won = false; 
        }

        public bool isOver()
        {
            return isWon() || isLost();
        }

        public abstract bool isWon();
        public abstract bool isLost();

        public abstract override string ToString();

    }
}
