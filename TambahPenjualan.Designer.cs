namespace lks
{
    partial class TambahPenjualan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            button2 = new Button();
            namauser = new TextBox();
            label3 = new Label();
            uid = new TextBox();
            label2 = new Label();
            cariuid = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label5 = new Label();
            dtp = new DateTimePicker();
            textBox1 = new TextBox();
            label4 = new Label();
            idpenjualan = new TextBox();
            label6 = new Label();
            groupBox3 = new GroupBox();
            button3 = new Button();
            stokdata = new Label();
            stok = new TextBox();
            label10 = new Label();
            harga = new TextBox();
            label7 = new Label();
            button1 = new Button();
            idmenu = new TextBox();
            namamenu = new TextBox();
            label8 = new Label();
            cariidmenu = new TextBox();
            label9 = new Label();
            dataGridView1 = new DataGridView();
            idmenutbl = new DataGridViewTextBoxColumn();
            namamenutbl = new DataGridViewTextBoxColumn();
            jumlahtbl = new DataGridViewTextBoxColumn();
            totaltbl = new DataGridViewTextBoxColumn();
            button4 = new Button();
            grandtotaltb = new TextBox();
            label12 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(namauser);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(uid);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cariuid);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(297, 11);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(275, 272);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "User";
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = Color.Azure;
            button2.Location = new Point(108, 60);
            button2.Name = "button2";
            button2.Size = new Size(146, 30);
            button2.TabIndex = 10;
            button2.Text = "Cari";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // namauser
            // 
            namauser.Enabled = false;
            namauser.Location = new Point(108, 156);
            namauser.Margin = new Padding(3, 2, 3, 2);
            namauser.Name = "namauser";
            namauser.Size = new Size(146, 29);
            namauser.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 159);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 4;
            label3.Text = "Nama User";
            // 
            // uid
            // 
            uid.Enabled = false;
            uid.Location = new Point(108, 123);
            uid.Margin = new Padding(3, 2, 3, 2);
            uid.Name = "uid";
            uid.Size = new Size(146, 29);
            uid.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 126);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 2;
            label2.Text = "ID User";
            // 
            // cariuid
            // 
            cariuid.Location = new Point(108, 26);
            cariuid.Margin = new Padding(3, 2, 3, 2);
            cariuid.Name = "cariuid";
            cariuid.Size = new Size(146, 29);
            cariuid.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 30);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 0;
            label1.Text = "Cari ID ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(dtp);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(idpenjualan);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(590, 12);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(325, 271);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Penjualan";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 68);
            label5.Name = "label5";
            label5.Size = new Size(140, 20);
            label5.TabIndex = 7;
            label5.Text = "Tanggal Transaksi";
            // 
            // dtp
            // 
            dtp.Format = DateTimePickerFormat.Short;
            dtp.Location = new Point(164, 62);
            dtp.Name = "dtp";
            dtp.Size = new Size(146, 29);
            dtp.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(164, 155);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(146, 29);
            textBox1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 158);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 4;
            label4.Text = "Nama Petugas";
            // 
            // idpenjualan
            // 
            idpenjualan.Location = new Point(164, 26);
            idpenjualan.Margin = new Padding(3, 2, 3, 2);
            idpenjualan.Name = "idpenjualan";
            idpenjualan.Size = new Size(146, 29);
            idpenjualan.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 29);
            label6.Name = "label6";
            label6.Size = new Size(102, 20);
            label6.TabIndex = 0;
            label6.Text = "ID Penjualan";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(stokdata);
            groupBox3.Controls.Add(stok);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(harga);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(idmenu);
            groupBox3.Controls.Add(namamenu);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(cariidmenu);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(933, 12);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(325, 271);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Penjualan";
            // 
            // button3
            // 
            button3.BackColor = Color.SteelBlue;
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatStyle = FlatStyle.Popup;
            button3.ForeColor = Color.Azure;
            button3.Location = new Point(11, 219);
            button3.Name = "button3";
            button3.Size = new Size(299, 30);
            button3.TabIndex = 17;
            button3.Text = "Tambah";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // stokdata
            // 
            stokdata.AutoSize = true;
            stokdata.Location = new Point(231, 149);
            stokdata.Name = "stokdata";
            stokdata.Size = new Size(31, 20);
            stokdata.TabIndex = 16;
            stokdata.Text = "/ 0";
            // 
            // stok
            // 
            stok.Location = new Point(164, 146);
            stok.Margin = new Padding(3, 2, 3, 2);
            stok.Name = "stok";
            stok.Size = new Size(61, 29);
            stok.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(11, 149);
            label10.Name = "label10";
            label10.Size = new Size(42, 20);
            label10.TabIndex = 14;
            label10.Text = "Stok";
            // 
            // harga
            // 
            harga.Enabled = false;
            harga.Location = new Point(164, 185);
            harga.Margin = new Padding(3, 2, 3, 2);
            harga.Name = "harga";
            harga.Size = new Size(146, 29);
            harga.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 188);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 12;
            label7.Text = "Harga";
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.Azure;
            button1.Location = new Point(164, 61);
            button1.Name = "button1";
            button1.Size = new Size(146, 30);
            button1.TabIndex = 11;
            button1.Text = "Cari";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // idmenu
            // 
            idmenu.Enabled = false;
            idmenu.Location = new Point(11, 59);
            idmenu.Margin = new Padding(3, 2, 3, 2);
            idmenu.Name = "idmenu";
            idmenu.Size = new Size(128, 29);
            idmenu.TabIndex = 7;
            idmenu.Visible = false;
            // 
            // namamenu
            // 
            namamenu.Enabled = false;
            namamenu.Location = new Point(164, 104);
            namamenu.Margin = new Padding(3, 2, 3, 2);
            namamenu.Name = "namamenu";
            namamenu.Size = new Size(146, 29);
            namamenu.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 107);
            label8.Name = "label8";
            label8.Size = new Size(98, 20);
            label8.TabIndex = 4;
            label8.Text = "Nama Menu";
            // 
            // cariidmenu
            // 
            cariidmenu.Location = new Point(164, 25);
            cariidmenu.Margin = new Padding(3, 2, 3, 2);
            cariidmenu.Name = "cariidmenu";
            cariidmenu.Size = new Size(146, 29);
            cariidmenu.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(11, 28);
            label9.Name = "label9";
            label9.Size = new Size(71, 20);
            label9.TabIndex = 0;
            label9.Text = "ID Menu";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idmenutbl, namamenutbl, jumlahtbl, totaltbl });
            dataGridView1.Location = new Point(298, 288);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(960, 422);
            dataGridView1.TabIndex = 13;
            dataGridView1.RowsAdded += dataGridView1_RowsAdded;
            // 
            // idmenutbl
            // 
            idmenutbl.HeaderText = "ID Menu";
            idmenutbl.Name = "idmenutbl";
            idmenutbl.ReadOnly = true;
            // 
            // namamenutbl
            // 
            namamenutbl.HeaderText = "Nama Menu";
            namamenutbl.Name = "namamenutbl";
            namamenutbl.ReadOnly = true;
            // 
            // jumlahtbl
            // 
            jumlahtbl.HeaderText = "Jumlah";
            jumlahtbl.Name = "jumlahtbl";
            jumlahtbl.ReadOnly = true;
            // 
            // totaltbl
            // 
            totaltbl.HeaderText = "Total";
            totaltbl.Name = "totaltbl";
            totaltbl.ReadOnly = true;
            // 
            // button4
            // 
            button4.BackColor = Color.SteelBlue;
            button4.FlatAppearance.BorderSize = 2;
            button4.FlatStyle = FlatStyle.Popup;
            button4.ForeColor = Color.Azure;
            button4.Location = new Point(959, 764);
            button4.Name = "button4";
            button4.Size = new Size(299, 30);
            button4.TabIndex = 18;
            button4.Text = "Simpan";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // grandtotaltb
            // 
            grandtotaltb.Enabled = false;
            grandtotaltb.Location = new Point(1112, 728);
            grandtotaltb.Margin = new Padding(3, 2, 3, 2);
            grandtotaltb.Name = "grandtotaltb";
            grandtotaltb.Size = new Size(146, 29);
            grandtotaltb.TabIndex = 20;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(959, 731);
            label12.Name = "label12";
            label12.Size = new Size(95, 20);
            label12.TabIndex = 19;
            label12.Text = "Total Harga";
            // 
            // TambahPenjualan
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1538, 805);
            Controls.Add(grandtotaltb);
            Controls.Add(label12);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Satoshi", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "TambahPenjualan";
            Text = "TambahPenjualan";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox namauser;
        private Label label3;
        private TextBox uid;
        private Label label2;
        private TextBox cariuid;
        private Label label1;
        private Button button2;
        private GroupBox groupBox2;
        private Label label5;
        private DateTimePicker dtp;
        private TextBox textBox1;
        private Label label4;
        private TextBox idpenjualan;
        private Label label6;
        private GroupBox groupBox3;
        private Button button1;
        private TextBox idmenu;
        private TextBox namamenu;
        private Label label8;
        private TextBox cariidmenu;
        private Label label9;
        private Button button3;
        private Label stokdata;
        private TextBox stok;
        private Label label10;
        private TextBox harga;
        private Label label7;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idmenutbl;
        private DataGridViewTextBoxColumn namamenutbl;
        private DataGridViewTextBoxColumn jumlahtbl;
        private DataGridViewTextBoxColumn totaltbl;
        private Button button4;
        private TextBox grandtotaltb;
        private Label label12;
    }
}