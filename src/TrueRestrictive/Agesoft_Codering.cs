using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TrueRestrictive
{
    public partial class Agesoft_Codering : Form
    {
        public Agesoft_Codering()
        {
            InitializeComponent();
        }

        public string DocumentText = "";
        private void Agesoft_Codering_Load(object sender, EventArgs e)
        {
            CodeBox.Text = DocumentText;
            this.BringToFront();
        }

        private void CodeBox_TextChanged(object sender, EventArgs e)
        {

            // getting keywords/functions
            string keywords = @"\b(public|private|protected|partial|static|namespace|class|struct|enum|using|void|string|int|bool|float|double|short|byte|char|const)\b";
            MatchCollection keywordMatches = Regex.Matches(CodeBox.Text, keywords);

            // getting conds
            string conds = @"\b(if|else|switch|case|foreach)\b";
            MatchCollection condsMatches = Regex.Matches(CodeBox.Text, conds);

            // getting types/classes from the text 
            string types = @"\b(Console|Regex|Agesoft|Font|Application)\b";
            MatchCollection typeMatches = Regex.Matches(CodeBox.Text, types);

            // getting comments (inline or multiline)
            string comments = @"(\/\/.+?$|\/\*.+?\*\/)";
            MatchCollection commentMatches = Regex.Matches(CodeBox.Text, comments, RegexOptions.Multiline);

            // getting strings
            string strings = "\".+?\"";
            MatchCollection stringMatches = Regex.Matches(CodeBox.Text, strings);

            // saving the original caret position + forecolor
            int originalIndex = CodeBox.SelectionStart;
            int originalLength = CodeBox.SelectionLength;
            Color originalColor = Color.White;

            // MANDATORY - focuses a label before highlighting (avoids blinking)
            titleLabel.Focus();

            // removes any previous highlighting (so modified words won't remain highlighted)
            CodeBox.SelectionStart = 0;
            CodeBox.SelectionLength = CodeBox.Text.Length;
            CodeBox.SelectionColor = originalColor;

            // scanning...
            foreach (Match m in keywordMatches)
            {
                CodeBox.SelectionStart = m.Index;
                CodeBox.SelectionLength = m.Length;
                CodeBox.SelectionColor = Color.FromArgb(86, 156, 214);
            }

            foreach (Match m in condsMatches)
            {
                CodeBox.SelectionStart = m.Index;
                CodeBox.SelectionLength = m.Length;
                CodeBox.SelectionColor = Color.FromArgb(197,134,192);
            }

            foreach (Match m in typeMatches)
            {
                CodeBox.SelectionStart = m.Index;
                CodeBox.SelectionLength = m.Length;
                CodeBox.SelectionColor = Color.FromArgb(78, 201, 176);
            }

            foreach (Match m in commentMatches)
            {
                CodeBox.SelectionStart = m.Index;
                CodeBox.SelectionLength = m.Length;
                CodeBox.SelectionColor = Color.Green;
            }

            foreach (Match m in stringMatches)
            {
                CodeBox.SelectionStart = m.Index;
                CodeBox.SelectionLength = m.Length;
                CodeBox.SelectionColor = Color.FromArgb(206,145,120);
            }

            // restoring the original colors, for further writing
            CodeBox.SelectionStart = originalIndex;
            CodeBox.SelectionLength = originalLength;
            CodeBox.SelectionColor = originalColor;

            // giving back the focus
            CodeBox.Focus();
        }
    }
}
