namespace MiniTrello.View
{
    partial class CtrlListe
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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.txtCarte = new System.Windows.Forms.TextBox();
            this.btnAddCarte = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddCom = new System.Windows.Forms.Button();
            this.btnSupp = new System.Windows.Forms.Button();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.txtTitre);
            this.flowLayoutPanel2.Controls.Add(this.txtCarte);
            this.flowLayoutPanel2.Controls.Add(this.btnAddCarte);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 15);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(262, 262);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // txtTitre
            // 
            this.txtTitre.Location = new System.Drawing.Point(3, 3);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(100, 20);
            this.txtTitre.TabIndex = 3;
            // 
            // txtCarte
            // 
            this.txtCarte.Location = new System.Drawing.Point(3, 29);
            this.txtCarte.Name = "txtCarte";
            this.txtCarte.Size = new System.Drawing.Size(100, 20);
            this.txtCarte.TabIndex = 4;
            // 
            // btnAddCarte
            // 
            this.btnAddCarte.Location = new System.Drawing.Point(3, 55);
            this.btnAddCarte.Name = "btnAddCarte";
            this.btnAddCarte.Size = new System.Drawing.Size(100, 23);
            this.btnAddCarte.TabIndex = 1;
            this.btnAddCarte.Text = "Ajouter une carte";
            this.btnAddCarte.UseVisualStyleBackColor = true;
            this.btnAddCarte.Click += new System.EventHandler(this.btnAddCarte_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAddCom);
            this.flowLayoutPanel1.Controls.Add(this.btnSupp);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 84);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(184, 37);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // btnAddCom
            // 
            this.btnAddCom.Location = new System.Drawing.Point(3, 3);
            this.btnAddCom.Name = "btnAddCom";
            this.btnAddCom.Size = new System.Drawing.Size(75, 23);
            this.btnAddCom.TabIndex = 5;
            this.btnAddCom.Text = "Ajouter";
            this.btnAddCom.UseVisualStyleBackColor = true;
            // 
            // btnSupp
            // 
            this.btnSupp.Location = new System.Drawing.Point(84, 3);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(75, 23);
            this.btnSupp.TabIndex = 6;
            this.btnSupp.Text = "X";
            this.btnSupp.UseVisualStyleBackColor = true;
            // 
            // CtrlListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel2);
            this.Name = "CtrlListe";
            this.Size = new System.Drawing.Size(433, 359);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.Button btnAddCarte;
        private System.Windows.Forms.TextBox txtCarte;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.Button btnAddCom;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
