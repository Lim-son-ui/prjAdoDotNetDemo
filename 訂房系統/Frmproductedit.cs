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
    public partial class Frmproductedit : Form
    {
        public Frmproductedit()
        {
            InitializeComponent();
        }

        bool _isoklclick = false;

        public bool isokclicked
        {
            get { return _isoklclick; }
        }

        
        public int id
        {
            //get { return int.Parse(txtId.Text); }
            //set { txtId.Text = value.ToString(); }
            get;
            set;
        }
        public string name
        {
            //get { return txtName.Text; }
            //set { txtName.Text = value; }
            get;
            set;
        }

        public decimal store
        {
            //get { return int.Parse(txtQty.Text); }
            //set { txtQty.Text = value.ToString(); }
            get;
            set;
        }

        public decimal amount
        {
            //get { return int.Parse(txtAmt.Text); }
            //set { txtAmt.Text = value.ToString(); }
            get;
            set;
        }

        public decimal price
        {
            //get { return int.Parse(txtAmt.Text); }
            //set { txtAmt.Text = value.ToString(); }
            get;
            set;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _isoklclick = true;
            id = Convert.ToInt32(txtId.Text);
            name = txtName.Text;
            store = Convert.ToDecimal(txtQty.Text);
            amount = Convert.ToDecimal(txtAmt.Text);
            price = Convert.ToDecimal(txtPrice.Text);
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
