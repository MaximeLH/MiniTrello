﻿using MiniTrello.Model;

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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblUp = new System.Windows.Forms.Label();
            this.lblDown = new System.Windows.Forms.Label();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitreCarte
            // 
            this.lblTitreCarte.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTitreCarte.Location = new System.Drawing.Point(0, 37);
            this.lblTitreCarte.Name = "lblTitreCarte";
            this.lblTitreCarte.Size = new System.Drawing.Size(176, 22);
            this.lblTitreCarte.TabIndex = 0;
            this.lblTitreCarte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitreCarte.Click += new System.EventHandler(this.lblTitreCarte_Click);
            this.lblTitreCarte.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CtlCarte_MouseClick);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lblUp);
            this.flowLayoutPanel2.Controls.Add(this.lblDown);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(51, 33);
            this.flowLayoutPanel2.TabIndex = 20;
            // 
            // lblUp
            // 
            this.lblUp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUp.AutoSize = true;
            this.lblUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUp.Location = new System.Drawing.Point(3, 0);
            this.lblUp.Name = "lblUp";
            this.lblUp.Size = new System.Drawing.Size(43, 15);
            this.lblUp.TabIndex = 17;
            this.lblUp.Text = "Up";
            this.lblUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUp.Click += new System.EventHandler(this.lblUp_Click);
            // 
            // lblDown
            // 
            this.lblDown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDown.AutoSize = true;
            this.lblDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDown.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblDown.Location = new System.Drawing.Point(3, 15);
            this.lblDown.Name = "lblDown";
            this.lblDown.Size = new System.Drawing.Size(43, 15);
            this.lblDown.TabIndex = 18;
            this.lblDown.Text = "Down";
            this.lblDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDown.Click += new System.EventHandler(this.lblDown_Click);
            // 
            // CtlCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.lblTitreCarte);
            this.Name = "CtlCarte";
            this.Size = new System.Drawing.Size(176, 59);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitreCarte;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        internal System.Windows.Forms.Label lblUp;
        internal System.Windows.Forms.Label lblDown;
    }
}
