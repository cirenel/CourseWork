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
    public partial class TFForm : Form
    {
        public List<TFQuestion> questions; 
        public TFForm()
        {
            InitializeComponent();
            questions = new List<TFQuestion>();
        }

        private void addQBtn_Click(object sender, EventArgs e)
        {

            if(titleBox.Text!="" && questionbox.Text != "")
            {
                TFQuestion tf = new TFQuestion(titleBox.Text, questionbox.Text);
                tf.SetAnswer(tfAnsCheck.Checked);
                if (tagTxt.Text != "")
                {
                    tf.MakeTags(tagTxt.Text);
                }
                questions.Add(tf);
                addedQuestions.Items.Clear();
                addedQuestions.Items.AddRange(questions.ToArray());
            }

        }

        private void addAllBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
