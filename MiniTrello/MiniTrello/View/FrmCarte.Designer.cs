namespace MiniTrello
{
    partial class FrmCarte
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
            this.LblTitre = new System.Windows.Forms.Label();
            this.LblSousTitre = new System.Windows.Forms.Label();
            this.TxtBoxDescription = new System.Windows.Forms.TextBox();
            this.LblCheckList = new System.Windows.Forms.Label();
            this.FlowLayoutPnlCheckLists = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnAjouter = new System.Windows.Forms.Button();
            this.BtnSupprimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblTitre
            // 
            this.LblTitre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTitre.AutoSize = true;
            this.LblTitre.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitre.Location = new System.Drawing.Point(257, 9);
            this.LblTitre.Name = "LblTitre";
            this.LblTitre.Size = new System.Drawing.Size(186, 27);
            this.LblTitre.TabIndex = 0;
            this.LblTitre.Text = "Ajouter un titre...";
            this.LblTitre.TextChanged += new System.EventHandler(this.LblTitre_TextChanged);
            // 
            // LblSousTitre
            // 
            this.LblSousTitre.AutoSize = true;
            this.LblSousTitre.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSousTitre.ForeColor = System.Drawing.Color.Navy;
            this.LblSousTitre.Location = new System.Drawing.Point(560, 16);
            this.LblSousTitre.Name = "LblSousTitre";
            this.LblSousTitre.Size = new System.Drawing.Size(127, 17);
            this.LblSousTitre.TabIndex = 1;
            this.LblSousTitre.Text = "Dans la liste \"Liste1\"";
            // 
            // TxtBoxDescription
            // 
            this.TxtBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxDescription.Location = new System.Drawing.Point(25, 69);
            this.TxtBoxDescription.Multiline = true;
            this.TxtBoxDescription.Name = "TxtBoxDescription";
            this.TxtBoxDescription.Size = new System.Drawing.Size(662, 49);
            this.TxtBoxDescription.TabIndex = 2;
            // 
            // LblCheckList
            // 
            this.LblCheckList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblCheckList.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCheckList.ForeColor = System.Drawing.Color.Black;
            this.LblCheckList.Location = new System.Drawing.Point(306, 158);
            this.LblCheckList.Margin = new System.Windows.Forms.Padding(3, 8, 0, 0);
            this.LblCheckList.Name = "LblCheckList";
            this.LblCheckList.Size = new System.Drawing.Size(100, 31);
            this.LblCheckList.TabIndex = 1;
            this.LblCheckList.Text = "Checklists";
            // 
            // FlowLayoutPnlCheckLists
            // 
            this.FlowLayoutPnlCheckLists.AutoScroll = true;
            this.FlowLayoutPnlCheckLists.Location = new System.Drawing.Point(41, 189);
            this.FlowLayoutPnlCheckLists.Name = "FlowLayoutPnlCheckLists";
            this.FlowLayoutPnlCheckLists.Size = new System.Drawing.Size(628, 123);
            this.FlowLayoutPnlCheckLists.TabIndex = 4;
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAjouter.FlatAppearance.BorderSize = 0;
            this.BtnAjouter.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAjouter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnAjouter.Location = new System.Drawing.Point(235, 329);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.Size = new System.Drawing.Size(96, 33);
            this.BtnAjouter.TabIndex = 5;
            this.BtnAjouter.Text = "Ajouter";
            this.BtnAjouter.UseVisualStyleBackColor = true;
            this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // BtnSupprimer
            // 
            this.BtnSupprimer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnSupprimer.FlatAppearance.BorderSize = 0;
            this.BtnSupprimer.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSupprimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSupprimer.Location = new System.Drawing.Point(415, 329);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.Size = new System.Drawing.Size(96, 33);
            this.BtnSupprimer.TabIndex = 6;
            this.BtnSupprimer.Text = "Supprimer";
            this.BtnSupprimer.UseVisualStyleBackColor = true;
            this.BtnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
            // 
            // FrmCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(709, 410);
            this.Controls.Add(this.BtnSupprimer);
            this.Controls.Add(this.BtnAjouter);
            this.Controls.Add(this.FlowLayoutPnlCheckLists);
            this.Controls.Add(this.LblCheckList);
            this.Controls.Add(this.TxtBoxDescription);
            this.Controls.Add(this.LblSousTitre);
            this.Controls.Add(this.LblTitre);
            this.Name = "FrmCarte";
            this.Text = "FormulaireCarte";
            this.Load += new System.EventHandler(this.FrmCarte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitre;
        private System.Windows.Forms.Label LblSousTitre;
        private System.Windows.Forms.TextBox TxtBoxDescription;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPnlCheckLists;
        private System.Windows.Forms.Label LblCheckList;
        private System.Windows.Forms.Button BtnAjouter;
        private System.Windows.Forms.Button BtnSupprimer;
    }
}