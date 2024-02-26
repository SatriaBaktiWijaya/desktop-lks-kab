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



    public partial class Login : Form
    {
        public static String nama_user = "";
        public static String idrole = "";
        public static int uid = 0;
        SqlCommand cmd;
        SqlDataAdapter da;
        public Login()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelreg.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelreg.Visible = true;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (nama.Text != "" && unameReg.Text != "" && pwReg.Text != "")
            {
                Koneksi.cn.Open();
                cmd = new SqlCommand("INSERT INTO users(nama,uname,pw,id_role) VALUES ('" + nama.Text + "','" + unameReg.Text + "','" + pwReg.Text + "',0)",Koneksi.cn);
                cmd.ExecuteNonQuery();
                Koneksi.cn.Close();
                MessageBox.Show("Anda Berhasil Mendaftar", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nama.Text = "";
                unameReg.Text = "";
                pwReg.Text = "";


            }
            else
            {
                MessageBox.Show("Data Tidak Boleh Ada Yang Kosong", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (unameLog.Text != "" && pwLog.Text != "")
            {
                Koneksi.cn.Open();
                da = new SqlDataAdapter("SELECT * FROM users WHERE uname='" + unameLog.Text + "' AND pw='" + pwLog.Text + "'", Koneksi.cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    if (unameLog.Text == dr["uname"].ToString() && pwLog.Text == dr["pw"].ToString())
                    {
                        nama_user = dr["nama"].ToString();
                        uid = int.Parse(dr["uid"].ToString());
                        idrole = dr["id_role"].ToString();
                        new Splash().Show();
                        this.Hide();


                        MessageBox.Show("Anda Berhasil Login", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                Koneksi.cn.Close();

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
