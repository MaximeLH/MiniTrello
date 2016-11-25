using MiniTrello.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniTrello.View
{
    public partial class FrmTest : Form
    {
        public FrmTest()
        {
            InitializeComponent();
        }

        private void btnAddCarte_Click(object sender, EventArgs e)
        {
            Model.Carte carte = new Model.Carte();
            carte.Titre = txtCarte.Text;
            TextBox txtBox = new TextBox();
            txtBox.Text = txtCarte.Text;
            flpAffichageTitreCarte.Controls.Add(txtBox);
            txtCarte.Text = "";
        }
    }
}
