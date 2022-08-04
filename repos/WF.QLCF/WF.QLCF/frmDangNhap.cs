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
using System.Configuration;

namespace WF.QLCF
{
    public partial class frmDangNhap : Form
    {
        #region 
        string connectionString = ConfigurationManager.AppSettings["connectionString"];
        //string connectionString = @"Data Source=LAPTOP-MFDIDQSO\MAYAO;Initial Catalog = DemoCE12; Integrated Security = True";
        SqlConnection conn;
        DataSet ds;
        #endregion
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private bool CheckEmpty (TextBox obj , string Message)
        {
            if(obj.Text.Trim() == "")
            {
                MessageBox.Show(Message, "Thông Báo ");
                obj.Focus();
                return false;
            }
            return true;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(connectionString);
                if (CheckEmpty(txtAccountName, "Chưa Nhập Tài Khoản ") == false)
                    return;
                if (CheckEmpty(txtPassword, "Chưa Nhập Mật Khẩu ") == false)
                    return;
                if(conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "GET_ACCOUNT";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@AccountName", txtAccountName.Text.Trim());
                command.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                SqlDataAdapter da = new SqlDataAdapter(command);
                ds = new DataSet();
                da.Fill(ds);
                if(ds != null && ds.Tables.Count >0 )
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi Rồi "+ ex.Message, "Thông Báo");
            }
        }
    }
}
