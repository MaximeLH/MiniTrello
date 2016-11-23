namespace MiniTrello.View
{
    partial class FrmTest
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
            this.flpListe = new System.Windows.Forms.FlowLayoutPanel();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.txtCarte = new System.Windows.Forms.TextBox();
            this.btnAddCarte = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddCom = new System.Windows.Forms.Button();
            this.btnSupp = new System.Windows.Forms.Button();
            this.flpAffichageTitreCarte = new System.Windows.Forms.FlowLayoutPanel();
            this.flpListe.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpListe
            // 
            this.flpListe.Controls.Add(this.txtTitre);
            this.flpListe.Controls.Add(this.flpAffichageTitreCarte);
            this.flpListe.Controls.Add(this.txtCarte);
            this.flpListe.Controls.Add(this.btnAddCarte);
            this.flpListe.Controls.Add(this.flowLayoutPanel1);
            this.flpListe.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpListe.Location = new System.Drawing.Point(11, -1);
            this.flpListe.Name = "flpListe";
            this.flpListe.Size = new System.Drawing.Size(262, 262);
            this.flpListe.TabIndex = 5;
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
            this.txtCarte.Location = new System.Drawing.Point(3, 75);
            this.txtCarte.Name = "txtCarte";
            this.txtCarte.Size = new System.Drawing.Size(100, 20);
            this.txtCarte.TabIndex = 4;
            // 
            // btnAddCarte
            // 
            this.btnAddCarte.Location = new System.Drawing.Point(3, 101);
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 130);
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
            // flpAffichageTitreCarte
            // 
            this.flpAffichageTitreCarte.Location = new System.Drawing.Point(3, 29);
            this.flpAffichageTitreCarte.Name = "flpAffichageTitreCarte";
            this.flpAffichageTitreCarte.Size = new System.Drawing.Size(100, 40);
            this.flpAffichageTitreCarte.TabIndex = 8;
            // 
            // FrmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.flpListe);
            this.Name = "FrmTest";
            this.Text = "FrmTest";
            this.flpListe.ResumeLayout(false);
            this.flpListe.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpListe;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.TextBox txtCarte;
        private System.Windows.Forms.Button btnAddCarte;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAddCom;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.FlowLayoutPanel flpAffichageTitreCarte;
    }
}