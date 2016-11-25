namespace MiniTrello.View
{
    partial class CtlAjoutCarte
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxTitreCarte = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajout d\'une carte - Insérez un titre";
            // 
            // txtBoxTitreCarte
            // 
            this.txtBoxTitreCarte.Location = new System.Drawing.Point(3, 16);
            this.txtBoxTitreCarte.MinimumSize = new System.Drawing.Size(210, 58);
            this.txtBoxTitreCarte.Multiline = true;
            this.txtBoxTitreCarte.Name = "txtBoxTitreCarte";
            this.txtBoxTitreCarte.Size = new System.Drawing.Size(210, 58);
            this.txtBoxTitreCarte.TabIndex = 1;
            // 
            // CtlAjoutCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtBoxTitreCarte);
            this.Controls.Add(this.label1);
            this.Name = "CtlAjoutCarte";
            this.Size = new System.Drawing.Size(220, 84);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxTitreCarte;
    }
}
