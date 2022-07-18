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

namespace prjHotelDotCompApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "房型資料檔|*.xml";

            if(openFileDialog1.ShowDialog()  == DialogResult.OK)
            {
                DataSet ds = new DataSet();
                ds.ReadXml(openFileDialog1.FileName);
                dataGridView1.DataSource = ds.Tables[0];

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=dbDemo;Integrated Security=True";
            con.Open();

            SqlTransaction t = con.BeginTransaction();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.Transaction = t;

            try {
                cmd.CommandText = "insert into tcustomer(fname,fphone,femail,faddress,fpassword) values ('hello','02','hello@gmail.com','taipei','123546')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into tcustomer(fname,fphone,femail,faddress,fpassword) values ('hi','02','hello@gmail.com','taipei','546879')";
                cmd.ExecuteNonQuery();
                t.Commit();
                MessageBox.Show("新增資料成功");
            }

            catch{
                MessageBox.Show("新增資料失敗");
                t.Rollback();
            }

            finally{
                con.Close();
            }
        }
    }
}
