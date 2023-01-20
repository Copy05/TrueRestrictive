using System;
using System.Windows.Forms;

namespace TrueRestrictive
{
    public partial class Form1 : Form
    {
        public string Username, Password;
        public bool hasDisabledTextEditor, hasDisabledPaint, hasDisabledFileExplorer, hasDisabledAgesoftSmorting, hasDisabledAgesoftWrite,
            hasEnabledShutdownShortcut, killMostProcesses, hasEnabledEmergencyExit, hasEnabledAppBase;

        private void disableASSPCEbox_CheckedChanged(object sender, EventArgs e)
        {
            if (disableASSPCEbox.Checked) hasDisabledAgesoftSmorting = true;
            else hasDisabledAgesoftSmorting = false;
        }

        private void disableASWriteLBox_CheckedChanged(object sender, EventArgs e)
        {
            if (disableASWriteLBox.Checked) hasDisabledAgesoftWrite = true;
            else hasDisabledAgesoftWrite = false;
        }

        private void addShutdownBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (addShutdownBtn.Checked) hasEnabledShutdownShortcut = true;
            else hasEnabledShutdownShortcut = false;
        }

        private void killProcessesBox_CheckedChanged(object sender, EventArgs e)
        {
            if (killProcessesBox.Checked) killMostProcesses = true;
            else killMostProcesses = false;
        }

        private void Lock()
        {
            Screen2Lock s2l = new Screen2Lock();
            TR_Desktop TRD = new TR_Desktop();
            TRD.Settings = this;
            Helpers.KillProcess("explorer.exe");
            if (killMostProcesses)
            {
                string[] procName = { "chrome.exe", "teams.exe", "edge.exe", "firefox.exe", "word.exe", "excel.exe", "code.exe",
                    "powerpoint.exe", "outlook.exe", "notepad.exe", "mspaint.exe", "powershell.exe", "minecraft.exe", "access.exe", "discord.exe", "roblox.exe", "cmd.exe" };
                for (int i = 0; i < procName.Length; i++)
                {
                    Helpers.KillProcess(procName[i]);
                }
            }
            s2l.StartPosition = FormStartPosition.Manual;
            s2l.Bounds = Screen.AllScreens[0].Bounds;
            s2l.Show();
            TRD.Show();
            this.Hide();
        }

        private void restrictDeviceBtn_Click(object sender, EventArgs e)
        {
            Lock();
        }

        private void enableAppBaseCB_CheckedChanged(object sender, EventArgs e)
        {
            if (enableAppBaseCB.Checked) hasEnabledAppBase = true;
            else hasEnabledAppBase = false;
        }

        private void enableEmergencyExitBox_CheckedChanged(object sender, EventArgs e)
        {
            if (enableEmergencyExitBox.Checked) hasEnabledEmergencyExit = true;
            else hasEnabledEmergencyExit = false;
        }

        private void disableFileExplorerBox_CheckedChanged(object sender, EventArgs e)
        {
            if (disableFileExplorerBox.Checked) hasDisabledFileExplorer = true;
            else hasDisabledFileExplorer = false;
        }

        private void disablePaintBox_CheckedChanged(object sender, EventArgs e)
        {
            if (disablePaintBox.Checked) hasDisabledPaint = true;
            else hasDisabledPaint = false;
        }

        private void disableTextEditorBox_CheckedChanged(object sender, EventArgs e)
        {
            if (disableTextEditorBox.Checked) hasDisabledTextEditor = true;
            else hasDisabledTextEditor = false;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            if(username.Text.Length > 1 && password.Text.Length > 1)
            {
                Username = username.Text;
                Password = password.Text;
                restrictDeviceBtn.Enabled = true;
            } else
            {
                MessageBox.Show("The Password or Username is empty or too short try something else", "TrueRestrictive Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            restrictDeviceBtn.Enabled = false;
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            restrictDeviceBtn.Enabled = false;
        }
    }
}
