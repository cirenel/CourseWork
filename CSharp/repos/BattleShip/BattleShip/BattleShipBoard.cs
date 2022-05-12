using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleShip
{
    class BattleShipBoard
    {
        bool[,] board, incAttacks;
        Ship[] ships;
        Random r;
        int lostShips;
        bool gameLost; 

        public bool isLost
        {
            get { return gameLost; }
        }


        public bool[,] Board
        {
            get { return board; }
        }

        public BattleShipBoard(bool human)
        {
            r = new Random();
            //int[] shipLength = { 6, 5, 4, 3, 2 };
            int[] shipLength = { 6, 5 };
            board = new bool[10, 10];
            incAttacks = new bool[10, 10];
            ships = new Ship[shipLength.Length];
            lostShips = 0;

            if (human)
            {
                for (int i = 0; i < shipLength.Length; i++)
                {
                    PlaceShip ps = new PlaceShip(shipLength[i]);
                    Ship s;
                    do
                    {
                        // MessageBox.Show("DO");

                        ps.ShowDialog();
                        s = ps.GetShip;
                        if (canPlace(s))
                        {
                            ships[i] = s;
                            ps.Dispose();
                        }
                    } while (!canPlace(s));

                    Place(s);
                }
            } else
            {
                for (int i = 0; i < shipLength.Length; i++)
                {
                    Ship s;
                    do
                    {
                      int x = r.Next(0, 10);
                      int y = r.Next(0, 10);
                      bool b = (r.NextDouble() > 0.5) ? true : false;
                        s = new Ship(shipLength[i],x,y,b) ;
                    
                        if (canPlace(s))
                        {
                            ships[i] = s;
                        }
                    } while (!canPlace(s));

                    Place(s);
                }
            }
        }

        private void Place(Ship s)
        {
            int count = 0;
            while (count < s.Length)
            {
                if (s.Vertical)
                {
                    board[s.Left + count, s.Top] = true;

                }
                else //if (!s.Vertical)
                {
                    board[s.Left, s.Top + count] = true;
                }
                count++;
            }
        }
        private bool canPlace(Ship s)
        {
            if (s.Left + s.Length >= 10 && s.Vertical)
            {
                return false;
            }
            else if (s.Top + s.Length >= 10 && !s.Vertical)
            {
                return false;
            }

            int count = 0;
            while (count < s.Length)
            {
                if (s.Vertical && board[s.Left + count, s.Top])
                {
                    return false;
                }
                else if (!s.Vertical && board[s.Left, s.Top + count])
                {
                    return false;
                }
                count++;
            }

            return true;
        }

        public bool Attack(int x, int y)
        {
            if (containsShip(x, y) && !incAttacks[x,y])
            {
                incAttacks[x, y] = true;
                //find this ship
                Tuple<Ship,int> t = getShip(x, y);
                Ship s = t.Item1;
                s.hit(t.Item2);
                //sink counter up
                if (s.isSunk)
                {
                    lostShips++;
                    if(lostShips >= ships.Length)
                    {
                        gameLost = true;
                    }
                }

                return true; 
            }
            return false; 
        }

        public Tuple<Ship,int> getShip (int x, int y)
        {
            Ship ss = null;
            int count = 0;
            foreach( Ship s in ships )
            {
                count = 0;
                while (count < s.Length)
                {
                    if (s.Vertical && (s.Left + count == x) && (s.Top == y))
                    {
                        ss = s;
                        break;
                    }
                    else if (!s.Vertical && (s.Left == x) && (s.Top + count == y))
                    {
                        ss = s;
                        break;
                    }
                    count++;
                }
                if (ss != null)
                {
                    break;
                }

            }
            return Tuple.Create(ss,count); 
        }

        public bool containsShip(int x, int y)
        {
            return board[x, y];
        }

        public bool isFree(int x, int y)
        {
            return !incAttacks[x, y];
        }

    }
}
