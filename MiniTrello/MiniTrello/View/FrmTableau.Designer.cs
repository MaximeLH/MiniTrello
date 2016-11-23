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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitreTableau = new System.Windows.Forms.Label();
            this.txtAjout = new System.Windows.Forms.TextBox();
            this.pnlAjout = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlAjout.SuspendLayout();
            this.SuspendLayout();
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(0, 469);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(744, 24);
            this.hScrollBar1.TabIndex = 0;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(744, -1);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(24, 470);
            this.vScrollBar1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(25, 48);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(10, 402);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // lblTitreTableau
            // 
            this.lblTitreTableau.AutoSize = true;
            this.lblTitreTableau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreTableau.Location = new System.Drawing.Point(12, 9);
            this.lblTitreTableau.Name = "lblTitreTableau";
            this.lblTitreTableau.Size = new System.Drawing.Size(45, 20);
            this.lblTitreTableau.TabIndex = 4;
            this.lblTitreTableau.Text = "Titre";
            // 
            // txtAjout
            // 
            this.txtAjout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtAjout.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.pnlAjout.Location = new System.Drawing.Point(41, 48);
            this.pnlAjout.Name = "pnlAjout";
            this.pnlAjout.Size = new System.Drawing.Size(200, 100);
            this.pnlAjout.TabIndex = 7;
            // 
            // FrmTableau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 493);
            this.Controls.Add(this.pnlAjout);
            this.Controls.Add(this.lblTitreTableau);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.hScrollBar1);
            this.Name = "FrmTableau";
            this.Text = "FrmTableau";
            this.pnlAjout.ResumeLayout(false);
            this.pnlAjout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblTitreTableau;
        private System.Windows.Forms.TextBox txtAjout;
        private System.Windows.Forms.FlowLayoutPanel pnlAjout;
    }
}