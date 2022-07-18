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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void button5_Click(object sender, EventArgs e)
        {
            Frm_customer_edit frm = new Frm_customer_edit();
            //frm.MdiParent = this;
            frm.Show();

        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=dbDemo;Integrated Security=True";
            con.Open();
            //con.Close();

            string sql = "INSERT INTO tCustomer(fName,fPhone,fEmail,fAddress,fPassword) values('Marco','09233445','marco@gmail.com','taipei','1234')";


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("新增資料成功");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=dbDemo;Integrated Security=True";
            con.Open();
            //con.Close();

            string sql = "delete from tCustomer where fName = 'Marco'";


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("刪除資料成功");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=dbDemo;Integrated Security=True";
            con.Open();
            //con.Close();

            string sql = "update tCustomer set fPhone = '0912541',fEmail = 'marco@outlook.com 'where fName = 'Marco'";


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("修改資料成功");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=dbDemo;Integrated Security=True";
            con.Open();


            //SqlConnection com = new SqlConnection();
            //com.ConnectionString = @"";
            //com.Open();

            string sql = "select * from tCustomer";


            //SqlCommand cma = new SqlCommand();
            //cma.Connection = cma;



            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            SqlDataReader reader = cmd.ExecuteReader();

            string name = "沒有資料";

            if (reader.Read())
            {
                name = $"{reader["fName"].ToString()}" +
                    $"\r\n{reader["fPhone"].ToString()}{"/"}{reader["fEmail"].ToString()}";

            }


            con.Close();
            MessageBox.Show("查詢成功" + name);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Frm_productlist frm =  new Frm_productlist();
            frm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.IsMdiContainer = true;
        }
    }
}
