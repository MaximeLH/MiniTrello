namespace MiniTrello.View
{
    partial class FrmChecklist
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
            this.FlowLayoutPnlCheckList = new System.Windows.Forms.FlowLayoutPanel();
            this.FlowLayoutPnlCheckListElt = new System.Windows.Forms.FlowLayoutPanel();
            this.LinkLblAddElement = new System.Windows.Forms.LinkLabel();
            this.RadioBtnCheckList = new System.Windows.Forms.RadioButton();
            this.FlowLayoutPnlCheckList.SuspendLayout();
            this.SuspendLayout();
            // 
            // FlowLayoutPnlCheckList
            // 
            this.FlowLayoutPnlCheckList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlowLayoutPnlCheckList.Controls.Add(this.FlowLayoutPnlCheckListElt);
            this.FlowLayoutPnlCheckList.Controls.Add(this.LinkLblAddElement);
            this.FlowLayoutPnlCheckList.Controls.Add(this.RadioBtnCheckList);
            this.FlowLayoutPnlCheckList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlowLayoutPnlCheckList.Location = new System.Drawing.Point(25, 12);
            this.FlowLayoutPnlCheckList.Name = "FlowLayoutPnlCheckList";
            this.FlowLayoutPnlCheckList.Size = new System.Drawing.Size(449, 253);
            this.FlowLayoutPnlCheckList.TabIndex = 4;
            // 
            // FlowLayoutPnlCheckListElt
            // 
            this.FlowLayoutPnlCheckListElt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.FlowLayoutPnlCheckListElt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.FlowLayoutPnlCheckListElt.Location = new System.Drawing.Point(3, 3);
            this.FlowLayoutPnlCheckListElt.Name = "FlowLayoutPnlCheckListElt";
            this.FlowLayoutPnlCheckListElt.Size = new System.Drawing.Size(387, 212);
            this.FlowLayoutPnlCheckListElt.TabIndex = 0;
            // 
            // LinkLblAddElement
            // 
            this.LinkLblAddElement.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LinkLblAddElement.AutoSize = true;
            this.LinkLblAddElement.BackColor = System.Drawing.Color.Transparent;
            this.LinkLblAddElement.Font = new System.Drawing.Font("OpenSymbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLblAddElement.LinkColor = System.Drawing.Color.White;
            this.LinkLblAddElement.Location = new System.Drawing.Point(3, 218);
            this.LinkLblAddElement.Name = "LinkLblAddElement";
            this.LinkLblAddElement.Size = new System.Drawing.Size(133, 16);
            this.LinkLblAddElement.TabIndex = 1;
            this.LinkLblAddElement.TabStop = true;
            this.LinkLblAddElement.Text = "Ajouter un élement...";
            this.LinkLblAddElement.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLblAddElement_LinkClicked);
            // 
            // RadioBtnCheckList
            // 
            this.RadioBtnCheckList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.RadioBtnCheckList.Location = new System.Drawing.Point(396, 3);
            this.RadioBtnCheckList.Name = "RadioBtnCheckList";
            this.RadioBtnCheckList.Size = new System.Drawing.Size(30, 250);
            this.RadioBtnCheckList.TabIndex = 2;
            this.RadioBtnCheckList.TabStop = true;
            this.RadioBtnCheckList.UseVisualStyleBackColor = true;
            // 
            // FrmChecklist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(526, 277);
            this.Controls.Add(this.FlowLayoutPnlCheckList);
            this.MinimumSize = new System.Drawing.Size(542, 315);
            this.Name = "FrmChecklist";
            this.Text = "FrmChecklist";
            this.FlowLayoutPnlCheckList.ResumeLayout(false);
            this.FlowLayoutPnlCheckList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPnlCheckList;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPnlCheckListElt;
        private System.Windows.Forms.LinkLabel LinkLblAddElement;
        private System.Windows.Forms.RadioButton RadioBtnCheckList;
    }
}