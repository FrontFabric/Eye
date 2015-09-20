namespace FFLinkMain
{
    partial class FrmControls
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmControls));
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.pnlPanels = new System.Windows.Forms.Panel();
            this.btnSnapshots = new System.Windows.Forms.Button();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.btnSnapshots);
            this.pnlControls.Controls.Add(this.btnSettings);
            this.pnlControls.Location = new System.Drawing.Point(10, 1);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(200, 24);
            this.pnlControls.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(0, 0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(24, 24);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // pnlPanels
            // 
            this.pnlPanels.Location = new System.Drawing.Point(10, 28);
            this.pnlPanels.Name = "pnlPanels";
            this.pnlPanels.Size = new System.Drawing.Size(200, 224);
            this.pnlPanels.TabIndex = 1;
            this.pnlPanels.Visible = false;
            // 
            // btnSnapshots
            // 
            this.btnSnapshots.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSnapshots.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSnapshots.FlatAppearance.BorderSize = 0;
            this.btnSnapshots.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnapshots.Image = ((System.Drawing.Image)(resources.GetObject("btnSnapshots.Image")));
            this.btnSnapshots.Location = new System.Drawing.Point(24, 0);
            this.btnSnapshots.Name = "btnSnapshots";
            this.btnSnapshots.Size = new System.Drawing.Size(24, 24);
            this.btnSnapshots.TabIndex = 1;
            this.btnSnapshots.UseVisualStyleBackColor = true;
            this.btnSnapshots.Click += new System.EventHandler(this.btnSnapshots_Click);
            // 
            // FrmControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::FFLinkMain.Properties.Resources.handle_10_17;
            this.ClientSize = new System.Drawing.Size(233, 276);
            this.Controls.Add(this.pnlPanels);
            this.Controls.Add(this.pnlControls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmControls";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmControls";
            this.TopMost = true;
            this.pnlControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel pnlPanels;
        private System.Windows.Forms.Button btnSnapshots;
    }
}