
using System;
using System.Drawing;

namespace MagicEight
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
            this.questionBox = new System.Windows.Forms.TextBox();
            this.askButton = new System.Windows.Forms.Button();
            this.answerBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(6, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ask a Question";
            // 
            // questionBox
            // 
            this.questionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.questionBox.Location = new System.Drawing.Point(10, 103);
            this.questionBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.questionBox.Name = "questionBox";
            this.questionBox.Size = new System.Drawing.Size(390, 26);
            this.questionBox.TabIndex = 1;
            // 
            // askButton
            // 
            this.askButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.askButton.Location = new System.Drawing.Point(310, 141);
            this.askButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.askButton.Name = "askButton";
            this.askButton.Size = new System.Drawing.Size(87, 50);
            this.askButton.TabIndex = 2;
            this.askButton.Text = "Ask";
            this.askButton.UseVisualStyleBackColor = true;
            this.askButton.Click += new System.EventHandler(this.button1_Click);
            this.askButton.Enter += new System.EventHandler(this.colorChange);
            this.askButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.askButton_KeyPress);
            // 
            // answerBox
            // 
            this.answerBox.AutoSize = true;
            this.answerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.answerBox.Location = new System.Drawing.Point(6, 20);
            this.answerBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(392, 31);
            this.answerBox.TabIndex = 3;
            this.answerBox.Text = "                                                      ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 209);
            this.Controls.Add(this.answerBox);
            this.Controls.Add(this.askButton);
            this.Controls.Add(this.questionBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void colorChange(object sender, EventArgs e)
        {
            Random r = new Random(); 
            int R = r.Next(0,236), G = r.Next(0, 236), B = r.Next(0, 236);
            ((System.Windows.Forms.Button)sender).BackColor =  Color.FromArgb(R,G,B);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox questionBox;
        private System.Windows.Forms.Button askButton;
        private System.Windows.Forms.Label answerBox;
    }
}

