namespace FFLinkMain
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tmrSnapshot = new System.Windows.Forms.Timer(this.components);
            this.icnTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.mnuTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrHide = new System.Windows.Forms.Timer(this.components);
            this.tmrShowControlsForm = new System.Windows.Forms.Timer(this.components);
            this.mnuTray.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrSnapshot
            // 
            this.tmrSnapshot.Interval = 1000;
            this.tmrSnapshot.Tick += new System.EventHandler(this.tmrSnapshot_Tick);
            // 
            // icnTray
            // 
            this.icnTray.ContextMenuStrip = this.mnuTray;
            this.icnTray.Icon = ((System.Drawing.Icon)(resources.GetObject("icnTray.Icon")));
            this.icnTray.Text = "notifyIcon1";
            this.icnTray.Visible = true;
            // 
            // mnuTray
            // 
            this.mnuTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.mnuTray.Name = "mnuTray";
            this.mnuTray.Size = new System.Drawing.Size(98, 26);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // tmrHide
            // 
            this.tmrHide.Enabled = true;
            this.tmrHide.Interval = 1000;
            this.tmrHide.Tick += new System.EventHandler(this.tmrHide_Tick);
            // 
            // tmrShowControlsForm
            // 
            this.tmrShowControlsForm.Interval = 1000;
            this.tmrShowControlsForm.Tick += new System.EventHandler(this.tmrShowControlsForm_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(134, 137);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FFLink";
            this.mnuTray.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrSnapshot;
        private System.Windows.Forms.NotifyIcon icnTray;
        private System.Windows.Forms.ContextMenuStrip mnuTray;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Timer tmrHide;
        private System.Windows.Forms.Timer tmrShowControlsForm;
    }
}

