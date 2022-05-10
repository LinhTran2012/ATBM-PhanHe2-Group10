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

            dgv_info.DataSource = dt;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
                this.HienThiThongTin();
        }
        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_DangNhap dn = new f_DangNhap();
            dn.Show();
        }

        private void btn_chinhsua_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "UPDATE QLYCSYT.V_BENHNHAN_THONGTINCANHAN " +
                               "SET HOTEN='" + txt_hoten.Text + "' , NGAYSINH=TO_DATE('" + txt_ngaysinh.Text + "','dd/mm/yyyy')" +
                               " , CMND ='" + txt_CMND.Text + "' ,MACSYT='" + txt_CSYT.Text;
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
    } 
}
