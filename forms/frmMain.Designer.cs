namespace Magazyn
{
    partial class frmMain
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zmienHasloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZarządzajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.administratorToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(662, 24);
            this.menu.TabIndex = 2;
            this.menu.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zmienHasloToolStripMenuItem,
            this.zamknijSystemToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.menuToolStripMenuItem.Text = "System";
            // 
            // zmienHasloToolStripMenuItem
            // 
            this.zmienHasloToolStripMenuItem.Name = "zmienHasloToolStripMenuItem";
            this.zmienHasloToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.zmienHasloToolStripMenuItem.Text = "Zmień Hasło";
            this.zmienHasloToolStripMenuItem.Click += new System.EventHandler(this.zmienHasloToolStripMenuItem_Click);
            // 
            // zamknijSystemToolStripMenuItem
            // 
            this.zamknijSystemToolStripMenuItem.Name = "zamknijSystemToolStripMenuItem";
            this.zamknijSystemToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.zamknijSystemToolStripMenuItem.Text = "Zamknij System";
            this.zamknijSystemToolStripMenuItem.Click += new System.EventHandler(this.zamknijSystemToolStripMenuItem_Click);
            // 
            // administratorToolStripMenuItem
            // 
            this.administratorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ZarządzajToolStripMenuItem});
            this.administratorToolStripMenuItem.Name = "administratorToolStripMenuItem";
            this.administratorToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.administratorToolStripMenuItem.Text = "Administrator";
            this.administratorToolStripMenuItem.Visible = false;
            // 
            // ZarządzajToolStripMenuItem
            // 
            this.ZarządzajToolStripMenuItem.Name = "ZarządzajToolStripMenuItem";
            this.ZarządzajToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.ZarządzajToolStripMenuItem.Text = "Zarządzaj Użytkownikami";
            this.ZarządzajToolStripMenuItem.Click += new System.EventHandler(this.ZarządzajToolStripMenuItem_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWelcome.Location = new System.Drawing.Point(12, 45);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(199, 33);
            this.labelWelcome.TabIndex = 3;
            this.labelWelcome.Text = "labelWelcome";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 315);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.menu);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zmienHasloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ZarządzajToolStripMenuItem;
        private System.Windows.Forms.Label labelWelcome;

    }
}