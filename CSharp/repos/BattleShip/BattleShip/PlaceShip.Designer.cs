
namespace BattleShip
{
    partial class PlaceShip
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
            this.placeButton = new System.Windows.Forms.Button();
            this.vert = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.leftText = new System.Windows.Forms.TextBox();
            this.topText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // placeButton
            // 
            this.placeButton.Location = new System.Drawing.Point(208, 53);
            this.placeButton.Name = "placeButton";
            this.placeButton.Size = new System.Drawing.Size(75, 48);
            this.placeButton.TabIndex = 0;
            this.placeButton.Text = "Place";
            this.placeButton.UseVisualStyleBackColor = true;
            this.placeButton.Click += new System.EventHandler(this.placeButton_Click);
            // 
            // vert
            // 
            this.vert.Location = new System.Drawing.Point(12, 53);
            this.vert.Name = "vert";
            this.vert.Size = new System.Drawing.Size(75, 48);
            this.vert.TabIndex = 1;
            this.vert.Text = "Vertical";
            this.vert.UseVisualStyleBackColor = true;
            this.vert.Click += new System.EventHandler(this.vert_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.messageLabel.Location = new System.Drawing.Point(12, 16);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(155, 20);
            this.messageLabel.TabIndex = 2;
            this.messageLabel.Text = "Place ship of length: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Top:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Left:";
            // 
            // leftText
            // 
            this.leftText.Location = new System.Drawing.Point(129, 53);
            this.leftText.Name = "leftText";
            this.leftText.Size = new System.Drawing.Size(73, 20);
            this.leftText.TabIndex = 5;
            this.leftText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numlock_KeyPress);
            // 
            // topText
            // 
            this.topText.Location = new System.Drawing.Point(129, 81);
            this.topText.Name = "topText";
            this.topText.Size = new System.Drawing.Size(73, 20);
            this.topText.TabIndex = 6;
            this.topText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numlock_KeyPress);
            // 
            // PlaceShip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 113);
            this.Controls.Add(this.topText);
            this.Controls.Add(this.leftText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.vert);
            this.Controls.Add(this.placeButton);
            this.Name = "PlaceShip";
            this.Text = "PlaceShip";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button placeButton;
        private System.Windows.Forms.Button vert;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox leftText;
        private System.Windows.Forms.TextBox topText;
    }
}