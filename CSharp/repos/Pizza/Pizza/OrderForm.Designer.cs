
namespace PizzaOrder
{
    partial class OrderForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listboxOrder = new System.Windows.Forms.ListBox();
            this.textBoxSubtotal = new System.Windows.Forms.TextBox();
            this.textBoxTax = new System.Windows.Forms.TextBox();
            this.textBoxTip = new System.Windows.Forms.TextBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.btnAddPizza = new System.Windows.Forms.Button();
            this.btnAddDrink = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 378);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tip:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 358);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tax:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 337);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Subtotal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 399);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Your order:";
            // 
            // listboxOrder
            // 
            this.listboxOrder.AllowDrop = true;
            this.listboxOrder.FormattingEnabled = true;
            this.listboxOrder.ItemHeight = 15;
            this.listboxOrder.Location = new System.Drawing.Point(111, 26);
            this.listboxOrder.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.listboxOrder.Name = "listboxOrder";
            this.listboxOrder.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listboxOrder.Size = new System.Drawing.Size(167, 304);
            this.listboxOrder.TabIndex = 9;
            // 
            // textBoxSubtotal
            // 
            this.textBoxSubtotal.Location = new System.Drawing.Point(185, 336);
            this.textBoxSubtotal.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBoxSubtotal.Name = "textBoxSubtotal";
            this.textBoxSubtotal.ReadOnly = true;
            this.textBoxSubtotal.Size = new System.Drawing.Size(93, 23);
            this.textBoxSubtotal.TabIndex = 10;
            // 
            // textBoxTax
            // 
            this.textBoxTax.Location = new System.Drawing.Point(185, 357);
            this.textBoxTax.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBoxTax.Name = "textBoxTax";
            this.textBoxTax.ReadOnly = true;
            this.textBoxTax.Size = new System.Drawing.Size(93, 23);
            this.textBoxTax.TabIndex = 11;
            // 
            // textBoxTip
            // 
            this.textBoxTip.Location = new System.Drawing.Point(185, 378);
            this.textBoxTip.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBoxTip.Name = "textBoxTip";
            this.textBoxTip.Size = new System.Drawing.Size(93, 23);
            this.textBoxTip.TabIndex = 12;
            this.textBoxTip.Validated += new System.EventHandler(this.textBoxTip_TextChanged);
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(185, 399);
            this.textBoxTotal.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(93, 23);
            this.textBoxTotal.TabIndex = 13;
            // 
            // btnAddPizza
            // 
            this.btnAddPizza.Location = new System.Drawing.Point(8, 15);
            this.btnAddPizza.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAddPizza.Name = "btnAddPizza";
            this.btnAddPizza.Size = new System.Drawing.Size(81, 22);
            this.btnAddPizza.TabIndex = 14;
            this.btnAddPizza.Text = "Add Pizza";
            this.btnAddPizza.UseVisualStyleBackColor = true;
            this.btnAddPizza.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddDrink
            // 
            this.btnAddDrink.Location = new System.Drawing.Point(8, 50);
            this.btnAddDrink.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAddDrink.Name = "btnAddDrink";
            this.btnAddDrink.Size = new System.Drawing.Size(81, 22);
            this.btnAddDrink.TabIndex = 15;
            this.btnAddDrink.Text = "Add Drink";
            this.btnAddDrink.UseVisualStyleBackColor = true;
            this.btnAddDrink.Click += new System.EventHandler(this.btnAddDrink_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(8, 397);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(81, 22);
            this.btnCheckout.TabIndex = 16;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 447);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnAddDrink);
            this.Controls.Add(this.btnAddPizza);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.textBoxTip);
            this.Controls.Add(this.textBoxTax);
            this.Controls.Add(this.textBoxSubtotal);
            this.Controls.Add(this.listboxOrder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Location = new System.Drawing.Point(500, 0);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "OrderForm";
            this.Text = "Order Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listboxOrder;
        private System.Windows.Forms.TextBox textBoxSubtotal;
        private System.Windows.Forms.TextBox textBoxTax;
        private System.Windows.Forms.TextBox textBoxTip;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Button btnAddPizza;
        private System.Windows.Forms.Button btnAddDrink;
        private System.Windows.Forms.Button btnCheckout;
    }
}

