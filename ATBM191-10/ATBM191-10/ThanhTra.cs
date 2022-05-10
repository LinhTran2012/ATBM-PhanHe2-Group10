using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Configuration;

namespace ATBM191_10
{
    public partial class f_ThanhTra : Form
    {
        OracleConnection con = null;
        public f_ThanhTra(OracleConnection connect)
        {
            InitializeComponent();
            this.con = connect;
            this.HienThiThongTin();
        }
        private void HienThiThongTin()
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM QLYCSYT.V_NHANVIEN_THONGTINCANHAN";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Close();

            lb_name.Text = dt.Rows[0][1].ToString();
            txt_manv.Text = dt.Rows[0][0].ToString();
            txt_hoten.Text = dt.Rows[0][1].ToString();
            cb_phai.Text = dt.Rows[0][2].ToString();
            txt_ngaysinh.Text = dt.Rows[0][3].ToString().Substring(0, 10);
            txt_cmnd.Text = dt.Rows[0][4].ToString();
            txt_quequan.Text = dt.Rows[0][5].ToString();
            txt_sdt.Text = dt.Rows[0][6].ToString();
            cb_csyt.Text = dt.Rows[0][7].ToString();
            cb_vaitro.Text = dt.Rows[0][8].ToString();
            cb_chuyenkhoa.Text = dt.Rows[0][9].ToString();
        }

        private void btn_capnhatthongtin_Click(object sender, EventArgs e)
        {
            if (cb_vaitro.Text == "Thanh tra" || cb_vaitro.Text == "Co so y te" || cb_chuyenkhoa.Text != "")
            {
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE QLYCSYT.V_NHANVIEN_THONGTINCANHAN " +
                                   "SET HOTEN='" + txt_hoten.Text + "' , PHAI='" + cb_phai.Text + "' , NGAYSINH=TO_DATE('" + txt_ngaysinh.Text + "','dd/mm/yyyy')" +
                                   " , CMND ='" + txt_cmnd.Text + "' , QUEQUAN='" + txt_quequan.Text + "' , SODT='" + txt_sdt.Text +
                                   "' , CSYT ='" + cb_csyt.Text + "' , VAITRO='" + cb_vaitro.Text + "' , CHUYENKHOA='" + cb_chuyenkhoa.Text + "'";
                cmd.CommandType = CommandType.Text;

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("Cập nhật thành công");
                    }
                }
                catch (Exception exp) { MessageBox.Show(exp.Message); }
            }
            else
                MessageBox.Show("Chuyên khoa không được bỏ trống");
        }

        private void cb_vaitro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_vaitro.Text == "Thanh tra" || cb_vaitro.Text == "Co so y te")
            {
                cb_chuyenkhoa.Text = "";
                cb_chuyenkhoa.Enabled = false;
            }
            else
                cb_chuyenkhoa.Enabled = true;
        }


        private void HienThiDuLieu()
        {
            OracleCommand cmd = con.CreateCommand();
            if (cb_chon.Text == "Nhân Viên")
                cmd.CommandText = "SELECT * FROM QLYCSYT.NHANVIEN";
            else if (cb_chon.Text == "Bệnh Nhân")
                cmd.CommandText = "SELECT * FROM QLYCSYT.BENHNHAN";
            else if (cb_chon.Text == "HSBA")
                cmd.CommandText = "SELECT * FROM QLYCSYT.HSBA";
            else if (cb_chon.Text == "HSBA_DV")
                cmd.CommandText = "SELECT * FROM QLYCSYT.HSBA_DV";
            else
                cmd.CommandText = "SELECT * FROM QLYCSYT.CSYT";

            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Close();

            dgv_doc.DataSource = dt;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
                this.HienThiThongTin();
            else if (tabControl1.SelectedIndex == 1)
                this.HienThiDuLieu();
                
        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_DangNhap dn = new f_DangNhap();
            dn.Show();
        }

        private void btn_chon_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = con.CreateCommand();
            if (cb_chon.Text == "Nhân Viên")
                cmd.CommandText = "SELECT * FROM QLYCSYT.NHANVIEN";
            else if (cb_chon.Text == "Bệnh Nhân")
                cmd.CommandText = "SELECT * FROM QLYCSYT.BENHNHAN";
            else if (cb_chon.Text == "HSBA")
                cmd.CommandText = "SELECT * FROM QLYCSYT.HSBA";
            else if (cb_chon.Text == "HSBA_DV")
                cmd.CommandText = "SELECT * FROM QLYCSYT.HSBA_DV";
            else
                cmd.CommandText = "SELECT * FROM QLYCSYT.CSYT";

            cmd.CommandType = CommandType.Text;
            try
            {
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dr.Close();

                dgv_doc.DataSource = dt;
            }
            catch (Exception exp) { }
        }

        
    }
}

