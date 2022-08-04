using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoFormCE
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            try
            {
                string hovaten = " Thí Sinh: " + txthoten.Text.Trim();
                string trinhdo = " Trình Độ : " + cboTrinhDo.Text.Trim();
                string ngayinh = " Sinh Ngày: " + dtpNgaySinh.Text.Trim();
                string dangky = " " ;
                if (chkdangky.Checked == true)
                    dangky = " Đồng ý";
                else
                    dangky = " Không đồng ý ";
                string gioitinh = " ";
                if (rdonam.Checked == true)
                    gioitinh = "  Nam ";
                else
                    gioitinh = "  Nữ ";
                

                MessageBox.Show(hovaten +  ngayinh  +  trinhdo + "Giới Tính : " + gioitinh +  "Đăng ký : " + dangky  , "Thông báo");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:" + ex.Message ,"Thông báo");
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
