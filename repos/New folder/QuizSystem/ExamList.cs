using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuizSystem
{
    public partial class ExamList : UserControl
    {
        private SqlDataProcess sqlData = new SqlDataProcess();
        private SqlManager sqlManager = new SqlManager();
        public ExamList()
        {
            InitializeComponent();
        }

        private void btnToRight_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Đã Di Chuyển 1 Câu Hỏi Qua Bên Phải", "Thông Báo", MessageBoxButtons.OK);

        }

        private void btnToLeft_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Đã Di Chuyển 1 Câu Hỏi Qua Bên Trái", "Thông Báo", MessageBoxButtons.OK);

        }

        private void _LoadSource()
        {
            gridStudentList.DataSource = sqlManager.LoadAllStudents();
            gridExamList.DataSource = sqlManager.LoadAllStudentList();
        }

        private void cboChooseSubject_DropDown(object sender, EventArgs e)
        {
            cboChooseSubject.DataSource = sqlManager.LoadAllSubjects();
            cboChooseSubject.DisplayMember = "Name";
            cboChooseSubject.ValueMember = "SubjectID";
        }

        private void cboChooseRoom_DropDown(object sender, EventArgs e)
        {
            cboChooseRoom.DataSource = sqlManager.LoadAllTestRooms();
            cboChooseRoom.DisplayMember = "Name";
            cboChooseRoom.ValueMember = "RoomID";
        }

        private void cboChooseLecturer_DropDown(object sender, EventArgs e)
        {
            cboChooseLecturer.DataSource = sqlManager.LoadAllLecturers();
            cboChooseLecturer.DisplayMember = "Name";
            cboChooseLecturer.ValueMember = "LecturerID";
        }

        private void ExamList_Load(object sender, EventArgs e)
        {
            _LoadSource();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cboChooseLecturer.Text = "--Lựa Chọn--";
            cboChooseRoom.Text = "--Lựa Chọn--";
            cboChooseSubject.Text = "--Lựa Chọn--";
            _LoadSource();
            XtraMessageBox.Show("Đã Làm Mới!", "Thông Báo", MessageBoxButtons.OK);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
