using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FFLinkMain
{
    public partial class FrmMain : Form
    {
        private FrmControls frmControls;
        private FrmSettings frmSettings = new FrmSettings();

        public FrmMain()
        {
            InitializeComponent();
            frmControls = new FrmControls(this);            
        }

        public FrmControls ControlsForm
        {
            get { return frmControls; }
        }

        public FrmSettings SettingsForm
        {
            get { return frmSettings; }
        }

        private void tmrHide_Tick(object sender, EventArgs e)
        {
            tmrHide.Enabled = false;
            Hide();
            tmrShowControlsForm.Enabled = true;
        }

        private void tmrShowControlsForm_Tick(object sender, EventArgs e)
        {
            tmrShowControlsForm.Enabled = false;
            frmControls.Show();
        }

        private void tmrScreenshot_Tick(object sender, EventArgs e)
        {
            tmrScreenshot.Enabled = false;

            Bitmap bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
            Graphics graphics = Graphics.FromImage(bmp as Image);
            graphics.CopyFromScreen(0, 0, 0, 0, bmp.Size);
            bmp.Save(@"C:\Temp\shot.jpg", ImageFormat.Jpeg);
            Text = "Done";
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
