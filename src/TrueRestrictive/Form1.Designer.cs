namespace TrueRestrictive
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.applyBtn = new System.Windows.Forms.Button();
            this.restrictDeviceBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.enableEmergencyExitBox = new System.Windows.Forms.CheckBox();
            this.disableFileExplorerBox = new System.Windows.Forms.CheckBox();
            this.disablePaintBox = new System.Windows.Forms.CheckBox();
            this.disableASWriteLBox = new System.Windows.Forms.CheckBox();
            this.addShutdownBtn = new System.Windows.Forms.CheckBox();
            this.killProcessesBox = new System.Windows.Forms.CheckBox();
            this.disableASSPCEbox = new System.Windows.Forms.CheckBox();
            this.disableTextEditorBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.enableAppBaseCB = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.applyBtn);
            this.panel1.Controls.Add(this.restrictDeviceBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 438);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 54);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "(c) Copy05 2023";
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(309, 10);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(129, 33);
            this.applyBtn.TabIndex = 1;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // restrictDeviceBtn
            // 
            this.restrictDeviceBtn.Enabled = false;
            this.restrictDeviceBtn.Location = new System.Drawing.Point(444, 10);
            this.restrictDeviceBtn.Name = "restrictDeviceBtn";
            this.restrictDeviceBtn.Size = new System.Drawing.Size(129, 33);
            this.restrictDeviceBtn.TabIndex = 0;
            this.restrictDeviceBtn.Text = "Restrict Device";
            this.restrictDeviceBtn.UseVisualStyleBackColor = true;
            this.restrictDeviceBtn.Click += new System.EventHandler(this.restrictDeviceBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 352);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configurations";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.enableAppBaseCB);
            this.groupBox3.Controls.Add(this.enableEmergencyExitBox);
            this.groupBox3.Controls.Add(this.disableFileExplorerBox);
            this.groupBox3.Controls.Add(this.disablePaintBox);
            this.groupBox3.Controls.Add(this.disableASWriteLBox);
            this.groupBox3.Controls.Add(this.addShutdownBtn);
            this.groupBox3.Controls.Add(this.killProcessesBox);
            this.groupBox3.Controls.Add(this.disableASSPCEbox);
            this.groupBox3.Controls.Add(this.disableTextEditorBox);
            this.groupBox3.Location = new System.Drawing.Point(17, 136);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(515, 203);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Optional Settings";
            // 
            // enableEmergencyExitBox
            // 
            this.enableEmergencyExitBox.AutoSize = true;
            this.enableEmergencyExitBox.Location = new System.Drawing.Point(295, 29);
            this.enableEmergencyExitBox.Name = "enableEmergencyExitBox";
            this.enableEmergencyExitBox.Size = new System.Drawing.Size(162, 17);
            this.enableEmergencyExitBox.TabIndex = 8;
            this.enableEmergencyExitBox.Text = "Enable Emergency Exit in FE";
            this.enableEmergencyExitBox.UseVisualStyleBackColor = true;
            this.enableEmergencyExitBox.CheckedChanged += new System.EventHandler(this.enableEmergencyExitBox_CheckedChanged);
            // 
            // disableFileExplorerBox
            // 
            this.disableFileExplorerBox.AutoSize = true;
            this.disableFileExplorerBox.Location = new System.Drawing.Point(22, 72);
            this.disableFileExplorerBox.Name = "disableFileExplorerBox";
            this.disableFileExplorerBox.Size = new System.Drawing.Size(198, 17);
            this.disableFileExplorerBox.TabIndex = 7;
            this.disableFileExplorerBox.Text = "Disable File Explorer (fake obviously)";
            this.disableFileExplorerBox.UseVisualStyleBackColor = true;
            this.disableFileExplorerBox.CheckedChanged += new System.EventHandler(this.disableFileExplorerBox_CheckedChanged);
            // 
            // disablePaintBox
            // 
            this.disablePaintBox.AutoSize = true;
            this.disablePaintBox.Location = new System.Drawing.Point(22, 50);
            this.disablePaintBox.Name = "disablePaintBox";
            this.disablePaintBox.Size = new System.Drawing.Size(88, 17);
            this.disablePaintBox.TabIndex = 6;
            this.disablePaintBox.Text = "Disable Paint";
            this.disablePaintBox.UseVisualStyleBackColor = true;
            this.disablePaintBox.CheckedChanged += new System.EventHandler(this.disablePaintBox_CheckedChanged);
            // 
            // disableASWriteLBox
            // 
            this.disableASWriteLBox.AutoSize = true;
            this.disableASWriteLBox.Location = new System.Drawing.Point(22, 118);
            this.disableASWriteLBox.Name = "disableASWriteLBox";
            this.disableASWriteLBox.Size = new System.Drawing.Size(154, 17);
            this.disableASWriteLBox.TabIndex = 5;
            this.disableASWriteLBox.Text = "Disable Agesoft Write LITE";
            this.disableASWriteLBox.UseVisualStyleBackColor = true;
            this.disableASWriteLBox.CheckedChanged += new System.EventHandler(this.disableASWriteLBox_CheckedChanged);
            // 
            // addShutdownBtn
            // 
            this.addShutdownBtn.AutoSize = true;
            this.addShutdownBtn.Location = new System.Drawing.Point(22, 141);
            this.addShutdownBtn.Name = "addShutdownBtn";
            this.addShutdownBtn.Size = new System.Drawing.Size(139, 17);
            this.addShutdownBtn.TabIndex = 4;
            this.addShutdownBtn.Text = "Add Shutdown Shortcut";
            this.addShutdownBtn.UseVisualStyleBackColor = true;
            this.addShutdownBtn.CheckedChanged += new System.EventHandler(this.addShutdownBtn_CheckedChanged);
            // 
            // killProcessesBox
            // 
            this.killProcessesBox.AutoSize = true;
            this.killProcessesBox.Location = new System.Drawing.Point(22, 164);
            this.killProcessesBox.Name = "killProcessesBox";
            this.killProcessesBox.Size = new System.Drawing.Size(117, 17);
            this.killProcessesBox.TabIndex = 3;
            this.killProcessesBox.Text = "Kill Most Processes";
            this.killProcessesBox.UseVisualStyleBackColor = true;
            this.killProcessesBox.CheckedChanged += new System.EventHandler(this.killProcessesBox_CheckedChanged);
            // 
            // disableASSPCEbox
            // 
            this.disableASSPCEbox.AutoSize = true;
            this.disableASSPCEbox.Location = new System.Drawing.Point(22, 95);
            this.disableASSPCEbox.Name = "disableASSPCEbox";
            this.disableASSPCEbox.Size = new System.Drawing.Size(208, 17);
            this.disableASSPCEbox.TabIndex = 2;
            this.disableASSPCEbox.Text = "Disable Agesoft Smorting PCEssentials";
            this.disableASSPCEbox.UseVisualStyleBackColor = true;
            this.disableASSPCEbox.CheckedChanged += new System.EventHandler(this.disableASSPCEbox_CheckedChanged);
            // 
            // disableTextEditorBox
            // 
            this.disableTextEditorBox.AutoSize = true;
            this.disableTextEditorBox.Location = new System.Drawing.Point(22, 29);
            this.disableTextEditorBox.Name = "disableTextEditorBox";
            this.disableTextEditorBox.Size = new System.Drawing.Size(115, 17);
            this.disableTextEditorBox.TabIndex = 0;
            this.disableTextEditorBox.Text = "Disable Text Editor";
            this.disableTextEditorBox.UseVisualStyleBackColor = true;
            this.disableTextEditorBox.CheckedChanged += new System.EventHandler(this.disableTextEditorBox_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.password);
            this.groupBox2.Controls.Add(this.username);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(17, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(515, 95);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Login Details";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(86, 53);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(389, 20);
            this.password.TabIndex = 3;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(86, 23);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(389, 20);
            this.username.TabIndex = 2;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "TrueRestrictive";
            // 
            // enableAppBaseCB
            // 
            this.enableAppBaseCB.AutoSize = true;
            this.enableAppBaseCB.Location = new System.Drawing.Point(295, 52);
            this.enableAppBaseCB.Name = "enableAppBaseCB";
            this.enableAppBaseCB.Size = new System.Drawing.Size(104, 17);
            this.enableAppBaseCB.TabIndex = 9;
            this.enableAppBaseCB.Text = "Enable Appbase";
            this.enableAppBaseCB.UseVisualStyleBackColor = true;
            this.enableAppBaseCB.CheckedChanged += new System.EventHandler(this.enableAppBaseCB_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 492);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(605, 531);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(605, 531);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrueRestrictive Control Panel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button restrictDeviceBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox disableTextEditorBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox killProcessesBox;
        private System.Windows.Forms.CheckBox disableASSPCEbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox addShutdownBtn;
        private System.Windows.Forms.CheckBox disableFileExplorerBox;
        private System.Windows.Forms.CheckBox disablePaintBox;
        private System.Windows.Forms.CheckBox disableASWriteLBox;
        private System.Windows.Forms.CheckBox enableEmergencyExitBox;
        private System.Windows.Forms.CheckBox enableAppBaseCB;
    }
}

