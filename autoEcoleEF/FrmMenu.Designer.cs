namespace autoEcoleEF
{
    partial class FrmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eleveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiculeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gererToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gererToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bdgSourceEleve = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceEleve)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.eleveToolStripMenuItem,
            this.vehiculeToolStripMenuItem,
            this.leconToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(169, 34);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // eleveToolStripMenuItem
            // 
            this.eleveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gererToolStripMenuItem1});
            this.eleveToolStripMenuItem.Name = "eleveToolStripMenuItem";
            this.eleveToolStripMenuItem.Size = new System.Drawing.Size(68, 29);
            this.eleveToolStripMenuItem.Text = "Eleve";
            this.eleveToolStripMenuItem.Click += new System.EventHandler(this.eleveToolStripMenuItem_Click);
            // 
            // vehiculeToolStripMenuItem
            // 
            this.vehiculeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gererToolStripMenuItem,
            this.listeToolStripMenuItem});
            this.vehiculeToolStripMenuItem.Name = "vehiculeToolStripMenuItem";
            this.vehiculeToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            this.vehiculeToolStripMenuItem.Text = "Vehicule ";
            // 
            // gererToolStripMenuItem
            // 
            this.gererToolStripMenuItem.Name = "gererToolStripMenuItem";
            this.gererToolStripMenuItem.Size = new System.Drawing.Size(156, 34);
            this.gererToolStripMenuItem.Text = "Gerer";
            // 
            // listeToolStripMenuItem
            // 
            this.listeToolStripMenuItem.Name = "listeToolStripMenuItem";
            this.listeToolStripMenuItem.Size = new System.Drawing.Size(156, 34);
            this.listeToolStripMenuItem.Text = "Liste";
            // 
            // leconToolStripMenuItem
            // 
            this.leconToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.validerToolStripMenuItem});
            this.leconToolStripMenuItem.Name = "leconToolStripMenuItem";
            this.leconToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.leconToolStripMenuItem.Text = "Lecon";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(172, 34);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            // 
            // validerToolStripMenuItem
            // 
            this.validerToolStripMenuItem.Name = "validerToolStripMenuItem";
            this.validerToolStripMenuItem.Size = new System.Drawing.Size(172, 34);
            this.validerToolStripMenuItem.Text = "Valider";
            // 
            // gererToolStripMenuItem1
            // 
            this.gererToolStripMenuItem1.Name = "gererToolStripMenuItem1";
            this.gererToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.gererToolStripMenuItem1.Text = "Gerer";
            this.gererToolStripMenuItem1.Click += new System.EventHandler(this.gererToolStripMenuItem1_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "Gestion des lecon de conduite";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceEleve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eleveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiculeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gererToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gererToolStripMenuItem1;
        private System.Windows.Forms.BindingSource bdgSourceEleve;
    }
}

