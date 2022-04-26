using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotto
{
    public partial class Form1 : Form
    {
        Random r;
        Matching m;
        int matched; 
        int clickCount;
        Button lastClicked; 
        int lastX, lastY;
        char lastVal; 
        public Form1()
        {
            InitializeComponent();
            m = new Matching();
            r = new Random();
            clickCount = 0;
            lastX = 0;
            lastY = 0;
            matched = 0;
            lastVal = ' ';
            MessageBox.Show(m.showBoard());
        }

        private void button_Click(object sender, EventArgs e)
        {

            string name = ((Button)sender).Name;
            int x = Convert.ToInt32(name.Substring(name.Length - 2, 1));
            int y = Convert.ToInt32(name.Substring(name.Length - 1, 1));
            ((Button)sender).Text = m.getChar(x, y)+"";
            
            clickCount++;
            if (clickCount % 2 == 0)
            {
                if(lastVal == m.getChar(x, y))
                {
                    //is a match 
                    ((Button)sender).BackColor = Color.Green;
                    ((Button)sender).ForeColor = Color.White;
                    ((Button)sender).Click -= new System.EventHandler(this.button_Click);
                    lastClicked.BackColor = Color.Green;
                    lastClicked.ForeColor = Color.White;
                    lastClicked.Click -= new System.EventHandler(this.button_Click);
                    matched++;
                    if(matched == 8)
                    {
                        MessageBox.Show("You have won! \nIt took you " + (clickCount/2) +" tries");
                    }
                }
                else
                {
                    //no match 
                    MessageBox.Show("no match");
                    ((Button)sender).Text = "";
                    lastClicked.Text = "";
                    lastClicked.Click += new System.EventHandler(this.button_Click);
                }
            } 
            else
            {
                ((Button)sender).Click -= new System.EventHandler(this.button_Click);
                lastVal = m.getChar(x, y);
                lastY = y;
                lastX = x;
                lastClicked = (Button)sender; 
            }
        }

        private void alreadyClicked(object sender, EventArgs e)
        {
            
        }
    }
}
