namespace lks
{
    partial class LihatPetugas
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
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            button2 = new Button();
            uid = new TextBox();
            label3 = new Label();
            button1 = new Button();
            pw = new TextBox();
            label4 = new Label();
            uname = new TextBox();
            Username = new Label();
            nama = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 233);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(914, 437);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellClick += dataGridView1_CellClick_1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(uid);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(pw);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(uname);
            groupBox1.Controls.Add(Username);
            groupBox1.Controls.Add(nama);
            groupBox1.Controls.Add(label1);
            groupBox1.ImeMode = ImeMode.NoControl;
            groupBox1.Location = new Point(974, 233);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(635, 437);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lihat Petugas";
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = Color.Azure;
            button2.Location = new Point(313, 364);
            button2.Name = "button2";
            button2.Size = new Size(117, 39);
            button2.TabIndex = 9;
            button2.Text = "Hapus";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // uid
            // 
            uid.Enabled = false;
            uid.Location = new Point(224, 87);
            uid.Name = "uid";
            uid.Size = new Size(349, 33);
            uid.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 90);
            label3.Name = "label3";
            label3.Size = new Size(30, 24);
            label3.TabIndex = 7;
            label3.Text = "ID";
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.Azure;
            button1.Location = new Point(456, 364);
            button1.Name = "button1";
            button1.Size = new Size(117, 39);
            button1.TabIndex = 6;
            button1.Text = "Simpan";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // pw
            // 
            pw.Location = new Point(224, 285);
            pw.Name = "pw";
            pw.Size = new Size(349, 33);
            pw.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(96, 288);
            label4.Name = "label4";
            label4.Size = new Size(95, 24);
            label4.TabIndex = 4;
            label4.Text = "Password";
            // 
            // uname
            // 
            uname.Location = new Point(224, 219);
            uname.Name = "uname";
            uname.Size = new Size(349, 33);
            uname.TabIndex = 3;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(96, 228);
            Username.Name = "Username";
            Username.Size = new Size(100, 24);
            Username.TabIndex = 2;
            Username.Text = "Username";
            // 
            // nama
            // 
            nama.Location = new Point(224, 156);
            nama.Name = "nama";
            nama.Size = new Size(349, 33);
            nama.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 159);
            label1.Name = "label1";
            label1.Size = new Size(61, 24);
            label1.TabIndex = 0;
            label1.Text = "Nama";
            // 
            // LihatPetugas
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1692, 903);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Font = new Font("Satoshi", 14.25F, FontStyle.Bold);
            Margin = new Padding(5);
            Name = "LihatPetugas";
            Text = "LihatPetugas";
            Load += LihatPetugas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Button button2;
        private TextBox uid;
        private Label label3;
        private Button button1;
        private TextBox pw;
        private Label label4;
        private TextBox uname;
        private Label Username;
        private TextBox nama;
        private Label label1;
    }
}