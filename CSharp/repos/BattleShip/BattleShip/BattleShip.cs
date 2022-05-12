using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class BattleShip
    {
        BattleShipBoard a, b;
        Tuple<int, int> lastHit;
        int curPlayer;
        Random r;
        public BattleShip()
        {
            a = new BattleShipBoard(true);
            b = new BattleShipBoard(false);

            r = new Random();

            curPlayer = 1;
        }

        public BattleShipBoard getPlayerBoard()
        {
            return a;
        }

        public BattleShipBoard getEnemyBoard()
        {
            return b;
        }


        public bool Attack(int x, int y)
        {
            return b.Attack(x, y);
        }

        public Tuple<int,int,bool> AITurn()
        {
            int x;
            int y;
            if (lastHit != null && r.NextDouble() > 0.4)
            {
                do
                {
                    x = (r.NextDouble() > 0.5) ? lastHit.Item1+r.Next(-1,2):lastHit.Item1;
                    y = (r.NextDouble() < 0.5) ? lastHit.Item2 + r.Next(-1, 2):lastHit.Item2;
                    Console.WriteLine(x + " " + y);
                } while ( !(x >= 0 && y >= 0 && x < 10 && y < 10) || !a.isFree(x, y) );
            }
            else
            {
                do
                {
                    x = r.Next(0, 10);
                    y = r.Next(0, 10);
                    Console.WriteLine(x + " " + y);
                } while (!a.isFree(x, y));
            }
            bool hit = a.Attack(x, y);
            if (hit)
            {
                
                if (a.getShip(x, y).Item1.isSunk)
                {
                    lastHit = null;
                } else
                {
                    lastHit = Tuple.Create(x, y);
                }
            }
            return Tuple.Create(x,y,hit);

        }

        public bool isOver()
        {
            return a.isLost || b.isLost;
        }

        public string getWinner()
        {
            return (a.isLost) ? "Player 2" : "Player 1";
        }

    }
}
