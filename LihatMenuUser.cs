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

namespace lks
{
    public partial class LihatMenuUser : Form
    {
        SqlCommand cmd;
        public LihatMenuUser()
        {
            InitializeComponent();
        }

        private void LihatMenuUser_Load(object sender, EventArgs e)
        {
            Koneksi.cn.Open();
            cmd = new SqlCommand("SELECT * FROM menu", Koneksi.cn);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            Koneksi.cn.Close();
            dataGridView1.DataSource = dt;  
        }
    }
}
