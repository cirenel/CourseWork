
namespace GradeBook
{
    partial class GradeCalc
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.letterGrade = new System.Windows.Forms.Label();
            this.gradeNumber = new System.Windows.Forms.Label();
            this.gradeList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(478, 434);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 78);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(594, 527);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(150, 46);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add Grade";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(478, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your Grade:";
            // 
            // letterGrade
            // 
            this.letterGrade.AutoSize = true;
            this.letterGrade.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.letterGrade.Location = new System.Drawing.Point(583, 172);
            this.letterGrade.Name = "letterGrade";
            this.letterGrade.Size = new System.Drawing.Size(161, 177);
            this.letterGrade.TabIndex = 3;
            this.letterGrade.Text = "A";
            // 
            // gradeNumber
            // 
            this.gradeNumber.AutoSize = true;
            this.gradeNumber.Location = new System.Drawing.Point(504, 288);
            this.gradeNumber.Name = "gradeNumber";
            this.gradeNumber.Size = new System.Drawing.Size(84, 32);
            this.gradeNumber.TabIndex = 4;
            this.gradeNumber.Text = "100.00";
            this.gradeNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gradeList
            // 
            this.gradeList.FormattingEnabled = true;
            this.gradeList.ItemHeight = 32;
            this.gradeList.Location = new System.Drawing.Point(12, 74);
            this.gradeList.Name = "gradeList";
            this.gradeList.Size = new System.Drawing.Size(380, 452);
            this.gradeList.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Grades:";
            // 
            // GradeCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 657);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gradeList);
            this.Controls.Add(this.gradeNumber);
            this.Controls.Add(this.letterGrade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBox1);
            this.Name = "GradeCalc";
            this.Text = "Grade Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label letterGrade;
        private System.Windows.Forms.Label gradeNumber;
        private System.Windows.Forms.ListBox gradeList;
        private System.Windows.Forms.Label label2;
    }
}

