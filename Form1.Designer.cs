namespace WindowsFormsApplication1
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
            this.button1 = new System.Windows.Forms.Button();
            this.contentFtp = new System.Windows.Forms.Label();
            this.synchronize = new System.Windows.Forms.Button();
            this.telechargement = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.perProgressBar = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.letsgoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "getDir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click_1);
            // 
            // contentFtp
            // 
            this.contentFtp.AutoSize = true;
            this.contentFtp.Location = new System.Drawing.Point(172, 107);
            this.contentFtp.Name = "contentFtp";
            this.contentFtp.Size = new System.Drawing.Size(46, 17);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(49, 364);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1056, 114);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(49, 485);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(967, 23);
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
            this.perProgressBar.Location = new System.Drawing.Point(1037, 485);
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
            this.menuStrip1.Size = new System.Drawing.Size(1157, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.letsgoToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(92, 24);
            this.toolStripMenuItem1.Text = "Add server";
            // 
            // letsgoToolStripMenuItem
            // 
            this.letsgoToolStripMenuItem.Name = "letsgoToolStripMenuItem";
            this.letsgoToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.letsgoToolStripMenuItem.Text = "let\'sgo";
            this.letsgoToolStripMenuItem.Click += new System.EventHandler(this.addServer);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 512);
            this.Controls.Add(this.perProgressBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.telechargement);
            this.Controls.Add(this.synchronize);
            this.Controls.Add(this.contentFtp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label contentFtp;
        private System.Windows.Forms.Button synchronize;
        private System.Windows.Forms.Button telechargement;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label perProgressBar;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem letsgoToolStripMenuItem;
    }
}

