using System;
using System.Windows.Forms;

namespace TrueRestrictive
{
    public partial class FileExplorer_Main : Form
    {
        public TR_Desktop Settings = new TR_Desktop();
        public FileExplorer_Main()
        {
            InitializeComponent();
        }

        private void FileExplorer_Main_Load(object sender, EventArgs e)
        {
            EmergencyExitPanel.Visible = false;
            AppBasePanel.Visible = false;

            if (((TR_Desktop)Settings).hasEnabledEmergencyExit)
            {
                EmergencyExitPanel.Visible = true;
                NoAccessPanel.Visible = false;
            }

            if (((TR_Desktop)Settings).hasEnabledAppBase)
            {
                AppBasePanel.Visible = true;
                NoAccessPanel.Visible = false;
            }
            this.BringToFront();
        }

        private void EmergencyExitShortcut_Click(object sender, EventArgs e)
        {
            Helpers.Exit();
        }

        private void AppBaseShortcut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application not found.");
        }
    }
}
