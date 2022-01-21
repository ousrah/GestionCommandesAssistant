
namespace WindowsFormsApp2
{
    partial class FrmProduits
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iD_produitLabel;
            System.Windows.Forms.Label designation_produitLabel;
            System.Windows.Forms.Label iD_categorieLabel;
            System.Windows.Forms.Label qtestockLabel;
            System.Windows.Forms.Label prixUnitaireLabel;
            System.Windows.Forms.Label proprieteLabel;
            System.Windows.Forms.Label uniteLabel;
            this.gestioncommercialhamzaDataSet = new WindowsFormsApp2.gestioncommercialhamzaDataSet();
            this.produitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produitTableAdapter = new WindowsFormsApp2.gestioncommercialhamzaDataSetTableAdapters.ProduitTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.gestioncommercialhamzaDataSetTableAdapters.TableAdapterManager();
            this.produitListBox = new System.Windows.Forms.ListBox();
            this.iD_produitTextBox = new System.Windows.Forms.TextBox();
            this.designation_produitTextBox = new System.Windows.Forms.TextBox();
            this.image_produitTextBox = new System.Windows.Forms.TextBox();
            this.qtestockTextBox = new System.Windows.Forms.TextBox();
            this.prixUnitaireTextBox = new System.Windows.Forms.TextBox();
            this.proprieteTextBox = new System.Windows.Forms.TextBox();
            this.uniteTextBox = new System.Windows.Forms.TextBox();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rbStartBy = new System.Windows.Forms.RadioButton();
            this.rbContent = new System.Windows.Forms.RadioButton();
            this.rbEndBy = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.categorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.btnPicture = new System.Windows.Forms.Button();
            this.categorieTableAdapter = new WindowsFormsApp2.gestioncommercialhamzaDataSetTableAdapters.CategorieTableAdapter();
            this.btnCategories = new System.Windows.Forms.Button();
            iD_produitLabel = new System.Windows.Forms.Label();
            designation_produitLabel = new System.Windows.Forms.Label();
            iD_categorieLabel = new System.Windows.Forms.Label();
            qtestockLabel = new System.Windows.Forms.Label();
            prixUnitaireLabel = new System.Windows.Forms.Label();
            proprieteLabel = new System.Windows.Forms.Label();
            uniteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gestioncommercialhamzaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_produitLabel
            // 
            iD_produitLabel.AutoSize = true;
            iD_produitLabel.Location = new System.Drawing.Point(38, 41);
            iD_produitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            iD_produitLabel.Name = "iD_produitLabel";
            iD_produitLabel.Size = new System.Drawing.Size(95, 24);
            iD_produitLabel.TabIndex = 2;
            iD_produitLabel.Text = "ID produit:";
            // 
            // designation_produitLabel
            // 
            designation_produitLabel.AutoSize = true;
            designation_produitLabel.Location = new System.Drawing.Point(38, 80);
            designation_produitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            designation_produitLabel.Name = "designation_produitLabel";
            designation_produitLabel.Size = new System.Drawing.Size(177, 24);
            designation_produitLabel.TabIndex = 4;
            designation_produitLabel.Text = "Designation produit:";
            // 
            // iD_categorieLabel
            // 
            iD_categorieLabel.AutoSize = true;
            iD_categorieLabel.Location = new System.Drawing.Point(38, 116);
            iD_categorieLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            iD_categorieLabel.Name = "iD_categorieLabel";
            iD_categorieLabel.Size = new System.Drawing.Size(115, 24);
            iD_categorieLabel.TabIndex = 8;
            iD_categorieLabel.Text = "ID categorie:";
            // 
            // qtestockLabel
            // 
            qtestockLabel.AutoSize = true;
            qtestockLabel.Location = new System.Drawing.Point(38, 154);
            qtestockLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            qtestockLabel.Name = "qtestockLabel";
            qtestockLabel.Size = new System.Drawing.Size(84, 24);
            qtestockLabel.TabIndex = 10;
            qtestockLabel.Text = "qtestock:";
            // 
            // prixUnitaireLabel
            // 
            prixUnitaireLabel.AutoSize = true;
            prixUnitaireLabel.Location = new System.Drawing.Point(38, 193);
            prixUnitaireLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            prixUnitaireLabel.Name = "prixUnitaireLabel";
            prixUnitaireLabel.Size = new System.Drawing.Size(114, 24);
            prixUnitaireLabel.TabIndex = 12;
            prixUnitaireLabel.Text = "prix Unitaire:";
            // 
            // proprieteLabel
            // 
            proprieteLabel.AutoSize = true;
            proprieteLabel.Location = new System.Drawing.Point(38, 231);
            proprieteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            proprieteLabel.Name = "proprieteLabel";
            proprieteLabel.Size = new System.Drawing.Size(90, 24);
            proprieteLabel.TabIndex = 14;
            proprieteLabel.Text = "propriete:";
            // 
            // uniteLabel
            // 
            uniteLabel.AutoSize = true;
            uniteLabel.Location = new System.Drawing.Point(38, 270);
            uniteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            uniteLabel.Name = "uniteLabel";
            uniteLabel.Size = new System.Drawing.Size(56, 24);
            uniteLabel.TabIndex = 16;
            uniteLabel.Text = "unite:";
            // 
            // gestioncommercialhamzaDataSet
            // 
            this.gestioncommercialhamzaDataSet.DataSetName = "gestioncommercialhamzaDataSet";
            this.gestioncommercialhamzaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategorieTableAdapter = null;
            this.tableAdapterManager.ProduitTableAdapter = this.produitTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.gestioncommercialhamzaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // produitListBox
            // 
            this.produitListBox.DataSource = this.produitBindingSource;
            this.produitListBox.DisplayMember = "Designation_produit";
            this.produitListBox.FormattingEnabled = true;
            this.produitListBox.ItemHeight = 22;
            this.produitListBox.Location = new System.Drawing.Point(13, 78);
            this.produitListBox.Margin = new System.Windows.Forms.Padding(4);
            this.produitListBox.Name = "produitListBox";
            this.produitListBox.Size = new System.Drawing.Size(374, 400);
            this.produitListBox.TabIndex = 1;
            this.produitListBox.ValueMember = "ID_produit";
            // 
            // iD_produitTextBox
            // 
            this.iD_produitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "ID_produit", true));
            this.iD_produitTextBox.Location = new System.Drawing.Point(230, 37);
            this.iD_produitTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.iD_produitTextBox.Name = "iD_produitTextBox";
            this.iD_produitTextBox.Size = new System.Drawing.Size(280, 28);
            this.iD_produitTextBox.TabIndex = 3;
            // 
            // designation_produitTextBox
            // 
            this.designation_produitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "Designation_produit", true));
            this.designation_produitTextBox.Location = new System.Drawing.Point(230, 76);
            this.designation_produitTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.designation_produitTextBox.Name = "designation_produitTextBox";
            this.designation_produitTextBox.Size = new System.Drawing.Size(280, 28);
            this.designation_produitTextBox.TabIndex = 5;
            // 
            // image_produitTextBox
            // 
            this.image_produitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "Image_produit", true));
            this.image_produitTextBox.Location = new System.Drawing.Point(1016, 245);
            this.image_produitTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.image_produitTextBox.Name = "image_produitTextBox";
            this.image_produitTextBox.Size = new System.Drawing.Size(152, 28);
            this.image_produitTextBox.TabIndex = 7;
            this.image_produitTextBox.TextChanged += new System.EventHandler(this.image_produitTextBox_TextChanged);
            // 
            // qtestockTextBox
            // 
            this.qtestockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "qtestock", true));
            this.qtestockTextBox.Location = new System.Drawing.Point(230, 150);
            this.qtestockTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.qtestockTextBox.Name = "qtestockTextBox";
            this.qtestockTextBox.Size = new System.Drawing.Size(280, 28);
            this.qtestockTextBox.TabIndex = 11;
            // 
            // prixUnitaireTextBox
            // 
            this.prixUnitaireTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "prixUnitaire", true));
            this.prixUnitaireTextBox.Location = new System.Drawing.Point(230, 189);
            this.prixUnitaireTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.prixUnitaireTextBox.Name = "prixUnitaireTextBox";
            this.prixUnitaireTextBox.Size = new System.Drawing.Size(280, 28);
            this.prixUnitaireTextBox.TabIndex = 13;
            // 
            // proprieteTextBox
            // 
            this.proprieteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "propriete", true));
            this.proprieteTextBox.Location = new System.Drawing.Point(230, 227);
            this.proprieteTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.proprieteTextBox.Name = "proprieteTextBox";
            this.proprieteTextBox.Size = new System.Drawing.Size(280, 28);
            this.proprieteTextBox.TabIndex = 15;
            // 
            // uniteTextBox
            // 
            this.uniteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "unite", true));
            this.uniteTextBox.Location = new System.Drawing.Point(230, 266);
            this.uniteTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.uniteTextBox.Name = "uniteTextBox";
            this.uniteTextBox.Size = new System.Drawing.Size(280, 28);
            this.uniteTextBox.TabIndex = 17;
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(13, 489);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(4);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(52, 41);
            this.btnFirst.TabIndex = 18;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(73, 489);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(52, 41);
            this.btnPrevious.TabIndex = 19;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(275, 489);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(52, 41);
            this.btnNext.TabIndex = 20;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(335, 489);
            this.btnLast.Margin = new System.Windows.Forms.Padding(4);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(52, 41);
            this.btnLast.TabIndex = 21;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(312, 7);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 37);
            this.btnFind.TabIndex = 22;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(13, 7);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(293, 28);
            this.txtFind.TabIndex = 23;
            this.txtFind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFind_KeyUp);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(543, 447);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(134, 41);
            this.btnNew.TabIndex = 24;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(694, 447);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(134, 41);
            this.btnEdit.TabIndex = 25;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(846, 447);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(134, 41);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(621, 499);
            this.btnValidate.Margin = new System.Windows.Forms.Padding(4);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(134, 41);
            this.btnValidate.TabIndex = 27;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(763, 499);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(134, 41);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rbStartBy
            // 
            this.rbStartBy.AutoSize = true;
            this.rbStartBy.Location = new System.Drawing.Point(13, 42);
            this.rbStartBy.Name = "rbStartBy";
            this.rbStartBy.Size = new System.Drawing.Size(93, 28);
            this.rbStartBy.TabIndex = 29;
            this.rbStartBy.Text = "Start By";
            this.rbStartBy.UseVisualStyleBackColor = true;
            this.rbStartBy.CheckedChanged += new System.EventHandler(this.rbStartBy_CheckedChanged);
            this.rbStartBy.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // rbContent
            // 
            this.rbContent.AutoSize = true;
            this.rbContent.Checked = true;
            this.rbContent.Location = new System.Drawing.Point(112, 41);
            this.rbContent.Name = "rbContent";
            this.rbContent.Size = new System.Drawing.Size(96, 28);
            this.rbContent.TabIndex = 30;
            this.rbContent.TabStop = true;
            this.rbContent.Text = "Content";
            this.rbContent.UseVisualStyleBackColor = true;
            this.rbContent.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // rbEndBy
            // 
            this.rbEndBy.AutoSize = true;
            this.rbEndBy.Location = new System.Drawing.Point(214, 42);
            this.rbEndBy.Name = "rbEndBy";
            this.rbEndBy.Size = new System.Drawing.Size(92, 28);
            this.rbEndBy.TabIndex = 31;
            this.rbEndBy.Text = "End By";
            this.rbEndBy.UseVisualStyleBackColor = true;
            this.rbEndBy.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCategories);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(iD_produitLabel);
            this.panel1.Controls.Add(this.iD_produitTextBox);
            this.panel1.Controls.Add(designation_produitLabel);
            this.panel1.Controls.Add(this.designation_produitTextBox);
            this.panel1.Controls.Add(iD_categorieLabel);
            this.panel1.Controls.Add(qtestockLabel);
            this.panel1.Controls.Add(this.qtestockTextBox);
            this.panel1.Controls.Add(prixUnitaireLabel);
            this.panel1.Controls.Add(this.prixUnitaireTextBox);
            this.panel1.Controls.Add(proprieteLabel);
            this.panel1.Controls.Add(this.proprieteTextBox);
            this.panel1.Controls.Add(uniteLabel);
            this.panel1.Controls.Add(this.uniteTextBox);
            this.panel1.Location = new System.Drawing.Point(447, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 355);
            this.panel1.TabIndex = 32;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.produitBindingSource, "ID_categorie", true));
            this.comboBox1.DataSource = this.categorieBindingSource;
            this.comboBox1.DisplayMember = "Nom_cat";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(230, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(231, 30);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.ValueMember = "ID_categorie";
            // 
            // categorieBindingSource
            // 
            this.categorieBindingSource.DataMember = "Categorie";
            this.categorieBindingSource.DataSource = this.gestioncommercialhamzaDataSet;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbEndBy);
            this.panel2.Controls.Add(this.rbContent);
            this.panel2.Controls.Add(this.rbStartBy);
            this.panel2.Controls.Add(this.txtFind);
            this.panel2.Controls.Add(this.btnFind);
            this.panel2.Controls.Add(this.btnLast);
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Controls.Add(this.btnPrevious);
            this.panel2.Controls.Add(this.btnFirst);
            this.panel2.Controls.Add(this.produitListBox);
            this.panel2.Location = new System.Drawing.Point(0, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 551);
            this.panel2.TabIndex = 33;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1001, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 296);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // ofd
            // 
            this.ofd.Filter = "Fichiers PNG|*.png|Fichier JPG|*.JPG|Fichier GIF|*.GIF";
            // 
            // btnPicture
            // 
            this.btnPicture.Location = new System.Drawing.Point(1162, 379);
            this.btnPicture.Margin = new System.Windows.Forms.Padding(4);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(134, 41);
            this.btnPicture.TabIndex = 35;
            this.btnPicture.Text = "Get Picture";
            this.btnPicture.UseVisualStyleBackColor = true;
            this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
            // 
            // categorieTableAdapter
            // 
            this.categorieTableAdapter.ClearBeforeFill = true;
            // 
            // btnCategories
            // 
            this.btnCategories.Location = new System.Drawing.Point(468, 112);
            this.btnCategories.Margin = new System.Windows.Forms.Padding(4);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(50, 33);
            this.btnCategories.TabIndex = 25;
            this.btnCategories.Text = "...";
            this.btnCategories.UseVisualStyleBackColor = true;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // FrmProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1547, 584);
            this.Controls.Add(this.btnPicture);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.image_produitTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmProduits";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gestioncommercialhamzaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private gestioncommercialhamzaDataSet gestioncommercialhamzaDataSet;
        private System.Windows.Forms.BindingSource produitBindingSource;
        private gestioncommercialhamzaDataSetTableAdapters.ProduitTableAdapter produitTableAdapter;
        private gestioncommercialhamzaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ListBox produitListBox;
        private System.Windows.Forms.TextBox iD_produitTextBox;
        private System.Windows.Forms.TextBox designation_produitTextBox;
        private System.Windows.Forms.TextBox image_produitTextBox;
        private System.Windows.Forms.TextBox qtestockTextBox;
        private System.Windows.Forms.TextBox prixUnitaireTextBox;
        private System.Windows.Forms.TextBox proprieteTextBox;
        private System.Windows.Forms.TextBox uniteTextBox;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rbStartBy;
        private System.Windows.Forms.RadioButton rbContent;
        private System.Windows.Forms.RadioButton rbEndBy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Button btnPicture;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource categorieBindingSource;
        private gestioncommercialhamzaDataSetTableAdapters.CategorieTableAdapter categorieTableAdapter;
        private System.Windows.Forms.Button btnCategories;
    }
}

