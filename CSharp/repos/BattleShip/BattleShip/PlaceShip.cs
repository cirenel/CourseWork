using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleShip
{
    public partial class PlaceShip : Form
    {
        public Ship s;
        int length;
        bool vertical; 

        public Ship GetShip
        {
            get { return s; }
        }

        public PlaceShip(int len)
        {
            InitializeComponent();
            length = len;
            messageLabel.Text += len;
            vertical = true; 
            
        }

        private void vert_Click(object sender, EventArgs e)
        {
            if(vert.Text == "Vertical")
            {
                vert.Text = "Horizontal";
                vertical = false; 
            } else
            {
                vert.Text = "Vertical";
                vertical= true; 
            }
        }


        private void placeButton_Click(object sender, EventArgs e)
        {
            int x = int.Parse(topText.Text);
            int y = int.Parse(leftText.Text);
            s = new Ship(length, x, y, vertical);
            this.Close();
        }

        private void numlock_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }
    }
}
