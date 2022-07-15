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
    public partial class Frm_customer_edit : Form
    {
        public Frm_customer_edit()
        {
            InitializeComponent();
        }

        
        private void execute(string sql,List<SqlParameter> para)    // 
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=dbDemo;Integrated Security=True";
            con.Open();


            SqlCommand cmd = new SqlCommand();
            if(para != null) cmd.Parameters.AddRange(para.ToArray());
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            string sql = "INSERT INTO tCustomer(";
           
            sql += "fName,";
            sql += "fPhone,";
            sql += "fEmail,";
            sql += "fAddress,";
            sql += "fPassword ";

            sql += ")values(";
            sql += "@name,";
            sql += "@phone,";
            sql += "@email,";
            sql += "@address,";
            sql += "@password)";


            List<SqlParameter> sqllist = new List<SqlParameter>();
            sqllist.Add(new SqlParameter("name", txtName.Text));
            sqllist.Add(new SqlParameter("phone", txtPhone.Text));
            sqllist.Add(new SqlParameter("email", txtEmail.Text));
            sqllist.Add(new SqlParameter("address", txtAddress.Text));
            sqllist.Add(new SqlParameter("password", txtPassword.Text));
            execute(sql, sqllist);
            

            MessageBox.Show("新增資料成功");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string sql = "delete from tCustomer where fId = @id";
          

            List<SqlParameter> sqllist = new List<SqlParameter>();
            sqllist.Add(new SqlParameter("id", txtId.Text));
            execute(sql,sqllist);
            MessageBox.Show("刪除資料成功");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            string sql = "update tCustomer set ";
            sql += "fName = @name,";
            sql += "fPhone = @phone,";
            sql += "fEmail = @email,";
            sql += "fAddress = @address,";
            sql += "fPassword = @password ";
            sql += "where fid = @id";

            List<SqlParameter> sqllist = new List<SqlParameter>();
            sqllist.Add(new SqlParameter("name", txtName.Text));
            sqllist.Add(new SqlParameter("phone", txtPhone.Text));
            sqllist.Add(new SqlParameter("email", txtEmail.Text));
            sqllist.Add(new SqlParameter("address", txtAddress.Text));
            sqllist.Add(new SqlParameter("password", txtPassword.Text));
            sqllist.Add(new SqlParameter("id", txtId.Text));
            execute(sql, sqllist);
            MessageBox.Show("修改資料成功");
        }

        
        private void button4_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=dbDemo;Integrated Security=True";
            con.Open();

            string sql = "select * from tCustomer";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            SqlDataReader reader = cmd.ExecuteReader();

            listBox1.Items.Clear();
            while (reader.Read())
            {
                pks.Add((int)reader["fid"]);
                listBox1.Items.Add(reader["fName"].ToString());
               
            }

            con.Close();
            
        }
        public List<int> pks = new List<int>();
        public int a;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void displayBySql(string sql,List <SqlParameter> list)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=dbDemo;Integrated Security=True";
            con.Open();

            
            SqlCommand cmd = new SqlCommand();
            if (list != null) cmd.Parameters.AddRange(list.ToArray());

            cmd.Connection = con;
            cmd.CommandText = sql;
            SqlDataReader reader = cmd.ExecuteReader();


            if (reader.Read())
            {

                txtId.Text = $"{reader["fid"].ToString()}";
                txtName.Text = $"{reader["fname"].ToString()}";
                txtPhone.Text = $"{reader["fPhone"].ToString()}";
                txtEmail.Text = $"{reader["femail"].ToString()}";
                txtAddress.Text = $"{reader["faddress"].ToString()}";
                txtPassword.Text = $"{reader["fpassword"].ToString()}";

            }

            con.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
    
            int i = listBox1.SelectedIndex;     //判斷索引
            int pk = pks[i];
            //MessageBox.Show("" + pks.Count);
            //MessageBox.Show("" + i);
            string sql = "select * from tcustomer where fid = @id";

            List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("id", (object)pk));

            displayBySql(sql, list);



        }

        private void button5_Click(object sender, EventArgs e)  //呼叫查詢得到模糊比對到的完整資料
        {
           

            Frm_keyword fm = new Frm_keyword();
            

            fm.Text = "關鍵字查詢作業";
            fm.ShowDialog();            //會在按完按鈕才有出現下一對話框
            if (fm.isOkButtonClicked) {
                string sql = "select * from tcustomer where fname like @keyword ";
                sql += "or fphone like @keyword ";
                sql += "or femail like @keyword ";
                sql += "or faddress like @keyword ";

                List <SqlParameter> sqllist = new  List <SqlParameter>();
                sqllist.Add(new SqlParameter("keyword","%" + fm.keyword + "%"));

                displayBySql(sql,sqllist);

            } //'%" + fm.keyword + "%'

        }

        private void displayBySql(string sql, SqlParameter sqllist)
        {
            throw new NotImplementedException();
        }
    }
}
