
namespace ATBM191_10
{
    partial class f_YSiBacSi
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
            this.tab_hsba = new System.Windows.Forms.TabPage();
            this.tab_benhnhan = new System.Windows.Forms.TabPage();
            this.header_panel.SuspendLayout();
            this.tabControl1.SuspendLayout();
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
            this.header_panel.Location = new System.Drawing.Point(1, -1);
            this.header_panel.Name = "header_panel";
            this.header_panel.Size = new System.Drawing.Size(833, 40);
            this.header_panel.TabIndex = 3;
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
            this.tabControl1.Controls.Add(this.tab_hsba);
            this.tabControl1.Controls.Add(this.tab_benhnhan);
            this.tabControl1.Location = new System.Drawing.Point(12, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(810, 454);
            this.tabControl1.TabIndex = 4;
            // 
            // tab_thongtincanhan
            // 
            this.tab_thongtincanhan.Location = new System.Drawing.Point(4, 25);
            this.tab_thongtincanhan.Name = "tab_thongtincanhan";
            this.tab_thongtincanhan.Padding = new System.Windows.Forms.Padding(3);
            this.tab_thongtincanhan.Size = new System.Drawing.Size(802, 425);
            this.tab_thongtincanhan.TabIndex = 0;
            this.tab_thongtincanhan.Text = "Thông tin cá nhân";
            this.tab_thongtincanhan.UseVisualStyleBackColor = true;
            // 
            // tab_hsba
            // 
            this.tab_hsba.Location = new System.Drawing.Point(4, 25);
            this.tab_hsba.Name = "tab_hsba";
            this.tab_hsba.Padding = new System.Windows.Forms.Padding(3);
            this.tab_hsba.Size = new System.Drawing.Size(822, 434);
            this.tab_hsba.TabIndex = 1;
            this.tab_hsba.Text = "Hồ sơ bệnh án";
            this.tab_hsba.UseVisualStyleBackColor = true;
            // 
            // tab_benhnhan
            // 
            this.tab_benhnhan.Location = new System.Drawing.Point(4, 25);
            this.tab_benhnhan.Name = "tab_benhnhan";
            this.tab_benhnhan.Size = new System.Drawing.Size(822, 434);
            this.tab_benhnhan.TabIndex = 2;
            this.tab_benhnhan.Text = "Bệnh nhân";
            this.tab_benhnhan.UseVisualStyleBackColor = true;
            // 
            // f_YSiBacSi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 503);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.header_panel);
            this.Name = "f_YSiBacSi";
            this.Text = "Y sĩ bác sĩ";
            this.header_panel.ResumeLayout(false);
            this.header_panel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header_panel;
        private System.Windows.Forms.Button btn_dangxuat;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_thongtincanhan;
        private System.Windows.Forms.TabPage tab_hsba;
        private System.Windows.Forms.TabPage tab_benhnhan;
    }
}