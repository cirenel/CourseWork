using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathPractice
{
    public partial class Form1 : Form
    {
        MathProblem mp;
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string val = ansBox.Text;
            if(val == "")
            {
                val = "0";
            }
            bool probAns = mp.checkProblem(Convert.ToInt32(val));
            if (probAns)
            {
                score.Text = (Convert.ToInt32(score.Text)+1)+"";
            } else
            {
                MessageBox.Show("No, the correct answer is " + mp.ans);
            }
            ansBox.Text = "";
            totalProb.Text = (Convert.ToInt32(totalProb.Text) + 1) + "";
            updateProb();
        }

        

        private void updateProb()
        {
            mp = new MathProblem();
            string op = "";
            switch (mp.op)
            {
                case 0:
                    op = "+";
                    break;
                case 1:
                    op = "-";
                    break;
                case 2:
                    op = "/";
                    break;
                case 3:
                    op = "*";
                    break;
            }
            curProb.Text = mp.i + " " + op + " " + mp.j + " = ";

        }


        private void mainButton_Click(object sender, EventArgs e)
        {
            if (mainButton.Text == "Start")
            {
                updateProb();
                mainButton.Text = "Done";
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;

                mainButton.Text = "Start";
                score.Text = "0";
                totalProb.Text = "0";
                MessageBox.Show("Your final score is: "+((double)Convert.ToInt32(score.Text) / Convert.ToInt32(totalProb.Text)) *100);
            }
        }

        private void ansBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ansBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar=='-');
        }
    }
}
