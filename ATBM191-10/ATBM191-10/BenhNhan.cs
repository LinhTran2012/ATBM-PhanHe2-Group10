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
    public partial class f_BenhNhan : Form
    {
        OracleConnection con = null;
        public f_BenhNhan(OracleConnection connect)
        {
            InitializeComponent();
            this.con = connect;
            this.HienThiThongTin();
        }

        private void HienThiThongTin()
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM QLYCSYT.V_BENHNHAN_THONGTINCANHAN";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Close();

            lb_name.Text = dt.Rows[0][1].ToString();
            txt_mabn.Text = dt.Rows[0][0].ToString();
            cb_csyt.Text = dt.Rows[0][1].ToString();
            txt_hoten.Text = dt.Rows[0][2].ToString();
            txt_cmnd.Text = dt.Rows[0][3].ToString();
            txt_ngaysinh.Text = dt.Rows[0][4].ToString().Substring(0, 10);
            txt_sonha.Text = dt.Rows[0][5].ToString();
            txt_tenduong.Text = dt.Rows[0][6].ToString();
            txt_quanhuyen.Text = dt.Rows[0][7].ToString();
            txt_tinhtp.Text = dt.Rows[0][8].ToString();
            txt_tiensubenh.Text = dt.Rows[0][9].ToString();
            txt_tiensubenhgd.Text = dt.Rows[0][10].ToString();
            txt_diungthuoc.Text = dt.Rows[0][11].ToString();

        }

        private void btn_capnhatthongtin_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "UPDATE QLYCSYT.V_BENHNHAN_THONGTINCANHAN " +
                               "SET MACSYT='" + cb_csyt.Text + "' , TENBN='" + txt_hoten.Text + "' , NGAYSINH=TO_DATE('" + txt_ngaysinh.Text + "','dd/mm/yyyy')" +
                                   " , CMND ='" + txt_cmnd.Text + "' , SONHA='" + txt_sonha.Text + "' , TENDUONG='" + txt_tenduong.Text +
                                   "' , QUANHUYEN ='" + txt_quanhuyen.Text + "' , TINHTP='" + txt_tinhtp.Text + "' , TIENSUBENH='" + txt_tiensubenh.Text +
                                   "' , TIENSUBENHGD='" + txt_tiensubenhgd.Text + "' , DIUNGTHUOC='" + txt_diungthuoc.Text + "'";
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

        private void btn_dangxuat_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            f_DangNhap dn = new f_DangNhap();
            dn.Show();
        }
    } 
}
