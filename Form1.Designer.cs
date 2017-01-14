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
            this.synchronize.ForeColor = System.Drawing.Color.Cornsilk;
            this.synchronize.Location = new System.Drawing.Point(447, 12);
            this.synchronize.Name = "synchronize";
            this.synchronize.Size = new System.Drawing.Size(122, 44);
            this.synchronize.TabIndex = 4;
            this.synchronize.Text = "Synchronisation";
            this.synchronize.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.synchronize.UseVisualStyleBackColor = false;
            this.synchronize.Click += new System.EventHandler(this.button2_Click);
            // 
            // telechargement
            // 
            this.telechargement.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.telechargement.ForeColor = System.Drawing.Color.Cornsilk;
            this.telechargement.Location = new System.Drawing.Point(609, 12);
            this.telechargement.Name = "telechargement";
            this.telechargement.Size = new System.Drawing.Size(122, 44);
            this.telechargement.TabIndex = 5;
            this.telechargement.Text = "Téléchargement";
            this.telechargement.UseVisualStyleBackColor = false;
            this.telechargement.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(49, 364);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1096, 114);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 512);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.telechargement);
            this.Controls.Add(this.synchronize);
            this.Controls.Add(this.contentFtp);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label contentFtp;
        private System.Windows.Forms.Button synchronize;
        private System.Windows.Forms.Button telechargement;
        private System.Windows.Forms.TextBox textBox1;
    }
}

