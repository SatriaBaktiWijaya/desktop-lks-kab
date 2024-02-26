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
    public partial class TambahUser : Form
    {
        SqlCommand cmd;
        public TambahUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nama.Text != "" && uname.Text != "" && pw.Text != "" ) {
                Koneksi.cn.Open();
                cmd = new SqlCommand("INSERT INTO users(nama,uname,pw,id_role) VALUES ('" + nama.Text + "','" + uname.Text + "','" + pw.Text + "',0)",Koneksi.cn);
                cmd.ExecuteNonQuery();
                Koneksi.cn.Close();
                MessageBox.Show("Anda Berhasil Menambahkan Data", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nama.Text = "";
                uname.Text = "";
                pw.Text = "";
            }
            else
            {
                MessageBox.Show("Data Tidak Boleh Ada Yang Kosong", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
