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
    public partial class CtlAjoutCarte : UserControl
    {
        public CtlAjoutCarte()
        {
            InitializeComponent();
        }

        private void btnAjoutCarte_Click(object sender, EventArgs e)
        {
            Carte c = new Carte();
            c.Titre = txtBoxTitreCarte.Text;
            CtlCarte ctCarte = new CtlCarte();
            
        }
    }
}
