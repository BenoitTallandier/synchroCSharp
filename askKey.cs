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
    public partial class askKey : Form
    {
        private User user;

        public askKey(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void okBt_Click(object sender, EventArgs e)
        {
            if (BDDConnection.updateKey(user, key.Text))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Erreur de clée");
            }
        }

        private void ignoreBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
