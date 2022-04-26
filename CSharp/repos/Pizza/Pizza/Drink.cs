using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOrder
{
    public class Drink:Item
    {
        private int size;
        private string type;
        private bool ice; 

        public bool Ice
        {
            set { ice = value; }
            get { return ice;  }
        }

        public Drink(int s, string t)
        {
            size = s;
            type = t;
            computePrice();
        }

        public override void computePrice()
        {
            switch (size)
            {
                case 10:
                    price = 0.5;
                    break;
                case 12:
                    price = 1.00;
                    break;
                case 16:
                    price = 1.50;
                    break;
                case 20:
                    price = 2.50;
                    break;
            }
        }

        public override string ToString()
        {
            string ret = String.Format("{0:c2}: ", price);
            ret += size + "oz " + type; 
            return ret;

        }


    }
}
