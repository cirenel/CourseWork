using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PizzaOrder
{
    public partial class PizzaOrderForm : Form
    {
        private Pizza food; 

        public PizzaOrderForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string special = textBoxSpecial.Text;

            List<string> toppings = new List<string>();


            foreach(Control c in this.toppingPanel.Controls)
            {
                if (c is CheckBox && ((CheckBox)c).Checked)
                {
                    string s = ((CheckBox)c).Text;
                    toppings.Add(s);
                }
            }

            int size = 0;

            foreach (Control c in this.sizePanel.Controls)
            {
                if (c is RadioButton && ((RadioButton)c).Checked)
                {
                    if (c.Text == "Small") size = 10;
                    else if (c.Text == "Medium") size = 12;
                    else if (c.Text == "Large") size = 14;
                }
            }

            food = new Pizza(size, toppings, special);
            food.Cheese = sauceBox.Checked;
            food.Sauce = sauceBox.Checked;

            this.Close();

        }

        public Pizza getPizzaOrder()
        {
            return food;
        }

    }
}
