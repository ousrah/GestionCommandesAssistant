using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void categorieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categorieBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestioncommercialhamzaDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestioncommercialhamzaDataSet.Produit'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.produitTableAdapter.Fill(this.gestioncommercialhamzaDataSet.Produit);
            // TODO: cette ligne de code charge les données dans la table 'gestioncommercialhamzaDataSet.Categorie'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.categorieTableAdapter.Fill(this.gestioncommercialhamzaDataSet.Categorie);

        }
    }
}
