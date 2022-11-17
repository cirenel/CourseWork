namespace QuestionMaker
{
    partial class MCForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.titleText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tagTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addAllBtn = new System.Windows.Forms.Button();
            this.addedQuestions = new System.Windows.Forms.ListBox();
            this.addQBtn = new System.Windows.Forms.Button();
            this.quesBox = new System.Windows.Forms.TextBox();
            this.addOptionBtn = new System.Windows.Forms.Button();
            this.optionBox = new System.Windows.Forms.TextBox();
            this.isAnswer = new System.Windows.Forms.CheckBox();
            this.optionAnsList = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "Title";
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(12, 27);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(158, 23);
            this.titleText.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Tags";
            // 
            // tagTxt
            // 
            this.tagTxt.Location = new System.Drawing.Point(241, 237);
            this.tagTxt.Multiline = true;
            this.tagTxt.Name = "tagTxt";
            this.tagTxt.Size = new System.Drawing.Size(116, 59);
            this.tagTxt.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(480, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Added Questions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Question";
            // 
            // addAllBtn
            // 
            this.addAllBtn.Location = new System.Drawing.Point(605, 240);
            this.addAllBtn.Name = "addAllBtn";
            this.addAllBtn.Size = new System.Drawing.Size(75, 23);
            this.addAllBtn.TabIndex = 18;
            this.addAllBtn.Text = "Add>>";
            this.addAllBtn.UseVisualStyleBackColor = true;
            this.addAllBtn.Click += new System.EventHandler(this.addAllBtn_Click);
            // 
            // addedQuestions
            // 
            this.addedQuestions.FormattingEnabled = true;
            this.addedQuestions.ItemHeight = 15;
            this.addedQuestions.Location = new System.Drawing.Point(478, 35);
            this.addedQuestions.Name = "addedQuestions";
            this.addedQuestions.Size = new System.Drawing.Size(202, 199);
            this.addedQuestions.TabIndex = 17;
            // 
            // addQBtn
            // 
            this.addQBtn.Location = new System.Drawing.Point(397, 83);
            this.addQBtn.Name = "addQBtn";
            this.addQBtn.Size = new System.Drawing.Size(75, 45);
            this.addQBtn.TabIndex = 16;
            this.addQBtn.Text = "Add Question>>";
            this.addQBtn.UseVisualStyleBackColor = true;
            this.addQBtn.Click += new System.EventHandler(this.addQBtn_Click);
            // 
            // quesBox
            // 
            this.quesBox.Location = new System.Drawing.Point(12, 83);
            this.quesBox.Multiline = true;
            this.quesBox.Name = "quesBox";
            this.quesBox.Size = new System.Drawing.Size(197, 107);
            this.quesBox.TabIndex = 15;
            // 
            // addOptionBtn
            // 
            this.addOptionBtn.Location = new System.Drawing.Point(134, 278);
            this.addOptionBtn.Name = "addOptionBtn";
            this.addOptionBtn.Size = new System.Drawing.Size(75, 49);
            this.addOptionBtn.TabIndex = 27;
            this.addOptionBtn.Text = "Add Opt>>";
            this.addOptionBtn.UseVisualStyleBackColor = true;
            this.addOptionBtn.Click += new System.EventHandler(this.addOptionBtn_Click);
            // 
            // optionBox
            // 
            this.optionBox.Location = new System.Drawing.Point(12, 220);
            this.optionBox.Multiline = true;
            this.optionBox.Name = "optionBox";
            this.optionBox.Size = new System.Drawing.Size(197, 52);
            this.optionBox.TabIndex = 28;
            // 
            // isAnswer
            // 
            this.isAnswer.AutoSize = true;
            this.isAnswer.Location = new System.Drawing.Point(14, 282);
            this.isAnswer.Name = "isAnswer";
            this.isAnswer.Size = new System.Drawing.Size(81, 19);
            this.isAnswer.TabIndex = 29;
            this.isAnswer.Text = "Is Answer?";
            this.isAnswer.UseVisualStyleBackColor = true;
            // 
            // optionAnsList
            // 
            this.optionAnsList.FormattingEnabled = true;
            this.optionAnsList.Location = new System.Drawing.Point(241, 83);
            this.optionAnsList.Name = "optionAnsList";
            this.optionAnsList.Size = new System.Drawing.Size(150, 112);
            this.optionAnsList.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 31;
            this.label1.Text = "Option";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "Options and Answers";
            // 
            // MCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(690, 335);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.optionAnsList);
            this.Controls.Add(this.isAnswer);
            this.Controls.Add(this.optionBox);
            this.Controls.Add(this.addOptionBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tagTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addAllBtn);
            this.Controls.Add(this.addedQuestions);
            this.Controls.Add(this.addQBtn);
            this.Controls.Add(this.quesBox);
            this.Name = "MCForm";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MCForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label5;
        private TextBox titleText;
        private Label label4;
        private TextBox tagTxt;
        private Label label3;
        private Label label2;
        private Button addAllBtn;
        private ListBox addedQuestions;
        private Button addQBtn;
        private TextBox quesBox;
        private Button addOptionBtn;
        private TextBox optionBox;
        private CheckBox isAnswer;
        private CheckedListBox optionAnsList;
        private Label label1;
        private Label label6;
    }
}