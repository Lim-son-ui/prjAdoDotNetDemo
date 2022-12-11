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

        private void Frm_main_Load(object sender, EventArgs e)
        {
            new Frm_login().ShowDialog();
        }

        #region
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           
        }
        #endregion
        private void show_productlist_Click(object sender, EventArgs e)
        {
            Frm_productlist f = new Frm_productlist();
            //f.MdiParent = this;
            //f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void show_productedit_Click(object sender, EventArgs e)
        {
            Frm_customer_edit f = new Frm_customer_edit();
            //f.MdiParent = this;
            //f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void form_close_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
        }

       
        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
           // this.LayoutMdi(MdiLayout.);
        }

        private void 水平排列ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void 垂直排列ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void 階梯式排列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void 關閉目前視窗ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
        }

        private void 關閉所有視窗ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
        }
    }
}
