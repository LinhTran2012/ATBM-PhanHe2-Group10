

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
            this.lb_name = new System.Windows.Forms.Label();
            this.btn_dangxuat = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_thongtincanhan = new System.Windows.Forms.TabPage();
            this.dgv_info = new System.Windows.Forms.DataGridView();
            this.tab_suathongtin = new System.Windows.Forms.TabPage();
            this.btn_chinhsua = new System.Windows.Forms.Button();
            this.txt_CMND = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ngaysinh = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.header_panel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_thongtincanhan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info)).BeginInit();
            this.tab_suathongtin.SuspendLayout();
            this.SuspendLayout();
            // 
            // header_panel
            // 
            this.header_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.header_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.header_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.header_panel.Controls.Add(this.lb_name);
            this.header_panel.Controls.Add(this.btn_dangxuat);
            this.header_panel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header_panel.Location = new System.Drawing.Point(0, -1);
            this.header_panel.Name = "header_panel";
            this.header_panel.Size = new System.Drawing.Size(833, 40);
            this.header_panel.TabIndex = 11;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.ForeColor = System.Drawing.Color.White;
            this.lb_name.Location = new System.Drawing.Point(567, 6);
            this.lb_name.Margin = new System.Windows.Forms.Padding(70, 0, 3, 0);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(152, 25);
            this.lb_name.TabIndex = 2;
            this.lb_name.Text = "Nguyễn Văn A";
            this.lb_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_thongtincanhan);
            this.tabControl1.Controls.Add(this.tab_suathongtin);
            this.tabControl1.Location = new System.Drawing.Point(12, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(810, 454);
            this.tabControl1.TabIndex = 12;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tab_thongtincanhan
            // 
            this.tab_thongtincanhan.Controls.Add(this.dgv_info);
            this.tab_thongtincanhan.Location = new System.Drawing.Point(4, 25);
            this.tab_thongtincanhan.Name = "tab_thongtincanhan";
            this.tab_thongtincanhan.Padding = new System.Windows.Forms.Padding(3);
            this.tab_thongtincanhan.Size = new System.Drawing.Size(802, 425);
            this.tab_thongtincanhan.TabIndex = 0;
            this.tab_thongtincanhan.Text = "Thông tin cá nhân";
            this.tab_thongtincanhan.UseVisualStyleBackColor = true;
            // 
            // dgv_info
            // 
            this.dgv_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_info.Location = new System.Drawing.Point(3, 6);
            this.dgv_info.Name = "dgv_info";
            this.dgv_info.RowHeadersWidth = 51;
            this.dgv_info.RowTemplate.Height = 24;
            this.dgv_info.Size = new System.Drawing.Size(793, 413);
            this.dgv_info.TabIndex = 0;
            // 
            // tab_suathongtin
            // 
            this.tab_suathongtin.Controls.Add(this.btn_chinhsua);
            this.tab_suathongtin.Controls.Add(this.txt_CMND);
            this.tab_suathongtin.Controls.Add(this.label4);
            this.tab_suathongtin.Controls.Add(this.txt_ngaysinh);
            this.tab_suathongtin.Controls.Add(this.txt_SDT);
            this.tab_suathongtin.Controls.Add(this.label3);
            this.tab_suathongtin.Controls.Add(this.label2);
            this.tab_suathongtin.Controls.Add(this.label1);
            this.tab_suathongtin.Controls.Add(this.txt_hoten);
            this.tab_suathongtin.Location = new System.Drawing.Point(4, 25);
            this.tab_suathongtin.Name = "tab_suathongtin";
            this.tab_suathongtin.Padding = new System.Windows.Forms.Padding(3);
            this.tab_suathongtin.Size = new System.Drawing.Size(802, 425);
            this.tab_suathongtin.TabIndex = 1;
            this.tab_suathongtin.Text = "Chỉnh thông tin";
            this.tab_suathongtin.UseVisualStyleBackColor = true;
            // 
            // btn_chinhsua
            // 
            this.btn_chinhsua.Location = new System.Drawing.Point(300, 213);
            this.btn_chinhsua.Name = "btn_chinhsua";
            this.btn_chinhsua.Size = new System.Drawing.Size(75, 23);
            this.btn_chinhsua.TabIndex = 8;
            this.btn_chinhsua.Text = "Chỉnh sửa";
            this.btn_chinhsua.UseVisualStyleBackColor = true;
            this.btn_chinhsua.Click += new System.EventHandler(this.btn_chinhsua_Click);
            // 
            // txt_CMND
            // 
            this.txt_CMND.Location = new System.Drawing.Point(131, 160);
            this.txt_CMND.Name = "txt_CMND";
            this.txt_CMND.Size = new System.Drawing.Size(244, 22);
            this.txt_CMND.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "CMND";
            // 
            // txt_ngaysinh
            // 
            this.txt_ngaysinh.Location = new System.Drawing.Point(131, 119);
            this.txt_ngaysinh.Name = "txt_ngaysinh";
            this.txt_ngaysinh.Size = new System.Drawing.Size(244, 22);
            this.txt_ngaysinh.TabIndex = 5;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(131, 80);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(244, 22);
            this.txt_SDT.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "SDT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ tên";
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(131, 39);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(244, 22);
            this.txt_hoten.TabIndex = 0;
            // 
            // f_BenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 503);
            this.Controls.Add(this.header_panel);
            this.Controls.Add(this.tabControl1);
            this.Name = "f_BenhNhan";
            this.Text = "Bệnh nhân";
            this.header_panel.ResumeLayout(false);
            this.header_panel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tab_thongtincanhan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info)).EndInit();
            this.tab_suathongtin.ResumeLayout(false);
            this.tab_suathongtin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header_panel;
        private System.Windows.Forms.Button btn_dangxuat;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_thongtincanhan;
        private System.Windows.Forms.DataGridView dgv_info;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.TabPage tab_suathongtin;
        private System.Windows.Forms.TextBox txt_ngaysinh;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.TextBox txt_CMND;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_chinhsua;
    }
}

