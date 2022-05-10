
namespace ATBM191_10
{
    partial class f_NghienCuu
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
            this.tabcontrol1 = new System.Windows.Forms.TabControl();
            this.tab_thongtincanhan = new System.Windows.Forms.TabPage();
            this.cb_chuyenkhoa = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_vaitro = new System.Windows.Forms.ComboBox();
            this.cb_csyt = new System.Windows.Forms.ComboBox();
            this.cb_phai = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_quequan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_ngaysinh = new System.Windows.Forms.TextBox();
            this.btn_capnhatthongtin = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cmnd = new System.Windows.Forms.TextBox();
            this.tab_hsba = new System.Windows.Forms.TabPage();
            this.dgv_hsba = new System.Windows.Forms.DataGridView();
            this.tab_hsbadv = new System.Windows.Forms.TabPage();
            this.dgv_hsbadv = new System.Windows.Forms.DataGridView();
            this.header_panel.SuspendLayout();
            this.tabcontrol1.SuspendLayout();
            this.tab_thongtincanhan.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tab_hsba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hsba)).BeginInit();
            this.tab_hsbadv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hsbadv)).BeginInit();
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
            this.header_panel.Location = new System.Drawing.Point(0, -1);
            this.header_panel.Name = "header_panel";
            this.header_panel.Size = new System.Drawing.Size(833, 40);
            this.header_panel.TabIndex = 7;
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
            this.btn_dangxuat.Click += new System.EventHandler(this.btn_dangxuat_Click);
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
            // tabcontrol1
            // 
            this.tabcontrol1.Controls.Add(this.tab_thongtincanhan);
            this.tabcontrol1.Controls.Add(this.tab_hsba);
            this.tabcontrol1.Controls.Add(this.tab_hsbadv);
            this.tabcontrol1.Location = new System.Drawing.Point(12, 40);
            this.tabcontrol1.Name = "tabcontrol1";
            this.tabcontrol1.SelectedIndex = 0;
            this.tabcontrol1.Size = new System.Drawing.Size(810, 454);
            this.tabcontrol1.TabIndex = 8;
            this.tabcontrol1.SelectedIndexChanged += new System.EventHandler(this.tabcontrol1_SelectedIndexChanged);
            // 
            // tab_thongtincanhan
            // 
            this.tab_thongtincanhan.Controls.Add(this.cb_chuyenkhoa);
            this.tab_thongtincanhan.Controls.Add(this.label10);
            this.tab_thongtincanhan.Controls.Add(this.cb_vaitro);
            this.tab_thongtincanhan.Controls.Add(this.cb_csyt);
            this.tab_thongtincanhan.Controls.Add(this.cb_phai);
            this.tab_thongtincanhan.Controls.Add(this.label9);
            this.tab_thongtincanhan.Controls.Add(this.label8);
            this.tab_thongtincanhan.Controls.Add(this.label7);
            this.tab_thongtincanhan.Controls.Add(this.txt_sdt);
            this.tab_thongtincanhan.Controls.Add(this.label6);
            this.tab_thongtincanhan.Controls.Add(this.txt_quequan);
            this.tab_thongtincanhan.Controls.Add(this.label3);
            this.tab_thongtincanhan.Controls.Add(this.label2);
            this.tab_thongtincanhan.Controls.Add(this.txt_hoten);
            this.tab_thongtincanhan.Controls.Add(this.label1);
            this.tab_thongtincanhan.Controls.Add(this.txt_manv);
            this.tab_thongtincanhan.Controls.Add(this.groupBox1);
            this.tab_thongtincanhan.Location = new System.Drawing.Point(4, 25);
            this.tab_thongtincanhan.Name = "tab_thongtincanhan";
            this.tab_thongtincanhan.Padding = new System.Windows.Forms.Padding(3);
            this.tab_thongtincanhan.Size = new System.Drawing.Size(802, 425);
            this.tab_thongtincanhan.TabIndex = 0;
            this.tab_thongtincanhan.Text = "Thông tin cá nhân";
            this.tab_thongtincanhan.UseVisualStyleBackColor = true;
            // 
            // cb_chuyenkhoa
            // 
            this.cb_chuyenkhoa.FormattingEnabled = true;
            this.cb_chuyenkhoa.Items.AddRange(new object[] {
            "CK1",
            "CK2",
            "CK3",
            "CK4",
            "CK5"});
            this.cb_chuyenkhoa.Location = new System.Drawing.Point(440, 322);
            this.cb_chuyenkhoa.Name = "cb_chuyenkhoa";
            this.cb_chuyenkhoa.Size = new System.Drawing.Size(200, 24);
            this.cb_chuyenkhoa.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(437, 300);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Chuyên khoa";
            // 
            // cb_vaitro
            // 
            this.cb_vaitro.FormattingEnabled = true;
            this.cb_vaitro.Items.AddRange(new object[] {
            "Thanh tra",
            "Y si/bac si",
            "Co so y te",
            "Nghien cuu"});
            this.cb_vaitro.Location = new System.Drawing.Point(440, 249);
            this.cb_vaitro.Name = "cb_vaitro";
            this.cb_vaitro.Size = new System.Drawing.Size(200, 24);
            this.cb_vaitro.TabIndex = 21;
            this.cb_vaitro.SelectedValueChanged += new System.EventHandler(this.cb_vaitro_SelectedValueChanged);
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
            this.cb_csyt.Location = new System.Drawing.Point(440, 179);
            this.cb_csyt.Name = "cb_csyt";
            this.cb_csyt.Size = new System.Drawing.Size(200, 24);
            this.cb_csyt.TabIndex = 20;
            // 
            // cb_phai
            // 
            this.cb_phai.FormattingEnabled = true;
            this.cb_phai.Items.AddRange(new object[] {
            "Nam",
            "Nu"});
            this.cb_phai.Location = new System.Drawing.Point(161, 179);
            this.cb_phai.Name = "cb_phai";
            this.cb_phai.Size = new System.Drawing.Size(200, 24);
            this.cb_phai.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(437, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Vai trò";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(437, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cơ sở y tế";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(437, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Số điện thoại";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(440, 112);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(200, 22);
            this.txt_sdt.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(437, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Quê quán";
            // 
            // txt_quequan
            // 
            this.txt_quequan.Location = new System.Drawing.Point(440, 52);
            this.txt_quequan.Name = "txt_quequan";
            this.txt_quequan.Size = new System.Drawing.Size(200, 22);
            this.txt_quequan.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phái ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ tên";
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(161, 112);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(200, 22);
            this.txt_hoten.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã nhân viên";
            // 
            // txt_manv
            // 
            this.txt_manv.Enabled = false;
            this.txt_manv.Location = new System.Drawing.Point(161, 52);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(200, 22);
            this.txt_manv.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_ngaysinh);
            this.groupBox1.Controls.Add(this.btn_capnhatthongtin);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_cmnd);
            this.groupBox1.Location = new System.Drawing.Point(130, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 395);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // txt_ngaysinh
            // 
            this.txt_ngaysinh.Location = new System.Drawing.Point(31, 245);
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
            this.label5.Location = new System.Drawing.Point(30, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "CMND";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngày sinh";
            // 
            // txt_cmnd
            // 
            this.txt_cmnd.Location = new System.Drawing.Point(31, 318);
            this.txt_cmnd.Name = "txt_cmnd";
            this.txt_cmnd.Size = new System.Drawing.Size(200, 22);
            this.txt_cmnd.TabIndex = 6;
            // 
            // tab_hsba
            // 
            this.tab_hsba.Controls.Add(this.dgv_hsba);
            this.tab_hsba.Location = new System.Drawing.Point(4, 25);
            this.tab_hsba.Name = "tab_hsba";
            this.tab_hsba.Padding = new System.Windows.Forms.Padding(3);
            this.tab_hsba.Size = new System.Drawing.Size(802, 425);
            this.tab_hsba.TabIndex = 1;
            this.tab_hsba.Text = "Hồ sơ bệnh án";
            this.tab_hsba.UseVisualStyleBackColor = true;
            // 
            // dgv_hsba
            // 
            this.dgv_hsba.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_hsba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hsba.Location = new System.Drawing.Point(21, 36);
            this.dgv_hsba.Name = "dgv_hsba";
            this.dgv_hsba.RowHeadersWidth = 51;
            this.dgv_hsba.RowTemplate.Height = 24;
            this.dgv_hsba.Size = new System.Drawing.Size(751, 354);
            this.dgv_hsba.TabIndex = 0;
            this.dgv_hsba.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hsba_CellClick);
            // 
            // tab_hsbadv
            // 
            this.tab_hsbadv.Controls.Add(this.dgv_hsbadv);
            this.tab_hsbadv.Location = new System.Drawing.Point(4, 25);
            this.tab_hsbadv.Name = "tab_hsbadv";
            this.tab_hsbadv.Size = new System.Drawing.Size(802, 425);
            this.tab_hsbadv.TabIndex = 2;
            this.tab_hsbadv.Text = "Hồ sơ bệnh án - dịch vụ";
            this.tab_hsbadv.UseVisualStyleBackColor = true;
            // 
            // dgv_hsbadv
            // 
            this.dgv_hsbadv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_hsbadv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hsbadv.Location = new System.Drawing.Point(37, 37);
            this.dgv_hsbadv.Name = "dgv_hsbadv";
            this.dgv_hsbadv.RowHeadersWidth = 51;
            this.dgv_hsbadv.RowTemplate.Height = 24;
            this.dgv_hsbadv.Size = new System.Drawing.Size(719, 356);
            this.dgv_hsbadv.TabIndex = 0;
            // 
            // f_NghienCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 503);
            this.Controls.Add(this.header_panel);
            this.Controls.Add(this.tabcontrol1);
            this.Name = "f_NghienCuu";
            this.Text = "Nghiên cứu";
            this.header_panel.ResumeLayout(false);
            this.header_panel.PerformLayout();
            this.tabcontrol1.ResumeLayout(false);
            this.tab_thongtincanhan.ResumeLayout(false);
            this.tab_thongtincanhan.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tab_hsba.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hsba)).EndInit();
            this.tab_hsbadv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hsbadv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header_panel;
        private System.Windows.Forms.Button btn_dangxuat;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.TabControl tabcontrol1;
        private System.Windows.Forms.TabPage tab_thongtincanhan;
        private System.Windows.Forms.TabPage tab_hsba;
        private System.Windows.Forms.TabPage tab_hsbadv;
        private System.Windows.Forms.ComboBox cb_chuyenkhoa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_vaitro;
        private System.Windows.Forms.ComboBox cb_csyt;
        private System.Windows.Forms.ComboBox cb_phai;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_quequan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cmnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_capnhatthongtin;
        private System.Windows.Forms.DataGridView dgv_hsba;
        private System.Windows.Forms.DataGridView dgv_hsbadv;
        private System.Windows.Forms.TextBox txt_ngaysinh;
    }
}
