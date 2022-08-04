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
    public partial class SelectTestSubjectGUI : Form
    {
        public string StudentID { get; set; }
        public string QuizID { get; set; }
        //public string SubjectID { get; set; }
        public bool IsSelectedQuiz { get; set; }
        public bool IsClose { get; set; }
        private SqlDataProcess sqlData = new SqlDataProcess();
        public DTO.Student student { get; set; }
        public DTO.Quiz quiz { get; set; }
        public SelectTestSubjectGUI()
        {
            student = new DTO.Student();
            quiz = new DTO.Quiz();
            InitializeComponent();
            IsSelectedQuiz = false;
        }

        
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtStudentID.Text.Equals(""))
            {
                MessageBox.Show("Bạn Chưa Nhập Mã Số Sinh Viên! Vui lòng nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStudentID.Select();
            }
            else if (cboChooseQuiz.Text.Equals("--Lựa Chọn--"))
            {
                MessageBox.Show("Bạn Chưa Chọn Đề Thi! Vui lòng chọn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboChooseQuiz.Select();
            }
          
            else
            {
                QuizID = cboChooseQuiz.Text;
                StudentID = txtStudentID.Text;
        
                this.Close();
                IsClose = true;
               // IsSelectedQuiz = true;
            }
               
        }

        private void SelectTestSubjectGUI_Load(object sender, EventArgs e)
        {
            IsClose = false;
            
            //cboChooseQuiz.DataSource = new SqlManager().LoadAllQuizs();

            Location = new Point(250, 250);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        

        private void cboChooseQuiz_DropDown(object sender, EventArgs e)
        {
            cboChooseQuiz.DataSource = new SqlManager().LoadAllQuizs();
            cboChooseQuiz.DisplayMember = "QuizID";
            cboChooseQuiz.ValueMember = "QuizID";
            quiz = sqlData._SelectQuiz(int.Parse(cboChooseQuiz.Text));
           txtSubject.Text = quiz.SubjectID;
        }

        private void txtStudentID_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtStudentID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                student = sqlData._SelectStudent(txtStudentID.Text);
                txtStudentName.Text = student.Name;
                txtBirthDate.Text = student.BirthDate;
                txtFacalty.Text = student.FacultyID;
            }
        }
    }
}
