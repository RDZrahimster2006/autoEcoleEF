using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoEcoleEF
{
    public partial class FrmGererEleve : Form
    {
        private autoecoleEntities mesDonneesEF;
        
        public FrmGererEleve(autoecoleEntities mesDonneesEF)
        {
            InitializeComponent();
            for (int i = 0; i < 30; i++)
                this.cmbCredit.Items.Add(i);
            this.mesDonneesEF = mesDonneesEF;
            this.bdgSourceEleve.DataSource = this.mesDonneesEF.eleves.ToList();
        }
        private int getNumEleve()
        {
            var reqDernier = (from el in this.mesDonneesEF.eleves
                                   orderby el.id descending
                                   select el);
            eleve dernierEleve = reqDernier.First();
            int n = dernierEleve.id + 1;
            return n;   
        }
        private eleve newEleve()
        {
            eleve newEleve = new eleve();
            newEleve.id = Convert.ToInt16(txtNum.Text);
            newEleve.nom = txtNom.Text;
            newEleve.prenom = txtPrenom.Text;
            newEleve.adresse = txtAdresse.Text;
            newEleve.dateInscription = dtInscription.Value;
            return newEleve;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmGererEleve_Load(object sender, EventArgs e)
        {

        }

       

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            this.bdgSourceEleve.EndEdit();
            try
            {
                this.mesDonneesEF.eleves.Add(newEleve());
                this.mesDonneesEF.SaveChanges();
                MessageBox.Show("Enregistrement Validé");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'enregistrement : {ex.Message}");
                // Vous pouvez également gérer l'exception de manière plus spécifique selon vos besoins.
            }

        }
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.txtNum.Text = this.getNumEleve().ToString();
        }
    }
}
