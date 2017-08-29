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
        private UserInfosConnect userInfosConnect;

        public int level_auth;

        public MainForm(int level)
        {
            InitializeComponent();
            dbConnect = new DBConnect();
            userInfosConnect = new UserInfosConnect();
            level_auth = level;
            MessageBox.Show(userInfosConnect.UserLevel(1).ToString());
            
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
            tlsInfos += " | Auth. Level : " + level_auth;
            tls_infos.Text = tlsInfos;
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
