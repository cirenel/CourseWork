using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicEight
{
    public partial class Form1 : Form
    {
        Random r; 
        string[] answers = 
            { "Yes", "No", "Maybe", 
            "Definitely", "Ask again later", 
            "It is certain", "It is decidedly so", 
            "Without a doubt", "Signs point to yes", 
            "Reply hazy, try again", "Better not tell you", 
            "Cannot predict now", "Concentrate and ask again",
            "Don't count on it", "My reply is no", 
            "My sources say no", "Outlook not good", 
            "Very Doubtful" };
        public Form1()
        {
            InitializeComponent();
            r = new Random();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        

            questionBox.Text = "";
            answerBox.Text = answers[r.Next(0, answers.Length - 1)];
        }
    }
}
