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
using MiniTrello.Business;

namespace MiniTrello.View {
    public partial class CtlListe : UserControl {
        public MainController ctlr;

        public CtlListe() {
            InitializeComponent();
            ctlr = MainController.instance;
        }

        public void btnAddCarte_Click(object sender, EventArgs e) {

            // Definit une nouvelle carte
            Carte c = new Model.Carte();
            c.Titre = txtBoxTitreCarte.Text;

            // Ajoute la carte a la BD
            ctlr.AjouterCarteALaListe(c, (Liste)this.Tag);

            // Ajoute graphiquement la carte a la liste
            CtlCarte ctCarte = new CtlCarte();
            ctCarte.Tag = c;
            ctCarte.Init();
            ctCarte.SupprimeMoi += CtCarte_SupprimeMoi;

            flpCartes.Controls.Add(ctCarte);
            ctCarte.MoveUp += CtCarte_MoveUp;
            ctCarte.MoveDown += CtCarte_MoveDown;
        }

        private void CtCarte_MoveDown(object sender, CtlCarte c) {
            var alphaIndex = flpCartes.Controls.IndexOf(c);
            Control control = null;
            foreach (Control ctrl in flpCartes.Controls) {
                if (flpCartes.Controls.IndexOf(ctrl) == alphaIndex + 1) { control = ctrl; break; }
            }
            if (control == null) { } else {
                flpCartes.Controls.SetChildIndex(c, alphaIndex + 1);
                flpCartes.Controls.SetChildIndex(control, alphaIndex);
            }
        }

        private void CtCarte_MoveUp(object sender, CtlCarte c) {
            var alphaIndex = flpCartes.Controls.IndexOf(c);
            Control control = null;
            foreach (Control ctrl in flpCartes.Controls) {
                if (flpCartes.Controls.IndexOf(ctrl) == alphaIndex - 1) { control = ctrl; break; }
            }
            if (control == null) { } else {
                flpCartes.Controls.SetChildIndex(c, alphaIndex - 1);
                flpCartes.Controls.SetChildIndex(control, alphaIndex);
            }
        }

        private void CtCarte_SupprimeMoi(object sender, CtlCarte e) {
            flpCartes.Controls.Remove(e);
        }

        public event EventHandler<CtlListe> SupprimeMoi;

        private void btnSuppListe_Click(object sender, EventArgs e) {
            SupprimeMoi?.Invoke(this, this);
        }

        public event EventHandler MoveLeft;

        private void lblLeft_Click(object sender, EventArgs e) {
            MoveLeft?.Invoke(this, null);
        }

        public event EventHandler MoveRight;

        private void lblRight_Click(object sender, EventArgs e) {
            MoveRight?.Invoke(this, null);
        }

        public void InitCartes() {
            Liste l = (Liste)this.Tag;
            foreach (var item in l.Cartes) {
                CtlCarte ctlcarte = new CtlCarte();
                ctlcarte.Tag = item;
                ctlcarte.Init();
                flpCartes.Controls.Add(ctlcarte);
            }
        }
    }


}
