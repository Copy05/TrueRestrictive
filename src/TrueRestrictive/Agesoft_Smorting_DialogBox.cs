using System;
using System.Windows.Forms;

namespace TrueRestrictive
{
    public partial class Agesoft_Smorting_DialogBox : Form
    {
        private string DialogMessage;
        public Agesoft_Smorting_DialogBox(string message)
        {
            DialogMessage = message;
            InitializeComponent();
        }

        private void Agesoft_Smorting_DialogBox_Load(object sender, EventArgs e)
        {
            DialogText.Text = DialogMessage;
            this.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
