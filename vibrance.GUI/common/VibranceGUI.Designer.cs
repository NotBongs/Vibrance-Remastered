namespace vibrance.GUI.common
{
    partial class VibranceGUI
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VibranceGUI));
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.twitterToolStripTextBox = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.checkBoxAutostart = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxNeverChangeResolutions = new System.Windows.Forms.CheckBox();
            this.checkBoxPrimaryMonitorOnly = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelWindowsLevel = new System.Windows.Forms.Label();
            this.trackBarWindowsLevel = new System.Windows.Forms.TrackBar();
            this.statusLabel = new System.Windows.Forms.Label();
            this.observerStatusLabel = new System.Windows.Forms.Label();
            this.labelTwitter = new System.Windows.Forms.Label();
            this.linkLabelTwitter = new System.Windows.Forms.LinkLabel();
            this.settingsBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonProcessExplorer = new System.Windows.Forms.Button();
            this.buttonRemoveProgram = new System.Windows.Forms.Button();
            this.listApplications = new System.Windows.Forms.ListView();
            this.buttonAddProgram = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BetaTimer = new System.Windows.Forms.Timer(this.components);
            this.DonateButton = new System.Windows.Forms.Button();
            this.LabelUpdate = new System.Windows.Forms.Label();
            this.contextMenuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWindowsLevel)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.twitterToolStripTextBox,
            this.exitToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(217, 48);
            this.contextMenuStrip.Text = "Vibrance Control";
            // 
            // twitterToolStripTextBox
            // 
            this.twitterToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
            this.twitterToolStripTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(69)))), ((int)(((byte)(173)))));
            this.twitterToolStripTextBox.Name = "twitterToolStripTextBox";
            this.twitterToolStripTextBox.Size = new System.Drawing.Size(216, 22);
            this.twitterToolStripTextBox.Text = "https://twitter.com/juvlarN";
            this.twitterToolStripTextBox.Click += new System.EventHandler(this.twitterToolStripTextBox_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            // 
            // checkBoxAutostart
            // 
            this.checkBoxAutostart.AutoSize = true;
            this.checkBoxAutostart.Location = new System.Drawing.Point(6, 19);
            this.checkBoxAutostart.Name = "checkBoxAutostart";
            this.checkBoxAutostart.Size = new System.Drawing.Size(74, 17);
            this.checkBoxAutostart.TabIndex = 8;
            this.checkBoxAutostart.Text = "Autostart";
            this.checkBoxAutostart.UseVisualStyleBackColor = true;
            this.checkBoxAutostart.CheckedChanged += new System.EventHandler(this.checkBoxAutostart_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxNeverChangeResolutions);
            this.groupBox1.Controls.Add(this.checkBoxPrimaryMonitorOnly);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.checkBoxAutostart);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(13, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 143);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // checkBoxNeverChangeResolutions
            // 
            this.checkBoxNeverChangeResolutions.AutoSize = true;
            this.checkBoxNeverChangeResolutions.Location = new System.Drawing.Point(178, 42);
            this.checkBoxNeverChangeResolutions.Name = "checkBoxNeverChangeResolutions";
            this.checkBoxNeverChangeResolutions.Size = new System.Drawing.Size(157, 17);
            this.checkBoxNeverChangeResolutions.TabIndex = 16;
            this.checkBoxNeverChangeResolutions.Text = "Never Change Resolution";
            this.toolTip.SetToolTip(this.checkBoxNeverChangeResolutions, "When checking this, VibranceGUI will never change the resolution on any of your m" +
        "onitors.");
            this.checkBoxNeverChangeResolutions.UseVisualStyleBackColor = true;
            this.checkBoxNeverChangeResolutions.CheckedChanged += new System.EventHandler(this.checkBoxNeverChangeResolutions_CheckedChanged);
            // 
            // checkBoxPrimaryMonitorOnly
            // 
            this.checkBoxPrimaryMonitorOnly.AutoSize = true;
            this.checkBoxPrimaryMonitorOnly.Location = new System.Drawing.Point(6, 42);
            this.checkBoxPrimaryMonitorOnly.Name = "checkBoxPrimaryMonitorOnly";
            this.checkBoxPrimaryMonitorOnly.Size = new System.Drawing.Size(168, 17);
            this.checkBoxPrimaryMonitorOnly.TabIndex = 15;
            this.checkBoxPrimaryMonitorOnly.Text = "Affect Primary Monitor Only";
            this.toolTip.SetToolTip(this.checkBoxPrimaryMonitorOnly, "When checking this, VibranceGUI will only change vibrance values on your primary " +
        "monitor.");
            this.checkBoxPrimaryMonitorOnly.UseVisualStyleBackColor = true;
            this.checkBoxPrimaryMonitorOnly.CheckedChanged += new System.EventHandler(this.checkBoxPrimaryMonitorOnly_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelWindowsLevel);
            this.groupBox3.Controls.Add(this.trackBarWindowsLevel);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(7, 65);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(191, 72);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Windows Vibrance Level";
            // 
            // labelWindowsLevel
            // 
            this.labelWindowsLevel.AutoSize = true;
            this.labelWindowsLevel.Location = new System.Drawing.Point(148, 22);
            this.labelWindowsLevel.Name = "labelWindowsLevel";
            this.labelWindowsLevel.Size = new System.Drawing.Size(0, 13);
            this.labelWindowsLevel.TabIndex = 1;
            // 
            // trackBarWindowsLevel
            // 
            this.trackBarWindowsLevel.Location = new System.Drawing.Point(15, 22);
            this.trackBarWindowsLevel.Maximum = 63;
            this.trackBarWindowsLevel.Name = "trackBarWindowsLevel";
            this.trackBarWindowsLevel.Size = new System.Drawing.Size(131, 45);
            this.trackBarWindowsLevel.TabIndex = 0;
            this.trackBarWindowsLevel.Scroll += new System.EventHandler(this.trackBarWindowsLevel_Scroll);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.Crimson;
            this.statusLabel.Location = new System.Drawing.Point(106, 502);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(70, 13);
            this.statusLabel.TabIndex = 14;
            this.statusLabel.Text = "Initializing...";
            this.statusLabel.Click += new System.EventHandler(this.statusLabel_Click);
            // 
            // observerStatusLabel
            // 
            this.observerStatusLabel.AutoSize = true;
            this.observerStatusLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.observerStatusLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.observerStatusLabel.Location = new System.Drawing.Point(12, 502);
            this.observerStatusLabel.Name = "observerStatusLabel";
            this.observerStatusLabel.Size = new System.Drawing.Size(94, 13);
            this.observerStatusLabel.TabIndex = 13;
            this.observerStatusLabel.Text = "Observer Status: ";
            // 
            // labelTwitter
            // 
            this.labelTwitter.AutoSize = true;
            this.labelTwitter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTwitter.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTwitter.Location = new System.Drawing.Point(12, 48);
            this.labelTwitter.Name = "labelTwitter";
            this.labelTwitter.Size = new System.Drawing.Size(54, 17);
            this.labelTwitter.TabIndex = 11;
            this.labelTwitter.Text = "Version:";
            this.labelTwitter.Click += new System.EventHandler(this.labelTwitter_Click);
            // 
            // linkLabelTwitter
            // 
            this.linkLabelTwitter.ActiveLinkColor = System.Drawing.Color.MediumOrchid;
            this.linkLabelTwitter.AutoSize = true;
            this.linkLabelTwitter.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelTwitter.LinkColor = System.Drawing.Color.MediumOrchid;
            this.linkLabelTwitter.Location = new System.Drawing.Point(363, 52);
            this.linkLabelTwitter.Name = "linkLabelTwitter";
            this.linkLabelTwitter.Size = new System.Drawing.Size(47, 13);
            this.linkLabelTwitter.TabIndex = 10;
            this.linkLabelTwitter.TabStop = true;
            this.linkLabelTwitter.Text = "Contact";
            this.linkLabelTwitter.VisitedLinkColor = System.Drawing.Color.MediumOrchid;
            this.linkLabelTwitter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelTwitter_LinkClicked);
            // 
            // settingsBackgroundWorker
            // 
            this.settingsBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.settingsBackgroundWorker_DoWork);
            this.settingsBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.settingsBackgroundWorker_RunWorkerCompleted);
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 100;
            this.toolTip.IsBalloon = true;
            this.toolTip.ReshowDelay = 100;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonProcessExplorer);
            this.groupBox5.Controls.Add(this.buttonRemoveProgram);
            this.groupBox5.Controls.Add(this.listApplications);
            this.groupBox5.Controls.Add(this.buttonAddProgram);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox5.Location = new System.Drawing.Point(13, 231);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(397, 227);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Program Settings";
            // 
            // buttonProcessExplorer
            // 
            this.buttonProcessExplorer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonProcessExplorer.FlatAppearance.BorderSize = 0;
            this.buttonProcessExplorer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProcessExplorer.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonProcessExplorer.Location = new System.Drawing.Point(7, 20);
            this.buttonProcessExplorer.Name = "buttonProcessExplorer";
            this.buttonProcessExplorer.Size = new System.Drawing.Size(75, 23);
            this.buttonProcessExplorer.TabIndex = 3;
            this.buttonProcessExplorer.Text = "Add";
            this.buttonProcessExplorer.UseVisualStyleBackColor = false;
            this.buttonProcessExplorer.Click += new System.EventHandler(this.buttonProcessExplorer_Click);
            // 
            // buttonRemoveProgram
            // 
            this.buttonRemoveProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRemoveProgram.FlatAppearance.BorderSize = 0;
            this.buttonRemoveProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveProgram.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonRemoveProgram.Location = new System.Drawing.Point(186, 20);
            this.buttonRemoveProgram.Name = "buttonRemoveProgram";
            this.buttonRemoveProgram.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveProgram.TabIndex = 2;
            this.buttonRemoveProgram.Text = "Remove";
            this.buttonRemoveProgram.UseVisualStyleBackColor = false;
            this.buttonRemoveProgram.Click += new System.EventHandler(this.buttonRemoveProgram_Click);
            // 
            // listApplications
            // 
            this.listApplications.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listApplications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.listApplications.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listApplications.HideSelection = false;
            this.listApplications.Location = new System.Drawing.Point(12, 55);
            this.listApplications.Name = "listApplications";
            this.listApplications.Size = new System.Drawing.Size(384, 172);
            this.listApplications.TabIndex = 1;
            this.listApplications.UseCompatibleStateImageBehavior = false;
            this.listApplications.DoubleClick += new System.EventHandler(this.listApplications_DoubleClick);
            // 
            // buttonAddProgram
            // 
            this.buttonAddProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAddProgram.FlatAppearance.BorderSize = 0;
            this.buttonAddProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddProgram.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAddProgram.Location = new System.Drawing.Point(88, 20);
            this.buttonAddProgram.Name = "buttonAddProgram";
            this.buttonAddProgram.Size = new System.Drawing.Size(92, 23);
            this.buttonAddProgram.TabIndex = 0;
            this.buttonAddProgram.Text = "Add Manually";
            this.buttonAddProgram.UseVisualStyleBackColor = false;
            this.buttonAddProgram.Click += new System.EventHandler(this.buttonAddProgram_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 35);
            this.panel1.TabIndex = 19;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(11, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vibrance Remastered";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Crimson;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(339, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 35);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Crimson;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(379, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 35);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BetaTimer
            // 
            this.BetaTimer.Tick += new System.EventHandler(this.BetaTimer_Tick);
            // 
            // DonateButton
            // 
            this.DonateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DonateButton.FlatAppearance.BorderSize = 0;
            this.DonateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DonateButton.Image = ((System.Drawing.Image)(resources.GetObject("DonateButton.Image")));
            this.DonateButton.Location = new System.Drawing.Point(379, 475);
            this.DonateButton.Name = "DonateButton";
            this.DonateButton.Size = new System.Drawing.Size(40, 40);
            this.DonateButton.TabIndex = 20;
            this.DonateButton.UseVisualStyleBackColor = true;
            this.DonateButton.Click += new System.EventHandler(this.DonateButton_Click);
            // 
            // LabelUpdate
            // 
            this.LabelUpdate.AutoSize = true;
            this.LabelUpdate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.LabelUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelUpdate.Location = new System.Drawing.Point(63, 49);
            this.LabelUpdate.Name = "LabelUpdate";
            this.LabelUpdate.Size = new System.Drawing.Size(65, 17);
            this.LabelUpdate.TabIndex = 21;
            this.LabelUpdate.Text = "Fetching...";
            // 
            // VibranceGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(419, 524);
            this.Controls.Add(this.LabelUpdate);
            this.Controls.Add(this.DonateButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.observerStatusLabel);
            this.Controls.Add(this.labelTwitter);
            this.Controls.Add(this.linkLabelTwitter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VibranceGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vibrance GUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuStrip.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWindowsLevel)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem twitterToolStripTextBox;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.CheckBox checkBoxAutostart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelWindowsLevel;
        private System.Windows.Forms.TrackBar trackBarWindowsLevel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label observerStatusLabel;
        private System.Windows.Forms.Label labelTwitter;
        private System.Windows.Forms.LinkLabel linkLabelTwitter;
        private System.ComponentModel.BackgroundWorker settingsBackgroundWorker;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.CheckBox checkBoxPrimaryMonitorOnly;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonRemoveProgram;
        private System.Windows.Forms.ListView listApplications;
        private System.Windows.Forms.Button buttonAddProgram;
        private System.Windows.Forms.Button buttonProcessExplorer;
        private System.Windows.Forms.CheckBox checkBoxNeverChangeResolutions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer BetaTimer;
        private System.Windows.Forms.Button DonateButton;
        private System.Windows.Forms.Label LabelUpdate;
    }
}

