
namespace write
{
    partial class DisplayPopup
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
            this.bgWinCol = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.winTxtCol = new System.Windows.Forms.Button();
            this.textCol = new System.Windows.Forms.Button();
            this.txtBgCol = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttnBG = new System.Windows.Forms.Button();
            this.buttonTxt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bgWinCol
            // 
            this.bgWinCol.Location = new System.Drawing.Point(21, 16);
            this.bgWinCol.Name = "bgWinCol";
            this.bgWinCol.Size = new System.Drawing.Size(200, 23);
            this.bgWinCol.TabIndex = 0;
            this.bgWinCol.Text = "Select Window Background Color";
            this.bgWinCol.UseVisualStyleBackColor = true;
            this.bgWinCol.Click += new System.EventHandler(this.bgWinCol_Click);
            // 
            // winTxtCol
            // 
            this.winTxtCol.Location = new System.Drawing.Point(21, 45);
            this.winTxtCol.Name = "winTxtCol";
            this.winTxtCol.Size = new System.Drawing.Size(200, 23);
            this.winTxtCol.TabIndex = 1;
            this.winTxtCol.Text = "Select Window Text Color";
            this.winTxtCol.UseVisualStyleBackColor = true;
            this.winTxtCol.Click += new System.EventHandler(this.winTxtCol_Click);
            // 
            // textCol
            // 
            this.textCol.Location = new System.Drawing.Point(21, 103);
            this.textCol.Name = "textCol";
            this.textCol.Size = new System.Drawing.Size(200, 23);
            this.textCol.TabIndex = 2;
            this.textCol.Text = "Select Text Color";
            this.textCol.UseVisualStyleBackColor = true;
            this.textCol.Click += new System.EventHandler(this.textCol_Click);
            // 
            // txtBgCol
            // 
            this.txtBgCol.Location = new System.Drawing.Point(21, 74);
            this.txtBgCol.Name = "txtBgCol";
            this.txtBgCol.Size = new System.Drawing.Size(200, 23);
            this.txtBgCol.TabIndex = 3;
            this.txtBgCol.Text = "Select Text Background Color";
            this.txtBgCol.UseVisualStyleBackColor = true;
            this.txtBgCol.Click += new System.EventHandler(this.txtBgCol_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 244);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Opacity:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttnBG
            // 
            this.buttnBG.Location = new System.Drawing.Point(21, 132);
            this.buttnBG.Name = "buttnBG";
            this.buttnBG.Size = new System.Drawing.Size(200, 23);
            this.buttnBG.TabIndex = 7;
            this.buttnBG.Text = "Select Button Background Color";
            this.buttnBG.UseVisualStyleBackColor = true;
            this.buttnBG.Click += new System.EventHandler(this.buttnBG_Click);
            // 
            // buttonTxt
            // 
            this.buttonTxt.Location = new System.Drawing.Point(21, 161);
            this.buttonTxt.Name = "buttonTxt";
            this.buttonTxt.Size = new System.Drawing.Size(200, 23);
            this.buttonTxt.TabIndex = 8;
            this.buttonTxt.Text = "Select Button Text Color";
            this.buttonTxt.UseVisualStyleBackColor = true;
            this.buttonTxt.Click += new System.EventHandler(this.buttonTxt_Click);
            // 
            // DisplayPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 371);
            this.Controls.Add(this.buttonTxt);
            this.Controls.Add(this.buttnBG);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtBgCol);
            this.Controls.Add(this.textCol);
            this.Controls.Add(this.winTxtCol);
            this.Controls.Add(this.bgWinCol);
            this.Name = "DisplayPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Display Op Popup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bgWinCol;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button winTxtCol;
        private System.Windows.Forms.Button textCol;
        private System.Windows.Forms.Button txtBgCol;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttnBG;
        private System.Windows.Forms.Button buttonTxt;
    }
}