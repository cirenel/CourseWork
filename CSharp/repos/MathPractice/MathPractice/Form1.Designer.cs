
namespace MathPractice
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.totalProb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ansBox = new System.Windows.Forms.TextBox();
            this.curProb = new System.Windows.Forms.TextBox();
            this.mainButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score:";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.score.Location = new System.Drawing.Point(177, 25);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(54, 65);
            this.score.TabIndex = 1;
            this.score.Text = "0";
            // 
            // totalProb
            // 
            this.totalProb.AutoSize = true;
            this.totalProb.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalProb.Location = new System.Drawing.Point(278, 25);
            this.totalProb.Name = "totalProb";
            this.totalProb.Size = new System.Drawing.Size(54, 65);
            this.totalProb.TabIndex = 3;
            this.totalProb.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(231, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 65);
            this.label3.TabIndex = 2;
            this.label3.Text = "/";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ansBox);
            this.panel1.Controls.Add(this.curProb);
            this.panel1.Controls.Add(this.mainButton);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 460);
            this.panel1.TabIndex = 4;
            // 
            // ansBox
            // 
            this.ansBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ansBox.Location = new System.Drawing.Point(396, 181);
            this.ansBox.Name = "ansBox";
            this.ansBox.Size = new System.Drawing.Size(199, 64);
            this.ansBox.TabIndex = 9;
            this.ansBox.TextChanged += new System.EventHandler(this.ansBox_TextChanged);
            this.ansBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ansBox_KeyPress);
            // 
            // curProb
            // 
            this.curProb.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.curProb.Location = new System.Drawing.Point(22, 181);
            this.curProb.Name = "curProb";
            this.curProb.ReadOnly = true;
            this.curProb.Size = new System.Drawing.Size(356, 64);
            this.curProb.TabIndex = 8;
            this.curProb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mainButton
            // 
            this.mainButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainButton.Location = new System.Drawing.Point(22, 321);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(177, 117);
            this.mainButton.TabIndex = 7;
            this.mainButton.Text = "Start";
            this.mainButton.UseVisualStyleBackColor = true;
            this.mainButton.Click += new System.EventHandler(this.mainButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(418, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 117);
            this.button1.TabIndex = 1;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.totalProb);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.score);
            this.panel2.Location = new System.Drawing.Point(22, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 116);
            this.panel2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 489);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label totalProb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button mainButton;
        private System.Windows.Forms.TextBox ansBox;
        private System.Windows.Forms.TextBox curProb;
    }
}

