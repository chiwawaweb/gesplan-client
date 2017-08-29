using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

        private void connectUser()
        {
            // contenu du click bouton connexion

        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_connexion_Click(object sender, EventArgs e)
        {
            int userID = userConnect.Connect(txt_uid.Text, txt_password.Text);

            // vérifie que les champs ne soient pas vides
            if (txt_uid.Text=="" || txt_password.Text=="")
            {
                // erreur de saisie
                MessageBox.Show("Le matricule ou le mot de passe ne peuvent pas être vide.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (userID > 0)
                {
                    this.Close();
                    MainForm mainForm = new MainForm(userID);
                    mainForm.Activate();
                    MessageBox.Show("ID #" + userID);
                }
                else
                {
                    MessageBox.Show("Le matricule ou le mot de passe sont incorrects.", "Connexion refusée", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_password.Text = "";
                    txt_password.Focus();
                }
            }
            
        }
    }
}
