
namespace GameChooser
{
    partial class GameChooser
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
            this.gameChoice = new System.Windows.Forms.ComboBox();
            this.playButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.winLabel = new System.Windows.Forms.Label();
            this.lossLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameChoice
            // 
            this.gameChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.gameChoice.FormattingEnabled = true;
            this.gameChoice.Items.AddRange(new object[] {
            "Guessing Game",
            "Hangman",
            "Tic-Tac-Toe"});
            this.gameChoice.Location = new System.Drawing.Point(28, 59);
            this.gameChoice.Name = "gameChoice";
            this.gameChoice.Size = new System.Drawing.Size(218, 33);
            this.gameChoice.TabIndex = 0;
            // 
            // playButton
            // 
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.playButton.Location = new System.Drawing.Point(96, 98);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(82, 42);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose your game....";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Win";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(210, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Loss";
            // 
            // winLabel
            // 
            this.winLabel.AutoSize = true;
            this.winLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.winLabel.Location = new System.Drawing.Point(12, 193);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(42, 20);
            this.winLabel.TabIndex = 5;
            this.winLabel.Text = "XXX";
            // 
            // lossLabel
            // 
            this.lossLabel.AutoSize = true;
            this.lossLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lossLabel.Location = new System.Drawing.Point(211, 193);
            this.lossLabel.Name = "lossLabel";
            this.lossLabel.Size = new System.Drawing.Size(42, 20);
            this.lossLabel.TabIndex = 6;
            this.lossLabel.Text = "XXX";
            // 
            // GameChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 229);
            this.Controls.Add(this.lossLabel);
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.gameChoice);
            this.Name = "GameChooser";
            this.Text = "Game Chooser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox gameChoice;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Label lossLabel;
    }
}

