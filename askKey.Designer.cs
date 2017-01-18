namespace WindowsFormsApplication1
{
    partial class askKey
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
            this.okBt = new System.Windows.Forms.Button();
            this.ignoreBt = new System.Windows.Forms.Button();
            this.key = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okBt
            // 
            this.okBt.Location = new System.Drawing.Point(50, 126);
            this.okBt.Name = "okBt";
            this.okBt.Size = new System.Drawing.Size(75, 40);
            this.okBt.TabIndex = 0;
            this.okBt.Text = "Ok";
            this.okBt.UseVisualStyleBackColor = true;
            this.okBt.Click += new System.EventHandler(this.okBt_Click);
            // 
            // ignoreBt
            // 
            this.ignoreBt.Location = new System.Drawing.Point(167, 126);
            this.ignoreBt.Name = "ignoreBt";
            this.ignoreBt.Size = new System.Drawing.Size(75, 40);
            this.ignoreBt.TabIndex = 1;
            this.ignoreBt.Text = "Ignorer";
            this.ignoreBt.UseVisualStyleBackColor = true;
            this.ignoreBt.Click += new System.EventHandler(this.ignoreBt_Click);
            // 
            // key
            // 
            this.key.Location = new System.Drawing.Point(53, 82);
            this.key.Mask = "AAAA-AAAA-AAAA-AAAA";
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(190, 22);
            this.key.TabIndex = 3;
            this.key.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vous n\'avez pas encore enregistré votre clé produit";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // askKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 179);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.key);
            this.Controls.Add(this.ignoreBt);
            this.Controls.Add(this.okBt);
            this.Name = "askKey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "askKey";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okBt;
        private System.Windows.Forms.Button ignoreBt;
        private System.Windows.Forms.MaskedTextBox key;
        private System.Windows.Forms.Label label1;

    }
}