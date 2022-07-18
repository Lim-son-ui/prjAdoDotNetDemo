using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
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
            refresh();
            //setGridStyle();
        }

        private void Frm_productlist_Load(object sender, EventArgs e)
        {
            refresh();
            setGridStyle();
        }

        SqlCommandBuilder builder = new SqlCommandBuilder();
        SqlDataAdapter adapter;
        private int _position = -1;

        private void refresh()      //要幫他把資料存入datatable
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=dbDemo;Integrated Security=True";
            con.Open();

            adapter = new SqlDataAdapter("select * from tproduct", con);
            builder.DataAdapter = adapter;
            
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            con.Close();


            DataView dv = new DataView();
            dv.Table = ds.Tables[0];
            dataGridView1.DataSource = dv;

           // dataGridView1.DataSource = new DataView(ds.Tables[0]);

            comboBox1.Items.Clear();

            foreach (DataColumn c in ds.Tables[0].Columns)
            {
                comboBox1.Items.Add(c.ColumnName);
            }

            setGridStyle();
        }


        private void setGridStyle()
        {
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 350;
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 300;

            bool iscolochange = false;
            Color bgcolor;

            foreach(DataGridViewRow r in dataGridView1.Rows)
            {
                iscolochange = !iscolochange;
                bgcolor = Color.LightBlue;

                if (iscolochange)
                    bgcolor = Color.WhiteSmoke;

                foreach (DataGridViewCell c in r.Cells)
                    c.Style.BackColor = bgcolor;
            }
        }

        private void btnrenew_Click(object sender, EventArgs e)          //重整
        {
            refresh();
            setGridStyle();
        }

        
        private void btncheck_Click(object sender, EventArgs e)          //查詢
        {

            Frm_keyword f = new Frm_keyword();
            f.Text = "關鍵字查詢作業";
            f.ShowDialog();

            if (f.isOkButtonClicked) {
                setGridStyle();
                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    foreach(DataGridViewCell c in r.Cells)
                    {
                        if (c.Value == null) continue;
                        if (c.Value.ToString().ToUpper().Contains(f.keyword.ToUpper()))
                        {
                            c.Style.BackColor = Color.Yellow;
                        }
                    }
                }
            }

            #region
            //DataTable table = (DataTable)dataGridView1.DataSource;
            //DataTable table1 = (DataTable)dataGridView2.DataSource;
            //string nam = textBox1.Text;

            //DataRow[] rows = table.Select("fname like '%" + nam + "%'");

            //DataRow row;

            //for (int i = 0; i < rows.Length; i++)
            //{
            //    row += table1.Rows[i];
            //    table1.Rows.Add(rows[i]);
            //}


            //DataRow row1 = new DataRow();


            //int id = Convert.ToInt32(nam.ToString());
            //MessageBox.Show("" + id);


            //table.Rows.Add(rows[0]);
            //table1.Rows.Add(rows[0]);


            //for (int i = 0; i < rows.Length; i++)
            //{

            //    label1.Text += rows[i]["fid"].ToString() + " " + rows[i]["fname"].ToString() + "\r\n";
            //}
            #endregion

        }

        private void btninsert_Click(object sender, EventArgs e)         //新增
        {
            Frmproductedit fpd =  new Frmproductedit();


            fpd.ShowDialog();


            if (fpd.isokclicked)
            {

                DataTable table = (DataTable)dataGridView1.DataSource;      //建一個表 在表中實作出一個row
                DataRow row = table.NewRow();
                CProduct p = fpd._cpd;
            
                row["fid"] = p.id;
                row["fname"] = p.name;
                row["fqty"] = p.qty;
                row["fcost"] = p.cost;
                row["fprice"] = p.price;


                table.Rows.Add(row);
                setGridStyle();
            }


        }

        #region
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        #endregion

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)         //紀錄所點擊的位置
        {
            _position = e.RowIndex;
        }

        private void btnupd_Click(object sender, EventArgs e)      //更新
        {

            if (_position < 0) return;
            
            DataTable table = dataGridView1.DataSource as DataTable;
            DataRow row = table.Rows[_position];
            CProduct p = new CProduct()
            {
                id = (int)row["fid"],
                name = row["fname"].ToString(),
                qty = (int)row["fqty"],
                cost = (decimal)row["fcost"],
                price = (decimal)row["fprice"],

            };

            Frmproductedit fpd = new Frmproductedit();
            fpd._cpd =  p;
            fpd.ShowDialog();

            if (!fpd.isokclicked) return;


            row["fid"] = fpd._cpd.id;
            row["fname"] = fpd._cpd.name;
            row["fcost"] = fpd._cpd.cost;
            row["fprice"] = fpd._cpd.price;
            row["fqty"] = fpd._cpd.qty;
        }

        private void btndelete_Click(object sender, EventArgs e)      //刪除
        {
            if (_position < 0) return;

            DataTable table = dataGridView1.DataSource as DataTable;
            DataView table1 = dataGridView1.DataSource as DataView;

            //DataView row1 = table1.Table.Rows[_position];
            DataRow row = table.Rows[_position];
            row.Delete();
            //row.AcceptChanges();
        }

        private void Frm_productlist_FormClosed(object sender, FormClosedEventArgs e)       //關掉時還要連線
        {
            //DataTable table = dataGridView1.DataSource as DataTable;
            //if(table.Rows.Count > 0)  adapter.Update(table);        //要關閉form把更改存入
            ////adapter.Update(table);
            ///

            DataView dv = dataGridView1.DataSource as DataView;         //view 丟入adapter
            if (dv.Count > 0) adapter.Update(dv.Table);
        }
        #region
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region
            //    SqlConnection con = new SqlConnection();
            //    con.ConnectionString = @"Data Source=.;Initial Catalog=dbDemo;Integrated Security=True";
            //    con.Open();

            //    adapter = new SqlDataAdapter("select * from tproduct order by " + comboBox1.Text + " asc ", con);

            //    builder.DataAdapter = adapter;
            //    DataSet ds = new DataSet();
            //    adapter.Fill(ds);
            //    con.Close();
            //    dataGridView1.DataSource = ds.Tables[0];
            //    setGridStyle();
            #endregion   
            //第一種方式

            DataView dv = dataGridView1.DataSource as DataView;  //由小到大排序
            dv.Sort = comboBox1.Text + "desc";
            setGridStyle();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "房型資料檔|*.xml";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //DataSet ds = new DataSet();
                DataView dv = dataGridView1.DataSource as DataView;
                DataTable texport = new DataTable("texport only for hotel.com");
                //dv.Table.WriteXml(saveFileDialog1.FileName);

                texport.Columns.Add("房型");
                texport.Columns.Add("數量");
                texport.Columns.Add("價格");

                foreach(DataRow r in dv.Table.Rows)
                {
                    DataRow row = texport.NewRow();
                    row["房型"] = r["fname"].ToString();
                    row["數量"] = r["fqty"].ToString();
                    decimal price = (decimal)r["fprice"];
                    row["價格"] = (price * 0.95m).ToString();
                    texport.Rows.Add(row);
                }

                texport.WriteXml(saveFileDialog1.FileName);

            }
                
        }
    }
}
