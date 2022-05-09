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
    }
}
