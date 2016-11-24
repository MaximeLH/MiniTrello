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
    public partial class Titre : Form
    {
        public Titre()
        {
            InitializeComponent();
            LblTitre.Name = "";
            LblSousTitre.Name = "Se trouve dans: " + "";
            
        }

        private void FormulaireCarte_Load(object sender, EventArgs e)
        {

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
    }
}
