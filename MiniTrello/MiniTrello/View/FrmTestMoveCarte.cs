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
    public partial class FrmTestMoveCarte : Form
    {
        public FrmTestMoveCarte()
        {
            InitializeComponent();
        }

        private void btnUp1_Click(object sender, EventArgs e)
        {
            var alphaIndex = flowLayoutPanel2.Controls.IndexOf(panel1);
            Control control = null;
            foreach (Control c in flowLayoutPanel2.Controls)
            {
                if (flowLayoutPanel2.Controls.IndexOf(c) == alphaIndex - 1)
                { control = c; break; }
            }
            if (control == null)
            { }
            else
            {
                flowLayoutPanel2.Controls.SetChildIndex(panel1, alphaIndex - 1);
                flowLayoutPanel2.Controls.SetChildIndex(control, alphaIndex);
            }
        }

        private void btnDown2_Click(object sender, EventArgs e)
        {
            var alphaIndex = flowLayoutPanel2.Controls.IndexOf(panel1);
            Control control = null;
            foreach (Control c in flowLayoutPanel2.Controls)
            {
                if (flowLayoutPanel2.Controls.IndexOf(c) == alphaIndex + 1)
                { control = c; break; }
            }
            if (control == null)
            { }
            else
            {
                flowLayoutPanel2.Controls.SetChildIndex(panel1, alphaIndex + 1);
                flowLayoutPanel2.Controls.SetChildIndex(control, alphaIndex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var alphaIndex = flowLayoutPanel2.Controls.IndexOf(panel2);
            Control control = null;
            foreach (Control c in flowLayoutPanel2.Controls)
            {
                if (flowLayoutPanel2.Controls.IndexOf(c) == alphaIndex - 1)
                { control = c; break; }
            }
            if (control == null)
            { }
            else
            {
                flowLayoutPanel2.Controls.SetChildIndex(panel2, alphaIndex - 1);
                flowLayoutPanel2.Controls.SetChildIndex(control, alphaIndex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var alphaIndex = flowLayoutPanel2.Controls.IndexOf(panel2);
            Control control = null;
            foreach (Control c in flowLayoutPanel2.Controls)
            {
                if (flowLayoutPanel2.Controls.IndexOf(c) == alphaIndex + 1)
                { control = c; break; }
            }
            if (control == null)
            { }
            else
            {
                flowLayoutPanel2.Controls.SetChildIndex(panel2, alphaIndex + 1);
                flowLayoutPanel2.Controls.SetChildIndex(control, alphaIndex);
            }
        }

        private void flowLayoutPanel2_DragEnter(object sender, DragEventArgs e)
        {
            //    e.Effect = DragDropEffects.Move;
        }

    private void flowLayoutPanel2_DragDrop(object sender, DragEventArgs e)
    {
        //    GroupBox data = (GroupBox)e.Data.GetData(typeof(GroupBox));
        //    Point p = flowLayoutPanel2.PointToClient(new Point(e.X, e.Y));
        //    var item = flowLayoutPanel2.GetChildAtPoint(p);
        //    int index = flowLayoutPanel2.Controls.GetChildIndex(item, false);
        //    flowLayoutPanel2.Controls.SetChildIndex(data, index);
        //    flowLayoutPanel2.Invalidate();
    }
}
}
