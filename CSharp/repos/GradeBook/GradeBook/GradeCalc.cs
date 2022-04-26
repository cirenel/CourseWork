using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeBook
{
    public partial class GradeCalc : Form
    {

        public GradeCalc()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            double grade = Convert.ToDouble(textBox1.Text);
            gradeList.Items.Add(grade);
            double[] allGrades = convertToArray(gradeList.Items);
            double gpa = computeAvg(allGrades);
            gradeNumber.Text = Math.Round(gpa,2)+"";
            letterGrade.Text = findLetterGrade(gpa);
        }

        private double[] convertToArray(ListBox.ObjectCollection obj)
        {
            double[] ret = new double[obj.Count];
            for (int i =0; i < obj.Count; i++)
            {
                ret[i] = (double)obj[i];
            }
            return ret;
        }

        private double computeAvg(double[] grades)
        {
            double avg = 0;
            foreach (double g in grades)
            {
                avg += g;
            }
            return (avg / (grades.Length));
        }

        private string findLetterGrade(double gpa)
        {
            if(gpa >= 90)
            {
                return "A";
            } else if (gpa >= 80)
            {
                return "B";
            }
            else if (gpa >= 70)
            {
                return "C";
            }
            else if (gpa >= 60)
            {
                return "D";
            }
            else 
            {
                return "F";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
  
    
    
    
    }
}
