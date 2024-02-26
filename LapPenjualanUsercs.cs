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
    public partial class LapPenjualanUser : Form
    {
        SqlCommand cmd;
        public LapPenjualanUser()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            display();
        }
        void display()
        {
            Koneksi.cn.Open();
            cmd = new SqlCommand("SELECT * FROM penjualan WHERE uid='" + Login.uid + "'", Koneksi.cn);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            Koneksi.cn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Koneksi.cn.Open();
            cmd = new SqlCommand("SELECT * FROM penjualan WHERE tgl_beli BETWEEN '" + dtp1.Value.ToString("yyyy-MM-dd") + "' AND'" + dtp2.Value.ToString("yyyy-MM-dd") + "' AND uid='" + Login.uid + "'", Koneksi.cn);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;

            Koneksi.cn.Close();
        }
        private void LapPenjualanUsercs_Load(object sender, EventArgs e)
        {
            display();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
