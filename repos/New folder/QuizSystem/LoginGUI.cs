using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizSystem
{
    public partial class LoginGUI : Form
    {
        public string userID { get; set; }
        public string pass { get; set; }
        public bool IsLecturer { get; set; }
        public bool IsStudent { get; set; }

        public bool IsTestingRoom { get; set; }
        public string typedStudentID { get; set; }
        public string typedFaculty { get; set; }
        public LoginGUI()
        {
            InitializeComponent();
            
        }

        private void LoginGUI_Load(object sender, EventArgs e) 
        {
            IsLecturer = false;
            IsStudent = false;
            IsTestingRoom = false;
            Location = new Point(200, 200);
        }

        
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (cboUser.Text.Equals("") || cboUser.Text.Equals("--Lựa chọn--"))
            {
                MessageBox.Show("Tài khoản không được để trống! Xin mời nhập lại!");
                cboUser.Select();
            }
            else if (txtPassword.Equals(""))
            {
                MessageBox.Show("Mật khẩu không được để trống! Xin mời nhập lại!");
                txtPassword.Select();
            }
            else
            {
                if (cboUser.Text.Equals("Lecturer") && txtPassword.Text.Equals("1"))
                {
                    IsLecturer = true;             
                    userID = cboUser.Text;
                    pass = txtPassword.Text;
                    this.Hide();
                }
                else if (cboUser.Text.Equals("Student") && txtPassword.Text.Equals("1"))
                {
                   // InputInformationGUI frmInput = new InputInformationGUI();
                   // this.Hide();
                  //  frmInput.ShowDialog();                 
                    IsStudent = true;               
                    userID = cboUser.Text;
                    pass = txtPassword.Text;
                    this.Hide();
                  //  typedFaculty = frmInput.TypedFaculty;
                   // typedStudentID = frmInput.TypedStudentID;
                   
                }
                else if (cboUser.Text.Equals("TestingRoom") && txtPassword.Text.Equals("1"))
                {
                    IsTestingRoom = true;
                    userID = cboUser.Text;
                    pass = txtPassword.Text;
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng! Xin mời nhập lại!");
                    cboUser.Select();
                }
            }
        }
    }
}
