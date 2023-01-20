namespace TrueRestrictive
{
    partial class FileExplorer_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileExplorer_Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NoAccessPanel = new System.Windows.Forms.Panel();
            this.EmergencyExitPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.AppBasePanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.AppBaseShortcut = new System.Windows.Forms.PictureBox();
            this.EmergencyExitShortcut = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.NoAccessPanel.SuspendLayout();
            this.EmergencyExitPanel.SuspendLayout();
            this.AppBasePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppBaseShortcut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmergencyExitShortcut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 574);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "TRC:/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(454, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "You dont have access to the File Explorer";
            // 
            // NoAccessPanel
            // 
            this.NoAccessPanel.Controls.Add(this.pictureBox2);
            this.NoAccessPanel.Controls.Add(this.label2);
            this.NoAccessPanel.Location = new System.Drawing.Point(226, 178);
            this.NoAccessPanel.Name = "NoAccessPanel";
            this.NoAccessPanel.Size = new System.Drawing.Size(553, 210);
            this.NoAccessPanel.TabIndex = 3;
            // 
            // EmergencyExitPanel
            // 
            this.EmergencyExitPanel.Controls.Add(this.label3);
            this.EmergencyExitPanel.Controls.Add(this.EmergencyExitShortcut);
            this.EmergencyExitPanel.Location = new System.Drawing.Point(226, 12);
            this.EmergencyExitPanel.Name = "EmergencyExitPanel";
            this.EmergencyExitPanel.Size = new System.Drawing.Size(70, 109);
            this.EmergencyExitPanel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Emergency\r\nExit";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AppBasePanel
            // 
            this.AppBasePanel.Controls.Add(this.label4);
            this.AppBasePanel.Controls.Add(this.AppBaseShortcut);
            this.AppBasePanel.Location = new System.Drawing.Point(299, 12);
            this.AppBasePanel.Name = "AppBasePanel";
            this.AppBasePanel.Size = new System.Drawing.Size(70, 109);
            this.AppBasePanel.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Appbase";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AppBaseShortcut
            // 
            this.AppBaseShortcut.Image = global::TrueRestrictive.Properties.Resources.database_64__1_;
            this.AppBaseShortcut.Location = new System.Drawing.Point(3, 3);
            this.AppBaseShortcut.Name = "AppBaseShortcut";
            this.AppBaseShortcut.Size = new System.Drawing.Size(64, 64);
            this.AppBaseShortcut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AppBaseShortcut.TabIndex = 4;
            this.AppBaseShortcut.TabStop = false;
            this.AppBaseShortcut.Click += new System.EventHandler(this.AppBaseShortcut_Click);
            // 
            // EmergencyExitShortcut
            // 
            this.EmergencyExitShortcut.Image = global::TrueRestrictive.Properties.Resources.restore_window_64;
            this.EmergencyExitShortcut.Location = new System.Drawing.Point(3, 3);
            this.EmergencyExitShortcut.Name = "EmergencyExitShortcut";
            this.EmergencyExitShortcut.Size = new System.Drawing.Size(64, 64);
            this.EmergencyExitShortcut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.EmergencyExitShortcut.TabIndex = 4;
            this.EmergencyExitShortcut.TabStop = false;
            this.EmergencyExitShortcut.Click += new System.EventHandler(this.EmergencyExitShortcut_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TrueRestrictive.Properties.Resources.cancel_128;
            this.pictureBox2.Location = new System.Drawing.Point(207, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TrueRestrictive.Properties.Resources.box_64;
            this.pictureBox1.Location = new System.Drawing.Point(58, 244);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FileExplorer_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(802, 574);
            this.Controls.Add(this.AppBasePanel);
            this.Controls.Add(this.EmergencyExitPanel);
            this.Controls.Add(this.NoAccessPanel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 613);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(818, 613);
            this.Name = "FileExplorer_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileExplorer";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FileExplorer_Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.NoAccessPanel.ResumeLayout(false);
            this.NoAccessPanel.PerformLayout();
            this.EmergencyExitPanel.ResumeLayout(false);
            this.EmergencyExitPanel.PerformLayout();
            this.AppBasePanel.ResumeLayout(false);
            this.AppBasePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppBaseShortcut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmergencyExitShortcut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel NoAccessPanel;
        private System.Windows.Forms.PictureBox EmergencyExitShortcut;
        private System.Windows.Forms.Panel EmergencyExitPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel AppBasePanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox AppBaseShortcut;
    }
}