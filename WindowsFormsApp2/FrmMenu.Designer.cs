
namespace WindowsFormsApp2
{
    partial class FrmMenu
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TsBtnCategories = new System.Windows.Forms.ToolStripButton();
            this.TsBtnProduits = new System.Windows.Forms.ToolStripButton();
            this.TsBtnClients = new System.Windows.Forms.ToolStripButton();
            this.TsBtnCommandes = new System.Windows.Forms.ToolStripButton();
            this.TSBtnFermer = new System.Windows.Forms.ToolStripButton();
            this.PnlEcran = new System.Windows.Forms.Panel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.PnlEcran);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 142;
            this.splitContainer1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(100, 100);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsBtnCategories,
            this.TsBtnProduits,
            this.TsBtnClients,
            this.TsBtnCommandes,
            this.TSBtnFermer,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 132);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TsBtnCategories
            // 
            this.TsBtnCategories.Image = global::WindowsFormsApp2.Properties.Resources.categories;
            this.TsBtnCategories.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtnCategories.Name = "TsBtnCategories";
            this.TsBtnCategories.Size = new System.Drawing.Size(110, 129);
            this.TsBtnCategories.Text = "Categories";
            this.TsBtnCategories.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.TsBtnCategories.Click += new System.EventHandler(this.TsBtnCategories_Click);
            // 
            // TsBtnProduits
            // 
            this.TsBtnProduits.Image = global::WindowsFormsApp2.Properties.Resources.brand_identity;
            this.TsBtnProduits.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtnProduits.Name = "TsBtnProduits";
            this.TsBtnProduits.Size = new System.Drawing.Size(104, 129);
            this.TsBtnProduits.Text = "Produits";
            this.TsBtnProduits.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.TsBtnProduits.Click += new System.EventHandler(this.TsBtnProduits_Click);
            // 
            // TsBtnClients
            // 
            this.TsBtnClients.Image = global::WindowsFormsApp2.Properties.Resources.shopping;
            this.TsBtnClients.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtnClients.Name = "TsBtnClients";
            this.TsBtnClients.Size = new System.Drawing.Size(104, 129);
            this.TsBtnClients.Text = "Clients";
            this.TsBtnClients.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.TsBtnClients.Click += new System.EventHandler(this.TsBtnClients_Click);
            // 
            // TsBtnCommandes
            // 
            this.TsBtnCommandes.Image = global::WindowsFormsApp2.Properties.Resources.cargo;
            this.TsBtnCommandes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtnCommandes.Name = "TsBtnCommandes";
            this.TsBtnCommandes.Size = new System.Drawing.Size(126, 129);
            this.TsBtnCommandes.Text = "Commandes";
            this.TsBtnCommandes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.TsBtnCommandes.Click += new System.EventHandler(this.TsBtnCommandes_Click);
            // 
            // TSBtnFermer
            // 
            this.TSBtnFermer.Image = global::WindowsFormsApp2.Properties.Resources.close;
            this.TSBtnFermer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBtnFermer.Name = "TSBtnFermer";
            this.TSBtnFermer.Size = new System.Drawing.Size(104, 129);
            this.TSBtnFermer.Text = "Fermer";
            this.TSBtnFermer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.TSBtnFermer.Click += new System.EventHandler(this.TSBtnFermer_Click);
            // 
            // PnlEcran
            // 
            this.PnlEcran.BackColor = System.Drawing.SystemColors.Control;
            this.PnlEcran.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlEcran.Location = new System.Drawing.Point(0, 0);
            this.PnlEcran.Name = "PnlEcran";
            this.PnlEcran.Size = new System.Drawing.Size(800, 304);
            this.PnlEcran.TabIndex = 0;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::WindowsFormsApp2.Properties.Resources.téléchargement;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(104, 129);
            this.toolStripButton1.Text = "About";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel PnlEcran;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TsBtnCategories;
        private System.Windows.Forms.ToolStripButton TsBtnProduits;
        private System.Windows.Forms.ToolStripButton TsBtnClients;
        private System.Windows.Forms.ToolStripButton TsBtnCommandes;
        private System.Windows.Forms.ToolStripButton TSBtnFermer;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}