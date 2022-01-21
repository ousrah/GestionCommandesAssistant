
namespace WindowsFormsApp2
{
    partial class FrmNewCommande
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
            System.Windows.Forms.Label date_commandeLabel;
            this.gestioncommercialhamzaDataSet = new WindowsFormsApp2.gestioncommercialhamzaDataSet();
            this.commandeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commandeTableAdapter = new WindowsFormsApp2.gestioncommercialhamzaDataSetTableAdapters.CommandeTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.gestioncommercialhamzaDataSetTableAdapters.TableAdapterManager();
            this.date_commandeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.iD_clientTextBox = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnValidate = new System.Windows.Forms.Button();
            date_commandeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gestioncommercialhamzaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gestioncommercialhamzaDataSet
            // 
            this.gestioncommercialhamzaDataSet.DataSetName = "gestioncommercialhamzaDataSet";
            this.gestioncommercialhamzaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // commandeBindingSource
            // 
            this.commandeBindingSource.DataMember = "Commande";
            this.commandeBindingSource.DataSource = this.gestioncommercialhamzaDataSet;
            // 
            // commandeTableAdapter
            // 
            this.commandeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategorieTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.CommandeTableAdapter = this.commandeTableAdapter;
            this.tableAdapterManager.LigneTableAdapter = null;
            this.tableAdapterManager.ProduitTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.gestioncommercialhamzaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // date_commandeLabel
            // 
            date_commandeLabel.AutoSize = true;
            date_commandeLabel.Location = new System.Drawing.Point(30, 25);
            date_commandeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            date_commandeLabel.Name = "date_commandeLabel";
            date_commandeLabel.Size = new System.Drawing.Size(168, 24);
            date_commandeLabel.TabIndex = 3;
            date_commandeLabel.Text = "Date commande:";
            // 
            // date_commandeDateTimePicker
            // 
            this.date_commandeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.commandeBindingSource, "Date_commande", true));
            this.date_commandeDateTimePicker.Location = new System.Drawing.Point(34, 64);
            this.date_commandeDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.date_commandeDateTimePicker.Name = "date_commandeDateTimePicker";
            this.date_commandeDateTimePicker.Size = new System.Drawing.Size(453, 28);
            this.date_commandeDateTimePicker.TabIndex = 4;
            // 
            // iD_clientTextBox
            // 
            this.iD_clientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commandeBindingSource, "ID_client", true));
            this.iD_clientTextBox.Location = new System.Drawing.Point(289, 247);
            this.iD_clientTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iD_clientTextBox.Name = "iD_clientTextBox";
            this.iD_clientTextBox.Size = new System.Drawing.Size(274, 28);
            this.iD_clientTextBox.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(446, 143);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(134, 41);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(304, 143);
            this.btnValidate.Margin = new System.Windows.Forms.Padding(4);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(134, 41);
            this.btnValidate.TabIndex = 29;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // FrmNewCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 197);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(date_commandeLabel);
            this.Controls.Add(this.date_commandeDateTimePicker);
            this.Controls.Add(this.iD_clientTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmNewCommande";
            this.Text = "FrmNewCommande";
            this.Load += new System.EventHandler(this.FrmNewCommande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gestioncommercialhamzaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private gestioncommercialhamzaDataSet gestioncommercialhamzaDataSet;
        private System.Windows.Forms.BindingSource commandeBindingSource;
        private gestioncommercialhamzaDataSetTableAdapters.CommandeTableAdapter commandeTableAdapter;
        private gestioncommercialhamzaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker date_commandeDateTimePicker;
        private System.Windows.Forms.TextBox iD_clientTextBox;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnValidate;
    }
}