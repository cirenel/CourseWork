
namespace Nutrients
{
    partial class Primary
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
            this.EnteredFoods = new System.Windows.Forms.Label();
            this.listFoods = new System.Windows.Forms.ListBox();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.entryPanel = new System.Windows.Forms.Panel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.calorieBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLoadItem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.entryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.EnteredFoods);
            this.panel1.Controls.Add(this.listFoods);
            this.panel1.Controls.Add(this.buttonPanel);
            this.panel1.Controls.Add(this.entryPanel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1170, 1081);
            this.panel1.TabIndex = 3;
            // 
            // EnteredFoods
            // 
            this.EnteredFoods.AutoSize = true;
            this.EnteredFoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EnteredFoods.Location = new System.Drawing.Point(17, 29);
            this.EnteredFoods.Name = "EnteredFoods";
            this.EnteredFoods.Size = new System.Drawing.Size(227, 37);
            this.EnteredFoods.TabIndex = 7;
            this.EnteredFoods.Text = "Entered Foods";
            // 
            // listFoods
            // 
            this.listFoods.FormattingEnabled = true;
            this.listFoods.ItemHeight = 25;
            this.listFoods.Location = new System.Drawing.Point(24, 69);
            this.listFoods.Name = "listFoods";
            this.listFoods.Size = new System.Drawing.Size(502, 754);
            this.listFoods.TabIndex = 5;
            // 
            // buttonPanel
            // 
            this.buttonPanel.Location = new System.Drawing.Point(24, 843);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(1120, 203);
            this.buttonPanel.TabIndex = 6;
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Location = new System.Drawing.Point(403, 658);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(188, 103);
            this.buttonAddItem.TabIndex = 0;
            this.buttonAddItem.Text = "Add Item";
            this.buttonAddItem.UseVisualStyleBackColor = true;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // entryPanel
            // 
            this.entryPanel.Controls.Add(this.buttonLoadItem);
            this.entryPanel.Controls.Add(this.buttonAddItem);
            this.entryPanel.Controls.Add(this.textBox7);
            this.entryPanel.Controls.Add(this.label9);
            this.entryPanel.Controls.Add(this.textBox6);
            this.entryPanel.Controls.Add(this.label8);
            this.entryPanel.Controls.Add(this.textBox5);
            this.entryPanel.Controls.Add(this.label7);
            this.entryPanel.Controls.Add(this.textBox4);
            this.entryPanel.Controls.Add(this.label6);
            this.entryPanel.Controls.Add(this.textBox3);
            this.entryPanel.Controls.Add(this.label5);
            this.entryPanel.Controls.Add(this.textBox2);
            this.entryPanel.Controls.Add(this.label4);
            this.entryPanel.Controls.Add(this.textBox1);
            this.entryPanel.Controls.Add(this.label3);
            this.entryPanel.Controls.Add(this.calorieBox);
            this.entryPanel.Controls.Add(this.label2);
            this.entryPanel.Controls.Add(this.nameBox);
            this.entryPanel.Controls.Add(this.label1);
            this.entryPanel.Location = new System.Drawing.Point(532, 29);
            this.entryPanel.Name = "entryPanel";
            this.entryPanel.Size = new System.Drawing.Size(612, 794);
            this.entryPanel.TabIndex = 4;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(29, 694);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(206, 31);
            this.textBox7.TabIndex = 17;
            this.textBox7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.restrictNum_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 666);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "Protein (g)";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(29, 613);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(206, 31);
            this.textBox6.TabIndex = 15;
            this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.restrictNum_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 585);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Protein (g)";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(29, 532);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(206, 31);
            this.textBox5.TabIndex = 13;
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.restrictNum_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 504);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Protein (g)";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(29, 451);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(206, 31);
            this.textBox4.TabIndex = 11;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.restrictNum_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fat (g)";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(29, 370);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(206, 31);
            this.textBox3.TabIndex = 9;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.restrictNum_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sugars (g)";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(29, 289);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(206, 31);
            this.textBox2.TabIndex = 7;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.restrictNum_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sodium (g)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 208);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 31);
            this.textBox1.TabIndex = 5;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.restrictNum_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fiber (g)";
            // 
            // calorieBox
            // 
            this.calorieBox.Location = new System.Drawing.Point(29, 127);
            this.calorieBox.Name = "calorieBox";
            this.calorieBox.Size = new System.Drawing.Size(206, 31);
            this.calorieBox.TabIndex = 3;
            this.calorieBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.restrictNum_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Calories";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(29, 56);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(499, 31);
            this.nameBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // buttonLoadItem
            // 
            this.buttonLoadItem.Location = new System.Drawing.Point(403, 523);
            this.buttonLoadItem.Name = "buttonLoadItem";
            this.buttonLoadItem.Size = new System.Drawing.Size(188, 103);
            this.buttonLoadItem.TabIndex = 18;
            this.buttonLoadItem.Text = "Load Item";
            this.buttonLoadItem.UseVisualStyleBackColor = true;
            this.buttonLoadItem.Click += new System.EventHandler(this.buttonLoadItem_Click);
            // 
            // Primary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 1105);
            this.Controls.Add(this.panel1);
            this.Name = "Primary";
            this.Text = "Primary";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.entryPanel.ResumeLayout(false);
            this.entryPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label EnteredFoods;
        private System.Windows.Forms.ListBox listFoods;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button buttonAddItem;
        private System.Windows.Forms.Panel entryPanel;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox calorieBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLoadItem;
    }
}