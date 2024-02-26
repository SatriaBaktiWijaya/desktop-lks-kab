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
    public partial class LapPenjualan : Form
    {
        SqlDataAdapter da;
        SqlCommand cmd;
        int idjual =0, uid = 0, totalharga = 0;
            String nama ="", tglbeli="";
        public LapPenjualan()
        {
            InitializeComponent();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            display();
        }
        void display()
        {
            Koneksi.cn.Open();
            cmd = new SqlCommand("SELECT * FROM penjualan", Koneksi.cn);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            Koneksi.cn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Koneksi.cn.Open();
            cmd = new SqlCommand("SELECT * FROM penjualan WHERE tgl_beli BETWEEN '" + dtp1.Value.ToString("yyyy-MM-dd") + "' AND'" + dtp2.Value.ToString("yyyy-MM-dd") + "' ", Koneksi.cn);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            Koneksi.cn.Close();
        }

        private void LapPenjualan_Load(object sender, EventArgs e)
        {
            display();
        }

        private void dtp1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            
            idjual = int.Parse(dataGridView1[0,i].Value.ToString());
            uid = int.Parse(dataGridView1[1, i].Value.ToString());
            totalharga = int.Parse(dataGridView1[2, i].Value.ToString());
            tglbeli = dataGridView1[3, i].Value.ToString();
            Koneksi.cn.Open();
            da = new SqlDataAdapter("SELECT * FROM users WHERE uid ='" + uid.ToString() + "'", Koneksi.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    nama = dr["nama"].ToString();
                }
            }
            MessageBox.Show("Nama Pelanggan : " + nama.ToString() +"\n"+
                "Nomer Nota : " + idjual.ToString() + "\n" +
                "Id Pelanggan : " + uid.ToString() +"\n" +
                "Total Harga : IDR." + totalharga.ToString() + "\n" +
                "Tanggal Transaksi : " + tglbeli.ToString(),"Nota",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Koneksi.cn.Close();



        }
    }
}
