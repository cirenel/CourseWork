
namespace Tables
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dropdownOp = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dropdownJ = new System.Windows.Forms.ComboBox();
            this.dropdownI = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dropdownOp);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dropdownJ);
            this.panel1.Controls.Add(this.dropdownI);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.outputBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1911, 1375);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(14, 589);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 95);
            this.button1.TabIndex = 7;
            this.button1.Text = "Do the thing!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dropdownOp
            // 
            this.dropdownOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dropdownOp.FormattingEnabled = true;
            this.dropdownOp.Items.AddRange(new object[] {
            "*",
            "/",
            "+",
            "-",
            "%"});
            this.dropdownOp.Location = new System.Drawing.Point(122, 447);
            this.dropdownOp.Name = "dropdownOp";
            this.dropdownOp.Size = new System.Drawing.Size(121, 59);
            this.dropdownOp.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(3, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 63);
            this.label3.TabIndex = 5;
            this.label3.Text = "Operator";
            // 
            // dropdownJ
            // 
            this.dropdownJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dropdownJ.FormattingEnabled = true;
            this.dropdownJ.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.dropdownJ.Location = new System.Drawing.Point(122, 265);
            this.dropdownJ.Name = "dropdownJ";
            this.dropdownJ.Size = new System.Drawing.Size(121, 59);
            this.dropdownJ.TabIndex = 4;
            // 
            // dropdownI
            // 
            this.dropdownI.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dropdownI.FormattingEnabled = true;
            this.dropdownI.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.dropdownI.Location = new System.Drawing.Point(122, 91);
            this.dropdownI.Name = "dropdownI";
            this.dropdownI.Size = new System.Drawing.Size(121, 59);
            this.dropdownI.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(203, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 63);
            this.label2.TabIndex = 2;
            this.label2.Text = "j";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(203, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = "i";
            // 
            // outputBox
            // 
            this.outputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputBox.Location = new System.Drawing.Point(282, 3);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(1626, 1369);
            this.outputBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1935, 1399);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox dropdownOp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox dropdownJ;
        private System.Windows.Forms.ComboBox dropdownI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox outputBox;
    }
}

