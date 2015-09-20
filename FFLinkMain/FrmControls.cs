using System;
using System.Windows.Forms;

namespace FFLinkMain
{
    public partial class FrmControls : Form
    {
        private readonly FrmMain _frmMain;

        public FrmControls()
        {
            InitializeComponent();
        }

        public FrmControls(FrmMain frmMain)
            : this()
        {
            _frmMain = frmMain;
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            _frmMain.SettingsForm.Show();            
        }

        private void btnSnapshots_Click(object sender, EventArgs e)
        {
            _frmMain.StartSnapshots();
        }
    }
}
