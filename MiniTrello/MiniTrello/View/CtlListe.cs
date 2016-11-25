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

namespace MiniTrello.View
{
    public partial class CtlListe : UserControl
    {
        public CtlListe()
        {
            InitializeComponent();
        }
        public void btnAddCarte_Click(object sender, EventArgs e)
        {
            CtlCarte ctCarte = new CtlCarte();
            using (var ctx = new MiniTrello.Data.MinitrelloDB())
            {
                Carte c = new Model.Carte();
                c.Titre = txtBoxTitreCarte.Text;
                ctx.Cartes.Add(c);
                ctx.SaveChanges();
                ctCarte.Tag = c;
                ctCarte.Init();
                ctCarte.SupprimeMoi += CtCarte_SupprimeMoi;
            }
            flpCartes.Controls.Add(ctCarte);

        }

        private void CtCarte_SupprimeMoi(object sender, CtlCarte e)
        {
            flpCartes.Controls.Remove(e);
        }

        public event EventHandler<CtlListe> SupprimeMoi;

        private void btnSuppListe_Click(object sender, EventArgs e)
        {
            SupprimeMoi?.Invoke(this, this);
        }
    }
}
