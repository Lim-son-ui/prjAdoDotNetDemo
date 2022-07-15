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
    public partial class Frm_keyword : Form
    {
        public Frm_keyword()
        {
            InitializeComponent();
        }
        bool _isOkClick = false;        

        public string keyword           //屬性    回傳這頁所輸入要查詢的部分關鍵字
        {
            get { return textBox1.Text;  }
            set { textBox1.Text = value; }
        }

        public bool isOkButtonClicked   //屬性 
        {
            get { return _isOkClick; }
        }
        private void button2_Click(object sender, EventArgs e)      //確定按鈕
        {
            _isOkClick = true;
            Close();

        }

        private void button1_Click(object sender, EventArgs e)      //取消按鈕
        {
            Close();
        }
    }
}
