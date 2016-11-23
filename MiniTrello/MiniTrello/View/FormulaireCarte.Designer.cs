namespace MiniTrello
{
    partial class Titre
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
            this.FlowLayoutPnlCheckList = new System.Windows.Forms.FlowLayoutPanel();
            this.FlowLayoutPnlCheckListElt = new System.Windows.Forms.FlowLayoutPanel();
            this.CheckListEltBox = new System.Windows.Forms.CheckedListBox();
            this.LinkLblAddElement = new System.Windows.Forms.LinkLabel();
            this.LblCheckList = new System.Windows.Forms.Label();
            this.RadioBtnCheckList = new System.Windows.Forms.RadioButton();
            this.FlowLayoutPnlCheckLists = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnAjouter = new System.Windows.Forms.Button();
            this.BtnSupprimer = new System.Windows.Forms.Button();
            this.FlowLayoutPnlCheckList.SuspendLayout();
            this.FlowLayoutPnlCheckListElt.SuspendLayout();
            this.FlowLayoutPnlCheckLists.SuspendLayout();
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
            // FlowLayoutPnlCheckList
            // 
            this.FlowLayoutPnlCheckList.Controls.Add(this.FlowLayoutPnlCheckListElt);
            this.FlowLayoutPnlCheckList.Controls.Add(this.RadioBtnCheckList);
            this.FlowLayoutPnlCheckLists.SetFlowBreak(this.FlowLayoutPnlCheckList, true);
            this.FlowLayoutPnlCheckList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlowLayoutPnlCheckList.Location = new System.Drawing.Point(3, 3);
            this.FlowLayoutPnlCheckList.Name = "FlowLayoutPnlCheckList";
            this.FlowLayoutPnlCheckList.Size = new System.Drawing.Size(444, 55);
            this.FlowLayoutPnlCheckList.TabIndex = 3;
            // 
            // FlowLayoutPnlCheckListElt
            // 
            this.FlowLayoutPnlCheckListElt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.FlowLayoutPnlCheckListElt.Controls.Add(this.CheckListEltBox);
            this.FlowLayoutPnlCheckListElt.Controls.Add(this.LinkLblAddElement);
            this.FlowLayoutPnlCheckListElt.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlowLayoutPnlCheckListElt.Location = new System.Drawing.Point(3, 3);
            this.FlowLayoutPnlCheckListElt.Name = "FlowLayoutPnlCheckListElt";
            this.FlowLayoutPnlCheckListElt.Size = new System.Drawing.Size(416, 47);
            this.FlowLayoutPnlCheckListElt.TabIndex = 0;
            // 
            // CheckListEltBox
            // 
            this.CheckListEltBox.FormattingEnabled = true;
            this.CheckListEltBox.Location = new System.Drawing.Point(3, 3);
            this.CheckListEltBox.Name = "CheckListEltBox";
            this.CheckListEltBox.Size = new System.Drawing.Size(396, 19);
            this.CheckListEltBox.TabIndex = 0;
            // 
            // LinkLblAddElement
            // 
            this.LinkLblAddElement.AutoSize = true;
            this.LinkLblAddElement.Font = new System.Drawing.Font("OpenSymbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLblAddElement.LinkColor = System.Drawing.Color.White;
            this.LinkLblAddElement.Location = new System.Drawing.Point(3, 25);
            this.LinkLblAddElement.Name = "LinkLblAddElement";
            this.LinkLblAddElement.Size = new System.Drawing.Size(133, 16);
            this.LinkLblAddElement.TabIndex = 1;
            this.LinkLblAddElement.TabStop = true;
            this.LinkLblAddElement.Text = "Ajouter un élement...";
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
            // RadioBtnCheckList
            // 
            this.RadioBtnCheckList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.RadioBtnCheckList.Location = new System.Drawing.Point(425, 3);
            this.RadioBtnCheckList.Name = "RadioBtnCheckList";
            this.RadioBtnCheckList.Size = new System.Drawing.Size(19, 47);
            this.RadioBtnCheckList.TabIndex = 2;
            this.RadioBtnCheckList.TabStop = true;
            this.RadioBtnCheckList.UseVisualStyleBackColor = true;
            // 
            // FlowLayoutPnlCheckLists
            // 
            this.FlowLayoutPnlCheckLists.Controls.Add(this.FlowLayoutPnlCheckList);
            this.FlowLayoutPnlCheckLists.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
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
            // 
            // Titre
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
            this.Name = "Titre";
            this.Text = "FormulaireCarte";
            this.Load += new System.EventHandler(this.FormulaireCarte_Load);
            this.FlowLayoutPnlCheckList.ResumeLayout(false);
            this.FlowLayoutPnlCheckListElt.ResumeLayout(false);
            this.FlowLayoutPnlCheckListElt.PerformLayout();
            this.FlowLayoutPnlCheckLists.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitre;
        private System.Windows.Forms.Label LblSousTitre;
        private System.Windows.Forms.TextBox TxtBoxDescription;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPnlCheckList;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPnlCheckListElt;
        private System.Windows.Forms.CheckedListBox CheckListEltBox;
        private System.Windows.Forms.LinkLabel LinkLblAddElement;
        private System.Windows.Forms.RadioButton RadioBtnCheckList;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPnlCheckLists;
        private System.Windows.Forms.Label LblCheckList;
        private System.Windows.Forms.Button BtnAjouter;
        private System.Windows.Forms.Button BtnSupprimer;
    }
}