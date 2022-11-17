namespace QuestionMaker
{
    partial class TFForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.tagTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addAllBtn = new System.Windows.Forms.Button();
            this.addedQuestions = new System.Windows.Forms.ListBox();
            this.addQBtn = new System.Windows.Forms.Button();
            this.questionbox = new System.Windows.Forms.TextBox();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.tfAnsCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Tags";
            // 
            // tagTxt
            // 
            this.tagTxt.Location = new System.Drawing.Point(12, 228);
            this.tagTxt.Multiline = true;
            this.tagTxt.Name = "tagTxt";
            this.tagTxt.Size = new System.Drawing.Size(116, 59);
            this.tagTxt.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Added Questions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Question";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Title";
            // 
            // addAllBtn
            // 
            this.addAllBtn.Location = new System.Drawing.Point(355, 237);
            this.addAllBtn.Name = "addAllBtn";
            this.addAllBtn.Size = new System.Drawing.Size(75, 23);
            this.addAllBtn.TabIndex = 14;
            this.addAllBtn.Text = "Add>>";
            this.addAllBtn.UseVisualStyleBackColor = true;
            this.addAllBtn.Click += new System.EventHandler(this.addAllBtn_Click);
            // 
            // addedQuestions
            // 
            this.addedQuestions.FormattingEnabled = true;
            this.addedQuestions.ItemHeight = 15;
            this.addedQuestions.Location = new System.Drawing.Point(228, 27);
            this.addedQuestions.Name = "addedQuestions";
            this.addedQuestions.Size = new System.Drawing.Size(202, 199);
            this.addedQuestions.TabIndex = 13;
            // 
            // addQBtn
            // 
            this.addQBtn.Location = new System.Drawing.Point(134, 264);
            this.addQBtn.Name = "addQBtn";
            this.addQBtn.Size = new System.Drawing.Size(75, 23);
            this.addQBtn.TabIndex = 12;
            this.addQBtn.Text = "Add>>";
            this.addQBtn.UseVisualStyleBackColor = true;
            this.addQBtn.Click += new System.EventHandler(this.addQBtn_Click);
            // 
            // questionbox
            // 
            this.questionbox.Location = new System.Drawing.Point(12, 74);
            this.questionbox.Multiline = true;
            this.questionbox.Name = "questionbox";
            this.questionbox.Size = new System.Drawing.Size(197, 107);
            this.questionbox.TabIndex = 11;
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(12, 27);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(197, 23);
            this.titleBox.TabIndex = 10;
            // 
            // tfAnsCheck
            // 
            this.tfAnsCheck.AutoSize = true;
            this.tfAnsCheck.Location = new System.Drawing.Point(14, 189);
            this.tfAnsCheck.Name = "tfAnsCheck";
            this.tfAnsCheck.Size = new System.Drawing.Size(91, 19);
            this.tfAnsCheck.TabIndex = 21;
            this.tfAnsCheck.Text = "True or False";
            this.tfAnsCheck.UseVisualStyleBackColor = true;
            // 
            // TFForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(447, 300);
            this.Controls.Add(this.tfAnsCheck);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tagTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addAllBtn);
            this.Controls.Add(this.addedQuestions);
            this.Controls.Add(this.addQBtn);
            this.Controls.Add(this.questionbox);
            this.Controls.Add(this.titleBox);
            this.Name = "TFForm";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TFForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label4;
        private TextBox tagTxt;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button addAllBtn;
        private ListBox addedQuestions;
        private Button addQBtn;
        private TextBox questionbox;
        private TextBox titleBox;
        private CheckBox tfAnsCheck;
    }
}