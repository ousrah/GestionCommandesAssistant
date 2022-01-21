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
    public partial class FrmNewCommande : Form
    {
        private string idClient;
        public FrmNewCommande()
        {
            InitializeComponent();
        }

        public FrmNewCommande(string idClient)
        {
            this.idClient = idClient;
            InitializeComponent();
        }

        private void commandeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.commandeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestioncommercialhamzaDataSet);

        }

        private void FrmNewCommande_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestioncommercialhamzaDataSet.Commande'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.commandeTableAdapter.Fill(this.gestioncommercialhamzaDataSet.Commande);
            commandeBindingSource.AddNew();
            date_commandeDateTimePicker.Value = DateTime.Now;
            iD_clientTextBox.Text = this.idClient;
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.commandeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestioncommercialhamzaDataSet);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            commandeBindingSource.CancelEdit();
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
