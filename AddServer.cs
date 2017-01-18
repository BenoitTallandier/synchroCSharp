using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class AddServer : Form
    {
        private User user;
        private Main form;
        public AddServer(User u, Main f)
        {
            this.form = f;
            this.user = u;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ok_Click(object sender, EventArgs e)
        {
            BDDConnection.addServer(user, adressServer.Text, nameServer.Text, userServer.Text, passServer.Text);
            form.reloadServer();
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
