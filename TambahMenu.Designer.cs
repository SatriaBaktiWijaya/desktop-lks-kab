﻿namespace lks
{
    partial class TambahMenu
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
            button1 = new Button();
            stok = new TextBox();
            label4 = new Label();
            harga = new TextBox();
            label2 = new Label();
            nama = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(stok);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(harga);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(nama);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(482, 233);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(729, 437);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tambah Menu";
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.Azure;
            button1.Location = new Point(499, 343);
            button1.Name = "button1";
            button1.Size = new Size(117, 39);
            button1.TabIndex = 6;
            button1.Text = "Tambah";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // stok
            // 
            stok.Location = new Point(267, 265);
            stok.Name = "stok";
            stok.Size = new Size(349, 33);
            stok.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(164, 268);
            label4.Name = "label4";
            label4.Size = new Size(48, 24);
            label4.TabIndex = 4;
            label4.Text = "Stok";
            // 
            // harga
            // 
            harga.Location = new Point(267, 193);
            harga.Name = "harga";
            harga.Size = new Size(349, 33);
            harga.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 193);
            label2.Name = "label2";
            label2.Size = new Size(63, 24);
            label2.TabIndex = 2;
            label2.Text = "Harga";
            // 
            // nama
            // 
            nama.Location = new Point(267, 121);
            nama.Name = "nama";
            nama.Size = new Size(349, 33);
            nama.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(164, 124);
            label1.Name = "label1";
            label1.Size = new Size(61, 24);
            label1.TabIndex = 0;
            label1.Text = "Nama";
            // 
            // TambahMenu
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1692, 903);
            Controls.Add(groupBox1);
            Font = new Font("Satoshi", 14.25F, FontStyle.Bold);
            Margin = new Padding(5);
            Name = "TambahMenu";
            Text = "TambahMenu";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private TextBox stok;
        private Label label4;
        private TextBox harga;
        private Label label2;
        private TextBox nama;
        private Label label1;
    }
}