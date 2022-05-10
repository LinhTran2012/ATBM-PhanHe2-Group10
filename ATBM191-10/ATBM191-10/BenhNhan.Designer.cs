

namespace ATBM191_10
{
    partial class f_BenhNhan
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
            this.header_panel = new System.Windows.Forms.Panel();
            this.btn_dangxuat = new System.Windows.Forms.Button();
            this.lb_name = new System.Windows.Forms.Label();
            this.tab_thongtincanhan = new System.Windows.Forms.TabPage();
            this.cb_csyt = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_sonha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_tenduong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_mabn = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_ngaysinh = new System.Windows.Forms.TextBox();
            this.btn_capnhatthongtin = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cmnd = new System.Windows.Forms.TextBox();
            this.tabcontrol1 = new System.Windows.Forms.TabControl();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_quanhuyen = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_tinhtp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tiensubenh = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_tiensubenhgd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_diungthuoc = new System.Windows.Forms.TextBox();
            this.header_panel.SuspendLayout();
            this.tab_thongtincanhan.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabcontrol1.SuspendLayout();
            this.SuspendLayout();
            // 
            // header_panel
            // 
            this.header_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.header_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.header_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.header_panel.Controls.Add(this.btn_dangxuat);
            this.header_panel.Controls.Add(this.lb_name);
            this.header_panel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header_panel.Location = new System.Drawing.Point(0, 4);
            this.header_panel.Name = "header_panel";
            this.header_panel.Size = new System.Drawing.Size(833, 40);
            this.header_panel.TabIndex = 11;
            // 
            // btn_dangxuat
            // 
            this.btn_dangxuat.AutoSize = true;
            this.btn_dangxuat.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangxuat.Location = new System.Drawing.Point(739, 5);
            this.btn_dangxuat.Name = "btn_dangxuat";
            this.btn_dangxuat.Size = new System.Drawing.Size(82, 30);
            this.btn_dangxuat.TabIndex = 1;
            this.btn_dangxuat.Text = "Đăng xuất";
            this.btn_dangxuat.UseVisualStyleBackColor = true;
            this.btn_dangxuat.Click += new System.EventHandler(this.btn_dangxuat_Click_1);
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.ForeColor = System.Drawing.Color.White;
            this.lb_name.Location = new System.Drawing.Point(48, 8);
            this.lb_name.Margin = new System.Windows.Forms.Padding(70, 0, 3, 0);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(152, 25);
            this.lb_name.TabIndex = 0;
            this.lb_name.Text = "Nguyễn Văn A";
            this.lb_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tab_thongtincanhan
            // 
            this.tab_thongtincanhan.Controls.Add(this.label6);
            this.tab_thongtincanhan.Controls.Add(this.txt_tenduong);
            this.tab_thongtincanhan.Controls.Add(this.label1);
            this.tab_thongtincanhan.Controls.Add(this.txt_mabn);
            this.tab_thongtincanhan.Controls.Add(this.groupBox1);
            this.tab_thongtincanhan.Location = new System.Drawing.Point(4, 25);
            this.tab_thongtincanhan.Name = "tab_thongtincanhan";
            this.tab_thongtincanhan.Padding = new System.Windows.Forms.Padding(3);
            this.tab_thongtincanhan.Size = new System.Drawing.Size(802, 425);
            this.tab_thongtincanhan.TabIndex = 0;
            this.tab_thongtincanhan.Text = "Thông tin cá nhân";
            this.tab_thongtincanhan.UseVisualStyleBackColor = true;
            // 
            // cb_csyt
            // 
            this.cb_csyt.FormattingEnabled = true;
            this.cb_csyt.Items.AddRange(new object[] {
            "CS1",
            "CS2",
            "CS3",
            "CS4",
            "CS5",
            "CS6",
            "CS7",
            "CS8",
            "CS9",
            "CS10"});
            this.cb_csyt.Location = new System.Drawing.Point(31, 94);
            this.cb_csyt.Name = "cb_csyt";
            this.cb_csyt.Size = new System.Drawing.Size(200, 24);
            this.cb_csyt.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cơ sở y tế";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Số nhà";
            // 
            // txt_sonha
            // 
            this.txt_sonha.Location = new System.Drawing.Point(31, 316);
            this.txt_sonha.Name = "txt_sonha";
            this.txt_sonha.Size = new System.Drawing.Size(200, 22);
            this.txt_sonha.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(437, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tên đường";
            // 
            // txt_tenduong
            // 
            this.txt_tenduong.Location = new System.Drawing.Point(440, 52);
            this.txt_tenduong.Name = "txt_tenduong";
            this.txt_tenduong.Size = new System.Drawing.Size(200, 22);
            this.txt_tenduong.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ tên";
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(31, 142);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(200, 22);
            this.txt_hoten.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã bệnh nhân";
            // 
            // txt_mabn
            // 
            this.txt_mabn.Enabled = false;
            this.txt_mabn.Location = new System.Drawing.Point(161, 52);
            this.txt_mabn.Name = "txt_mabn";
            this.txt_mabn.Size = new System.Drawing.Size(200, 22);
            this.txt_mabn.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_diungthuoc);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_tiensubenhgd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txt_tiensubenh);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_tinhtp);
            this.groupBox1.Controls.Add(this.txt_ngaysinh);
            this.groupBox1.Controls.Add(this.txt_quanhuyen);
            this.groupBox1.Controls.Add(this.btn_capnhatthongtin);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cb_csyt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_cmnd);
            this.groupBox1.Controls.Add(this.txt_sonha);
            this.groupBox1.Controls.Add(this.txt_hoten);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(130, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 395);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // txt_ngaysinh
            // 
            this.txt_ngaysinh.Location = new System.Drawing.Point(31, 256);
            this.txt_ngaysinh.Name = "txt_ngaysinh";
            this.txt_ngaysinh.Size = new System.Drawing.Size(200, 22);
            this.txt_ngaysinh.TabIndex = 25;
            // 
            // btn_capnhatthongtin
            // 
            this.btn_capnhatthongtin.AutoSize = true;
            this.btn_capnhatthongtin.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capnhatthongtin.Location = new System.Drawing.Point(202, 355);
            this.btn_capnhatthongtin.Name = "btn_capnhatthongtin";
            this.btn_capnhatthongtin.Size = new System.Drawing.Size(136, 30);
            this.btn_capnhatthongtin.TabIndex = 2;
            this.btn_capnhatthongtin.Text = "Cập nhật thông tin";
            this.btn_capnhatthongtin.UseVisualStyleBackColor = true;
            this.btn_capnhatthongtin.Click += new System.EventHandler(this.btn_capnhatthongtin_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "CMND";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngày sinh";
            // 
            // txt_cmnd
            // 
            this.txt_cmnd.Location = new System.Drawing.Point(31, 198);
            this.txt_cmnd.Name = "txt_cmnd";
            this.txt_cmnd.Size = new System.Drawing.Size(200, 22);
            this.txt_cmnd.TabIndex = 6;
            // 
            // tabcontrol1
            // 
            this.tabcontrol1.Controls.Add(this.tab_thongtincanhan);
            this.tabcontrol1.Location = new System.Drawing.Point(12, 45);
            this.tabcontrol1.Name = "tabcontrol1";
            this.tabcontrol1.SelectedIndex = 0;
            this.tabcontrol1.Size = new System.Drawing.Size(810, 454);
            this.tabcontrol1.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(307, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 17);
            this.label11.TabIndex = 26;
            this.label11.Text = "Quận huyện";
            // 
            // txt_quanhuyen
            // 
            this.txt_quanhuyen.Location = new System.Drawing.Point(310, 96);
            this.txt_quanhuyen.Name = "txt_quanhuyen";
            this.txt_quanhuyen.Size = new System.Drawing.Size(200, 22);
            this.txt_quanhuyen.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(307, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "Tỉnh ,Thành phố";
            // 
            // txt_tinhtp
            // 
            this.txt_tinhtp.Location = new System.Drawing.Point(310, 142);
            this.txt_tinhtp.Name = "txt_tinhtp";
            this.txt_tinhtp.Size = new System.Drawing.Size(200, 22);
            this.txt_tinhtp.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tiền sử bệnh";
            // 
            // txt_tiensubenh
            // 
            this.txt_tiensubenh.Location = new System.Drawing.Point(310, 198);
            this.txt_tiensubenh.Name = "txt_tiensubenh";
            this.txt_tiensubenh.Size = new System.Drawing.Size(200, 22);
            this.txt_tiensubenh.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(307, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "Tiền sử bệnh gia đình";
            // 
            // txt_tiensubenhgd
            // 
            this.txt_tiensubenhgd.Location = new System.Drawing.Point(310, 256);
            this.txt_tiensubenhgd.Name = "txt_tiensubenhgd";
            this.txt_tiensubenhgd.Size = new System.Drawing.Size(200, 22);
            this.txt_tiensubenhgd.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(307, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 17);
            this.label10.TabIndex = 30;
            this.label10.Text = "Dị ứng thuốc";
            // 
            // txt_diungthuoc
            // 
            this.txt_diungthuoc.Location = new System.Drawing.Point(310, 316);
            this.txt_diungthuoc.Name = "txt_diungthuoc";
            this.txt_diungthuoc.Size = new System.Drawing.Size(200, 22);
            this.txt_diungthuoc.TabIndex = 29;
            // 
            // f_BenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 503);
            this.Controls.Add(this.header_panel);
            this.Controls.Add(this.tabcontrol1);
            this.Name = "f_BenhNhan";
            this.Text = "Bệnh nhân";
            this.header_panel.ResumeLayout(false);
            this.header_panel.PerformLayout();
            this.tab_thongtincanhan.ResumeLayout(false);
            this.tab_thongtincanhan.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabcontrol1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header_panel;
        private System.Windows.Forms.Button btn_dangxuat;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.TabPage tab_thongtincanhan;
        private System.Windows.Forms.ComboBox cb_csyt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_sonha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_tenduong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_mabn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_ngaysinh;
        private System.Windows.Forms.Button btn_capnhatthongtin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cmnd;
        private System.Windows.Forms.TabControl tabcontrol1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_quanhuyen;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_diungthuoc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_tiensubenhgd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_tiensubenh;
        private System.Windows.Forms.TextBox txt_tinhtp;
    }
}

