namespace MiniTrello
{
    partial class FrmTableau
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
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.flnListe = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitreTableau = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSuppListe = new System.Windows.Forms.Button();
            this.btnEnregistrerListe = new System.Windows.Forms.Button();
            this.txtTitreListe = new System.Windows.Forms.TextBox();
            this.btnAjoutListe = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hScrollBar1.Location = new System.Drawing.Point(0, 962);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(1547, 15);
            this.hScrollBar1.TabIndex = 0;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vScrollBar1.Location = new System.Drawing.Point(1547, -1);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(24, 963);
            this.vScrollBar1.TabIndex = 1;
            // 
            // flnListe
            // 
            this.flnListe.AutoScroll = true;
            this.flnListe.AutoSize = true;
            this.flnListe.BackColor = System.Drawing.SystemColors.Control;
            this.flnListe.Location = new System.Drawing.Point(251, 14);
            this.flnListe.Name = "flnListe";
            this.flnListe.Size = new System.Drawing.Size(190, 413);
            this.flnListe.TabIndex = 2;
            this.flnListe.WrapContents = false;
            // 
            // lblTitreTableau
            // 
            this.lblTitreTableau.Location = new System.Drawing.Point(0, 0);
            this.lblTitreTableau.Name = "lblTitreTableau";
            this.lblTitreTableau.Size = new System.Drawing.Size(100, 23);
            this.lblTitreTableau.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.btnAjoutListe);
            this.panel1.Controls.Add(this.txtTitreListe);
            this.panel1.Controls.Add(this.btnSuppListe);
            this.panel1.Controls.Add(this.flnListe);
            this.panel1.Controls.Add(this.btnEnregistrerListe);
            this.panel1.Location = new System.Drawing.Point(16, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 449);
            this.panel1.TabIndex = 8;
            // 
            // btnSuppListe
            // 
            this.btnSuppListe.BackColor = System.Drawing.Color.Firebrick;
            this.btnSuppListe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSuppListe.Location = new System.Drawing.Point(149, 53);
            this.btnSuppListe.Name = "btnSuppListe";
            this.btnSuppListe.Size = new System.Drawing.Size(40, 24);
            this.btnSuppListe.TabIndex = 5;
            this.btnSuppListe.Text = "X";
            this.btnSuppListe.UseVisualStyleBackColor = false;
            this.btnSuppListe.Click += new System.EventHandler(this.btnSuppListe_Click);
            // 
            // btnEnregistrerListe
            // 
            this.btnEnregistrerListe.BackColor = System.Drawing.Color.Lime;
            this.btnEnregistrerListe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEnregistrerListe.Location = new System.Drawing.Point(15, 53);
            this.btnEnregistrerListe.Name = "btnEnregistrerListe";
            this.btnEnregistrerListe.Size = new System.Drawing.Size(86, 25);
            this.btnEnregistrerListe.TabIndex = 4;
            this.btnEnregistrerListe.Text = "Enregistrer";
            this.btnEnregistrerListe.UseVisualStyleBackColor = false;
            this.btnEnregistrerListe.Click += new System.EventHandler(this.btnEnregistrerListe_Click);
            // 
            // txtTitreListe
            // 
            this.txtTitreListe.Location = new System.Drawing.Point(15, 17);
            this.txtTitreListe.Name = "txtTitreListe";
            this.txtTitreListe.Size = new System.Drawing.Size(203, 20);
            this.txtTitreListe.TabIndex = 3;
            // 
            // btnAjoutListe
            // 
            this.btnAjoutListe.Location = new System.Drawing.Point(15, 14);
            this.btnAjoutListe.Name = "btnAjoutListe";
            this.btnAjoutListe.Size = new System.Drawing.Size(203, 23);
            this.btnAjoutListe.TabIndex = 0;
            this.btnAjoutListe.Text = "Ajouter une liste...";
            this.btnAjoutListe.UseVisualStyleBackColor = true;
            this.btnAjoutListe.Click += new System.EventHandler(this.btnAjoutListe_Click);
            // 
            // FrmTableau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(953, 493);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitreTableau);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.hScrollBar1);
            this.Name = "FrmTableau";
            this.Text = "FrmTableau";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.FlowLayoutPanel flnListe;
        private System.Windows.Forms.Label lblTitreTableau;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAjoutListe;
        private System.Windows.Forms.TextBox txtTitreListe;
        private System.Windows.Forms.Button btnSuppListe;
        private System.Windows.Forms.Button btnEnregistrerListe;
    }
}