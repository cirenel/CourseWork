using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOrder
{
    
    public class Pizza:Item
    {
        private List<string> toppings;
        private int diameter;
        private bool extraCheese, extraSauce;
        private string crustType, custom;


        public bool Cheese
        {
            set { extraCheese = value;  }
        }
        public bool Sauce
        {
            set { extraSauce = value;  }
        }

        public Pizza(int size, List<string> top, string instruct)
        {
            diameter = size;
            toppings = top;
            custom = instruct;

            computePrice();
        }

        public override void computePrice()
        {
            price = 4; 
            if(diameter == 10)
            {
                price += 2;
            } else if (diameter == 12)
            {
                price += 4;
            } else if (diameter == 14)
            {
                price += 6;
            }

            price += (toppings.Count * 0.5);
            
            if (extraCheese)
            {
                price += 1.75;
            }
            if (extraSauce)
            {
                price += 1.50;
            }

        }


        public override string ToString()
        {
            string ret = String.Format("{0:c2}: ", price);
            ret += diameter + " inch pizza";
            ret += (toppings.Count>0) ?" with:\n":"\n";
            foreach(string s in toppings){
                ret += "\t"+s + "\n";
            }
            ret += ((extraCheese)?"with extra cheese\n":"");
            ret += ((extraSauce) ? "with extra sauce\n" : "");
            ret += custom;
            return ret; 
        }

    }
}
