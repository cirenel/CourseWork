
namespace GameChooser
{
    partial class GuessingGameForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.guessTextBox = new System.Windows.Forms.MaskedTextBox();
            this.replyLabel = new System.Windows.Forms.Label();
            this.guessButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "I\'m thinking of a number....";
            // 
            // guessTextBox
            // 
            this.guessTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.guessTextBox.Location = new System.Drawing.Point(18, 54);
            this.guessTextBox.Mask = "000";
            this.guessTextBox.Name = "guessTextBox";
            this.guessTextBox.Size = new System.Drawing.Size(71, 32);
            this.guessTextBox.TabIndex = 1;
            this.guessTextBox.ValidatingType = typeof(int);
            // 
            // replyLabel
            // 
            this.replyLabel.AutoSize = true;
            this.replyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.replyLabel.Location = new System.Drawing.Point(12, 112);
            this.replyLabel.Name = "replyLabel";
            this.replyLabel.Size = new System.Drawing.Size(84, 20);
            this.replyLabel.TabIndex = 2;
            this.replyLabel.Text = "---------------";
            // 
            // guessButton
            // 
            this.guessButton.Location = new System.Drawing.Point(132, 54);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(112, 32);
            this.guessButton.TabIndex = 3;
            this.guessButton.Text = "Guess";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
            // 
            // GuessingGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 154);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.replyLabel);
            this.Controls.Add(this.guessTextBox);
            this.Controls.Add(this.label1);
            this.Name = "GuessingGameForm";
            this.Text = "GuessingGameForm";

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox guessTextBox;
        private System.Windows.Forms.Label replyLabel;
        private System.Windows.Forms.Button guessButton;
    }
}