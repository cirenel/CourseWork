using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuestionMaker
{


    public partial class QAtableForm : Form
    {
        int inputs;
        public DragQuestion dQuestion;
        Dictionary<string, string> qAdict; 
        public QAtableForm()
        {
            InitializeComponent();
        }

        private void QAtableForm_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inputs = int.Parse(numInput.Text);
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.RowCount = inputs;
            for (int i = 0; i < inputs; i++)
            {                 
                TextBox tb1 = new TextBox();
                tb1.Name = "tbAns"+i;
                tb1.Text = "Answer "+i;
                tb1.Anchor = AnchorStyles.Top;
                tb1.SetBounds(0, 0, 200, 45);
                tableLayoutPanel1.Controls.Add(tb1, 0, i);

                TextBox tb2 = new TextBox();
                tb2.Name = "tbQue" + i;
                tb2.Text = "Question " + i;
                tb2.Multiline = true;
                tb2.SetBounds(0, 0, 450, 100);

                tableLayoutPanel1.Controls.Add(tb2, 1, i);
                }
            tableLayoutPanel1.AutoSize= true;
            Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            qAdict = new Dictionary<string, string>();
            string title = titleText.Text;
            string question = questionText.Text;
            int border = int.Parse(borderText.Text);
            int padding = int.Parse(paddingText.Text);
            int numCol;
            int numRow;
            if(inputs % 3 == 0)
            {
                numCol = 3;
                numRow = inputs / 2;
            } else if(inputs % 2 == 0)
            {
                numCol = 2;
                numRow = inputs / 2;
            } else
            {
                numCol = 1;
                numRow = inputs; 
            }

            for(int i = 0; i < inputs; i++)
            {
                qAdict.Add(tableLayoutPanel1.GetControlFromPosition(0,i).Text, tableLayoutPanel1.GetControlFromPosition(1, i).Text);
            }
            dQuestion = new DragQuestion(title, question, qAdict, border, padding, numCol, numRow);

            this.Close();
        }

        private void QAtableForm_Load(object sender, EventArgs e)
            {
            }
        }
}
