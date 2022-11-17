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
    public partial class MatchingForm : Form
    {
        public MatchQuestion mQuestion; 

        public MatchingForm()
        {
            InitializeComponent();

        }

        public void newQuest()
        {
            mQuestion = new MatchQuestion(titleText.Text, instrucitonText.Text);
        }

        private void addQBtn_Click(object sender, EventArgs e)
        {
            if (wordBox.Text != "" && ansBox.Text != "")
            {
                if (mQuestion == null)
                {
                    newQuest();
                }
                mQuestion.AddPair(wordBox.Text, ansBox.Text);
                wordBox.Clear();
                ansBox.Clear();
                addedQuestions.Items.Clear();
                addedQuestions.Items.AddRange(mQuestion.getQuestionRep());

            }
        }

        private void addAllBtn_Click(object sender, EventArgs e)
        {
            if(tagTxt.Text != "")
            {
                mQuestion.MakeTags(tagTxt.Text);
                tagTxt.Clear();
            }

            this.Close();
        }
    }
}
