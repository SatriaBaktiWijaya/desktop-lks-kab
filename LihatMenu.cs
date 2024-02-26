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
    public partial class LihatMenu : Form
    {
        SqlCommand cmd;
        public LihatMenu()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            uid.Text = dataGridView1[0, i].Value.ToString();
            namamenu.Text = dataGridView1[1, i].Value.ToString();
            harga.Text = dataGridView1[2, i].Value.ToString();
            stok.Text = dataGridView1[3, i].Value.ToString();


        }

        void display()
        {
            Koneksi.cn.Open();
            cmd = new SqlCommand("SELECT * FROM menu", Koneksi.cn);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            Koneksi.cn.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (uid.Text != "" && namamenu.Text != "" && harga.Text != "" && stok.Text != "")
            {
                Koneksi.cn.Open();
                try
                {
                    cmd = new SqlCommand("UPDATE menu SET nama_menu='" + namamenu.Text + "', harga = '" + harga.Text + "', stok = '" + stok.Text + "' WHERE id_menu ='" + uid.Text + "'", Koneksi.cn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Anda Berhasil Mengupdate Data ", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Data Tidak Sesuai", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                Koneksi.cn.Close();
                namamenu.Text = "";
                harga.Text = "";
                uid.Text = "";
                stok.Text = "";
                display();


            }
            else
            {
                MessageBox.Show("Data Tidak Boleh Ada Yang Kosong", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (uid.Text != "")
            {
                Koneksi.cn.Open();
                cmd = new SqlCommand("DELETE FROM menu WHERE id_menu ='" + uid.Text + "'", Koneksi.cn);
                cmd.ExecuteNonQuery();
                Koneksi.cn.Close();
                namamenu.Text = "";
                harga.Text = "";
                uid.Text = "";
                stok.Text = "";
                display();
                MessageBox.Show("Anda Berhasil Menghapus Data", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Pilih Data Terlebih Dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void LihatMenu_Load(object sender, EventArgs e)
        {
            display();

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            uid.Text = dataGridView1[0, i].Value.ToString();
            namamenu.Text = dataGridView1[1, i].Value.ToString();
            harga.Text = dataGridView1[2, i].Value.ToString();
            stok.Text = dataGridView1[3, i].Value.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (uid.Text != "" && namamenu.Text != "" && harga.Text != "" && stok.Text != "")
            {
                Koneksi.cn.Open();
                try
                {
                    cmd = new SqlCommand("UPDATE menu SET nama_menu='" + namamenu.Text + "', harga = '" + harga.Text + "', stok = '" + stok.Text + "' WHERE id_menu ='" + uid.Text + "'", Koneksi.cn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Anda Berhasil Mengupdate Data ", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Data Tidak Sesuai", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                Koneksi.cn.Close();
                namamenu.Text = "";
                harga.Text = "";
                uid.Text = "";
                stok.Text = "";
                display();


            }
            else
            {
                MessageBox.Show("Data Tidak Boleh Ada Yang Kosong", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (uid.Text != "")
            {
                Koneksi.cn.Open();
                cmd = new SqlCommand("DELETE FROM menu WHERE id_menu ='" + uid.Text + "'", Koneksi.cn);
                cmd.ExecuteNonQuery();
                Koneksi.cn.Close();
                namamenu.Text = "";
                harga.Text = "";
                uid.Text = "";
                stok.Text = "";
                display();
                MessageBox.Show("Anda Berhasil Menghapus Data", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Pilih Data Terlebih Dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
