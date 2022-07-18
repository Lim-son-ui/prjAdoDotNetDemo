using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 訂房系統
{
    public partial class Frm_main : Form
    {
        public Frm_main()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Frm_productlist f = new Frm_productlist();
            f.MdiParent = this;
            //f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Frmproductedit f = new Frmproductedit();
            f.MdiParent = this;
            //f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void 水平排列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void 垂直排列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // this.LayoutMdi(MdiLayout.);
        }

        private void Frm_main_Load(object sender, EventArgs e)
        {
            new Frm_login().ShowDialog();
        }
    }
}
