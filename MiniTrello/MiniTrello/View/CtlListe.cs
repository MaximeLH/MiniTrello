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
            ctCarte.MoveUp += delegate (object s, EventArgs ev) { lblUp_Click(sender, e, ctCarte); };
            ctCarte.MoveDown += delegate (object s, EventArgs ev) { lblDown_Click(sender, e, ctCarte); };
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

        public event EventHandler MoveLeft;

        private void lblLeft_Click(object sender, EventArgs e)
        {
            MoveLeft?.Invoke(this, null);
        }

        public event EventHandler MoveRight;

        private void lblRight_Click(object sender, EventArgs e)
        {
            MoveRight?.Invoke(this, null);
        }

        private void lblUp_Click(object sender, EventArgs e, CtlCarte c)
        {
            var alphaIndex = flpCartes.Controls.IndexOf(c);
            Control control = null;
            foreach (Control ctrl in flpCartes.Controls)
            {
                if (flpCartes.Controls.IndexOf(ctrl) == alphaIndex - 1)
                { control = ctrl; break; }
            }
            if (control == null)
            { }
            else
            {
                flpCartes.Controls.SetChildIndex(c, alphaIndex - 1);
                flpCartes.Controls.SetChildIndex(control, alphaIndex);
            }
        }

        private void lblDown_Click(object sender, EventArgs e, CtlCarte c)
        {
            var alphaIndex = flpCartes.Controls.IndexOf(c);
            Control control = null;
            foreach (Control ctrl in flpCartes.Controls)
            {
                if (flpCartes.Controls.IndexOf(ctrl) == alphaIndex + 1)
                { control = ctrl; break; }
            }
            if (control == null)
            { }
            else
            {
                flpCartes.Controls.SetChildIndex(c, alphaIndex + 1);
                flpCartes.Controls.SetChildIndex(control, alphaIndex);
            }
        }
    }
}
