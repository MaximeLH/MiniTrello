using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniTrello.View
{
    public partial class CtrlListe : UserControl
    {
        public CtrlListe()
        {
            InitializeComponent();
        }
        private void btnAddCarte_Click(object sender, EventArgs e)
        {
            Carte carte = new Carte () ;
            carte.Titre = txtCarte.Text;
            

        }
    }
}
