using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visucal_client
{
    public partial class PlanningViewForm : Form
    {
        private static int ID_site;

        public PlanningViewForm(int s = 0)
        {
            InitializeComponent();
            ID_site = s;
        }

        private void PlanningViewForm_Load(object sender, EventArgs e)
        {
            lbl_titre.Text = ID_site.ToString();
        }
    }
}
