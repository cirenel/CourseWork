
namespace PizzaOrder
{
    partial class DrinkOrderForm
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
            this.bttnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboSize = new System.Windows.Forms.ComboBox();
            this.comboDrink = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkIce = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // bttnAdd
            // 
            this.bttnAdd.Location = new System.Drawing.Point(140, 88);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(75, 23);
            this.bttnAdd.TabIndex = 0;
            this.bttnAdd.Text = "Add to Order";
            this.bttnAdd.UseVisualStyleBackColor = true;
            this.bttnAdd.Click += new System.EventHandler(this.bttnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Size (oz)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Drink";
            // 
            // comboSize
            // 
            this.comboSize.AutoCompleteCustomSource.AddRange(new string[] {
            "10",
            "12",
            "15",
            "20"});
            this.comboSize.FormattingEnabled = true;
            this.comboSize.Items.AddRange(new object[] {
            "10",
            "12",
            "16",
            "20"});
            this.comboSize.Location = new System.Drawing.Point(155, 19);
            this.comboSize.Name = "comboSize";
            this.comboSize.Size = new System.Drawing.Size(60, 23);
            this.comboSize.TabIndex = 3;
            // 
            // comboDrink
            // 
            this.comboDrink.AutoCompleteCustomSource.AddRange(new string[] {
            "Coke",
            "Diet Coke",
            "Coke 0",
            "Sprite",
            "Malk",
            "Water",
            "Tea (unsweet)",
            "Tea (sweet)",
            "Tears of the Forgotten "});
            this.comboDrink.FormattingEnabled = true;
            this.comboDrink.Items.AddRange(new object[] {
            "Coke",
            "Diet Coke",
            "Coke 0",
            "Sprite",
            "Malk",
            "Water",
            "Tea (unsweet)",
            "Tea (sweet)",
            "Tears of the Forgotten "});
            this.comboDrink.Location = new System.Drawing.Point(53, 56);
            this.comboDrink.Name = "comboDrink";
            this.comboDrink.Size = new System.Drawing.Size(162, 23);
            this.comboDrink.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ice?";
            // 
            // checkIce
            // 
            this.checkIce.AutoSize = true;
            this.checkIce.Checked = true;
            this.checkIce.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkIce.Location = new System.Drawing.Point(45, 23);
            this.checkIce.Name = "checkIce";
            this.checkIce.Size = new System.Drawing.Size(15, 14);
            this.checkIce.TabIndex = 6;
            this.checkIce.UseVisualStyleBackColor = true;
            // 
            // DrinkOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 123);
            this.Controls.Add(this.checkIce);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboDrink);
            this.Controls.Add(this.comboSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnAdd);
            this.Name = "DrinkOrderForm";
            this.Text = "DrinkOrderForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboSize;
        private System.Windows.Forms.ComboBox comboDrink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkIce;
    }
}