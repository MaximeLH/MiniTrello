using MiniTrello.Data;
using MiniTrello.Model;
using MiniTrello.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniTrello
{
    public partial class FrmTableau : Form
    {

        public MinitrelloDB ctx;

        public FrmTableau()
        {
            InitializeComponent();
            ctx = new MinitrelloDB();
            PremiereConfig();
        }

        public void btnAjoutListe_Click(object sender, EventArgs e)
        {
            DeuxiemeConfig();
        }
        public void PremiereConfig()
        {
            btnAjoutListe.Visible = true;
            txtTitreListe.Visible = false;
            btnEnregistrerListe.Visible = false;
            btnSuppListe.Visible = false;
        }
        public void DeuxiemeConfig()
        {
            btnAjoutListe.Visible = false;
            txtTitreListe.Visible = true;
            btnEnregistrerListe.Visible = true;
            btnSuppListe.Visible = true;
        }

        private void btnEnregistrerListe_Click(object sender, EventArgs e)
        {
            CtlListe c = new CtlListe();
            c.txtTitreListe.Text = txtTitreListe.Text;
            flnListe.Controls.Add(c);
            PremiereConfig();
            c.lblLeft.Click += delegate (object s, EventArgs ev) { lblLeft_Click(sender, e, c); };
            c.lblRight.Click += delegate (object s, EventArgs ev) { lblRight_Click(sender, e, c); };

            c.SupprimeMoi += delegate (object s, EventArgs ev) { C_SupprimeMoi(sender, e, c); };

        }

        private void C_SupprimeMoi(object sender, EventArgs e, CtlListe c)
        {
            flnListe.Controls.Remove(c);
        }

        private void lblLeft_Click(object sender, EventArgs e, CtlListe c)
        {
            var alphaIndex = flnListe.Controls.IndexOf(c);
            Control control = null;
            foreach (Control ctrl in flnListe.Controls)
            {
                if (flnListe.Controls.IndexOf(ctrl) == alphaIndex - 1)
                { control = ctrl; break; }
            }
            if (control == null)
            { }
            else
            {
                flnListe.Controls.SetChildIndex(c, alphaIndex - 1);
                flnListe.Controls.SetChildIndex(control, alphaIndex);
            }
        }

        private void lblRight_Click(object sender, EventArgs e, CtlListe c)
        {
            var alphaIndex = flnListe.Controls.IndexOf(c);
            Control control = null;
            foreach (Control ctrl in flnListe.Controls)
            {
                if (flnListe.Controls.IndexOf(ctrl) == alphaIndex + 1)
                { control = ctrl; break; }
            }
            if (control == null)
            { }
            else
            {
                flnListe.Controls.SetChildIndex(c, alphaIndex + 1);
                flnListe.Controls.SetChildIndex(control, alphaIndex);
            }
        }

        private void btnSuppListe_Click(object sender, EventArgs e)
        {
            PremiereConfig();
        }

        private void BtnResetDB_Click(object sender, EventArgs e)
        {

            foreach (var item in ctx.Tableaux)
            {
                ctx.Tableaux.Remove(item);
            }
            foreach (var item in ctx.Listes)
            {
                ctx.Listes.Remove(item);
            }
            foreach (var item in ctx.Cartes)
            {
                ctx.Cartes.Remove(item);
            }
            foreach (var item in ctx.Checklists)
            {
                ctx.Checklists.Remove(item);
            }
            foreach (var item in ctx.EltChecklists)
            {
                ctx.EltChecklists.Remove(item);
            }

            ctx.SaveChanges();

            Tableau t = new Tableau { Titre = "Tableau de test " };

            Liste l = new Liste { Titre = "Liste n°1" };
            Liste m = new Liste { Titre = "Liste n°2" };

            Carte c = new Carte { Titre = "Carte a", Description = "première carte créée" };
            Carte d = new Carte { Titre = "Carte b", Description = "deuxième carte créée" };

            Checklist ch = new Checklist { };
            Checklist ci = new Checklist { };

            ElementChecklist v = new ElementChecklist { Etat = true, TextElt = "Element de checklist n°1" };
            ElementChecklist g = new ElementChecklist { Etat = false, TextElt = "Element de checklist n°2" };

            ch.CheckL = new List<ElementChecklist>();
            ch.CheckL.Add(v);
            ci.CheckL = new List<ElementChecklist>();
            ci.CheckL.Add(g);

            c.Checklists = new List<Checklist>();
            c.Checklists.Add(ch);

            d.Checklists = new List<Checklist>();
            d.Checklists.Add(ci);


            l.Cartes = new List<Carte>();
            l.Cartes.Add(c);
            m.Cartes = new List<Carte>();
            m.Cartes.Add(d);

            t.Listes = new List<Liste>();
            t.Listes.Add(l);
            t.Listes.Add(m);

            ctx.Tableaux.Add(t);

            ctx.SaveChanges();

        }
    }
}
