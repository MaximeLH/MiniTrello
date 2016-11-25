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
        public FrmTableau()
        {
            InitializeComponent();
            using (var ctx = new MinitrelloDB())
            {
                Tableau t = new Tableau { Titre = "Deuxième Tableau " };
                Liste l = new Liste { Titre = "Liste l2" };
                Carte c = new Carte { Titre = "Carte c2", Description = "deuxième carte créée" };
                Checklist ch = new Checklist { };
                ElementChecklist e = new ElementChecklist { Etat = true, TextElt = "element de checklist n°1" };

                ch.CheckL = new List<ElementChecklist>();
                ch.CheckL.Add(e);
                c.Checklists = new List<Checklist>();
                c.Checklists.Add(ch);
                l.Cartes = new List<Carte>();
                l.Cartes.Add(c);
                t.Listes = new List<Liste>();
                t.Listes.Add(l);
                ctx.Tableaux.Add(t);
                ctx.SaveChanges();

                PremiereConfig();
                
            }
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
            CtrlListe c = new CtrlListe();
            c.txtTitreListe.Text = txtTitreListe.Text;
            flnListe.Controls.Add(c);
            PremiereConfig();
        }

        private void btnSuppListe_Click(object sender, EventArgs e)
        {
            PremiereConfig();
        }
    }
}
