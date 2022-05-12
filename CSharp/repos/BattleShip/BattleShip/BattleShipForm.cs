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
    public partial class BattleShipForm : Form
    {
        BattleShip game;
        List<Button> buttonsA, buttonsB;  
        bool[,] myBoard;
            bool[,] enemyBoard; 
        public BattleShipForm()
        {
            InitializeComponent();
            game = new BattleShip();
            buttonsA = new List<Button>();
            buttonsB = new List<Button>();
            myBoard = game.getPlayerBoard().Board;
            enemyBoard = game.getEnemyBoard().Board;
            this.SuspendLayout();

            this.flowPanelA.SuspendLayout();
            
            int height = 50;// flowPanel.Height / 10;
            int width = 50;// flowPanel.Width / 10;
            for (int i = 0; i < myBoard.GetLength(0); i++)
            {
                for (int j = 0; j < myBoard.GetLength(1); j++)
                {
                    System.Windows.Forms.Button button1 = new System.Windows.Forms.Button();
                    flowPanelA.Controls.Add(button1);                    
                    button1.Name = "btn-A-"+i+"-"+j;
                    button1.Size = new System.Drawing.Size(width,height);
                    button1.TabIndex = 0;
                    button1.UseVisualStyleBackColor = true;
                    button1.Margin = new Padding(1,1,1,1);
                    if (myBoard[i,j])
                    {
                        button1.BackColor = Color.Gray;
                        
                    } else
                    {
                        button1.BackColor = Color.LightBlue;
                    }
                    button1.Enabled = false; 
                    buttonsA.Add(button1);
                }
            }
            this.flowPanelA.ResumeLayout(false);

            this.flowPanelB.SuspendLayout();
            for (int i = 0; i < enemyBoard.GetLength(0); i++)
            {
                for (int j = 0; j < myBoard.GetLength(1); j++)
                {
                    System.Windows.Forms.Button button1 = new System.Windows.Forms.Button();
                    flowPanelB.Controls.Add(button1);
                    button1.Name = "btn-B-" + i + "-" + j;
                    button1.Size = new System.Drawing.Size(width, height);
                    button1.TabIndex = 0;
                    button1.Text = "";
                    button1.UseVisualStyleBackColor = true;
                    button1.Margin = new Padding(1, 1, 1, 1);
                    button1.BackColor = Color.LightBlue;
                    button1.Click += new System.EventHandler(button1_Click);
                    buttonsB.Add(button1);
                }
            }
            this.flowPanelB.ResumeLayout(false);

            this.ResumeLayout(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = ((Button)sender);
            string name = b.Name;
            string[] vals = name.Split('-');
            int i = int.Parse(vals[2]);
            int j = int.Parse(vals[3]);
            if (game.Attack(i, j))
            {
                b.BackColor = Color.Red;                
            } else
            {
                b.BackColor = Color.DarkBlue;
            }
            b.Enabled = false;


            if (!game.isOver())
            {
                Tuple<int, int, bool> t = game.AITurn();
                Button bb = null;
                name = "btn-A-" + t.Item1 + "-" + t.Item2;

                foreach (Control c in flowPanelA.Controls)
                {
                    if (c is Button && c.Name == name)
                    {
                        bb = c as Button;
                    }
                }
                if (bb != null)
                {
                    if (t.Item3)
                    {
                        bb.BackColor = Color.Red;
                    }
                    else
                    {
                        bb.BackColor = Color.DarkBlue;
                    }
                    bb.Enabled = false;
                }
            }

            if (game.isOver()) {
                string winner = game.getWinner();
                DialogResult res=MessageBox.Show(winner + " has won!\nDo you want to play again?", "Game over.", MessageBoxButtons.YesNo);
                if(res == DialogResult.Yes)
                {
                    this.Close();
                    

                } else
                {
                    this.Close();
                }
            }

        }

        private void BattleShipForm_Load(object sender, EventArgs e)
        {

        }
    }
}
