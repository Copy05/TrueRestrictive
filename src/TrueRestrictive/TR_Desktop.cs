using System;
using System.Windows.Forms;
using TrueRestrictive.Security;

namespace TrueRestrictive
{
    public partial class TR_Desktop : Form
    {
        public DisableKeys DisableKeys = new DisableKeys();
        public Form1 Settings = new Form1();

        public string Username, Password;
        public bool hasEnabledEmergencyExit, hasEnabledAppBase;
        public TR_Desktop()
        {
            InitializeComponent();
        }

        private void TR_Desktop_Load(object sender, EventArgs e)
        {

            if (((Form1)Settings).hasEnabledEmergencyExit) hasEnabledEmergencyExit = true;
            if (((Form1)Settings).hasEnabledAppBase) hasEnabledAppBase = true;
            this.Username = ((Form1)Settings).Username;
            this.Password = ((Form1)Settings).Password;

            pbb2.Visible = false;
            if (((Form1)Settings).hasDisabledTextEditor)
            {
                textEditorShortcut.Visible = false;
                textEditorShortCut2.Visible = false;
            }
            if (((Form1)Settings).hasDisabledAgesoftSmorting)
            {
                pbb5.Visible = false;
            }
            if (((Form1)Settings).hasDisabledAgesoftWrite)
            {
                pbb6.Visible = false;
            }
            if (((Form1)Settings).hasDisabledFileExplorer)
            {
                pbb4.Visible = false;
            }
            if (((Form1)Settings).hasDisabledPaint)
            {
                pbb3.Visible = false;
            }
            if (((Form1)Settings).hasEnabledShutdownShortcut)
            {
                pbb2.Visible = true;
            }
            this.BringToFront();
        }

        private void TR_Desktop_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void TR_Desktop_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void textEditorShortCut2_Click_1(object sender, EventArgs e)
        {
            TR_TextEditor TTE = new TR_TextEditor();
            TTE.Show();
        }

        private void LeaveShortCut2_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Settings = this;
            lf.Show();
        }

        private void LeaveShortCut_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Settings = this;
            lf.Show();
        }

        private void textEditorShortCut_Click(object sender, EventArgs e)
        {
            TR_TextEditor TTE = new TR_TextEditor();
            TTE.Show();
        }

        private void AgesoftWriteShortCut_Click(object sender, EventArgs e)
        {
            Agesoft_Write ASW = new Agesoft_Write();
            ASW.Show();
        }

        private void ShutdownShortCut_Click(object sender, EventArgs e)
        {
            DialogResult dr;

            dr = MessageBox.Show("Do you really want to shutdown?", "True Restrictive", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dr == DialogResult.Yes)
            {
                Helpers.ExecuteCommand("shutdown /p");
            }
        }

        private void AgesoftCodeShortcut_Click(object sender, EventArgs e)
        {
            Agesoft_Codering asc = new Agesoft_Codering();
            asc.Show();
        }

        private void AgesoftSmortingShortcut_Click(object sender, EventArgs e)
        {
            Agesoft_Smorting_PCE_Main aspm = new Agesoft_Smorting_PCE_Main();
            aspm.Show();
        }

        private void workdeskShortcut2_Click(object sender, EventArgs e)
        {
            FileExplorer_Main fem = new FileExplorer_Main();
            fem.Settings = this;
            fem.Show();
        }

        private void PaintShortcut_Click(object sender, EventArgs e)
        {
            TR_Paint paint = new TR_Paint();
            paint.Show();
        }

        private void workdeskShortcut_Click(object sender, EventArgs e)
        {
            FileExplorer_Main fem = new FileExplorer_Main();
            fem.Settings = this;
            fem.Show();
        }
    }
}
