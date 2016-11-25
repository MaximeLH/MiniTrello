namespace MiniTrello.View
{
    partial class CtlCheckList
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
            this.FlowLayoutPnlCheckListElt = new System.Windows.Forms.FlowLayoutPanel();
            this.LinkLblAddElement = new System.Windows.Forms.LinkLabel();
            this.LinkLblSupprElt = new System.Windows.Forms.LinkLabel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // FlowLayoutPnlCheckListElt
            // 
            this.FlowLayoutPnlCheckListElt.AutoScroll = true;
            this.FlowLayoutPnlCheckListElt.BackColor = System.Drawing.Color.Transparent;
            this.FlowLayoutPnlCheckListElt.Location = new System.Drawing.Point(3, 3);
            this.FlowLayoutPnlCheckListElt.Name = "FlowLayoutPnlCheckListElt";
            this.FlowLayoutPnlCheckListElt.Size = new System.Drawing.Size(567, 69);
            this.FlowLayoutPnlCheckListElt.TabIndex = 5;
            // 
            // LinkLblAddElement
            // 
            this.LinkLblAddElement.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LinkLblAddElement.AutoSize = true;
            this.LinkLblAddElement.BackColor = System.Drawing.SystemColors.Control;
            this.LinkLblAddElement.Font = new System.Drawing.Font("OpenSymbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLblAddElement.LinkColor = System.Drawing.Color.Black;
            this.LinkLblAddElement.Location = new System.Drawing.Point(3, 75);
            this.LinkLblAddElement.Name = "LinkLblAddElement";
            this.LinkLblAddElement.Size = new System.Drawing.Size(133, 16);
            this.LinkLblAddElement.TabIndex = 6;
            this.LinkLblAddElement.TabStop = true;
            this.LinkLblAddElement.Text = "Ajouter un élement...";
            this.LinkLblAddElement.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLblAddElement_LinkClicked_1);
            // 
            // LinkLblSupprElt
            // 
            this.LinkLblSupprElt.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LinkLblSupprElt.AutoSize = true;
            this.LinkLblSupprElt.BackColor = System.Drawing.Color.Transparent;
            this.LinkLblSupprElt.Font = new System.Drawing.Font("OpenSymbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLblSupprElt.LinkColor = System.Drawing.Color.Black;
            this.LinkLblSupprElt.Location = new System.Drawing.Point(142, 75);
            this.LinkLblSupprElt.Name = "LinkLblSupprElt";
            this.LinkLblSupprElt.Size = new System.Drawing.Size(153, 16);
            this.LinkLblSupprElt.TabIndex = 7;
            this.LinkLblSupprElt.TabStop = true;
            this.LinkLblSupprElt.Text = "Supprimer un élement...";
            this.LinkLblSupprElt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLblSupprElt_LinkClicked_1);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(576, 30);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // CtlCheckList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FlowLayoutPnlCheckListElt);
            this.Controls.Add(this.LinkLblAddElement);
            this.Controls.Add(this.LinkLblSupprElt);
            this.Controls.Add(this.checkBox1);
            this.Name = "CtlCheckList";
            this.Size = new System.Drawing.Size(600, 99);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPnlCheckListElt;
        private System.Windows.Forms.LinkLabel LinkLblAddElement;
        private System.Windows.Forms.LinkLabel LinkLblSupprElt;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
