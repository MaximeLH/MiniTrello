namespace MiniTrello.View
{
    partial class CtlListe
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.flnCarte = new System.Windows.Forms.FlowLayoutPanel();
            this.txtTitreListe = new System.Windows.Forms.TextBox();
            this.flpCartes = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddCarte = new System.Windows.Forms.Button();
            this.txtBoxTitreCarte = new System.Windows.Forms.TextBox();
            this.flnCarte.SuspendLayout();
            this.SuspendLayout();
            // 
            // flnCarte
            // 
            this.flnCarte.AutoSize = true;
            this.flnCarte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flnCarte.Controls.Add(this.txtTitreListe);
            this.flnCarte.Controls.Add(this.flpCartes);
            this.flnCarte.Controls.Add(this.txtBoxTitreCarte);
            this.flnCarte.Controls.Add(this.btnAddCarte);
            this.flnCarte.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flnCarte.Location = new System.Drawing.Point(3, 3);
            this.flnCarte.MaximumSize = new System.Drawing.Size(227, 500);
            this.flnCarte.Name = "flnCarte";
            this.flnCarte.Size = new System.Drawing.Size(227, 89);
            this.flnCarte.TabIndex = 4;
            // 
            // txtTitreListe
            // 
            this.txtTitreListe.Location = new System.Drawing.Point(3, 3);
            this.txtTitreListe.Name = "txtTitreListe";
            this.txtTitreListe.Size = new System.Drawing.Size(219, 20);
            this.txtTitreListe.TabIndex = 3;
            // 
            // flpCartes
            // 
            this.flpCartes.AccessibleName = "flpCartes";
            this.flpCartes.AutoScroll = true;
            this.flpCartes.AutoSize = true;
            this.flpCartes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpCartes.Location = new System.Drawing.Point(3, 29);
            this.flpCartes.Name = "flpCartes";
            this.flpCartes.Size = new System.Drawing.Size(0, 0);
            this.flpCartes.TabIndex = 4;
            // 
            // btnAddCarte
            // 
            this.btnAddCarte.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddCarte.Location = new System.Drawing.Point(4, 61);
            this.btnAddCarte.Name = "btnAddCarte";
            this.btnAddCarte.Size = new System.Drawing.Size(216, 23);
            this.btnAddCarte.TabIndex = 1;
            this.btnAddCarte.Text = "Ajouter une carte";
            this.btnAddCarte.UseVisualStyleBackColor = true;
            this.btnAddCarte.Click += new System.EventHandler(this.btnAddCarte_Click);
            // 
            // txtBoxTitreCarte
            // 
            this.txtBoxTitreCarte.Location = new System.Drawing.Point(3, 35);
            this.txtBoxTitreCarte.Name = "txtBoxTitreCarte";
            this.txtBoxTitreCarte.Size = new System.Drawing.Size(217, 20);
            this.txtBoxTitreCarte.TabIndex = 5;
            // 
            // CtlListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.flnCarte);
            this.Name = "CtlListe";
            this.Size = new System.Drawing.Size(251, 113);
            this.flnCarte.ResumeLayout(false);
            this.flnCarte.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flnCarte;
        private System.Windows.Forms.Button btnAddCarte;
        internal System.Windows.Forms.TextBox txtTitreListe;
        public System.Windows.Forms.FlowLayoutPanel flpCartes;
        private System.Windows.Forms.TextBox txtBoxTitreCarte;
    }
}
