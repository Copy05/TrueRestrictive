using System;
using System.Windows.Forms;

namespace TrueRestrictive
{
    public partial class LoginForm : Form
    {
        public TR_Desktop Settings = new TR_Desktop();
        public string Username, Password;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.Username = ((TR_Desktop)Settings).Username;
            this.Password = ((TR_Desktop)Settings).Password;
            this.BringToFront();
        }

        private void UnlockBtn_Click(object sender, EventArgs e)
        {
            if (UsernameBox.Text == Settings.Username && PassBox.Text == Settings.Password)
            {
                Helpers.Exit();
            }

            if (UsernameBox.Text != Settings.Username || PassBox.Text != Settings.Password)
            {
                MessageBox.Show("The login or password is incorrect. please try again", "TrueLock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
