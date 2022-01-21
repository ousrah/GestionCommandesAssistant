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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void TSBtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AfficherFenetre(Form f)
        {
            PnlEcran.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            this.PnlEcran.Controls.Add(f);
            f.Show();
        }

        private void TsBtnCategories_Click(object sender, EventArgs e)
        {
    
            AfficherFenetre(new FrmCategories());
       /*     DialogResult d = f.ShowDialog();
            if (d == DialogResult.Yes)
                MessageBox.Show("vous avez cliqué sur btn1");
            else
        if (d == DialogResult.No)
                MessageBox.Show("vous avez cliqué sur btn2");
            else

                MessageBox.Show("vous avez cliqué sur btn3");*/

        }

        private void TsBtnProduits_Click(object sender, EventArgs e)
        {

  
            AfficherFenetre(new FrmProduits());
        }

        private void TsBtnClients_Click(object sender, EventArgs e)
        {
            AfficherFenetre(new FrmClients());
        }

        private void TsBtnCommandes_Click(object sender, EventArgs e)
        {
            AfficherFenetre(new FrmCommandes());
        }
    }
}
