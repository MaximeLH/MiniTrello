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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTableau));
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.flnListe = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitreTableau = new System.Windows.Forms.Label();
            this.txtAjout = new System.Windows.Forms.TextBox();
            this.pnlAjout = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnResetDB = new System.Windows.Forms.ToolStripButton();
            this.pnlAjout.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
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
            this.pnlAjout.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pnlAjout.Controls.Add(this.txtAjout);
            this.pnlAjout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlAjout.Location = new System.Drawing.Point(12, 14);
            this.pnlAjout.Name = "pnlAjout";
            this.pnlAjout.Size = new System.Drawing.Size(206, 100);
            this.pnlAjout.TabIndex = 7;
            this.pnlAjout.WrapContents = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pnlAjout);
            this.panel1.Controls.Add(this.flnListe);
            this.panel1.Location = new System.Drawing.Point(16, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 449);
            this.panel1.TabIndex = 8;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnResetDB});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(953, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnResetDB
            // 
            this.BtnResetDB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnResetDB.Image = ((System.Drawing.Image)(resources.GetObject("BtnResetDB.Image")));
            this.BtnResetDB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnResetDB.Name = "BtnResetDB";
            this.BtnResetDB.Size = new System.Drawing.Size(105, 22);
            this.BtnResetDB.Text = "Reset/Initialize DB";
            this.BtnResetDB.Click += new System.EventHandler(this.BtnResetDB_Click);
            // 
            // FrmTableau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(953, 493);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitreTableau);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.hScrollBar1);
            this.Name = "FrmTableau";
            this.Text = "FrmTableau";
            this.pnlAjout.ResumeLayout(false);
            this.pnlAjout.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnResetDB;
    }
}