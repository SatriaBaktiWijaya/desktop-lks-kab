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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            panel1.Width = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (panel1.Width <= 776)
            {
                panel1.Width += 25;

            }
            else
            {
                timer1.Stop();
                if (Login.idrole == "0")
                {
                    new Dashboard("user").Show();
                }
                else if (Login.idrole == "2")
                {
                    new Dashboard("Petugas").Show();
                }
                else
                {
                    new Dashboard("Admin").Show();
                }


            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label4.Text = "Halo, " + Login.nama_user;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
