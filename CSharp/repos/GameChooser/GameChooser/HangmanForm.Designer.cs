
namespace GameChooser
{
    partial class HangmanForm
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
            this.gameDisplayBox = new System.Windows.Forms.RichTextBox();
            this.guessButton = new System.Windows.Forms.Button();
            this.guessTextBox = new System.Windows.Forms.MaskedTextBox();
            this.goodGuessedTextBox = new System.Windows.Forms.TextBox();
            this.badGuessedTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // gameDisplayBox
            // 
            this.gameDisplayBox.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameDisplayBox.Location = new System.Drawing.Point(13, 13);
            this.gameDisplayBox.Name = "gameDisplayBox";
            this.gameDisplayBox.ReadOnly = true;
            this.gameDisplayBox.Size = new System.Drawing.Size(309, 298);
            this.gameDisplayBox.TabIndex = 0;
            this.gameDisplayBox.Text = "";
            // 
            // guessButton
            // 
            this.guessButton.Location = new System.Drawing.Point(330, 63);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(186, 23);
            this.guessButton.TabIndex = 1;
            this.guessButton.Text = "Guess";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
            // 
            // guessTextBox
            // 
            this.guessTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.guessTextBox.Location = new System.Drawing.Point(373, 25);
            this.guessTextBox.Mask = "L";
            this.guessTextBox.Name = "guessTextBox";
            this.guessTextBox.Size = new System.Drawing.Size(100, 32);
            this.guessTextBox.TabIndex = 2;
            this.guessTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // goodGuessedTextBox
            // 
            this.goodGuessedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.goodGuessedTextBox.Location = new System.Drawing.Point(330, 124);
            this.goodGuessedTextBox.Name = "goodGuessedTextBox";
            this.goodGuessedTextBox.Size = new System.Drawing.Size(186, 26);
            this.goodGuessedTextBox.TabIndex = 3;
            // 
            // badGuessedTextBox
            // 
            this.badGuessedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.badGuessedTextBox.Location = new System.Drawing.Point(330, 175);
            this.badGuessedTextBox.Name = "badGuessedTextBox";
            this.badGuessedTextBox.Size = new System.Drawing.Size(186, 26);
            this.badGuessedTextBox.TabIndex = 4;
            // 
            // HangmanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 335);
            this.Controls.Add(this.badGuessedTextBox);
            this.Controls.Add(this.goodGuessedTextBox);
            this.Controls.Add(this.guessTextBox);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.gameDisplayBox);
            this.Name = "HangmanForm";
            this.Text = "HangmanForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox gameDisplayBox;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.MaskedTextBox guessTextBox;
        private System.Windows.Forms.TextBox goodGuessedTextBox;
        private System.Windows.Forms.TextBox badGuessedTextBox;
    }
}