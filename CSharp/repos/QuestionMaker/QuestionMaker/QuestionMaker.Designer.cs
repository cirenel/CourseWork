namespace QuestionMaker
{
    partial class QuestionMaker
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.writeButton = new System.Windows.Forms.Button();
            this.questionTypes = new System.Windows.Forms.ListBox();
            this.createButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 32;
            this.listBox1.Location = new System.Drawing.Point(557, 26);
            this.listBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(420, 740);
            this.listBox1.TabIndex = 1;
            // 
            // writeButton
            // 
            this.writeButton.Location = new System.Drawing.Point(557, 811);
            this.writeButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(423, 124);
            this.writeButton.TabIndex = 2;
            this.writeButton.Text = "Write";
            this.writeButton.UseVisualStyleBackColor = true;
            this.writeButton.Click += new System.EventHandler(this.writeButton_Click);
            // 
            // questionTypes
            // 
            this.questionTypes.FormattingEnabled = true;
            this.questionTypes.ItemHeight = 32;
            this.questionTypes.Items.AddRange(new object[] {
            "True-False",
            "Multiple Choice",
            "Matching",
            "Category Change",
            "Q-A Table"});
            this.questionTypes.Location = new System.Drawing.Point(22, 26);
            this.questionTypes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.questionTypes.Name = "questionTypes";
            this.questionTypes.Size = new System.Drawing.Size(307, 260);
            this.questionTypes.TabIndex = 3;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(344, 26);
            this.createButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(202, 265);
            this.createButton.TabIndex = 4;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // QuestionMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(999, 960);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.questionTypes);
            this.Controls.Add(this.writeButton);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "QuestionMaker";
            this.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Moodle Question Maker";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listBox1;
        private Button writeButton;
        private ListBox questionTypes;
        private Button createButton;
        private SaveFileDialog saveFileDialog1;
    }
}