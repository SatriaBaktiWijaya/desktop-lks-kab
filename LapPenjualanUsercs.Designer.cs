namespace lks
{
    partial class LapPenjualanUser
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
            button1 = new Button();
            dtp2 = new DateTimePicker();
            label2 = new Label();
            dtp1 = new DateTimePicker();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dtp2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dtp1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(362, 167);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(968, 568);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Laporan Penjualan";
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = Color.Azure;
            button2.Location = new Point(679, 57);
            button2.Name = "button2";
            button2.Size = new Size(117, 39);
            button2.TabIndex = 8;
            button2.Text = "Cari";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.Azure;
            button1.Location = new Point(812, 57);
            button1.Name = "button1";
            button1.Size = new Size(117, 39);
            button1.TabIndex = 7;
            button1.Text = "Show All";
            button1.UseVisualStyleBackColor = false;
            // 
            // dtp2
            // 
            dtp2.Format = DateTimePickerFormat.Short;
            dtp2.Location = new Point(476, 60);
            dtp2.Name = "dtp2";
            dtp2.Size = new Size(153, 33);
            dtp2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(434, 64);
            label2.Name = "label2";
            label2.Size = new Size(43, 24);
            label2.TabIndex = 3;
            label2.Text = "S/D";
            // 
            // dtp1
            // 
            dtp1.Format = DateTimePickerFormat.Short;
            dtp1.Location = new Point(277, 60);
            dtp1.Name = "dtp1";
            dtp1.Size = new Size(153, 33);
            dtp1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 64);
            label1.Name = "label1";
            label1.Size = new Size(234, 24);
            label1.TabIndex = 1;
            label1.Text = "Cari Berdasarkan Tanggal";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(37, 105);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(892, 428);
            dataGridView1.TabIndex = 0;
            // 
            // LapPenjualanUser
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1692, 903);
            Controls.Add(groupBox1);
            Font = new Font("Satoshi", 14.25F, FontStyle.Bold);
            Margin = new Padding(5);
            Name = "LapPenjualanUser";
            Text = "LapPenjualanUsercs";
            Load += LapPenjualanUsercs_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button2;
        private Button button1;
        private DateTimePicker dtp2;
        private Label label2;
        private DateTimePicker dtp1;
        private Label label1;
        private DataGridView dataGridView1;
    }
}