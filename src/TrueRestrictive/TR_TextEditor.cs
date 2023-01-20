using System.Windows.Forms;

namespace TrueRestrictive
{
    public partial class TR_TextEditor : Form
    {
        public TR_TextEditor()
        {
            InitializeComponent();
        }

        public TR_TextEditor(string text)
        {
            InitializeComponent();
            TextBox.Text = text;
        }
    }
}
