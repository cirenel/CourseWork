using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PizzaOrder
{
    public partial class DrinkOrderForm : Form
    {
        Drink d;
        public DrinkOrderForm()
        {
            InitializeComponent();
        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            int size = int.Parse(comboSize.SelectedItem.ToString());
            string ty = comboDrink.SelectedItem.ToString();
             d = new Drink(size, ty);
            d.Ice = checkIce.Checked;
            this.Close();
        }

        public Drink getDrinkOrder()
        {
            return d; 
        }
    }
}
