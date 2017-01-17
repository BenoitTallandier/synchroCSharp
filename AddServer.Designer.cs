namespace WindowsFormsApplication1
{
    partial class AddServer
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
            this.nameServer = new System.Windows.Forms.TextBox();
            this.adressServer = new System.Windows.Forms.TextBox();
            this.passServer = new System.Windows.Forms.TextBox();
            this.userServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameServer
            // 
            this.nameServer.Location = new System.Drawing.Point(181, 27);
            this.nameServer.Name = "nameServer";
            this.nameServer.Size = new System.Drawing.Size(292, 22);
            this.nameServer.TabIndex = 0;
            // 
            // adressServer
            // 
            this.adressServer.Location = new System.Drawing.Point(181, 65);
            this.adressServer.Name = "adressServer";
            this.adressServer.Size = new System.Drawing.Size(292, 22);
            this.adressServer.TabIndex = 1;
            // 
            // passServer
            // 
            this.passServer.Location = new System.Drawing.Point(181, 147);
            this.passServer.Name = "passServer";
            this.passServer.Size = new System.Drawing.Size(292, 22);
            this.passServer.TabIndex = 3;
            // 
            // userServer
            // 
            this.userServer.Location = new System.Drawing.Point(181, 109);
            this.userServer.Name = "userServer";
            this.userServer.Size = new System.Drawing.Size(292, 22);
            this.userServer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nom du serveur :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Adresse du serveur :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nom de l\'utilisateur :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mot de passe :";
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(128, 196);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 8;
            this.ok.Text = "Ok";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(292, 196);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 9;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // AddServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 247);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passServer);
            this.Controls.Add(this.userServer);
            this.Controls.Add(this.adressServer);
            this.Controls.Add(this.nameServer);
            this.Name = "AddServer";
            this.Text = "addServeur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameServer;
        private System.Windows.Forms.TextBox adressServer;
        private System.Windows.Forms.TextBox passServer;
        private System.Windows.Forms.TextBox userServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button Cancel;
    }
}