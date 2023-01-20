using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrueRestrictive
{
    public partial class Agesoft_Write : Form
    {
        public string FontStyle = "Segoe UI";
        public int FontSize = 9;
        public Agesoft_Write()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontSize = 16;
            TextField.SelectionFont = new Font(FontStyle, FontSize);
        }

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontSize = 9;
            TextField.SelectionFont = new Font(FontStyle, FontSize);
        }

        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontSize = 24;
            TextField.SelectionFont = new Font(FontStyle, FontSize);
        }

        private void monospaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontStyle = "Consolas";
            TextField.SelectionFont = new Font(FontStyle, FontSize);
        }

        private void bahnschriftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontStyle = "Bahnschrift";
            TextField.SelectionFont = new Font(FontStyle, FontSize);
        }

        private void serifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontStyle = "Times New Roman";
            TextField.SelectionFont = new Font(FontStyle, FontSize);
        }

        private void sansSerifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontStyle = "Segoe UI Semilight";
            TextField.SelectionFont = new Font(FontStyle, FontSize);
        }

        private void romanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontStyle = "Ink Free";
            TextField.SelectionFont = new Font(FontStyle, FontSize);
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextField.SelectionColor = Color.Black;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextField.SelectionColor = Color.Tomato;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextField.SelectionColor = Color.DodgerBlue;
        }

        private void cyanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextField.SelectionColor = Color.DarkCyan;
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextField.SelectionColor = Color.Gold;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextField.SelectionColor = Color.SpringGreen;
        }

        private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextField.SelectionColor = Color.MediumSlateBlue;
        }

        private void pinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextField.SelectionColor = Color.Pink;
        }
    }
}
