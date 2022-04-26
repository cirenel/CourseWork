using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guessingGame
{
    public partial class Settings : Form
    {
        public int lo, hi, guess; 
        public Settings(int l, int h, int g)
        {
            InitializeComponent();
            txtLo.Text = ""+l;
            lo = l;
            hiTxt.Text = "" + h;
            hi = h;
            turnTxt.Text = "" + g;
            guess = g; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lo = Convert.ToInt32(txtLo.Text);
            hi = Convert.ToInt32(hiTxt.Text);
            guess = Convert.ToInt32(turnTxt.Text);
            this.Hide();
        }
    }
}
