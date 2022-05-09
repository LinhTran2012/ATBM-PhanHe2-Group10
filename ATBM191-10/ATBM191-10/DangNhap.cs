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
    public partial class f_DangNhap : Form
    {
        OracleConnection con = null;
        public f_DangNhap()
        {
            InitializeComponent();
        }

        private bool setConnection(string userID, string pass)
        {
            string strcon = "Data Source=localhost:1521 / xe;User Id=" + userID + ";Password=" + pass;
            con = new OracleConnection(strcon);
            try
            {
                con.Open();
                return true;
            }
            catch (Exception exp) { return false; }
        }

        public string getRole(string manv)
        {
            string strcon = "Data Source=localhost:1521 / xe;User Id=QLYCSYT ;Password=123";
            OracleConnection con = new OracleConnection(strcon);
            try
            {
                con.Open();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT VAITRO FROM QLYCSYT.NHANVIEN WHERE MANV = '" + manv + "'";
                cmd.CommandType = CommandType.Text;

                OracleDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dr.Close();

                return dt.Rows[0][0].ToString();
            }
            catch (Exception exp) { return null; }
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            if (txt_tendangnhap.Text == "" || txt_matkhau.Text == "")
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");

            else if (this.setConnection(txt_tendangnhap.Text, txt_matkhau.Text))
            {
                MessageBox.Show("Đăng nhập thành công");
                if (txt_tendangnhap.Text.Substring(0, 2) == "BN")
                {
                    f_BenhNhan bn = new f_BenhNhan(con);
                    bn.Show();
                }
                else
                {
                    string vaitro = getRole(txt_tendangnhap.Text);
                    if (vaitro == "Thanh tra")
                    {
                        f_ThanhTra tt = new f_ThanhTra(con);
                        tt.Show();
                    }
                    else if (vaitro == "Co so y te")
                    {
                        f_CoSoYTe csyt = new f_CoSoYTe(con);
                        csyt.Show();
                    }
                    else if (vaitro == "Y si/bac si")
                    {
                        f_YSiBacSi ybs = new f_YSiBacSi(con);
                        ybs.Show();
                    }
                    else if (vaitro == "Nghien cuu")
                    {
                        f_NghienCuu nc = new f_NghienCuu(con);
                        nc.Show();
                    }
                }
                this.Hide();

            }
            else
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
        }
    }
}
