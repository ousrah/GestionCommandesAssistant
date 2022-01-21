
namespace WindowsFormsApp2
{
    partial class FrmCommandes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label totalLabel;
            this.gestioncommercialhamzaDataSet = new WindowsFormsApp2.gestioncommercialhamzaDataSet();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new WindowsFormsApp2.gestioncommercialhamzaDataSetTableAdapters.ClientTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.gestioncommercialhamzaDataSetTableAdapters.TableAdapterManager();
            this.commandeTableAdapter = new WindowsFormsApp2.gestioncommercialhamzaDataSetTableAdapters.CommandeTableAdapter();
            this.clientComboBox = new System.Windows.Forms.ComboBox();
            this.commandeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commandeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnAjouterCommande = new System.Windows.Forms.Button();
            this.produitsParCommandeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produitsParCommandeTableAdapter = new WindowsFormsApp2.gestioncommercialhamzaDataSetTableAdapters.ProduitsParCommandeTableAdapter();
            this.produitsParCommandeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalParCommandeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.totalParCommandeTableAdapter = new WindowsFormsApp2.gestioncommercialhamzaDataSetTableAdapters.TotalParCommandeTableAdapter();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.cboProduit = new System.Windows.Forms.ComboBox();
            this.produitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produitTableAdapter = new WindowsFormsApp2.gestioncommercialhamzaDataSetTableAdapters.ProduitTableAdapter();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.txtQte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAjouterLigne = new System.Windows.Forms.Button();
            totalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gestioncommercialhamzaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitsParCommandeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitsParCommandeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalParCommandeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(1066, 435);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(48, 24);
            totalLabel.TabIndex = 7;
            totalLabel.Text = "total:";
            // 
            // gestioncommercialhamzaDataSet
            // 
            this.gestioncommercialhamzaDataSet.DataSetName = "gestioncommercialhamzaDataSet";
            this.gestioncommercialhamzaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.gestioncommercialhamzaDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategorieTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = this.clientTableAdapter;
            this.tableAdapterManager.CommandeTableAdapter = this.commandeTableAdapter;
            this.tableAdapterManager.LigneTableAdapter = null;
            this.tableAdapterManager.ProduitTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.gestioncommercialhamzaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // commandeTableAdapter
            // 
            this.commandeTableAdapter.ClearBeforeFill = true;
            // 
            // clientComboBox
            // 
            this.clientComboBox.DataSource = this.clientBindingSource;
            this.clientComboBox.DisplayMember = "Nom_client";
            this.clientComboBox.FormattingEnabled = true;
            this.clientComboBox.Location = new System.Drawing.Point(26, 54);
            this.clientComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.clientComboBox.Name = "clientComboBox";
            this.clientComboBox.Size = new System.Drawing.Size(374, 30);
            this.clientComboBox.TabIndex = 1;
            this.clientComboBox.ValueMember = "ID_client";
            // 
            // commandeBindingSource
            // 
            this.commandeBindingSource.DataMember = "FK_Commande_Client";
            this.commandeBindingSource.DataSource = this.clientBindingSource;
            // 
            // commandeDataGridView
            // 
            this.commandeDataGridView.AllowUserToAddRows = false;
            this.commandeDataGridView.AllowUserToDeleteRows = false;
            this.commandeDataGridView.AutoGenerateColumns = false;
            this.commandeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.commandeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.commandeDataGridView.DataSource = this.commandeBindingSource;
            this.commandeDataGridView.Location = new System.Drawing.Point(26, 114);
            this.commandeDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.commandeDataGridView.Name = "commandeDataGridView";
            this.commandeDataGridView.ReadOnly = true;
            this.commandeDataGridView.RowHeadersWidth = 51;
            this.commandeDataGridView.RowTemplate.Height = 24;
            this.commandeDataGridView.Size = new System.Drawing.Size(429, 302);
            this.commandeDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_commande";
            this.dataGridViewTextBoxColumn1.HeaderText = "Code";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Date_commande";
            this.dataGridViewTextBoxColumn2.HeaderText = "Date";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // btnClients
            // 
            this.btnClients.Location = new System.Drawing.Point(417, 54);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(62, 30);
            this.btnClients.TabIndex = 2;
            this.btnClients.Text = "...";
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnAjouterCommande
            // 
            this.btnAjouterCommande.Location = new System.Drawing.Point(26, 424);
            this.btnAjouterCommande.Name = "btnAjouterCommande";
            this.btnAjouterCommande.Size = new System.Drawing.Size(94, 44);
            this.btnAjouterCommande.TabIndex = 3;
            this.btnAjouterCommande.Text = "Ajouter";
            this.btnAjouterCommande.UseVisualStyleBackColor = true;
            this.btnAjouterCommande.Click += new System.EventHandler(this.btnAjouterCommande_Click);
            // 
            // produitsParCommandeBindingSource
            // 
            this.produitsParCommandeBindingSource.DataMember = "Commande_ProduitsParCommande";
            this.produitsParCommandeBindingSource.DataSource = this.commandeBindingSource;
            // 
            // produitsParCommandeTableAdapter
            // 
            this.produitsParCommandeTableAdapter.ClearBeforeFill = true;
            // 
            // produitsParCommandeDataGridView
            // 
            this.produitsParCommandeDataGridView.AllowUserToAddRows = false;
            this.produitsParCommandeDataGridView.AllowUserToDeleteRows = false;
            this.produitsParCommandeDataGridView.AutoGenerateColumns = false;
            this.produitsParCommandeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produitsParCommandeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn6,
            this.Prix});
            this.produitsParCommandeDataGridView.DataSource = this.produitsParCommandeBindingSource;
            this.produitsParCommandeDataGridView.Location = new System.Drawing.Point(466, 114);
            this.produitsParCommandeDataGridView.Name = "produitsParCommandeDataGridView";
            this.produitsParCommandeDataGridView.ReadOnly = true;
            this.produitsParCommandeDataGridView.RowHeadersWidth = 51;
            this.produitsParCommandeDataGridView.RowTemplate.Height = 24;
            this.produitsParCommandeDataGridView.Size = new System.Drawing.Size(834, 302);
            this.produitsParCommandeDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nom_cat";
            this.dataGridViewTextBoxColumn3.HeaderText = "Catégorie";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ID_produit";
            this.dataGridViewTextBoxColumn5.HeaderText = "Réf";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Designation_produit";
            this.dataGridViewTextBoxColumn8.HeaderText = "Designation";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Prix";
            this.dataGridViewTextBoxColumn7.HeaderText = "Prix";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Qte";
            this.dataGridViewTextBoxColumn6.HeaderText = "Qte";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // Prix
            // 
            this.Prix.DataPropertyName = "Total";
            this.Prix.HeaderText = "Total";
            this.Prix.MinimumWidth = 6;
            this.Prix.Name = "Prix";
            this.Prix.ReadOnly = true;
            this.Prix.Width = 125;
            // 
            // totalParCommandeBindingSource
            // 
            this.totalParCommandeBindingSource.DataMember = "FK_Ligne_Commande1";
            this.totalParCommandeBindingSource.DataSource = this.commandeBindingSource;
            // 
            // totalParCommandeTableAdapter
            // 
            this.totalParCommandeTableAdapter.ClearBeforeFill = true;
            // 
            // totalTextBox
            // 
            this.totalTextBox.BackColor = System.Drawing.Color.White;
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.totalParCommandeBindingSource, "total", true));
            this.totalTextBox.Location = new System.Drawing.Point(1129, 435);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(171, 28);
            this.totalTextBox.TabIndex = 8;
            // 
            // cboProduit
            // 
            this.cboProduit.DataSource = this.produitBindingSource;
            this.cboProduit.DisplayMember = "Designation_produit";
            this.cboProduit.FormattingEnabled = true;
            this.cboProduit.Location = new System.Drawing.Point(539, 66);
            this.cboProduit.Name = "cboProduit";
            this.cboProduit.Size = new System.Drawing.Size(290, 30);
            this.cboProduit.TabIndex = 9;
            this.cboProduit.ValueMember = "ID_produit";
            // 
            // produitBindingSource
            // 
            this.produitBindingSource.DataMember = "Produit";
            this.produitBindingSource.DataSource = this.gestioncommercialhamzaDataSet;
            // 
            // produitTableAdapter
            // 
            this.produitTableAdapter.ClearBeforeFill = true;
            // 
            // txtPrix
            // 
            this.txtPrix.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "prixUnitaire", true));
            this.txtPrix.Location = new System.Drawing.Point(835, 66);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(180, 28);
            this.txtPrix.TabIndex = 10;
            // 
            // txtQte
            // 
            this.txtQte.Location = new System.Drawing.Point(1021, 66);
            this.txtQte.Name = "txtQte";
            this.txtQte.Size = new System.Drawing.Size(100, 28);
            this.txtQte.TabIndex = 11;
            this.txtQte.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(535, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Liste des produits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(831, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Prix unitaire";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1017, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Quantité";
            // 
            // btnAjouterLigne
            // 
            this.btnAjouterLigne.Location = new System.Drawing.Point(1206, 52);
            this.btnAjouterLigne.Name = "btnAjouterLigne";
            this.btnAjouterLigne.Size = new System.Drawing.Size(94, 44);
            this.btnAjouterLigne.TabIndex = 15;
            this.btnAjouterLigne.Text = "Ajouter";
            this.btnAjouterLigne.UseVisualStyleBackColor = true;
            this.btnAjouterLigne.Click += new System.EventHandler(this.btnAjouterLigne_Click);
            // 
            // FrmCommandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 539);
            this.Controls.Add(this.btnAjouterLigne);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQte);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.cboProduit);
            this.Controls.Add(totalLabel);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.produitsParCommandeDataGridView);
            this.Controls.Add(this.btnAjouterCommande);
            this.Controls.Add(this.btnClients);
            this.Controls.Add(this.commandeDataGridView);
            this.Controls.Add(this.clientComboBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCommandes";
            this.Text = "FrmCommandes";
            this.Load += new System.EventHandler(this.FrmCommandes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gestioncommercialhamzaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitsParCommandeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitsParCommandeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalParCommandeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private gestioncommercialhamzaDataSet gestioncommercialhamzaDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private gestioncommercialhamzaDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private gestioncommercialhamzaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private gestioncommercialhamzaDataSetTableAdapters.CommandeTableAdapter commandeTableAdapter;
        private System.Windows.Forms.ComboBox clientComboBox;
        private System.Windows.Forms.BindingSource commandeBindingSource;
        private System.Windows.Forms.DataGridView commandeDataGridView;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnAjouterCommande;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource produitsParCommandeBindingSource;
        private gestioncommercialhamzaDataSetTableAdapters.ProduitsParCommandeTableAdapter produitsParCommandeTableAdapter;
        private System.Windows.Forms.DataGridView produitsParCommandeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.BindingSource totalParCommandeBindingSource;
        private gestioncommercialhamzaDataSetTableAdapters.TotalParCommandeTableAdapter totalParCommandeTableAdapter;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.ComboBox cboProduit;
        private System.Windows.Forms.BindingSource produitBindingSource;
        private gestioncommercialhamzaDataSetTableAdapters.ProduitTableAdapter produitTableAdapter;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.TextBox txtQte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAjouterLigne;
    }
}