using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        CProduct cpd = new CProduct();
        
        public CProduct _cpd
        {


            get {
                cpd.id = Convert.ToInt32(txtId.Text);
                cpd.name = txtName.Text;
                cpd.qty = Convert.ToInt32(txtQty.Text);
                cpd.cost = Convert.ToDecimal(txtCost.Text);
                cpd.price = Convert.ToDecimal(txtPrice.Text);

                return cpd;
            }

            set {
                cpd = value;
                txtId.Text = cpd.id.ToString();
                txtName.Text = cpd.name;
                txtQty.Text = cpd.qty.ToString();
                txtCost.Text = cpd.cost.ToString("0.0");
                txtPrice.Text = cpd.price.ToString("0.0");
            }
        }
        

        bool isDatavalidate()
        {
            string message = "";

            if(txtName.Text == "")
            {
                message += "\r\n名稱必須填寫";
            }

            if(txtQty.Text == "")
            {
                message += "\r\n庫存必須填寫";
            }

            if (txtCost.Text == "")
            {
                message += "\r\n成本必須填寫";
            }

            if (txtPrice.Text == "")
            {
                message += "\r\n價格必須填寫";
            }

            if(message != "")
            {
                MessageBox.Show(message);
            }

            return message == "";
        }
  

        private void button2_Click(object sender, EventArgs e)
        {
            if (!isDatavalidate())
            {
               
                //Debug.Fail("錯誤"); 
                return;
            }

            _isoklclick = true;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
