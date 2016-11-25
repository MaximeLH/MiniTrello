using MiniTrello.Business;
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
        public MainController ctlr;

        public FrmTableau()
        {
            InitializeComponent();
            ctlr = MainController.instance;
            PremiereConfig();
            Init();
        }

        public void Init() {
            foreach (var item in ctlr.Listes) {
                CtlListe ctlliste = new CtlListe();
                ctlliste.Tag = item;
                ctlliste.InitCartes();
                ctlliste.txtTitreListe.Text = item.Titre;
                flnListe.Controls.Add(ctlliste);
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
            CtlListe c = new CtlListe();
            c.txtTitreListe.Text = txtTitreListe.Text;
            flnListe.Controls.Add(c);
            PremiereConfig();
            c.MoveLeft += delegate (object s, EventArgs ev) { C_MoveLeft(sender, e, c); };
            c.MoveRight += delegate (object s, EventArgs ev) { C_MoveRight(sender, e, c); };

            c.SupprimeMoi += C_SupprimeMoi;
        }

        private void C_SupprimeMoi(object sender, CtlListe e)
        {
            flnListe.Controls.Remove(e);
        }

        private void C_MoveLeft(object sender, EventArgs e, CtlListe c)
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

        private void C_MoveRight(object sender, EventArgs e, CtlListe c)
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
            ctlr.ResetDB();
        }

    }
}
