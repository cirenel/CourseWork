
namespace write
{
    partial class Writer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Writer));
            this.textBody = new System.Windows.Forms.RichTextBox();
            this.saveSect = new System.Windows.Forms.Button();
            this.sectionTitle = new System.Windows.Forms.TextBox();
            this.sectionList = new System.Windows.Forms.ListBox();
            this.saveClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.itemDown = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBody
            // 
            this.textBody.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBody, "textBody");
            this.textBody.ForeColor = System.Drawing.SystemColors.Window;
            this.textBody.Name = "textBody";
            this.textBody.TabStop = false;
            // 
            // saveSect
            // 
            this.saveSect.BackColor = System.Drawing.Color.Black;
            this.saveSect.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.saveSect, "saveSect");
            this.saveSect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveSect.Name = "saveSect";
            this.saveSect.UseVisualStyleBackColor = false;
            this.saveSect.Click += new System.EventHandler(this.saveSect_Click);
            // 
            // sectionTitle
            // 
            this.sectionTitle.BackColor = System.Drawing.SystemColors.MenuText;
            this.sectionTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sectionTitle.ForeColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.sectionTitle, "sectionTitle");
            this.sectionTitle.Name = "sectionTitle";
            this.sectionTitle.TextChanged += new System.EventHandler(this.sectionTitle_TextChanged);
            // 
            // sectionList
            // 
            this.sectionList.BackColor = System.Drawing.SystemColors.MenuText;
            this.sectionList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.sectionList, "sectionList");
            this.sectionList.ForeColor = System.Drawing.SystemColors.Window;
            this.sectionList.FormattingEnabled = true;
            this.sectionList.Name = "sectionList";
            this.sectionList.DoubleClick += new System.EventHandler(this.sectionList_DoubleClick);
            // 
            // saveClear
            // 
            this.saveClear.BackColor = System.Drawing.Color.Black;
            this.saveClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.saveClear, "saveClear");
            this.saveClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveClear.Name = "saveClear";
            this.saveClear.UseVisualStyleBackColor = false;
            this.saveClear.Click += new System.EventHandler(this.saveClearSect_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.displayToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.saveProjectToolStripMenuItem,
            this.loadProjectToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            resources.ApplyResources(this.newProjectToolStripMenuItem, "newProjectToolStripMenuItem");
            this.newProjectToolStripMenuItem.Click += new System.EventHandler(this.newProjectToolStripMenuItem_Click);
            // 
            // saveProjectToolStripMenuItem
            // 
            this.saveProjectToolStripMenuItem.Name = "saveProjectToolStripMenuItem";
            resources.ApplyResources(this.saveProjectToolStripMenuItem, "saveProjectToolStripMenuItem");
            this.saveProjectToolStripMenuItem.Click += new System.EventHandler(this.saveProjectToolStripMenuItem_Click);
            // 
            // loadProjectToolStripMenuItem
            // 
            this.loadProjectToolStripMenuItem.Name = "loadProjectToolStripMenuItem";
            resources.ApplyResources(this.loadProjectToolStripMenuItem, "loadProjectToolStripMenuItem");
            this.loadProjectToolStripMenuItem.Click += new System.EventHandler(this.loadProjectToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontSizeToolStripMenuItem,
            this.colorOptionsToolStripMenuItem});
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            resources.ApplyResources(this.displayToolStripMenuItem, "displayToolStripMenuItem");
            // 
            // fontSizeToolStripMenuItem
            // 
            this.fontSizeToolStripMenuItem.Name = "fontSizeToolStripMenuItem";
            resources.ApplyResources(this.fontSizeToolStripMenuItem, "fontSizeToolStripMenuItem");
            this.fontSizeToolStripMenuItem.Click += new System.EventHandler(this.fontSizeToolStripMenuItem_Click);
            // 
            // colorOptionsToolStripMenuItem
            // 
            this.colorOptionsToolStripMenuItem.Name = "colorOptionsToolStripMenuItem";
            resources.ApplyResources(this.colorOptionsToolStripMenuItem, "colorOptionsToolStripMenuItem");
            this.colorOptionsToolStripMenuItem.Click += new System.EventHandler(this.colorOptionsToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.button2, "button2");
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.itemUp_Click);
            // 
            // itemDown
            // 
            this.itemDown.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.itemDown, "itemDown");
            this.itemDown.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.itemDown.Name = "itemDown";
            this.itemDown.UseVisualStyleBackColor = false;
            this.itemDown.Click += new System.EventHandler(this.itemDown_Click);
            // 
            // Writer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.Controls.Add(this.itemDown);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.saveClear);
            this.Controls.Add(this.sectionList);
            this.Controls.Add(this.sectionTitle);
            this.Controls.Add(this.saveSect);
            this.Controls.Add(this.textBody);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Writer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textBody;
        private System.Windows.Forms.Button saveSect;
        private System.Windows.Forms.TextBox sectionTitle;
        private System.Windows.Forms.ListBox sectionList;
        private System.Windows.Forms.Button saveClear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorOptionsToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button itemDown;
        private System.Windows.Forms.ToolStripMenuItem fontSizeToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

