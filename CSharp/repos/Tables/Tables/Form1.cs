using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tables
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(dropdownI.SelectedItem.ToString());
            int j = Convert.ToInt32(dropdownJ.SelectedItem.ToString());
            string op = dropdownOp.SelectedItem.ToString();
            string ret = computeTable(i,j,op);
            outputBox.Text = ret; 
        }

        private string computeTable(int col, int row, string math)
        {


            return "";
        }


    }
}
