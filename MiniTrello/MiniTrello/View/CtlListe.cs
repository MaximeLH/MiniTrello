using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniTrello.Model;
using MiniTrello.Data;

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
                Liste l = (Liste)this.Tag;
                Liste l2 = ctx.Listes.Include("Cartes").Single(x => x.Id == l.Id);
                l2.Cartes.Add(c);
                ctCarte.Tag = c;
                ctx.SaveChanges();
                ctCarte.Init();
            }
            flpCartes.Controls.Add(ctCarte);

        }

        public event EventHandler SupprimeMoi;

        private void btnSuppListe_Click(object sender, EventArgs e)
        {
            SupprimeMoi?.Invoke(this, null);
        }

        public void InitCartes()
        {
            using (var ctx = new MinitrelloDB())
            {
                Liste l = (Liste)this.Tag;
                foreach (var item in l.Cartes)
                {
                    CtlCarte ctlcarte = new CtlCarte();
                    ctlcarte.Tag = item;
                    ctlcarte.Init();
                    flpCartes.Controls.Add(ctlcarte);
                }
            }
        }
        }
        //public Liste FindListByCard(Carte c)
        //{
        //    using (var ctx = new MinitrelloDB())
        //    {
        //        foreach (Liste item in ctx.Listes.Include("Cartes"))
        //        {
        //            if (item.Cartes.Contains(c))
        //            {
        //                return item;
        //            }
        //        }
        //        return null;
        //    }
        //}

    
}
