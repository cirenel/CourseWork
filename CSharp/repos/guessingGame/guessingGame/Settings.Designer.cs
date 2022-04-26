
namespace guessingGame
{
    partial class Settings
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
            this.txtLo = new System.Windows.Forms.TextBox();
            this.hiTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.turnTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "low num";
            // 
            // txtLo
            // 
            this.txtLo.Location = new System.Drawing.Point(126, 12);
            this.txtLo.Name = "txtLo";
            this.txtLo.Size = new System.Drawing.Size(100, 31);
            this.txtLo.TabIndex = 1;
            // 
            // hiTxt
            // 
            this.hiTxt.Location = new System.Drawing.Point(126, 49);
            this.hiTxt.Name = "hiTxt";
            this.hiTxt.Size = new System.Drawing.Size(100, 31);
            this.hiTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "hi num";
            // 
            // turnTxt
            // 
            this.turnTxt.Location = new System.Drawing.Point(126, 86);
            this.turnTxt.Name = "turnTxt";
            this.turnTxt.Size = new System.Drawing.Size(100, 31);
            this.turnTxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "num turn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 68);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 256);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.turnTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hiTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLo);
            this.Controls.Add(this.label1);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLo;
        private System.Windows.Forms.TextBox hiTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox turnTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}