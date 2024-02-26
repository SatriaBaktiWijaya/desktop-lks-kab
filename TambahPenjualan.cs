using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lks
{

    public partial class TambahPenjualan : Form
    {
        SqlDataAdapter da;
        SqlCommand cmd;
        int stox = 0;
        int total = 0;
        public TambahPenjualan()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cariuid.Text != "")
            {
                Koneksi.cn.Open();
                da = new SqlDataAdapter("SELECT * FROM users WHERE uid='" + cariuid.Text + "' AND id_role=0", Koneksi.cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        uid.Text = dr["uid"].ToString();
                        namauser.Text = dr["nama"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Data Tidak Ditemukan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                Koneksi.cn.Close();




            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cariidmenu.Text != "")
            {
                Koneksi.cn.Open();
                da = new SqlDataAdapter("SELECT * FROM menu WHERE id_menu ='" + cariidmenu.Text + "'", Koneksi.cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        idmenu.Text = dr["id_menu"].ToString();
                        namamenu.Text = dr["nama_menu"].ToString();
                        stokdata.Text = dr["stok"].ToString();
                        stox = int.Parse(dr["stok"].ToString());
                        harga.Text = dr["harga"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Data Tidak Ditemukan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                Koneksi.cn.Close();

            }
        }



        private void button3_Click(object sender, EventArgs e)
        {

            if (idmenu.Text != "" && namamenu.Text != "" && stok.Text != "" && harga.Text != "")
            {
                if (stox >= int.Parse(stok.Text))
                {
                    Koneksi.cn.Open();
                    cmd = new SqlCommand("UPDATE menu SET stok-='" + stok.Text + "' WHERE id_menu = '" + idmenu.Text + "'", Koneksi.cn);
                    cmd.ExecuteNonQuery();
                    Koneksi.cn.Close();


                    total = int.Parse(stok.Text) * int.Parse(harga.Text);
                    dataGridView1.Rows.Add(idmenu.Text, namamenu.Text, harga.Text, total);
                    idmenu.Text = "";
                    namamenu.Text = "";
                    stokdata.Text = "";
                    harga.Text = "";
                    stok.Text = "";

                }
                else 
                {
                    MessageBox.Show("Stok tidak cukup", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
            else
            {
                MessageBox.Show("Isi Data terlebih dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int grandtotal = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                grandtotal += int.Parse(dataGridView1[3, i].Value.ToString());
            }
            grandtotaltb.Text = grandtotal.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && idpenjualan.Text != "" && uid.Text != "")
            {
                Koneksi.cn.Open();
                cmd = new SqlCommand("INSERT INTO penjualan(id_jual,uid,total_harga,tgl_beli) VALUES ('" + idpenjualan.Text + "','" + uid.Text + "','" + grandtotaltb.Text + "',@date) ", Koneksi.cn);
                cmd.Parameters.Add("@date", SqlDbType.Date).Value = dtp.Text;
                cmd.ExecuteNonQuery();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    cmd = new SqlCommand("INSERT INTO detail_jual(id_jual,id_menu,nama_menu,jumlah,totalharga) VALUES('" + idpenjualan.Text + "','" + dataGridView1[0, i].Value.ToString() + "','" + dataGridView1[1, i].Value.ToString() + "','" + dataGridView1[2, i].Value.ToString() + "','" + dataGridView1[3, i].Value.ToString() + "')", Koneksi.cn);
                    cmd.ExecuteNonQuery();
                }
                Koneksi.cn.Close();
                dataGridView1.Rows.Clear();
                grandtotaltb.Text = "";
                MessageBox.Show("Data Telah Disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else { 
                MessageBox.Show("Isi Data terlebih dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
