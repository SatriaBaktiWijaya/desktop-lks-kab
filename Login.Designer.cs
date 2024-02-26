namespace lks
{
    partial class Login
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
            panel1 = new Panel();
            label10 = new Label();
            panelreg = new Panel();
            nama = new TextBox();
            label9 = new Label();
            button3 = new Button();
            button4 = new Button();
            pwReg = new TextBox();
            label6 = new Label();
            unameReg = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            panellog = new Panel();
            button2 = new Button();
            button1 = new Button();
            pwLog = new TextBox();
            label3 = new Label();
            unameLog = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panelreg.SuspendLayout();
            panellog.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Azure;
            panel1.Controls.Add(label10);
            panel1.Controls.Add(panelreg);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panellog);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Satoshi", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(753, 0);
            label10.Name = "label10";
            label10.Size = new Size(23, 24);
            label10.TabIndex = 7;
            label10.Text = "X";
            label10.Click += label10_Click;
            // 
            // panelreg
            // 
            panelreg.BackColor = Color.LightCyan;
            panelreg.Controls.Add(nama);
            panelreg.Controls.Add(label9);
            panelreg.Controls.Add(button3);
            panelreg.Controls.Add(button4);
            panelreg.Controls.Add(pwReg);
            panelreg.Controls.Add(label6);
            panelreg.Controls.Add(unameReg);
            panelreg.Controls.Add(label7);
            panelreg.Controls.Add(label8);
            panelreg.Font = new Font("Satoshi", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelreg.Location = new Point(380, 25);
            panelreg.Name = "panelreg";
            panelreg.Size = new Size(361, 373);
            panelreg.TabIndex = 7;
            panelreg.Visible = false;
            // 
            // nama
            // 
            nama.Font = new Font("Satoshi", 14.25F, FontStyle.Bold);
            nama.Location = new Point(159, 110);
            nama.Name = "nama";
            nama.Size = new Size(166, 33);
            nama.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Satoshi", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(33, 113);
            label9.Name = "label9";
            label9.Size = new Size(61, 24);
            label9.TabIndex = 7;
            label9.Text = "Nama";
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Satoshi", 14.25F, FontStyle.Bold);
            button3.Location = new Point(35, 314);
            button3.Name = "button3";
            button3.Size = new Size(100, 32);
            button3.TabIndex = 6;
            button3.Text = "Login";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Satoshi", 14.25F, FontStyle.Bold);
            button4.Location = new Point(225, 314);
            button4.Name = "button4";
            button4.Size = new Size(100, 32);
            button4.TabIndex = 5;
            button4.Text = "Register";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // pwReg
            // 
            pwReg.Font = new Font("Satoshi", 14.25F, FontStyle.Bold);
            pwReg.Location = new Point(159, 223);
            pwReg.Name = "pwReg";
            pwReg.Size = new Size(166, 33);
            pwReg.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Satoshi", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(35, 226);
            label6.Name = "label6";
            label6.Size = new Size(95, 24);
            label6.TabIndex = 3;
            label6.Text = "Password";
            // 
            // unameReg
            // 
            unameReg.Font = new Font("Satoshi", 14.25F, FontStyle.Bold);
            unameReg.Location = new Point(160, 167);
            unameReg.Name = "unameReg";
            unameReg.Size = new Size(166, 33);
            unameReg.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Satoshi", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(34, 170);
            label7.Name = "label7";
            label7.Size = new Size(100, 24);
            label7.TabIndex = 1;
            label7.Text = "Username";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Satoshi", 20.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(140, 30);
            label8.Name = "label8";
            label8.Size = new Size(119, 34);
            label8.TabIndex = 0;
            label8.Text = "Register";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Satoshi", 150F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(-94, 212);
            label5.Name = "label5";
            label5.Size = new Size(359, 250);
            label5.TabIndex = 2;
            label5.Text = "☕";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Satoshi", 20.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(94, 56);
            label4.Name = "label4";
            label4.Size = new Size(150, 34);
            label4.TabIndex = 1;
            label4.Text = "Kedai Kopi";
            label4.Click += label4_Click;
            // 
            // panellog
            // 
            panellog.BackColor = Color.LightCyan;
            panellog.Controls.Add(button2);
            panellog.Controls.Add(button1);
            panellog.Controls.Add(pwLog);
            panellog.Controls.Add(label3);
            panellog.Controls.Add(unameLog);
            panellog.Controls.Add(label2);
            panellog.Controls.Add(label1);
            panellog.Font = new Font("Satoshi", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panellog.Location = new Point(380, 26);
            panellog.Name = "panellog";
            panellog.Size = new Size(361, 373);
            panellog.TabIndex = 0;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Satoshi", 14.25F, FontStyle.Bold);
            button2.Location = new Point(225, 311);
            button2.Name = "button2";
            button2.Size = new Size(100, 32);
            button2.TabIndex = 6;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Satoshi", 14.25F, FontStyle.Bold);
            button1.Location = new Point(34, 311);
            button1.Name = "button1";
            button1.Size = new Size(100, 32);
            button1.TabIndex = 5;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pwLog
            // 
            pwLog.Font = new Font("Satoshi", 14.25F, FontStyle.Bold);
            pwLog.Location = new Point(159, 190);
            pwLog.Name = "pwLog";
            pwLog.Size = new Size(166, 33);
            pwLog.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Satoshi", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 193);
            label3.Name = "label3";
            label3.Size = new Size(95, 24);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // unameLog
            // 
            unameLog.Font = new Font("Satoshi", 14.25F, FontStyle.Bold);
            unameLog.Location = new Point(159, 131);
            unameLog.Name = "unameLog";
            unameLog.Size = new Size(166, 33);
            unameLog.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Satoshi", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 134);
            label2.Name = "label2";
            label2.Size = new Size(100, 24);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Satoshi", 20.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(140, 30);
            label1.Name = "label1";
            label1.Size = new Size(86, 34);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelreg.ResumeLayout(false);
            panelreg.PerformLayout();
            panellog.ResumeLayout(false);
            panellog.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panellog;
        private TextBox pwLog;
        private Label label3;
        private TextBox unameLog;
        private Label label2;
        private Label label1;
        private Panel panelreg;
        private TextBox nama;
        private Label label9;
        private Button button3;
        private Button button4;
        private TextBox pwReg;
        private Label label6;
        private TextBox unameReg;
        private Label label7;
        private Label label8;
        private Label label5;
        private Label label4;
        private Button button2;
        private Button button1;
        private Label label10;
    }
}