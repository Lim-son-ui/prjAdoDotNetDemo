using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 訂房系統
{
    public partial class Frm_productlist : Form
    {
        public Frm_productlist()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=dbDemo;Integrated Security=True";
            con.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("select * from tproduct",con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            con.Close();

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Frmproductedit fpd =  new Frmproductedit();
            fpd.ShowDialog();

            if (fpd.isokclicked)
            {
                DataTable table = (DataTable)dataGridView1.DataSource;
                DataRow row = table.NewRow();
                row["fid"] = fpd.id;
                row["fname"] = fpd.name;
                row["fqty"] = fpd.store;
                row["fcost"] = fpd.amount;
                row["fprice"] = fpd.price;


                table.Rows.Add(row);

                //dataadap
            }
         
        }
    }
}
