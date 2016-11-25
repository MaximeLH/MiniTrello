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
    public partial class FrmCarte : Form
    {
        public MinitrelloDB ctx;
        public FrmCarte()
        {
            InitializeComponent();
            LblTitre.Name = "";
            LblSousTitre.Name = "Se trouve dans: " + "";
            
        }

        private void FrmCarte_Load(object sender, EventArgs e)
        {
            Carte carte = (Carte)this.Tag;
            LblTitre.Text = carte.Titre;
            TxtBoxDescription.Text= carte.Description ;

        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            CtlCheckList c1 = new CtlCheckList();
            c1.Selected += C1_Selected;
            FlowLayoutPnlCheckLists.Controls.Add(c1);
        }

        public CtlCheckList ctlSelected;

        private void C1_Selected(object sender, EventArgs e)
        {
            ctlSelected = (CtlCheckList) sender;
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            FlowLayoutPnlCheckLists.Controls.Remove(ctlSelected);
        }

        private void LblTitre_TextChanged(object sender, EventArgs e)
        {
                //Carte c2 = ctx.Cartes.Single(x => x.Id == c.Id);
                //c2.Titre = LblTitre.Text;
                //ctx.SaveChanges();
        }

        private void TxtBoxDescription_TextChanged(object sender, EventArgs e)
        {
                //Carte carte = (Carte)this.Tag;
                //carte.Description = TxtBoxDescription.Text;
                //ctx.SaveChanges();
        }

        private void BtnAddCommentaire_Click(object sender, EventArgs e)
        {
            Label l1 = new Label();
            l1.BackColor = Color.BlueViolet;
            l1.ForeColor = Color.White;
            l1.AutoSize = true;
            l1.Text = TxtBoxDescription.Text;
            FlnCommentaire.Controls.Add(l1);
            TxtBoxDescription.Text = "";
        }
    }
}
