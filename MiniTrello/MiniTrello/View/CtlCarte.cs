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
    public partial class CtlCarte : UserControl
    {
        public CtlCarte()
        {
            InitializeComponent();
        }

        private void CtlCarte_Click(object sender, EventArgs e)
        {
            Titre t = new MiniTrello.Titre();
            t.ShowDialog();
        }

        private void CtlCarte_MouseClick(object sender, MouseEventArgs e)
        {
            Titre t = new MiniTrello.Titre();
            t.ShowDialog();
        }
    }
}
