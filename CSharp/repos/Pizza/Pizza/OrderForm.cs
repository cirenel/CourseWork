using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrder
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void updatePrices()
        {
            double subtotal = 0;
            foreach (Item i in listboxOrder.Items)
            {
                subtotal += i.getPrice();
            }
            double tax = (0.075)*subtotal;
            bool b = double.TryParse(textBoxTip.Text, out double tip);
            double total = subtotal + tax + tip;

            textBoxSubtotal.Text = String.Format("{0:c2}",subtotal);
            textBoxTax.Text = String.Format("{0:c2}", tax);           
            textBoxTotal.Text = String.Format("{0:c2}", total);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PizzaOrderForm p = new PizzaOrderForm();
            p.ShowDialog();

            Pizza orderedPizza = p.getPizzaOrder();
           // MessageBox.Show(orderedPizza + "");
            listboxOrder.Items.Add(orderedPizza);

            p.Dispose();
            updatePrices();
        }



        private void textBoxTip_TextChanged(object sender, EventArgs e)
        {
            updatePrices();
        }

        private void btnAddDrink_Click(object sender, EventArgs e)
        {
            DrinkOrderForm d = new DrinkOrderForm();
            d.ShowDialog();

            Drink orderedDrink = d.getDrinkOrder();
            // MessageBox.Show(orderedPizza + "");
            listboxOrder.Items.Add(orderedDrink);

            d.Dispose();
            updatePrices();
        }

    }
}
