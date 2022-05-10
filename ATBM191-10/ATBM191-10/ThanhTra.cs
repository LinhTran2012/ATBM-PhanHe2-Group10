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

            dgv_info.DataSource = dt;
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

