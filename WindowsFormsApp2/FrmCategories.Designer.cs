
namespace WindowsFormsApp2
{
    partial class FrmCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategories));
            System.Windows.Forms.Label iD_categorieLabel;
            System.Windows.Forms.Label nom_catLabel;
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
            this.categorieListBox = new System.Windows.Forms.ListBox();
            this.iD_categorieTextBox = new System.Windows.Forms.TextBox();
            this.nom_catTextBox = new System.Windows.Forms.TextBox();
            iD_categorieLabel = new System.Windows.Forms.Label();
            nom_catLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gestioncommercialhamzaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingNavigator)).BeginInit();
            this.categorieBindingNavigator.SuspendLayout();
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
            this.tableAdapterManager.ProduitTableAdapter = null;
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
            this.categorieBindingNavigator.Size = new System.Drawing.Size(798, 27);
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
            // categorieListBox
            // 
            this.categorieListBox.DataSource = this.categorieBindingSource;
            this.categorieListBox.DisplayMember = "Nom_cat";
            this.categorieListBox.FormattingEnabled = true;
            this.categorieListBox.ItemHeight = 22;
            this.categorieListBox.Location = new System.Drawing.Point(15, 63);
            this.categorieListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.categorieListBox.Name = "categorieListBox";
            this.categorieListBox.Size = new System.Drawing.Size(374, 290);
            this.categorieListBox.TabIndex = 1;
            this.categorieListBox.ValueMember = "ID_categorie";
            // 
            // iD_categorieLabel
            // 
            iD_categorieLabel.AutoSize = true;
            iD_categorieLabel.Location = new System.Drawing.Point(424, 125);
            iD_categorieLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            iD_categorieLabel.Name = "iD_categorieLabel";
            iD_categorieLabel.Size = new System.Drawing.Size(115, 24);
            iD_categorieLabel.TabIndex = 2;
            iD_categorieLabel.Text = "ID categorie:";
            // 
            // iD_categorieTextBox
            // 
            this.iD_categorieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categorieBindingSource, "ID_categorie", true));
            this.iD_categorieTextBox.Location = new System.Drawing.Point(541, 121);
            this.iD_categorieTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iD_categorieTextBox.Name = "iD_categorieTextBox";
            this.iD_categorieTextBox.Size = new System.Drawing.Size(124, 28);
            this.iD_categorieTextBox.TabIndex = 3;
            // 
            // nom_catLabel
            // 
            nom_catLabel.AutoSize = true;
            nom_catLabel.Location = new System.Drawing.Point(424, 164);
            nom_catLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nom_catLabel.Name = "nom_catLabel";
            nom_catLabel.Size = new System.Drawing.Size(85, 24);
            nom_catLabel.TabIndex = 4;
            nom_catLabel.Text = "Nom cat:";
            // 
            // nom_catTextBox
            // 
            this.nom_catTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categorieBindingSource, "Nom_cat", true));
            this.nom_catTextBox.Location = new System.Drawing.Point(541, 160);
            this.nom_catTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nom_catTextBox.Name = "nom_catTextBox";
            this.nom_catTextBox.Size = new System.Drawing.Size(124, 28);
            this.nom_catTextBox.TabIndex = 5;
            // 
            // FrmCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 484);
            this.Controls.Add(iD_categorieLabel);
            this.Controls.Add(this.iD_categorieTextBox);
            this.Controls.Add(nom_catLabel);
            this.Controls.Add(this.nom_catTextBox);
            this.Controls.Add(this.categorieListBox);
            this.Controls.Add(this.categorieBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmCategories";
            this.Text = "FrmCategories";
            this.Load += new System.EventHandler(this.FrmCategories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gestioncommercialhamzaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingNavigator)).EndInit();
            this.categorieBindingNavigator.ResumeLayout(false);
            this.categorieBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.ListBox categorieListBox;
        private System.Windows.Forms.TextBox iD_categorieTextBox;
        private System.Windows.Forms.TextBox nom_catTextBox;
    }
}