using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestionMaker
{
    public partial class CatForm : Form
    {
        public CatQuestion cQuestion;
        public CatForm()
        {
            InitializeComponent();

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                cQuestion = new CatQuestion(textBox1.Text);
                this.Close();
            }
        }
    }
}
