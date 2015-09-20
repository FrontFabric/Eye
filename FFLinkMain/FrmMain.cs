using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace FFLinkMain
{
    public partial class FrmMain : Form
    {
        private readonly FrmControls _frmControls;
        private readonly FrmSettings _frmSettings = new FrmSettings();
        private DateTime _dtLast = DateTime.Now;

        public FrmMain()
        {
            InitializeComponent();
            _frmControls = new FrmControls(this);            
        }

        public FrmControls ControlsForm
        {
            get { return _frmControls; }
        }

        public FrmSettings SettingsForm
        {
            get { return _frmSettings; }
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
            _frmControls.Show();
        }

        private void tmrSnapshot_Tick(object sender, EventArgs e)
        {
            tmrSnapshot.Enabled = false;
            TakeSnapshot();
            tmrSnapshot.Enabled = true;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void StartSnapshots()
        {
            TakeSnapshot();
            tmrSnapshot.Interval = 1000*60*5;
            tmrSnapshot.Enabled = true;
        }

        private void TakeSnapshot()
        {
            var stamp = DateTime.Now.ToString("yyyy-MM-dd-HH-mm");
            Bitmap bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
            Graphics.FromImage(bmp).CopyFromScreen(0, 0, 0, 0, bmp.Size);
            bmp.Save(@"C:\Temp\" + stamp + ".jpg", ImageFormat.Jpeg);
        }
    }
}
