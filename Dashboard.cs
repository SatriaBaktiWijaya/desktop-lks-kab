using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lks
{
    public partial class Dashboard : Form
    {
        public Dashboard(string role)
        {
            InitializeComponent();
            if (role == "Admin")
            {
                paneluser.Visible = false;
            }
            else if (role == "Petugas")
            {
                paneluser.Visible = false;
                button4.Visible = false;
                panelmasterpetugas.Visible = false;
                panelMaster.Height = 326;
            }
            else
            {
                panelMaster.Visible = false;
                panelaktifitas.Visible = false;
            }
        }

        void FormLoad(Form form)
        {
            panelLoad.Controls.Clear();
            form.TopMost = true;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelLoad.Controls.Add(form);
            form.Show();
            label3.Text = form.Text;


        }

        private void button15_Click(object sender, EventArgs e)
        {
            FormLoad(new LapPenjualan());

        }

        private void panelaktifitas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString("T");
            label1.Text = DateTime.Now.ToString("D");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormLoad(new TambahUser());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormLoad(new LihatUser());

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormLoad(new TambahPetugas());

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormLoad(new LihatPetugas());

        }

        private void button9_Click(object sender, EventArgs e)
        {
            FormLoad(new TambahMenu());

        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormLoad(new LihatMenu());

        }

        private void button18_Click(object sender, EventArgs e)
        {
            FormLoad(new TambahPenjualan());

        }

        private void button12_Click(object sender, EventArgs e)
        {
            FormLoad(new LihatMenuUser());

        }

        private void button11_Click(object sender, EventArgs e)
        {
            FormLoad(new LapPenjualanUser());

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            FormLoad(new Home());

            timer1.Start();
            label5.Text = Login.nama_user;
            

        }

        private void Home_Click(object sender, EventArgs e)
        {
            FormLoad(new Home());

        }

        private void panelLoad_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
            Login.nama_user = "";
            Login.idrole = "";
            Login.uid = 0;
        }
    }
}
