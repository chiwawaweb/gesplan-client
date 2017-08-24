using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gesplan_client
{
    public partial class ConnexionForm : Form
    {
        private UserConnect userConnect;

        public ConnexionForm()
        {
            InitializeComponent();
            userConnect = new UserConnect();
        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_connexion_Click(object sender, EventArgs e)
        {
            if (userConnect.Connect(txt_uid.Text, txt_password.Text) == true)
            {
                MessageBox.Show("authentification ok");
            }
            else
            {
                MessageBox.Show("authentification en erreur !");
                txt_password.Text = "";
                txt_password.Focus();
            }
        }
    }
}
