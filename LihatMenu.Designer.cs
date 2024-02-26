namespace lks
{
    partial class LihatMenu
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
            stok = new TextBox();
            label4 = new Label();
            harga = new TextBox();
            Username = new Label();
            namamenu = new TextBox();
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
            dataGridView1.TabIndex = 8;
            dataGridView1.CellClick += dataGridView1_CellClick_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(uid);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(stok);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(harga);
            groupBox1.Controls.Add(Username);
            groupBox1.Controls.Add(namamenu);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(974, 233);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(635, 437);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lihat Menu";
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
            // stok
            // 
            stok.Location = new Point(224, 285);
            stok.Name = "stok";
            stok.Size = new Size(349, 33);
            stok.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(96, 288);
            label4.Name = "label4";
            label4.Size = new Size(48, 24);
            label4.TabIndex = 4;
            label4.Text = "Stok";
            // 
            // harga
            // 
            harga.Location = new Point(224, 219);
            harga.Name = "harga";
            harga.Size = new Size(349, 33);
            harga.TabIndex = 3;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(96, 228);
            Username.Name = "Username";
            Username.Size = new Size(63, 24);
            Username.TabIndex = 2;
            Username.Text = "Harga";
            // 
            // namamenu
            // 
            namamenu.Location = new Point(224, 156);
            namamenu.Name = "namamenu";
            namamenu.Size = new Size(349, 33);
            namamenu.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 159);
            label1.Name = "label1";
            label1.Size = new Size(116, 24);
            label1.TabIndex = 0;
            label1.Text = "Nama Menu";
            // 
            // LihatMenu
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1692, 903);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Font = new Font("Satoshi", 14.25F, FontStyle.Bold);
            Margin = new Padding(5);
            Name = "LihatMenu";
            Text = "LihatMenu";
            Load += LihatMenu_Load;
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
        private TextBox stok;
        private Label label4;
        private TextBox harga;
        private Label Username;
        private TextBox namamenu;
        private Label label1;
    }
}