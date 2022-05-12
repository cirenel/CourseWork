
namespace BattleShip
{
    partial class BattleShipForm
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
            this.flowPanelA = new System.Windows.Forms.FlowLayoutPanel();
            this.flowPanelB = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowPanelA
            // 
            this.flowPanelA.Location = new System.Drawing.Point(12, 58);
            this.flowPanelA.Margin = new System.Windows.Forms.Padding(1);
            this.flowPanelA.Name = "flowPanelA";
            this.flowPanelA.Size = new System.Drawing.Size(550, 550);
            this.flowPanelA.TabIndex = 0;
            // 
            // flowPanelB
            // 
            this.flowPanelB.Location = new System.Drawing.Point(635, 58);
            this.flowPanelB.Margin = new System.Windows.Forms.Padding(1);
            this.flowPanelB.Name = "flowPanelB";
            this.flowPanelB.Size = new System.Drawing.Size(550, 550);
            this.flowPanelB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your Board";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(997, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enemy Board";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BattleShipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 621);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowPanelB);
            this.Controls.Add(this.flowPanelA);
            this.Name = "BattleShipForm";
            this.Text = "Battle Ship";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowPanelA;
        private System.Windows.Forms.FlowLayoutPanel flowPanelB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

