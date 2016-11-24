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
    public partial class CtlCheckList : UserControl
    {
        public CtlCheckList()
        {
            InitializeComponent();
        }

        private void LinkLblAddElement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CtlChecklistElement c1 = new CtlChecklistElement();
            FlowLayoutPnlCheckListElt.Controls.Add(c1);
        }
    }
}
