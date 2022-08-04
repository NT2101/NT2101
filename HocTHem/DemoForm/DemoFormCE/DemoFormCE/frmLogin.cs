using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoFormCE
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            var Result = ReadFile();
            if (Result == true)
                chkDangNhap.Checked = true;
            else
                chkDangNhap.Checked = false;

        }

        public void RemmemberPassWord(string Account, string PassWord)
        {
            string fileName = "qlns.txt";
            string path = Path.Combine(Environment.CurrentDirectory, fileName);
            if (chkDangNhap.Checked == true)
            {
              
                string writeText = Account + ";" + PassWord;
                File.WriteAllText(path, writeText);
            }
          else
            {
             
               if(File.Exists(path))
                {
                    File.Delete(path);
                }

            }
        }
        public bool ReadFile()
        {
            try
            {
                string fileName = "qlns.txt";
                string path = Path.Combine(Environment.CurrentDirectory, fileName);
                if(File.Exists(path))
                {
                    string text = File.ReadAllText(path, Encoding.UTF8);
                    var arr = text.Split(';');
                    txtUser.Text = arr[0].ToString();
                    txtPass.Text = arr[1].ToString();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            RemmemberPassWord(txtUser.Text, txtPass.Text);
            if(txtUser.Text =="DucAnh"&&txtPass.Text=="1")
            {
                FrmChinh _frmChinh = new FrmChinh();
                _frmChinh.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Account not correct", "Thông báo");
            }
        }
    }   
}

