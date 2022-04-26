using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nutrients
{
    public partial class Primary : Form
    {
        public Primary()
        {
            InitializeComponent();
        }


        private void restrictNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            NutritionalItem n = new NutritionalItem(nameBox.Text+"", Convert.ToInt32(calorieBox.Text));
            listFoods.Items.Add(n);

            nameBox.Text = "";
            calorieBox.Text = "";

        }

        private void buttonLoadItem_Click(object sender, EventArgs e)
        {
            NutritionalItem item = listFoods.SelectedItem as NutritionalItem;
            nameBox.Text = item.name;
            calorieBox.Text = item.calories+"";
        }
    }
}
