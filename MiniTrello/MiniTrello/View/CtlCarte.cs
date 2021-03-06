﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniTrello.Model;
using MiniTrello;

namespace MiniTrello.View
{
    public partial class CtlCarte : UserControl
    {
    public CtlCarte()
        {
            InitializeComponent();
        }

        public void Init()
        {
            Carte c = (Carte)this.Tag;
            lblTitreCarte.Text = c.Titre;
        }

        private void CtlCarte_Click(object sender, EventArgs e)
        {
        }

        private void CtlCarte_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void lblTitreCarte_Click(object sender, EventArgs e)
        {
            FrmCarte t = new MiniTrello.FrmCarte();
            t.Tag = this.Tag;
            t.ShowDialog();
        }


        public event EventHandler<CtlCarte> SupprimeMoi;

        private void btnSupCarteListe_Click(object sender, EventArgs e)
        {
            SupprimeMoi?.Invoke(this, this);
        }


        public event EventHandler<CtlCarte> MoveUp;

        private void lblUp_Click(object sender, EventArgs e)
        {
            MoveUp?.Invoke(this, this);
        }

        public event EventHandler<CtlCarte> MoveDown;

        private void lblDown_Click(object sender, EventArgs e)
        {
            MoveDown?.Invoke(this, this);
        }
    }
}
