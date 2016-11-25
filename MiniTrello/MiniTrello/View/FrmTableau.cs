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
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            txtAjout.BackColor = Color.White;
            txtAjout.BorderStyle = BorderStyle.Fixed3D;
            txtAjout.Text = "";
            Button ajout = new Button();
            ajout.Text = "Enregistrer";
            ajout.BackColor = Color.LimeGreen;
            Button annuler = new Button();
            annuler.Text = "X";
            annuler.Width = 50;
            pnlAjout.Controls.Add(ajout);
            pnlAjout.Controls.Add(annuler);
            ajout.Click += new EventHandler(ajout_Click);
            annuler.Click += new EventHandler(annuler_Click);
        }
        private void ajout_Click(object sender, EventArgs e)
        {
            CtlListe c = new CtlListe();
            c.txtTitreListe.Text = txtAjout.Text;
            flnListe.Controls.Add(c);
        }
        private void annuler_Click(object sender, EventArgs e)
        {

            pnlAjout.Controls.Remove(txtAjout);
           
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
