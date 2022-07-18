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
    public partial class Frm_login : Form
    {
        bool isclosed = true;
        public Frm_login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString =  @"Data Source=.;Initial Catalog=dbDemo;Integrated Security=True";
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from tcustomer where femail = '" + textBox1.Text + "' and fpassword = " + textBox2.Text;

            SqlDataReader reader = cmd.ExecuteReader();

            string name = "沒有資料";
            if (reader.Read())
            {
                con.Close();
                isclosed = false;
                Close();
                return;
            }
            MessageBox.Show("帳號與密碼不符");
            con.Close();
        }

        private void Frm_login_Load(object sender, EventArgs e)
        {

        }

        private void Frm_login_FormClosing(object sender, FormClosingEventArgs e)
        {
           e.Cancel = isclosed;
        }
    }
}
