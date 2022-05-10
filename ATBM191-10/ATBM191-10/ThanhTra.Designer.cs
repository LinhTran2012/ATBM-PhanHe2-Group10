

namespace ATBM191_10
{
    partial class f_ThanhTra
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_thongtincanhan = new System.Windows.Forms.TabPage();
            this.dgv_info = new System.Windows.Forms.DataGridView();
            this.tab_docdulieu = new System.Windows.Forms.TabPage();
            this.cb_chon = new System.Windows.Forms.ComboBox();
            this.btn_chon = new System.Windows.Forms.Button();
            this.dgv_doc = new System.Windows.Forms.DataGridView();
            this.header_panel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_thongtincanhan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info)).BeginInit();
            this.tab_docdulieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doc)).BeginInit();
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
            this.header_panel.TabIndex = 5;
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
            this.lb_name.Location = new System.Drawing.Point(572, 5);
            this.lb_name.Margin = new System.Windows.Forms.Padding(70, 0, 3, 0);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(152, 25);
            this.lb_name.TabIndex = 0;
            this.lb_name.Text = "Nguyễn Văn A";
            this.lb_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_thongtincanhan);
            this.tabControl1.Controls.Add(this.tab_docdulieu);
            this.tabControl1.Location = new System.Drawing.Point(12, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(810, 454);
            this.tabControl1.TabIndex = 6;
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
            this.dgv_info.Location = new System.Drawing.Point(6, 6);
            this.dgv_info.Name = "dgv_info";
            this.dgv_info.RowHeadersWidth = 51;
            this.dgv_info.RowTemplate.Height = 24;
            this.dgv_info.Size = new System.Drawing.Size(790, 413);
            this.dgv_info.TabIndex = 0;
            // 
            // tab_docdulieu
            // 
            this.tab_docdulieu.Controls.Add(this.dgv_doc);
            this.tab_docdulieu.Controls.Add(this.btn_chon);
            this.tab_docdulieu.Controls.Add(this.cb_chon);
            this.tab_docdulieu.Location = new System.Drawing.Point(4, 25);
            this.tab_docdulieu.Name = "tab_docdulieu";
            this.tab_docdulieu.Padding = new System.Windows.Forms.Padding(3);
            this.tab_docdulieu.Size = new System.Drawing.Size(802, 425);
            this.tab_docdulieu.TabIndex = 1;
            this.tab_docdulieu.Text = "Đọc dữ liệu";
            this.tab_docdulieu.UseVisualStyleBackColor = true;
            // 
            // cb_chon
            // 
            this.cb_chon.FormattingEnabled = true;
            this.cb_chon.Items.AddRange(new object[] {
            "Nhân Viên",
            "Bệnh Nhân",
            "HSBA",
            "HSBA_DV",
            "CSYT"});
            this.cb_chon.Location = new System.Drawing.Point(6, 6);
            this.cb_chon.Name = "cb_chon";
            this.cb_chon.Size = new System.Drawing.Size(220, 24);
            this.cb_chon.TabIndex = 0;
            // 
            // btn_chon
            // 
            this.btn_chon.Location = new System.Drawing.Point(246, 6);
            this.btn_chon.Name = "btn_chon";
            this.btn_chon.Size = new System.Drawing.Size(75, 23);
            this.btn_chon.TabIndex = 1;
            this.btn_chon.Text = "Chọn";
            this.btn_chon.UseVisualStyleBackColor = true;
            this.btn_chon.Click += new System.EventHandler(this.btn_chon_Click);
            // 
            // dgv_doc
            // 
            this.dgv_doc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_doc.Location = new System.Drawing.Point(6, 49);
            this.dgv_doc.Name = "dgv_doc";
            this.dgv_doc.RowHeadersWidth = 51;
            this.dgv_doc.RowTemplate.Height = 24;
            this.dgv_doc.Size = new System.Drawing.Size(790, 370);
            this.dgv_doc.TabIndex = 2;
            // 
            // f_ThanhTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 503);
            this.Controls.Add(this.header_panel);
            this.Controls.Add(this.tabControl1);
            this.Name = "f_ThanhTra";
            this.Text = "Thanh Tra";
            this.header_panel.ResumeLayout(false);
            this.header_panel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tab_thongtincanhan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info)).EndInit();
            this.tab_docdulieu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header_panel;
        private System.Windows.Forms.Button btn_dangxuat;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_thongtincanhan;
        private System.Windows.Forms.TabPage tab_docdulieu;
        private System.Windows.Forms.DataGridView dgv_info;
        private System.Windows.Forms.Button btn_chon;
        private System.Windows.Forms.ComboBox cb_chon;
        private System.Windows.Forms.DataGridView dgv_doc;
    }
}
