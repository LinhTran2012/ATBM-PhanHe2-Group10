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
    public partial class f_CoSoYTe : Form
    {
        OracleConnection con = null;
        public f_CoSoYTe(OracleConnection connect)
        {
            InitializeComponent();
            this.con = connect;
            this.HienThiThongTin();
            if (DateTime.Now.Day<5 || DateTime.Now.Day>27)
                btn_Them.Enabled = btn_Xoa.Enabled =btn_ThemDV.Enabled =btn_XoaDV.Enabled = false;
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

        private void HienThiHSBA()
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM QLYCSYT.V_CSYT_HSBA";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Close();

            dgv_hsba.DataSource = dt;
            lb_csyt.Text = dt.Rows[0][6].ToString();
        }

        private void HienThiHSBA_DV()
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM QLYCSYT.V_HSBA_HSBA_DV";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Close();

            dgv_hsbadv.DataSource = dt;
        }

        private void resetAll()
        {
            txtbx_hsba.Text = "";
            txtbx_BN.Text = "";
            txtbx_ChanDoan.Text = "";
            txtbx_KetLuan.Text = "";
            txtbx_bs.Text = "";
            txtbx_khoa.Text = "";
            this.updateDataGridView();

            btn_Them.Enabled = true;
            btn_Xoa.Enabled = true;
        }

        private void resetAll_dv()
        {
            txtbx_hsbadv.Text = "";
            txtbx_dv.Text = "";
            txtbx_ktv.Text = "";
            txtbx_datedv.Text = "";
            txtbx_KetQua.Text = "";
            this.updateDataGridView_dv();

            btn_ThemDV.Enabled = true;
            btn_XoaDV.Enabled = true;
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

        private void btn_dangxuat_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            f_DangNhap dn = new f_DangNhap();
            dn.Show();
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

        private void tabcontrol1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabcontrol1.SelectedIndex == 0)
                this.HienThiThongTin();
            else if (tabcontrol1.SelectedIndex == 1)
                this.HienThiHSBA();
            else 
                this.HienThiHSBA_DV();
        }

        private void tab_thongtincanhan_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tab_hsba_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void f_CoSoYTe_Load(object sender, EventArgs e)
        {
            
        }

        private void updateDataGridView()
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM QLYCSYT.V_CSYT_HSBA";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Close();

            dgv_hsba.DataSource = dt;
        }

        private void updateDataGridView_dv()
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM QLYCSYT.V_HSBA_HSBA_DV";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Close();

            dgv_hsbadv.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            DataGridViewRow row = this.dgv_hsba.Rows[e.RowIndex];
            txt_hsba.Text = row.Cells[0].Value.ToString();
        }

        private void dgv_hsbadv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            DataGridViewRow row = this.dgv_hsbadv.Rows[e.RowIndex];
            txt_hsbadv.Text = row.Cells[0].Value.ToString();
            txtbx_hsbadv.Text = row.Cells[0].Value.ToString();
            txt_dv.Text = row.Cells[1].Value.ToString();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txtbx_hsba.Text == "")
            {
                MessageBox.Show("Mã HSBA không được trống!");
                return;
            }


            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = " insert into QLYCSYT.v_csyt_hsba (MAHSBA, MABN, NGAY, CHANDOAN, MABS, MAKHOA, MACSYT, KETLUAN) values ('" 
                + txtbx_hsba.Text.ToString() + "', '" + txtbx_BN.Text.ToString() + "', TO_DATE('" + txtbx_date.Text.ToString() + "','dd/mm/yyyy'),'"
                + txtbx_ChanDoan.Text.ToString() + "', '" + txtbx_bs.Text.ToString() + "', '"  + txtbx_khoa.Text.ToString() + "', '"  + lb_csyt.Text.ToString()
                + "', '"  + txtbx_KetLuan.Text.ToString() + "')";
            cmd.CommandType = CommandType.Text;

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Thêm HSBA thành công!");
                }
            } catch (Exception exp) { MessageBox.Show(exp.Message); }
            resetAll();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "DELETE FROM QLYCSYT.V_HSBA_HSBA_DV WHERE MAHSBA = '" + txt_hsba.Text.ToString() + "'";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();

            OracleCommand cmd1 = con.CreateCommand();
            cmd1.CommandText = "DELETE FROM QLYCSYT.V_CSYT_HSBA WHERE MAHSBA = '" + txt_hsba.Text.ToString() + "'";
            cmd1.CommandType = CommandType.Text;

            try
            {
                int i = cmd1.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Xóa HSBA thành công!");
                }
            }
            catch (Exception exp) { MessageBox.Show(exp.Message); }
            this.resetAll();
        }


        private void btn_ThemDV_Click(object sender, EventArgs e)
        {
            if (txtbx_hsbadv.Text == "" ||txtbx_dv.Text =="")
            {
                MessageBox.Show("Mã HSBA và DV không được trống!");
                return;
            }

            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = " insert into QLYCSYT.v_hsba_hsba_dv (MAHSBA, MADV, NGAY, MAKTV, KETQUA) values ('"
                + txtbx_hsbadv.Text.ToString() + "', '" + txtbx_dv.Text.ToString() + "', TO_DATE('" + txtbx_datedv.Text.ToString() 
                + "','dd/mm/yyyy'),'" + txtbx_ktv.Text.ToString() + "', '" + txtbx_KetLuan.Text.ToString() + "')";
            cmd.CommandType = CommandType.Text;

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Thêm dịch vụ thành công!");
                }
            }
            catch (Exception exp) { MessageBox.Show(exp.Message); }
            resetAll_dv();
        }

        private void btn_XoaDV_Click(object sender, EventArgs e)
        {
            if (txt_hsbadv.Text != "" &&txt_dv.Text!="" )
            {
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = "DELETE FROM QLYCSYT.V_HSBA_HSBA_DV WHERE MAHSBA = '" + txt_hsbadv.Text.ToString() + "' AND MADV ='"+txt_dv.Text.ToString()+"'";
                cmd.CommandType = CommandType.Text;

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("Xóa HSBA thành công!");
                    }
                }
                catch (Exception exp) { MessageBox.Show(exp.Message); }
                this.resetAll_dv();
            }
            else MessageBox.Show("Vui lòng nhập đầy đủ thông tin dịch vụ cần xóa");
        }

        private void txt_hsbadv_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbx_hsbadv_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
