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

        public CtlChecklistElement ctlElementSelected;

        private void C2_Selected(object sender, EventArgs e)
        {
            ctlElementSelected = (CtlChecklistElement)sender;
        }

        public event EventHandler Selected;

        private void ResizePanel()
        {
            int height = 0;

            foreach (Control ctl in FlowLayoutPnlCheckListElt.Controls)
            {
                height += ctl.Height;
            }

            FlowLayoutPnlCheckListElt.Height = height;
            LinkLblAddElement.Top = height;
            LinkLblSupprElt.Top = height;

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                Selected?.Invoke(this, e);
            else
                Selected?.Invoke(null, e);
        }

        private void LinkLblAddElement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CtlChecklistElement c1 = new CtlChecklistElement();
            c1.Selected += C2_Selected;
            FlowLayoutPnlCheckListElt.Controls.Add(c1);

            ResizePanel();
        }

        private void LinkLblSupprElt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FlowLayoutPnlCheckListElt.Controls.Remove(ctlElementSelected);

            ResizePanel();
        }
    }
}
