using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class FrmProduits : Form
    {
        public FrmProduits()
        {
            InitializeComponent();
        }
        public void Activate(bool v)
        {
            panel1.Enabled = !v;
            panel2.Enabled = v;
            btnNew.Visible = v;
            btnEdit.Visible = v;
            btnDelete.Visible = v;

            btnValidate.Visible = !v;
            btnCancel.Visible = !v;

            btnPicture.Visible = !v;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestioncommercialhamzaDataSet.Categorie'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.categorieTableAdapter.Fill(this.gestioncommercialhamzaDataSet.Categorie);
            // TODO: cette ligne de code charge les données dans la table 'gestioncommercialhamzaDataSet.Produit'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.produitTableAdapter.Fill(this.gestioncommercialhamzaDataSet.Produit);
            Activate(true);
        }

        private void produitBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produitBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestioncommercialhamzaDataSet);

        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            produitBindingSource.MoveLast();

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            produitBindingSource.MoveFirst();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (produitListBox.SelectedIndex == 0)
                produitBindingSource.MoveLast();
            else
                produitBindingSource.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (produitListBox.SelectedIndex == produitListBox.Items.Count - 1)
                produitBindingSource.MoveFirst();
            else
                produitBindingSource.MoveNext();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string start = "%";
            string end = "%";
            if (rbStartBy.Checked) start = "";
            if (rbEndBy.Checked) end = "";

            produitBindingSource.Filter = "designation_produit like '" + start + txtFind.Text + end + "'";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            produitBindingSource.AddNew();
            Activate(false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this product?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                produitBindingSource.RemoveCurrent();
                this.tableAdapterManager.UpdateAll(this.gestioncommercialhamzaDataSet);
            }
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produitBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestioncommercialhamzaDataSet);
            Activate(true);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            produitBindingSource.CancelEdit();
            Activate(true);
        }

        private void txtFind_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnFind.PerformClick();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Activate(false);
        }

        private void rbStartBy_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void image_produitTextBox_TextChanged(object sender, EventArgs e)
        {
            if (image_produitTextBox.Text == "")
                pictureBox1.Load("photos/empty.png");
            else
                pictureBox1.Load("photos/" + image_produitTextBox.Text);
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string ext = Path.GetExtension(ofd.FileName);
                string name = DateTime.Now.ToString().Replace(" ", "").Replace("/", "").Replace(":", "");
                Random r = new Random();
                name = name + (r.Next() * 1000) + ext;
                File.Copy(ofd.FileName, "photos/" + name);
                image_produitTextBox.Text = name;
            }
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {

            FrmCategories f = new FrmCategories();
            f.ShowDialog();
            this.categorieTableAdapter.Fill(this.gestioncommercialhamzaDataSet.Categorie);

        }
    }
}
