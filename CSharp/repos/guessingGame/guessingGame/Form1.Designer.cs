
namespace guessingGame
{
    partial class Form1
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
            this.buttonGuess = new System.Windows.Forms.Button();
            this.guessText = new System.Windows.Forms.TextBox();
            this.buttonSetting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "I\'m thinking of a number...";
            // 
            // buttonGuess
            // 
            this.buttonGuess.Location = new System.Drawing.Point(472, 153);
            this.buttonGuess.Name = "buttonGuess";
            this.buttonGuess.Size = new System.Drawing.Size(138, 89);
            this.buttonGuess.TabIndex = 1;
            this.buttonGuess.Text = "Guess";
            this.buttonGuess.UseVisualStyleBackColor = true;
            this.buttonGuess.Click += new System.EventHandler(this.buttonGuess_Click);
            // 
            // guessText
            // 
            this.guessText.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.guessText.Location = new System.Drawing.Point(21, 153);
            this.guessText.Name = "guessText";
            this.guessText.Size = new System.Drawing.Size(409, 83);
            this.guessText.TabIndex = 2;
            // 
            // buttonSetting
            // 
            this.buttonSetting.Location = new System.Drawing.Point(21, 373);
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.Size = new System.Drawing.Size(112, 54);
            this.buttonSetting.TabIndex = 3;
            this.buttonSetting.Text = "Settings";
            this.buttonSetting.UseVisualStyleBackColor = true;
            this.buttonSetting.Click += new System.EventHandler(this.buttonSetting_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSetting);
            this.Controls.Add(this.guessText);
            this.Controls.Add(this.buttonGuess);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGuess;
        private System.Windows.Forms.TextBox guessText;
        private System.Windows.Forms.Button buttonSetting;
    }
}

