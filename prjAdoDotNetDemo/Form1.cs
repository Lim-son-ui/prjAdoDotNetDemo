using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace prjAdoDotNetDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            SqlDataReader reader =  cmd.ExecuteReader();
            string name = "沒有資料";

            if (reader.Read())
            {
                name = $"{reader["fName"].ToString()}" +
                    $"\r\n{reader["fPhone"].ToString()}{"/"}{reader["fEmail"].ToString()}";
                
            }
        

            con.Close();
            MessageBox.Show("查詢成功" + name);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };

            IEnumerable<int> q = from n in nums
                                 where iseven(n)
                                 select n;

            foreach(int n in q)
            {
                this.listBox1.Items.Add(n);
            }

        }

        bool iseven(int n)
        {
            if(n%2 == 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
