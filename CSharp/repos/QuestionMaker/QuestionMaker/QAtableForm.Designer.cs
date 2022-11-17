
namespace QuestionMaker
{
    partial class QAtableForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.numInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.titleText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.borderText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.paddingText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.questionText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.01556F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.98444F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(31, 175);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1023, 200);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // numInput
            // 
            this.numInput.Location = new System.Drawing.Point(13, 48);
            this.numInput.Name = "numInput";
            this.numInput.Size = new System.Drawing.Size(200, 39);
            this.numInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of Inputs";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Create Prompts";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(869, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 46);
            this.button2.TabIndex = 4;
            this.button2.Text = "Create Question";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Question Title";
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(219, 48);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(237, 39);
            this.titleText.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(707, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Border thickness";
            // 
            // borderText
            // 
            this.borderText.Location = new System.Drawing.Point(707, 48);
            this.borderText.Name = "borderText";
            this.borderText.Size = new System.Drawing.Size(200, 39);
            this.borderText.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(913, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "Padding";
            // 
            // paddingText
            // 
            this.paddingText.Location = new System.Drawing.Point(913, 48);
            this.paddingText.Name = "paddingText";
            this.paddingText.Size = new System.Drawing.Size(200, 39);
            this.paddingText.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(462, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 32);
            this.label5.TabIndex = 12;
            this.label5.Text = "Instructions";
            // 
            // questionText
            // 
            this.questionText.Location = new System.Drawing.Point(462, 48);
            this.questionText.Multiline = true;
            this.questionText.Name = "questionText";
            this.questionText.Size = new System.Drawing.Size(237, 110);
            this.questionText.TabIndex = 11;
            // 
            // QAtableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 1818);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.questionText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.paddingText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.borderText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numInput);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "QAtableForm";
            this.Text = "QAtableForm";
            this.Load += new System.EventHandler(this.QAtableForm_Load);
            this.TextChanged += new System.EventHandler(this.QAtableForm_TextChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox numInput;
        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
        private TextBox titleText;
        private Label label3;
        private TextBox borderText;
        private Label label4;
        private TextBox paddingText;
        private Label label5;
        private TextBox questionText;
    }
}