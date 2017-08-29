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

        private static int userID;

        public MainForm(int u)
        {
            InitializeComponent();
            dbConnect = new DBConnect();
            userID = u;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // ouvre le formulaire d'édition du planning
            ConnexionForm frmConnect = new ConnexionForm();
            frmConnect.ShowDialog();

            menuStrip.Visible = true;
            statusStrip.Visible = true;

            // nombre de personnels dans la base -> barre d'état
            string tlsInfos = "Nombre de personnels dans la base : " + dbConnect.Count().ToString();
            tlsInfos += " | User ID : #" + userID.ToString();
            tls_infos.Text = tlsInfos;

            // affiche ID du user
            
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
