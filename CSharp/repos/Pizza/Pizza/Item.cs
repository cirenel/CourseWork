using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOrder
{
    public abstract class Item
    {
        protected double price; 


        public Item()
        {

        }

        public double getPrice()
        {
            return price; 
        }

        public abstract void computePrice();
        

    }
}
