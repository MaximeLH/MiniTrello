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
            c1.Selected += C2_Selected;
            FlowLayoutPnlCheckListElt.Controls.Add(c1);
        }

        private void LinkLblSupprElt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FlowLayoutPnlCheckListElt.Controls.Remove(ctlElementSelected);

        }

        public CtlChecklistElement ctlElementSelected;

        private void C2_Selected(object sender, EventArgs e)
        {
            ctlElementSelected = (CtlChecklistElement)sender;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Selected?.Invoke(this, e);
        }

        public event EventHandler Selected;
    }
}
