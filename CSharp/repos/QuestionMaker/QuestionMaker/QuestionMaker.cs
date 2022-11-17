namespace QuestionMaker
{
    public partial class QuestionMaker : Form
    {

        List<Question> questions; 

        public QuestionMaker()
        {
            InitializeComponent();
            questions = new List<Question>();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            string qType = questionTypes.SelectedItem.ToString();
            MessageBox.Show(qType + " ");

            switch (qType)
            {
                case "Multiple Choice":
                    MCForm mc = new MCForm();
                    mc.ShowDialog();
                    questions.AddRange(mc.questions);
                    mc.Dispose();

                    break;

                case "True-False":
                    TFForm tf = new TFForm();
                    tf.ShowDialog();
                    questions.AddRange(tf.questions);
                    tf.Dispose();

                    break;

                case "Matching":
                    MatchingForm mf = new MatchingForm();
                    mf.ShowDialog();
                    questions.Add(mf.mQuestion);
                    mf.Dispose();
                   
                    break;

                case "Category Change":
                    CatForm cc = new CatForm();
                    cc.ShowDialog();
                    questions.Add(cc.cQuestion);
                    cc.Dispose();

                    break;

                case "Q-A Table":
                    QAtableForm qatable = new QAtableForm();
                    qatable.ShowDialog();
                    questions.Add(qatable.dQuestion);
                    qatable.Dispose();  

                    break;
            }
            
            MessageBox.Show(questions.Count + "");
            listBox1.Items.Clear();
            listBox1.Items.AddRange(questions.ToArray());
        
        }

        private void writeButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string file = saveFileDialog1.FileName;
            

            string writeout = "";
            foreach(Question q in questions)
            {
                writeout += q.MakeGIFT();
            }
            writeout += "\n";

            File.WriteAllText(file, writeout);

        }
    }
}