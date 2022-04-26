using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace write
{

    

    public partial class DisplayPopup : Form
    {
        public Color bgWinC, forWinC, bgTxtC, forTxtC, btnTxtC, btnBgC;
        public double WinOp;



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double val = Convert.ToDouble(textBox1.Text)/100.0;
            if (val >= 0.25) {
                WinOp = val;
                textBox1.Text = (100 * WinOp) + "";
            }

        }


        public DisplayPopup(Color a, Color b, Color c, Color d, Color btc, Color bbc, double wo)
        {
            InitializeComponent();
            bgWinC = a;
            forWinC = b;
            bgTxtC = c;
            forTxtC = d;
            WinOp = wo;
            btnTxtC = btc;
            btnBgC = bbc;
            textBox1.Text = (100*WinOp)+"";
        }

        private void bgWinCol_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            colorDialog1.ShowDialog();
            bgWinC = colorDialog1.Color;
        }

        private void buttonTxt_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            colorDialog1.ShowDialog();
            btnTxtC = colorDialog1.Color;
        }

        private void buttnBG_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            colorDialog1.ShowDialog();
            btnBgC = colorDialog1.Color;
        }

        private void winTxtCol_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            colorDialog1.ShowDialog();
            forWinC = colorDialog1.Color;
        }
        private void textCol_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            colorDialog1.ShowDialog();
            forTxtC = colorDialog1.Color;
        }

        private void txtBgCol_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            colorDialog1.ShowDialog();
            bgTxtC = colorDialog1.Color;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
