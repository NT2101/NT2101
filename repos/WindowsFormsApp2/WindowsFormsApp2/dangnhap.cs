using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class dangnhap : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-MFDIDQSO\\MAYAO;Initial Catalog=QLKVC;Integrated Security=True");
        public dangnhap()
        {
            InitializeComponent();
        }

        private void btlT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btlDN_Click(object sender, EventArgs e)
        {
            con.Open();

            string tk = txtTK.Text;
            string mk = txtMK.Text;

            string sql = " select * from taikhoan where ttk = '" + tk + "' and mktk = '" + mk + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dta = cmd.ExecuteReader();
            if (dta.Read() == true)
            {
                MessageBox.Show("Đăng nhập thành công");
                var dn = new mainchinh();
                dn.ShowDialog();

            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công");
            }

            this.Hide();
        }

        private void dangnhap_Load(object sender, EventArgs e)
        {

        }
    }
}
