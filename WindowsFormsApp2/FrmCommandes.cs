using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FrmCommandes : Form
    {
        public FrmCommandes()
        {
            InitializeComponent();
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestioncommercialhamzaDataSet);

        }

        private void FrmCommandes_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestioncommercialhamzaDataSet.Produit'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.produitTableAdapter.Fill(this.gestioncommercialhamzaDataSet.Produit);
            // TODO: cette ligne de code charge les données dans la table 'gestioncommercialhamzaDataSet.TotalParCommande'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.totalParCommandeTableAdapter.Fill(this.gestioncommercialhamzaDataSet.TotalParCommande);
            // TODO: cette ligne de code charge les données dans la table 'gestioncommercialhamzaDataSet.ProduitsParCommande'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.produitsParCommandeTableAdapter.Fill(this.gestioncommercialhamzaDataSet.ProduitsParCommande);
            // TODO: cette ligne de code charge les données dans la table 'gestioncommercialhamzaDataSet.Commande'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.commandeTableAdapter.Fill(this.gestioncommercialhamzaDataSet.Commande);
            // TODO: cette ligne de code charge les données dans la table 'gestioncommercialhamzaDataSet.Client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientTableAdapter.Fill(this.gestioncommercialhamzaDataSet.Client);

        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            FrmClients f = new FrmClients();
            f.ShowDialog();
            this.clientTableAdapter.Fill(this.gestioncommercialhamzaDataSet.Client);

        }

        private void btnAjouterCommande_Click(object sender, EventArgs e)
        {
            FrmNewCommande f = new FrmNewCommande(clientComboBox.SelectedValue.ToString());
            if (f.ShowDialog()==DialogResult.OK)
            {
                this.commandeTableAdapter.Fill(this.gestioncommercialhamzaDataSet.Commande);
            }

        }

        private void btnAjouterLigne_Click(object sender, EventArgs e)
        {
            int idC = Convert.ToInt32(commandeDataGridView.CurrentRow.Cells[0].Value);
            string idP = cboProduit.SelectedValue.ToString();
            int qte = Convert.ToInt32(txtQte.Text);
            double prix = Convert.ToDouble(txtPrix.Text);

            produitsParCommandeTableAdapter.InsertLigne(idC,idP,qte,prix);
            this.totalParCommandeTableAdapter.Fill(this.gestioncommercialhamzaDataSet.TotalParCommande);
            this.produitsParCommandeTableAdapter.Fill(this.gestioncommercialhamzaDataSet.ProduitsParCommande);


        }
    }
}
