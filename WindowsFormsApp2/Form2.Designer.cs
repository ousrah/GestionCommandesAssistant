
namespace WindowsFormsApp2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.Label iD_produitLabel;
            System.Windows.Forms.Label designation_produitLabel;
            System.Windows.Forms.Label image_produitLabel;
            System.Windows.Forms.Label qtestockLabel;
            System.Windows.Forms.Label prixUnitaireLabel;
            System.Windows.Forms.Label proprieteLabel;
            System.Windows.Forms.Label uniteLabel;
            this.gestioncommercialhamzaDataSet = new WindowsFormsApp2.gestioncommercialhamzaDataSet();
            this.categorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categorieTableAdapter = new WindowsFormsApp2.gestioncommercialhamzaDataSetTableAdapters.CategorieTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.gestioncommercialhamzaDataSetTableAdapters.TableAdapterManager();
            this.categorieBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.categorieBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.categorieComboBox = new System.Windows.Forms.ComboBox();
            this.produitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produitTableAdapter = new WindowsFormsApp2.gestioncommercialhamzaDataSetTableAdapters.ProduitTableAdapter();
            this.produitListBox = new System.Windows.Forms.ListBox();
            this.iD_produitTextBox = new System.Windows.Forms.TextBox();
            this.designation_produitTextBox = new System.Windows.Forms.TextBox();
            this.image_produitTextBox = new System.Windows.Forms.TextBox();
            this.qtestockTextBox = new System.Windows.Forms.TextBox();
            this.prixUnitaireTextBox = new System.Windows.Forms.TextBox();
            this.proprieteTextBox = new System.Windows.Forms.TextBox();
            this.uniteTextBox = new System.Windows.Forms.TextBox();
            iD_produitLabel = new System.Windows.Forms.Label();
            designation_produitLabel = new System.Windows.Forms.Label();
            image_produitLabel = new System.Windows.Forms.Label();
            qtestockLabel = new System.Windows.Forms.Label();
            prixUnitaireLabel = new System.Windows.Forms.Label();
            proprieteLabel = new System.Windows.Forms.Label();
            uniteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gestioncommercialhamzaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingNavigator)).BeginInit();
            this.categorieBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gestioncommercialhamzaDataSet
            // 
            this.gestioncommercialhamzaDataSet.DataSetName = "gestioncommercialhamzaDataSet";
            this.gestioncommercialhamzaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categorieBindingSource
            // 
            this.categorieBindingSource.DataMember = "Categorie";
            this.categorieBindingSource.DataSource = this.gestioncommercialhamzaDataSet;
            // 
            // categorieTableAdapter
            // 
            this.categorieTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategorieTableAdapter = this.categorieTableAdapter;
            this.tableAdapterManager.ProduitTableAdapter = this.produitTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.gestioncommercialhamzaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // categorieBindingNavigator
            // 
            this.categorieBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.categorieBindingNavigator.BindingSource = this.categorieBindingSource;
            this.categorieBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.categorieBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.categorieBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.categorieBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.categorieBindingNavigatorSaveItem});
            this.categorieBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.categorieBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.categorieBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.categorieBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.categorieBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.categorieBindingNavigator.Name = "categorieBindingNavigator";
            this.categorieBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.categorieBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.categorieBindingNavigator.TabIndex = 0;
            this.categorieBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 20);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // categorieBindingNavigatorSaveItem
            // 
            this.categorieBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.categorieBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("categorieBindingNavigatorSaveItem.Image")));
            this.categorieBindingNavigatorSaveItem.Name = "categorieBindingNavigatorSaveItem";
            this.categorieBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.categorieBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.categorieBindingNavigatorSaveItem.Click += new System.EventHandler(this.categorieBindingNavigatorSaveItem_Click);
            // 
            // categorieComboBox
            // 
            this.categorieComboBox.DataSource = this.categorieBindingSource;
            this.categorieComboBox.DisplayMember = "Nom_cat";
            this.categorieComboBox.FormattingEnabled = true;
            this.categorieComboBox.Location = new System.Drawing.Point(93, 48);
            this.categorieComboBox.Name = "categorieComboBox";
            this.categorieComboBox.Size = new System.Drawing.Size(300, 24);
            this.categorieComboBox.TabIndex = 1;
            this.categorieComboBox.ValueMember = "ID_categorie";
            // 
            // produitBindingSource
            // 
            this.produitBindingSource.DataMember = "FK_Produit_Categorie";
            this.produitBindingSource.DataSource = this.categorieBindingSource;
            // 
            // produitTableAdapter
            // 
            this.produitTableAdapter.ClearBeforeFill = true;
            // 
            // produitListBox
            // 
            this.produitListBox.DataSource = this.produitBindingSource;
            this.produitListBox.DisplayMember = "Designation_produit";
            this.produitListBox.FormattingEnabled = true;
            this.produitListBox.ItemHeight = 16;
            this.produitListBox.Location = new System.Drawing.Point(116, 149);
            this.produitListBox.Name = "produitListBox";
            this.produitListBox.Size = new System.Drawing.Size(300, 212);
            this.produitListBox.TabIndex = 2;
            this.produitListBox.ValueMember = "ID_produit";
            // 
            // iD_produitLabel
            // 
            iD_produitLabel.AutoSize = true;
            iD_produitLabel.Location = new System.Drawing.Point(476, 172);
            iD_produitLabel.Name = "iD_produitLabel";
            iD_produitLabel.Size = new System.Drawing.Size(73, 17);
            iD_produitLabel.TabIndex = 3;
            iD_produitLabel.Text = "ID produit:";
            // 
            // iD_produitTextBox
            // 
            this.iD_produitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "ID_produit", true));
            this.iD_produitTextBox.Location = new System.Drawing.Point(617, 169);
            this.iD_produitTextBox.Name = "iD_produitTextBox";
            this.iD_produitTextBox.Size = new System.Drawing.Size(100, 22);
            this.iD_produitTextBox.TabIndex = 4;
            // 
            // designation_produitLabel
            // 
            designation_produitLabel.AutoSize = true;
            designation_produitLabel.Location = new System.Drawing.Point(476, 200);
            designation_produitLabel.Name = "designation_produitLabel";
            designation_produitLabel.Size = new System.Drawing.Size(135, 17);
            designation_produitLabel.TabIndex = 5;
            designation_produitLabel.Text = "Designation produit:";
            // 
            // designation_produitTextBox
            // 
            this.designation_produitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "Designation_produit", true));
            this.designation_produitTextBox.Location = new System.Drawing.Point(617, 197);
            this.designation_produitTextBox.Name = "designation_produitTextBox";
            this.designation_produitTextBox.Size = new System.Drawing.Size(100, 22);
            this.designation_produitTextBox.TabIndex = 6;
            // 
            // image_produitLabel
            // 
            image_produitLabel.AutoSize = true;
            image_produitLabel.Location = new System.Drawing.Point(476, 228);
            image_produitLabel.Name = "image_produitLabel";
            image_produitLabel.Size = new System.Drawing.Size(98, 17);
            image_produitLabel.TabIndex = 7;
            image_produitLabel.Text = "Image produit:";
            // 
            // image_produitTextBox
            // 
            this.image_produitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "Image_produit", true));
            this.image_produitTextBox.Location = new System.Drawing.Point(617, 225);
            this.image_produitTextBox.Name = "image_produitTextBox";
            this.image_produitTextBox.Size = new System.Drawing.Size(100, 22);
            this.image_produitTextBox.TabIndex = 8;
            // 
            // qtestockLabel
            // 
            qtestockLabel.AutoSize = true;
            qtestockLabel.Location = new System.Drawing.Point(476, 256);
            qtestockLabel.Name = "qtestockLabel";
            qtestockLabel.Size = new System.Drawing.Size(65, 17);
            qtestockLabel.TabIndex = 11;
            qtestockLabel.Text = "qtestock:";
            // 
            // qtestockTextBox
            // 
            this.qtestockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "qtestock", true));
            this.qtestockTextBox.Location = new System.Drawing.Point(617, 253);
            this.qtestockTextBox.Name = "qtestockTextBox";
            this.qtestockTextBox.Size = new System.Drawing.Size(100, 22);
            this.qtestockTextBox.TabIndex = 12;
            // 
            // prixUnitaireLabel
            // 
            prixUnitaireLabel.AutoSize = true;
            prixUnitaireLabel.Location = new System.Drawing.Point(476, 284);
            prixUnitaireLabel.Name = "prixUnitaireLabel";
            prixUnitaireLabel.Size = new System.Drawing.Size(87, 17);
            prixUnitaireLabel.TabIndex = 13;
            prixUnitaireLabel.Text = "prix Unitaire:";
            // 
            // prixUnitaireTextBox
            // 
            this.prixUnitaireTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "prixUnitaire", true));
            this.prixUnitaireTextBox.Location = new System.Drawing.Point(617, 281);
            this.prixUnitaireTextBox.Name = "prixUnitaireTextBox";
            this.prixUnitaireTextBox.Size = new System.Drawing.Size(100, 22);
            this.prixUnitaireTextBox.TabIndex = 14;
            // 
            // proprieteLabel
            // 
            proprieteLabel.AutoSize = true;
            proprieteLabel.Location = new System.Drawing.Point(476, 312);
            proprieteLabel.Name = "proprieteLabel";
            proprieteLabel.Size = new System.Drawing.Size(69, 17);
            proprieteLabel.TabIndex = 15;
            proprieteLabel.Text = "propriete:";
            // 
            // proprieteTextBox
            // 
            this.proprieteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "propriete", true));
            this.proprieteTextBox.Location = new System.Drawing.Point(617, 309);
            this.proprieteTextBox.Name = "proprieteTextBox";
            this.proprieteTextBox.Size = new System.Drawing.Size(100, 22);
            this.proprieteTextBox.TabIndex = 16;
            // 
            // uniteLabel
            // 
            uniteLabel.AutoSize = true;
            uniteLabel.Location = new System.Drawing.Point(476, 340);
            uniteLabel.Name = "uniteLabel";
            uniteLabel.Size = new System.Drawing.Size(43, 17);
            uniteLabel.TabIndex = 17;
            uniteLabel.Text = "unite:";
            // 
            // uniteTextBox
            // 
            this.uniteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "unite", true));
            this.uniteTextBox.Location = new System.Drawing.Point(617, 337);
            this.uniteTextBox.Name = "uniteTextBox";
            this.uniteTextBox.Size = new System.Drawing.Size(100, 22);
            this.uniteTextBox.TabIndex = 18;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(iD_produitLabel);
            this.Controls.Add(this.iD_produitTextBox);
            this.Controls.Add(designation_produitLabel);
            this.Controls.Add(this.designation_produitTextBox);
            this.Controls.Add(image_produitLabel);
            this.Controls.Add(this.image_produitTextBox);
            this.Controls.Add(qtestockLabel);
            this.Controls.Add(this.qtestockTextBox);
            this.Controls.Add(prixUnitaireLabel);
            this.Controls.Add(this.prixUnitaireTextBox);
            this.Controls.Add(proprieteLabel);
            this.Controls.Add(this.proprieteTextBox);
            this.Controls.Add(uniteLabel);
            this.Controls.Add(this.uniteTextBox);
            this.Controls.Add(this.produitListBox);
            this.Controls.Add(this.categorieComboBox);
            this.Controls.Add(this.categorieBindingNavigator);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gestioncommercialhamzaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingNavigator)).EndInit();
            this.categorieBindingNavigator.ResumeLayout(false);
            this.categorieBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private gestioncommercialhamzaDataSet gestioncommercialhamzaDataSet;
        private System.Windows.Forms.BindingSource categorieBindingSource;
        private gestioncommercialhamzaDataSetTableAdapters.CategorieTableAdapter categorieTableAdapter;
        private gestioncommercialhamzaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator categorieBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton categorieBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox categorieComboBox;
        private gestioncommercialhamzaDataSetTableAdapters.ProduitTableAdapter produitTableAdapter;
        private System.Windows.Forms.BindingSource produitBindingSource;
        private System.Windows.Forms.ListBox produitListBox;
        private System.Windows.Forms.TextBox iD_produitTextBox;
        private System.Windows.Forms.TextBox designation_produitTextBox;
        private System.Windows.Forms.TextBox image_produitTextBox;
        private System.Windows.Forms.TextBox qtestockTextBox;
        private System.Windows.Forms.TextBox prixUnitaireTextBox;
        private System.Windows.Forms.TextBox proprieteTextBox;
        private System.Windows.Forms.TextBox uniteTextBox;
    }
}