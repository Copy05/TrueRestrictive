using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace TrueRestrictive
{
    public partial class TR_Paint : Form
    {
        Graphics graphics;
        int x = -1, y = -1;
        int strokeSize = 5;
        Color currentColor = Color.Black;
        bool moving = false;
        bool erase = false;
        Pen pen;
        Pen Eraser;
        public TR_Paint()
        {
            InitializeComponent();
            graphics = PaintCanvas.CreateGraphics();
            graphics.SmoothingMode = SmoothingMode.HighQuality;

            pen = new Pen(currentColor, strokeSize);
            Eraser = new Pen(Color.White, strokeSize);

            pen.StartCap = pen.EndCap = LineCap.Round;
            Eraser.StartCap = Eraser.EndCap = LineCap.Round;
            this.BringToFront();
        }

        private void panel26_Click(object sender, EventArgs e)
        {
            Panel p = (Panel)sender;
            pen.Color = p.BackColor;
            CurrentColor.BackColor = p.BackColor;
        }

        private void PaintCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X;
            y = e.Y;
            PaintCanvas.Cursor = Cursors.Hand;
        }

        private void PaintCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;
            PaintCanvas.Cursor = Cursors.Default;
        }

        private void StrokeTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Eraser.Width = float.Parse(StrokeTB.Text);
                pen.Width = float.Parse(StrokeTB.Text);
            } catch (Exception)
            {
                MessageBox.Show("Invalid stroke value. enter a number.", "TrueRestrictive", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void PenTool_Click(object sender, EventArgs e)
        {
            erase = false;
            PenTool.BackColor = Color.FromArgb(75, 75, 75);
            EraserTool.BackColor = Color.Transparent;
        }

        private void EraserTool_Click(object sender, EventArgs e)
        {
            erase = true;
            EraserTool.BackColor = Color.FromArgb(75, 75, 75);
            PenTool.BackColor = Color.Transparent;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
        }

        private void PaintCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if(moving && x != -1 && y != -1)
            {
                if (erase)
                {
                    graphics.DrawLine(Eraser, new Point(x, y), e.Location);
                    x = e.X;
                    y = e.Y;
                }
                else
                {
                    graphics.DrawLine(pen, new Point(x, y), e.Location);
                    x = e.X;
                    y = e.Y;
                }
            }
        }
    }
}
