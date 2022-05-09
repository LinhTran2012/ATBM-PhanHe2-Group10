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
        }
    }
}
