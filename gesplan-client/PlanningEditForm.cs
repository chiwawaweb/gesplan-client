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
    public partial class PlanningEditForm : Form
    {
        private DBConnect dbConnect;

        public PlanningEditForm()
        {
            InitializeComponent();

            dbConnect = new DBConnect();    
        }

        private void PlanningEditForm_Load(object sender, EventArgs e)
        {
            List<string>[] list;
            list = dbConnect.Select();

            dgvPersonnels.Rows.Clear();
            for (int i=0; i<list[0].Count; i++)
            {
                int number = dgvPersonnels.Rows.Add();
                dgvPersonnels.Rows[number].Cells[0].Value = list[0][i];
                dgvPersonnels.Rows[number].Cells[1].Value = list[1][i];
                dgvPersonnels.Rows[number].Cells[2].Value = list[2][i];
            }

            // création du formulaire à la volée
            TextBox txt_nbPersonnels = new TextBox();
            txt_nbPersonnels.Location = new Point(50, 50);
            Controls.Add(txt_nbPersonnels);

            // nombre de personnels dans la base -> barre d'état
            string tlsInfos = "Nombre de personnels dans la base : " + dbConnect.Count().ToString();
            //tls_infos.Text = tlsInfos;

        }
    }
}
