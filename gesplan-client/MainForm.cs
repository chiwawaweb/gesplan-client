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
    public partial class MainForm : Form
    {
        private DBConnect dbConnect;
        private UserConnect userConnect;

        private static int userID;

        public MainForm(int u)
        {
            InitializeComponent();
            dbConnect = new DBConnect();
            userConnect = new UserConnect();
            userID = u;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // ouvre le formulaire d'édition du planning
            ConnexionForm frmConnect = new ConnexionForm();
            frmConnect.ShowDialog();

            menuStrip.Visible = true;
            statusStrip.Visible = true;



            // liste des droits de l'utilisateur
            List<string>[] droits;
            droits = userConnect.UserDroits(userID);

            string mesDroits = "";
            for (int i =0;i<droits[0].Count; i++)
            {
                mesDroits += "("+droits[0][i]+")";
            }

            MessageBox.Show(mesDroits);


            // infos diverses dans la barre d'état
            string tlsInfos = "Nombre de personnels dans la base : " + dbConnect.Count().ToString();
            tlsInfos += " | Utilisateur connecté : " + userConnect.UserName(userID);
            tls_infos.Text = tlsInfos;

            
            
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
