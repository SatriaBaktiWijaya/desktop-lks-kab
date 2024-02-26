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
    public partial class TambahMenu : Form
    {
        SqlCommand cmd;
        public TambahMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nama.Text != "" && harga.Text != "" && stok.Text != "")
            {
                Koneksi.cn.Open();
                try {
                    cmd = new SqlCommand("INSERT INTO menu(nama_menu,harga,stok) VALUES ('" + nama.Text + "','" + harga.Text + "','" + stok.Text + "')", Koneksi.cn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Anda Berhasil Menambahkan Data", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch {
                    MessageBox.Show("Data yang Anda masukkan Tidak Sesuai", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Koneksi.cn.Close();
                nama.Text = "";
                harga.Text = "";
                stok.Text = "";
            }
            else
            {
                MessageBox.Show("Data Tidak Boleh Ada Yang Kosong", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
