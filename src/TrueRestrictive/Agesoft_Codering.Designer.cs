namespace TrueRestrictive
{
    partial class Agesoft_Codering
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agesoft_Codering));
            this.CodeBox = new System.Windows.Forms.RichTextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CodeBox
            // 
            this.CodeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.CodeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CodeBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeBox.ForeColor = System.Drawing.Color.White;
            this.CodeBox.Location = new System.Drawing.Point(12, 12);
            this.CodeBox.Name = "CodeBox";
            this.CodeBox.Size = new System.Drawing.Size(1244, 704);
            this.CodeBox.TabIndex = 0;
            this.CodeBox.Text = "";
            this.CodeBox.TextChanged += new System.EventHandler(this.CodeBox_TextChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.titleLabel.Location = new System.Drawing.Point(469, 407);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(28, 13);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "       ";
            // 
            // Agesoft_Codering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1268, 728);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.CodeBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1284, 767);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1284, 767);
            this.Name = "Agesoft_Codering";
            this.Text = "Agesoft Codering";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Agesoft_Codering_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox CodeBox;
        private System.Windows.Forms.Label titleLabel;
    }
}