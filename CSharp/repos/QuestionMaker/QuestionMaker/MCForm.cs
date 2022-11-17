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
    public partial class MCForm : Form
    {
        public List<MCQuestion> questions;
        public MCForm()
        {
            InitializeComponent();
            questions = new List<MCQuestion>();
        }

        private void addOptionBtn_Click(object sender, EventArgs e)
        {
            if(optionBox.Text != "")
            {
                optionAnsList.Items.Add(optionBox.Text, isAnswer.Checked);
                optionBox.Clear();
                isAnswer.Checked = false; 
            }
        }

        private void addQBtn_Click(object sender, EventArgs e)
        {
            MCQuestion mc = new MCQuestion(titleText.Text, quesBox.Text);

            foreach(string s in optionAnsList.Items)
            {
                mc.AddOption(s, optionAnsList.CheckedItems.Contains(s));
            }

            mc.MakeTags(tagTxt.Text);
            questions.Add(mc);

            titleText.Clear();
            quesBox.Clear();
            optionAnsList.Items.Clear();
            addedQuestions.Items.Clear();
            addedQuestions.Items.AddRange(questions.ToArray());

        }

        private void addAllBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
