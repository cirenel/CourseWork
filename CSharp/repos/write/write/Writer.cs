using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace write
{
    public partial class Writer : Form
    {
        Section activeSection; 
        Dictionary <string, Section> allSections;
 
        public Writer()
        {
            InitializeComponent();
            activeSection = new Section();
            allSections = new Dictionary<string, Section>();
        }

        private void processInString(string input)
        {
            activeSection = new Section();
            allSections = new Dictionary<string, Section>();
            sectionList.Items.Clear();

            string[] all = input.Split('[');
            for (int i = 0; i < all.Length; i++)
            {

                string[] single = all[i].Split(']');
                if (single.Length > 1)
                {
                    Section s = new Section(single[0]);
                    MessageBox.Show(single[1]);
                    
                    s.contents = single[1]+"";
                    allSections.Add(single[0]+"", s);
                    sectionList.Items.Add(s);
                }
            }
        }

        private void SectToList()
        {
            MessageBox.Show("i am here");
            if (textBody.Text != "" && sectionTitle.Text != "")
            {
                activeSection.title = sectionTitle.Text;
                activeSection.contents = textBody.Text;
                Section s;
                MessageBox.Show(allSections.TryGetValue(sectionTitle.Text, out s)+"");
                if (allSections.TryGetValue(sectionTitle.Text, out s) == true)
                {
                    MessageBox.Show("1");
                    allSections.Remove(activeSection.title+"");
                    int i = sectionList.SelectedIndex;
                    sectionList.Items.Insert(i, activeSection);
                    sectionList.Items.Remove(sectionList.SelectedItem);
                    sectionList.SelectedIndex = i; 
                } 
                else
                {
                    MessageBox.Show("2");

                    sectionList.Items.Add(activeSection);
                }
                allSections.Add(activeSection.title, activeSection);
                activeSection.writeSection();

            } else
            {
                MessageBox.Show("Please provide title and body.");
            }
        }

        private void loadSect()
        {

            sectionTitle.Text = sectionList.SelectedItem + "";
            allSections.TryGetValue(sectionList.SelectedItem + "", out activeSection);
            textBody.Text = activeSection.contents;
        }

        private void saveSect_Click(object sender, EventArgs e)
        {
            SectToList();
        }

        private void saveClearSect_Click(object sender, EventArgs e)
        {
            SectToList();
            sectionTitle.Text = "";
            textBody.Text = "";
            activeSection = null;
        }

        private void sectionTitle_TextChanged(object sender, EventArgs e)
        {
            activeSection = new Section( sectionTitle.Text );
            activeSection.contents = textBody.Text;
        }

        private void sectionList_DoubleClick(object sender, EventArgs e)
        {
            loadSect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadSect();
        }

        private void swap(int i, int j)
        {
            object o = sectionList.Items[i];
            sectionList.Items[i] = sectionList.Items[j];
            sectionList.Items[j] = o;
            sectionList.SelectedIndex = j;
        }

        private void itemUp_Click(object sender, EventArgs e)
        {
            if(sectionList.SelectedIndex > 0)
            {
                swap(sectionList.SelectedIndex, sectionList.SelectedIndex - 1);
            }
        }

        private void itemDown_Click(object sender, EventArgs e)
        {
            if (sectionList.SelectedIndex < sectionList.Items.Count-1)
            {
                swap(sectionList.SelectedIndex, sectionList.SelectedIndex + 1);
            }
        }

        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            activeSection = new Section();
            allSections = new Dictionary<string, Section>();
            sectionTitle.Text = "";
            sectionList.Items.Clear();
            textBody.Text = "";
        }

        private void saveProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //choose output file and path 
            SaveFileDialog sf = new SaveFileDialog();
            sf.Title = "Select file location";
            sf.ShowDialog();
            string path = sf.FileName;
            MessageBox.Show(path);
            StreamWriter sw = File.CreateText(path);

            Section s = new Section();
            string curSect = "";
            string toWrite = "Writing out at "+DateTime.Now.ToString();
            sw.WriteLine(toWrite);
            for (int i = 0; i < sectionList.Items.Count; i++)
            {                
                curSect = sectionList.Items[i].ToString();
                allSections.TryGetValue(curSect, out s);
                toWrite = "\n[" + s.title + "]" + s.contents;
                sw.Write(toWrite);
            }
            sw.Flush();
            sw.Close();
            MessageBox.Show("File written sucessfully.");
        }

        private void loadProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Title = "Select file... ";
            of.ShowDialog();
            string path = of.FileName;
            MessageBox.Show(path);
            string readIn = "";
            if (File.Exists(path))
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        readIn += (s+'\n');
                    }
                }

                processInString(readIn);
                MessageBox.Show("File opened.");
            } else
            {
                MessageBox.Show("This file cannot be opened.");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            string path = "closedWithoutSaving.txt";
            
            StreamWriter sw = File.CreateText(path);

            Section s = new Section();
            string curSect = "";
            string toWrite = "Writing out at " + DateTime.Now.ToString();
            sw.WriteLine(toWrite);
            for (int i = 0; i < sectionList.Items.Count; i++)
            {
                curSect = sectionList.Items[i].ToString();
                allSections.TryGetValue(curSect, out s);
                toWrite = "\n[" + s.title + "]\n" + s.contents;
                sw.WriteLine(toWrite);
            }
            sw.Flush();
            sw.Close();

            this.Close();
        }

        private void fontSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;

            fontDialog1.Font = textBody.Font;
            fontDialog1.Color = textBody.ForeColor;

            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                textBody.Font = fontDialog1.Font;
                textBody.ForeColor = fontDialog1.Color;
            }
        }

        private void colorOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayPopup dp = new DisplayPopup(this.BackColor, this.ForeColor, textBody.BackColor, textBody.ForeColor, button1.ForeColor,button1.BackColor, this.Opacity);

            dp.ShowDialog();
            this.BackColor = dp.bgWinC;
            this.ForeColor = dp.forWinC;
            textBody.BackColor = dp.bgTxtC;
            textBody.ForeColor = dp.forTxtC;
            this.Opacity = dp.WinOp;

            sectionList.BackColor = textBody.BackColor;
            sectionList.ForeColor = textBody.ForeColor;

            sectionTitle.BackColor = textBody.BackColor;
            sectionTitle.ForeColor = textBody.ForeColor;

            foreach (Control c in this.Controls)
            {
                Button btn = c as Button;
                if (btn != null) 
                {
                    btn.BackColor = dp.btnBgC;
                    btn.ForeColor = dp.btnTxtC;
                }
            }


        }

    }
}
