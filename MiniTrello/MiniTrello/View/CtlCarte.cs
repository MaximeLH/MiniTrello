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
    public partial class CtlCarte : UserControl
    {
        public Carte c;
    public CtlCarte()
        {
            InitializeComponent();
            
        }

        private void CtlCarte_Click(object sender, EventArgs e)
        {
        }

        private void CtlCarte_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void lblTitreCarte_Click(object sender, EventArgs e)
        {
            FrmCarte t = new MiniTrello.FrmCarte();
            t.c = c;
            t.ShowDialog();
        }
    }
}
