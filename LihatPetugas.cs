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
    public partial class LihatPetugas : Form
    {
        SqlCommand cmd;
        public LihatPetugas()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            uid.Text = dataGridView1[0, i].Value.ToString();
            nama.Text = dataGridView1[1, i].Value.ToString();
            uname.Text = dataGridView1[2, i].Value.ToString();
            pw.Text = dataGridView1[3, i].Value.ToString();


        }

        void display()
        {
            Koneksi.cn.Open();
            cmd = new SqlCommand("SELECT * FROM users WHERE id_role=2", Koneksi.cn);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            Koneksi.cn.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (uid.Text != "" && nama.Text != "" && uname.Text != "" && pw.Text != "")
            {
                Koneksi.cn.Open();
                cmd = new SqlCommand("UPDATE users SET nama='" + nama.Text + "', uname = '" + uname.Text + "', pw = '" + pw.Text + "' WHERE uid ='" + uid.Text + "'", Koneksi.cn);
                cmd.ExecuteNonQuery();
                Koneksi.cn.Close();
                nama.Text = "";
                uname.Text = "";
                uid.Text = "";
                pw.Text = "";
                display();
                MessageBox.Show("Anda Berhasil Mengupdate Data ", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                cmd = new SqlCommand("DELETE FROM users WHERE uid ='" + uid.Text + "'", Koneksi.cn);
                cmd.ExecuteNonQuery();
                Koneksi.cn.Close();
                nama.Text = "";
                uname.Text = "";
                uid.Text = "";
                pw.Text = "";
                display();
                MessageBox.Show("Anda Berhasil Menghapus Data", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Pilih Data Terlebigh Dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void LihatPetugas_Load(object sender, EventArgs e)
        {
            display();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            uid.Text = dataGridView1[0, i].Value.ToString();
            nama.Text = dataGridView1[1, i].Value.ToString();
            uname.Text = dataGridView1[2, i].Value.ToString();
            pw.Text = dataGridView1[3, i].Value.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            if (uid.Text != "")
            {
                Koneksi.cn.Open();
                cmd = new SqlCommand("DELETE FROM users WHERE uid ='" + uid.Text + "'", Koneksi.cn);
                cmd.ExecuteNonQuery();
                Koneksi.cn.Close();
                nama.Text = "";
                uname.Text = "";
                uid.Text = "";
                pw.Text = "";
                display();
                MessageBox.Show("Anda Berhasil Menghapus Data", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Pilih Data Terlebigh Dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (uid.Text != "" && nama.Text != "" && uname.Text != "" && pw.Text != "")
            {
                Koneksi.cn.Open();
                cmd = new SqlCommand("UPDATE users SET nama='" + nama.Text + "', uname = '" + uname.Text + "', pw = '" + pw.Text + "' WHERE uid ='" + uid.Text + "'", Koneksi.cn);
                cmd.ExecuteNonQuery();
                Koneksi.cn.Close();
                nama.Text = "";
                uname.Text = "";
                uid.Text = "";
                pw.Text = "";
                display();
                MessageBox.Show("Anda Berhasil Mengupdate Data ", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Data Tidak Boleh Ada Yang Kosong", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
