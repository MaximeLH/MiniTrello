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
        public FrmTableau()
        {
            InitializeComponent();
        }

        private void btnAjouterListe_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            txtAjout.BackColor = Color.White;
            txtAjout.BorderStyle = BorderStyle.Fixed3D;
            txtAjout.Text = "";
            Button ajout = new Button();
            ajout.Text = "Enregistrer";
            ajout.Width = pnlAjout.Width - 80;
            ajout.BackColor = Color.LimeGreen;
            Button annuler = new Button();
            annuler.Text = "X";
            annuler.Width = 50;
            pnlAjout.Controls.Add(ajout);
            pnlAjout.Controls.Add(annuler);
            ajout.Click += new EventHandler(ajout_Click);
        }
        private void ajout_Click(object sender, EventArgs e)
        {
            TextBox txtTitreCarte = new TextBox();
            txtTitreCarte.Text = txtAjout.Text;

            Button ajCarte = new Button();
            ajCarte.Text = "Ajouter une carte";


            flnListe.Controls.Add(txtTitreCarte);
            flnListe.Controls.Add(ajCarte);
        }

        private void FrmTableau_Load(object sender, EventArgs e)
        {

        }
    }
}
