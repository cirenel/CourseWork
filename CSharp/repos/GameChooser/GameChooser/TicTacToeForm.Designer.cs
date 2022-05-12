
namespace GameChooser
{
    partial class TicTacToeForm
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
            this.gameBoardText = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colTextBox = new System.Windows.Forms.TextBox();
            this.rowTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // gameBoardText
            // 
            this.gameBoardText.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameBoardText.Location = new System.Drawing.Point(12, 12);
            this.gameBoardText.Name = "gameBoardText";
            this.gameBoardText.ReadOnly = true;
            this.gameBoardText.Size = new System.Drawing.Size(203, 203);
            this.gameBoardText.TabIndex = 0;
            this.gameBoardText.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Place X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.play_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Col";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Row";
            // 
            // colTextBox
            // 
            this.colTextBox.Location = new System.Drawing.Point(49, 245);
            this.colTextBox.Name = "colTextBox";
            this.colTextBox.Size = new System.Drawing.Size(50, 20);
            this.colTextBox.TabIndex = 4;
            // 
            // rowTextBox
            // 
            this.rowTextBox.Location = new System.Drawing.Point(127, 245);
            this.rowTextBox.Name = "rowTextBox";
            this.rowTextBox.Size = new System.Drawing.Size(50, 20);
            this.rowTextBox.TabIndex = 5;
            // 
            // TicTacToeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 307);
            this.Controls.Add(this.rowTextBox);
            this.Controls.Add(this.colTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gameBoardText);
            this.Name = "TicTacToeForm";
            this.Text = "TicTacToeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox gameBoardText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox colTextBox;
        private System.Windows.Forms.TextBox rowTextBox;
    }
}