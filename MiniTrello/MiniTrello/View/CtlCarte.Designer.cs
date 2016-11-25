using MiniTrello.Model;

namespace MiniTrello.View
{
    partial class CtlCarte
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitreCarte = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitreCarte
            // 
            this.lblTitreCarte.BackColor = System.Drawing.Color.Gainsboro;
            this.lblTitreCarte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitreCarte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitreCarte.Location = new System.Drawing.Point(0, 0);
            this.lblTitreCarte.Name = "lblTitreCarte";
            this.lblTitreCarte.Size = new System.Drawing.Size(147, 22);
            this.lblTitreCarte.TabIndex = 0;
            this.lblTitreCarte.Text = "" ;
            this.lblTitreCarte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitreCarte.Click += new System.EventHandler(this.lblTitreCarte_Click);
            this.lblTitreCarte.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CtlCarte_MouseClick);
            // 
            // CtlCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.Controls.Add(this.lblTitreCarte);
            this.Name = "CtlCarte";
            this.Size = new System.Drawing.Size(147, 22);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitreCarte;
    }
}
