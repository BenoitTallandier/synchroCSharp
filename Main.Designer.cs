namespace WindowsFormsApplication1
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.contentFtp = new System.Windows.Forms.Label();
            this.synchronize = new System.Windows.Forms.Button();
            this.telechargement = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.perProgressBar = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.letsgoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.login = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timeLeft = new System.Windows.Forms.Label();
            this.server = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameServer = new System.Windows.Forms.Label();
            this.pauseBt = new System.Windows.Forms.Button();
            this.breakBt = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // contentFtp
            // 
            this.contentFtp.Location = new System.Drawing.Point(164, 164);
            this.contentFtp.Name = "contentFtp";
            this.contentFtp.Size = new System.Drawing.Size(941, 157);
            this.contentFtp.TabIndex = 3;
            this.contentFtp.Text = "label1";
            this.contentFtp.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // synchronize
            // 
            this.synchronize.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.synchronize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.synchronize.ForeColor = System.Drawing.SystemColors.Control;
            this.synchronize.Location = new System.Drawing.Point(447, 42);
            this.synchronize.Name = "synchronize";
            this.synchronize.Size = new System.Drawing.Size(131, 44);
            this.synchronize.TabIndex = 4;
            this.synchronize.Text = "Synchronisation";
            this.synchronize.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.synchronize.UseVisualStyleBackColor = false;
            this.synchronize.Click += new System.EventHandler(this.synchronize_Click);
            this.synchronize.MouseEnter += new System.EventHandler(this.synchronize_MouseEnter);
            this.synchronize.MouseLeave += new System.EventHandler(this.synchronize_MouseOut);
            // 
            // telechargement
            // 
            this.telechargement.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.telechargement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.telechargement.ForeColor = System.Drawing.Color.Cornsilk;
            this.telechargement.Location = new System.Drawing.Point(609, 42);
            this.telechargement.Name = "telechargement";
            this.telechargement.Size = new System.Drawing.Size(122, 44);
            this.telechargement.TabIndex = 5;
            this.telechargement.Text = "Téléchargement";
            this.telechargement.UseVisualStyleBackColor = false;
            this.telechargement.Click += new System.EventHandler(this.telechargement_Click);
            this.telechargement.MouseEnter += new System.EventHandler(this.synchronize_MouseEnter);
            this.telechargement.MouseLeave += new System.EventHandler(this.synchronize_MouseOut);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(167, 467);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(851, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1034, 485);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 8;
            // 
            // perProgressBar
            // 
            this.perProgressBar.AutoSize = true;
            this.perProgressBar.Location = new System.Drawing.Point(1034, 473);
            this.perProgressBar.Name = "perProgressBar";
            this.perProgressBar.Size = new System.Drawing.Size(46, 17);
            this.perProgressBar.TabIndex = 9;
            this.perProgressBar.Text = "label2";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1157, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.letsgoToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(70, 24);
            this.toolStripMenuItem1.Text = "Serveur";
            // 
            // letsgoToolStripMenuItem
            // 
            this.letsgoToolStripMenuItem.Name = "letsgoToolStripMenuItem";
            this.letsgoToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.letsgoToolStripMenuItem.Text = "Ajouter";
            this.letsgoToolStripMenuItem.Click += new System.EventHandler(this.addServer);
            // 
            // login
            // 
            this.login.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.login.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.login.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.Salmon;
            this.login.Location = new System.Drawing.Point(993, 0);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(135, 28);
            this.login.TabIndex = 11;
            this.login.Text = "a";
            this.login.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(964, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(1128, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // timeLeft
            // 
            this.timeLeft.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLeft.ForeColor = System.Drawing.SystemColors.Highlight;
            this.timeLeft.Location = new System.Drawing.Point(864, 0);
            this.timeLeft.Name = "timeLeft";
            this.timeLeft.Size = new System.Drawing.Size(100, 28);
            this.timeLeft.TabIndex = 14;
            this.timeLeft.Text = "time Left";
            this.timeLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // server
            // 
            this.server.BackColor = System.Drawing.Color.Lavender;
            this.server.FormattingEnabled = true;
            this.server.ItemHeight = 16;
            this.server.Location = new System.Drawing.Point(12, 125);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(120, 196);
            this.server.TabIndex = 16;
            this.server.SelectedIndexChanged += new System.EventHandler(this.server_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(45, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Serveurs";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // nameServer
            // 
            this.nameServer.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameServer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nameServer.Location = new System.Drawing.Point(489, 103);
            this.nameServer.Name = "nameServer";
            this.nameServer.Size = new System.Drawing.Size(211, 23);
            this.nameServer.TabIndex = 18;
            this.nameServer.Text = "label3";
            this.nameServer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pauseBt
            // 
            this.pauseBt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pauseBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pauseBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pauseBt.ForeColor = System.Drawing.Color.Cornsilk;
            this.pauseBt.Location = new System.Drawing.Point(44, 376);
            this.pauseBt.Name = "pauseBt";
            this.pauseBt.Size = new System.Drawing.Size(75, 27);
            this.pauseBt.TabIndex = 19;
            this.pauseBt.Text = "Pause";
            this.pauseBt.UseVisualStyleBackColor = false;
            this.pauseBt.Click += new System.EventHandler(this.pauseBt_Click);
            // 
            // breakBt
            // 
            this.breakBt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.breakBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.breakBt.ForeColor = System.Drawing.Color.Cornsilk;
            this.breakBt.Location = new System.Drawing.Point(44, 443);
            this.breakBt.Name = "breakBt";
            this.breakBt.Size = new System.Drawing.Size(75, 27);
            this.breakBt.TabIndex = 20;
            this.breakBt.Text = "Stop";
            this.breakBt.UseVisualStyleBackColor = false;
            this.breakBt.Click += new System.EventHandler(this.breakBt_Click);
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.Color.Lavender;
            this.log.Location = new System.Drawing.Point(167, 337);
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.ReadOnly = true;
            this.log.Size = new System.Drawing.Size(913, 110);
            this.log.TabIndex = 21;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1157, 534);
            this.Controls.Add(this.log);
            this.Controls.Add(this.breakBt);
            this.Controls.Add(this.pauseBt);
            this.Controls.Add(this.nameServer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.server);
            this.Controls.Add(this.timeLeft);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.login);
            this.Controls.Add(this.perProgressBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.telechargement);
            this.Controls.Add(this.synchronize);
            this.Controls.Add(this.contentFtp);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Synchronize";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label contentFtp;
        private System.Windows.Forms.Button synchronize;
        private System.Windows.Forms.Button telechargement;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label perProgressBar;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem letsgoToolStripMenuItem;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label timeLeft;
        private System.Windows.Forms.ListBox server;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nameServer;
        private System.Windows.Forms.Button pauseBt;
        private System.Windows.Forms.Button breakBt;
        private System.Windows.Forms.TextBox log;
    }
}

