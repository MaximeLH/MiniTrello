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
    public partial class CtlChecklistElement : UserControl
    {
        public CtlChecklistElement()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            Selected?.Invoke(this, e);
        }
        public event EventHandler Selected;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
            Selected?.Invoke(this, e);
            }
            else
            {
            Selected?.Invoke(null, e);
            }

        }
    }
}
