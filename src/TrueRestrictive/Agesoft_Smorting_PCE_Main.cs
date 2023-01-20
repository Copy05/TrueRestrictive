using System;
using System.Windows.Forms;

namespace TrueRestrictive
{
    public partial class Agesoft_Smorting_PCE_Main : Form
    {
        public Agesoft_Smorting_PCE_Main()
        {
            InitializeComponent();
        }

        private void ButtonLessionBtn_Click(object sender, EventArgs e)
        {
            Agesoft_Smorting_DialogBox asd = new Agesoft_Smorting_DialogBox("This lession isnt ready yet. sorry");
            asd.Show();
        }

        private void TextBoxLessionBtn_Click(object sender, EventArgs e)
        {
            Agesoft_Smorting_DialogBox asd = new Agesoft_Smorting_DialogBox("This lession isnt ready yet. sorry");
            asd.Show();
        }

        private void Agesoft_Smorting_PCE_Main_Load(object sender, EventArgs e)
        {
            this.BringToFront();
        }
    }
}
