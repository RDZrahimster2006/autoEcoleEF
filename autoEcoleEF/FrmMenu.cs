using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoEcoleEF
{
    public partial class FrmMenu : Form
    {
        private autoecoleEntities mesDonneesEF;
        public FrmMenu()
        {
            InitializeComponent();
            this.mesDonneesEF = new autoecoleEntities();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void eleveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGererEleve f = new FrmGererEleve(this.mesDonneesEF);
            f.MdiParent = this;
            f.Show();
        }

        private void gererToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmGererEleve f = new FrmGererEleve(this.mesDonneesEF);
            f.MdiParent = this;
            f.Show();
        }
    }
}
