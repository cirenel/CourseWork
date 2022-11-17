namespace QuestionMaker
{
    partial class MatchingForm
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
            this.wordBox = new System.Windows.Forms.TextBox();
            this.ansBox = new System.Windows.Forms.TextBox();
            this.addQBtn = new System.Windows.Forms.Button();
            this.addedQuestions = new System.Windows.Forms.ListBox();
            this.addAllBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tagTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.titleText = new System.Windows.Forms.TextBox();
            this.instrucitonText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wordBox
            // 
            this.wordBox.Location = new System.Drawing.Point(12, 96);
            this.wordBox.Name = "wordBox";
            this.wordBox.Size = new System.Drawing.Size(197, 23);
            this.wordBox.TabIndex = 2;
            // 
            // ansBox
            // 
            this.ansBox.Location = new System.Drawing.Point(12, 143);
            this.ansBox.Multiline = true;
            this.ansBox.Name = "ansBox";
            this.ansBox.Size = new System.Drawing.Size(197, 107);
            this.ansBox.TabIndex = 3;
            // 
            // addQBtn
            // 
            this.addQBtn.Location = new System.Drawing.Point(134, 270);
            this.addQBtn.Name = "addQBtn";
            this.addQBtn.Size = new System.Drawing.Size(75, 23);
            this.addQBtn.TabIndex = 4;
            this.addQBtn.Text = "Add>>";
            this.addQBtn.UseVisualStyleBackColor = true;
            this.addQBtn.Click += new System.EventHandler(this.addQBtn_Click);
            // 
            // addedQuestions
            // 
            this.addedQuestions.FormattingEnabled = true;
            this.addedQuestions.ItemHeight = 15;
            this.addedQuestions.Location = new System.Drawing.Point(228, 96);
            this.addedQuestions.Name = "addedQuestions";
            this.addedQuestions.Size = new System.Drawing.Size(202, 199);
            this.addedQuestions.TabIndex = 30;
            this.addedQuestions.TabStop = false;
            // 
            // addAllBtn
            // 
            this.addAllBtn.Location = new System.Drawing.Point(355, 306);
            this.addAllBtn.Name = "addAllBtn";
            this.addAllBtn.Size = new System.Drawing.Size(75, 23);
            this.addAllBtn.TabIndex = 6;
            this.addAllBtn.Text = "Add>>";
            this.addAllBtn.UseVisualStyleBackColor = true;
            this.addAllBtn.Click += new System.EventHandler(this.addAllBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Word";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Answer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Added Pairs";
            // 
            // tagTxt
            // 
            this.tagTxt.Location = new System.Drawing.Point(12, 270);
            this.tagTxt.Multiline = true;
            this.tagTxt.Name = "tagTxt";
            this.tagTxt.Size = new System.Drawing.Size(116, 59);
            this.tagTxt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tags";
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(12, 40);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(158, 23);
            this.titleText.TabIndex = 0;
            // 
            // instrucitonText
            // 
            this.instrucitonText.Location = new System.Drawing.Point(176, 40);
            this.instrucitonText.Name = "instrucitonText";
            this.instrucitonText.Size = new System.Drawing.Size(254, 23);
            this.instrucitonText.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Title";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Instruction";
            // 
            // MatchingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(457, 344);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.instrucitonText);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tagTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addAllBtn);
            this.Controls.Add(this.addedQuestions);
            this.Controls.Add(this.addQBtn);
            this.Controls.Add(this.ansBox);
            this.Controls.Add(this.wordBox);
            this.Name = "MatchingForm";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MatchingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox wordBox;
        private TextBox ansBox;
        private Button addQBtn;
        private ListBox addedQuestions;
        private Button addAllBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tagTxt;
        private Label label4;
        private TextBox titleText;
        private TextBox instrucitonText;
        private Label label5;
        private Label label6;
    }
}