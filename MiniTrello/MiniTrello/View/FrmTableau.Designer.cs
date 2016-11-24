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
            this.txtAjout = new System.Windows.Forms.TextBox();
            this.pnlAjout = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlAjout.SuspendLayout();
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
            this.flnListe.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flnListe.Location = new System.Drawing.Point(215, 13);
            this.flnListe.Name = "flnListe";
            this.flnListe.Size = new System.Drawing.Size(697, 417);
            this.flnListe.TabIndex = 2;
            // 
            // pnlAjout
            // 
            this.pnlAjout.Controls.Add(this.txtAjout);
            this.pnlAjout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlAjout.Location = new System.Drawing.Point(41, 48);
            this.pnlAjout.Name = "pnlAjout";
            this.pnlAjout.Size = new System.Drawing.Size(200, 100);
            this.pnlAjout.TabIndex = 7;
            // 
            // txtTitreTableau
            // 
            this.txtTitreTableau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitreTableau.Location = new System.Drawing.Point(12, 12);
            this.txtTitreTableau.Name = "txtTitreTableau";
            this.txtTitreTableau.Size = new System.Drawing.Size(109, 26);
            this.txtTitreTableau.TabIndex = 8;
            this.txtTitreTableau.Text = "Titre";
            // 
            // txtAjout
            // 
            this.txtAjout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtAjout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAjout.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtAjout.Location = new System.Drawing.Point(3, 3);
            this.txtAjout.Name = "txtAjout";
            this.txtAjout.Size = new System.Drawing.Size(197, 13);
            this.txtAjout.TabIndex = 6;
            this.txtAjout.Text = "Ajouter une liste ...";
            this.txtAjout.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // pnlAjout
            // 
            this.pnlAjout.Controls.Add(this.txtAjout);
            this.pnlAjout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlAjout.Location = new System.Drawing.Point(3, 13);
            this.pnlAjout.Name = "pnlAjout";
            this.pnlAjout.Size = new System.Drawing.Size(206, 100);
            this.pnlAjout.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.flnListe);
            this.panel1.Controls.Add(this.pnlAjout);
            this.panel1.Location = new System.Drawing.Point(16, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 449);
            this.panel1.TabIndex = 8;
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
            this.Load += new System.EventHandler(this.FrmTableau_Load);
            this.pnlAjout.ResumeLayout(false);
            this.pnlAjout.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.FlowLayoutPanel flnListe;
        private System.Windows.Forms.Label lblTitreTableau;
        private System.Windows.Forms.TextBox txtAjout;
        private System.Windows.Forms.FlowLayoutPanel pnlAjout;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Panel panel1;
    }
}