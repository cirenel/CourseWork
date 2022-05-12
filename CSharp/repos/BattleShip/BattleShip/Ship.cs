using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    public class Ship
    {
        int length;
        bool vert, sunk;
        bool[] hits; 
        int xPos, yPos; //topmost, leftmost position 

        public bool isSunk
        {
            get { return sunk; }
        }
        
        public int Top
        {
            get { return yPos; }
        }
        public int Left
        {
            get { return xPos; }
        }

        public bool Vertical
        {
            get { return vert; }
        }

        public int Length
        {
            get { return length; }
        }

        public Ship(int l, int x, int y, bool v)
        {
            vert = v; 
            length = l;
            hits = new bool[length];
            while(!vert && x+length > 10)
            {
                x -= 1;
            } 
            while(vert && y+length > 10)
            {
                y -= 1;
            }
            xPos = x;
            yPos = y;
            sunk = false; 
        }

        public void hit(int val)
        {
            hits[val] = true;
            sunk = true;
            foreach (bool b in hits)
            {
                if (!b)
                {
                    sunk = false;
                }
            }
        }
    }
}
