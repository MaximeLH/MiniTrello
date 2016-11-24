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
    public partial class FrmChecklist : Form
    {
        public FrmChecklist()
        {
            InitializeComponent();
        }

        private void LinkLblAddElement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //FlowLayoutPanel f1 = new FlowLayoutPanel();
            //    f1.Controls.Add(new TextBox());
            //f1.Controls.Add(new CheckBox());
            //FlowLayoutPnlCheckListElt.Controls.Add(f1);
            CtlChecklistElement c1 = new CtlChecklistElement();
            FlowLayoutPnlCheckListElt.Controls.Add(c1);
}
    }
}
