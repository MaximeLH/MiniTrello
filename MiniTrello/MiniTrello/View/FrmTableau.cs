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
            }
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
        }
        private void ajout_Click(object sender, EventArgs e)
        {
            CtrlListe c = new CtrlListe();
            c.txtTitreListe.Text = txtAjout.Text;
            flnListe.Controls.Add(c);
        }

        private void txtAjout_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
