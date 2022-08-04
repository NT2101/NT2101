using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuizSystem
{
    public partial class MainGUI : Form
    {
        public DTO.Student student { get; set; }
        public DTO.Quiz quiz { get; set; }
        private WelcomeGUI frmHome;
        private LoginGUI frmLogin;
        //private QuestionGUI frmQuestion;
        private DoQuizGUI frmDoQuiz;

        public MainGUI()
        {
            InitializeComponent();
            frmDoQuiz = new DoQuizGUI();
           // frmQuestion = new QuestionGUI();
            frmHome = new WelcomeGUI();
            frmLogin = new LoginGUI();

        }

        private void MainGUI_Load(object sender, EventArgs e)
        {

            DisableAllControls();
            panelMain.Controls.Clear();
            frmHome.Show();
            frmHome.Dock = DockStyle.Fill;
            panelMain.Controls.Add(frmHome);
            Location = new Point(0, 0);
            barTextWelcome.Enabled = false;
            barTextCurrentTime.Caption = DateTime.Now.ToShortTimeString();
            barTextCurrentDate.Caption = DateTime.Now.ToString("dd-MM-yyyy");
        }

        public void DisableAllControls()
        {

            navItemQuestionLevel.Enabled = false;
            navItemBlendQuiz.Enabled = false;
            navItemCreateTestList.Enabled = false;
            navItemCreateQuestion.Enabled = false;
            navItemDoQuiz.Enabled = false;
            grbTestRoom.Enabled = false;
            grbImportStudent.Enabled = false;
            grbQuiz.Enabled = false;
            grbQuestion.Enabled = false;
            grbExamList.Enabled = false;
            
            
        }


        private void btnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DisableAllControls();
            MainGUI_Load(sender, e);
            frmLogin.ShowDialog();
            if (frmLogin.IsLecturer)
            {
                navItemCreateQuestion.Enabled = true;
                grbQuiz.Enabled = true;
                grbQuestion.Enabled = true;
                barTextStatus.Caption = "Trạng thái: Đã đăng nhập";
                barTextCurrentAccount.Caption = "Tài khoản hiện đang sử dụng: " + frmLogin.userID;
            }
            else if (frmLogin.IsTestingRoom)
            {
                navItemBlendQuiz.Enabled = true;
                navItemCreateTestList.Enabled = true;
                navItemQuestionLevel.Enabled = true;
                grbExamList.Enabled = true;
                grbImportStudent.Enabled = true;
                grbTestRoom.Enabled = true; 
                barTextStatus.Caption = "Trạng thái: Đã đăng nhập";
               barTextCurrentAccount.Caption = "Tài khoản hiện đang sử dụng: " + frmLogin.userID;
            }
            else if (frmLogin.IsStudent)
            {
                barTextCurrentAccount.Caption = "Tài khoản hiện đang sử dụng: " + frmLogin.userID;
                barTextStatus.Caption = "Trạng thái: Đã đăng nhập";
                navItemDoQuiz.Enabled = true;
             //   if (!frmLogin.typedStudentID.Equals(""))
                //{
               //     barTextWelcome.Enabled = true;
                  //  barTextWelcome.Caption += frmLogin.typedStudentID;
                //}
                //navItemSubmit.Enabled = true;
            }
            else
            {
                MainGUI_Load(sender, e);
            }
        }


        
        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //this.Close();
            Application.Exit();
        }



        public void navItemGoHome_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelMain.Controls.Clear();
            frmHome.Show();
            frmHome.Dock = DockStyle.Fill;
            panelMain.Controls.Add(frmHome);
        }

        private void btnViewQuestion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            CreateQuiz frmCreateQues = new CreateQuiz();
            frmCreateQues.Show();
            frmCreateQues.Dock = DockStyle.Fill;
            panelMain.Controls.Add(frmCreateQues);
        }

        private void navItemDoQuiz_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //RegulationGUI frmRegular = new RegulationGUI();
            //frmRegular.ShowDialog();
            DialogResult regularBox;
            regularBox = MessageBox.Show("01. CẤM gây ồn ào, mất trật tự tại khu vực thi, khi thi.\r02. CẤM mang điện thoại di động vào phòng thi\r03. CẤM mang tài liệu vào phòng thi.", "Nội Quy Phòng Thi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (regularBox == DialogResult.OK)
            {
                

                //SelectTestSubjectGUI frmSelectQuiz = new SelectTestSubjectGUI();
                //frmSelectQuiz.ShowDialog();
               
                    panelMain.Controls.Clear();
                    frmDoQuiz.Show();
                    frmDoQuiz.Dock = DockStyle.Fill;
                    panelMain.Controls.Add(frmDoQuiz);
                     
            }
        }

        private void btnImportStudent_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFileDialog fileOpen = new OpenFileDialog();
            fileOpen.Filter = "XML file(*.xml)|*.xml|Excel File(*.xlsx)|*.xlsx|All file(*.*)|*.*";
            fileOpen.Title = "Chọn danh sách sinh viên";
            fileOpen.ShowDialog();
            if (fileOpen.ShowDialog()==DialogResult.OK)
            {
                string path = fileOpen.FileName;
            }
        }

        private void navItemCreateQuestion_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            CreateQuiz frmCreateQuestion = new CreateQuiz();
            panelMain.Controls.Clear();
            frmCreateQuestion.Show();
            frmCreateQuestion.Dock = DockStyle.Fill;
            panelMain.Controls.Add(frmCreateQuestion);
        }

        private void btnViewQuiz_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewQuizGUI frmViewQuiz = new ViewQuizGUI();
            panelMain.Controls.Clear();
            frmViewQuiz.Show();
            frmViewQuiz.Dock = DockStyle.Fill;
            panelMain.Controls.Add(frmViewQuiz);
        }

        private void navItemBlendQuiz_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            CreateTestQuiz frmCreateQuiz = new CreateTestQuiz();
            frmCreateQuiz.Show();
        }

        private void navItemCreateTestList_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ExamList frmExamList = new ExamList();
            panelMain.Controls.Clear();
            frmExamList.Show();
            frmExamList.Dock = DockStyle.Fill;
            panelMain.Controls.Add(frmExamList);
        }

        private void navItemQuestionLevel_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            XtraMessageBox.Show("Xin lỗi! Chức Năng Hiện Đang Xây Dựng!", "Thông Báo", MessageBoxButtons.OK);
        }

        private void btnViewTestRoom_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewRoom frmViewRoom = new ViewRoom();
            panelMain.Controls.Clear();
            frmViewRoom.Show();
            frmViewRoom.Dock = DockStyle.Fill;
            panelMain.Controls.Add(frmViewRoom);
        }

        private void btnViewExamList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewListExam viewList = new ViewListExam();
            panelMain.Controls.Clear();
            viewList.Show();
            viewList.Dock = DockStyle.Fill;
            panelMain.Controls.Add(viewList);
        }

        private void btnAddRoom_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraMessageBox.Show("Xin lỗi! Chức Năng Hiện Đang Xây Dựng!", "Thông Báo", MessageBoxButtons.OK);
        }

        private void btnUpdateRoom_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraMessageBox.Show("Xin lỗi! Chức Năng Hiện Đang Xây Dựng!", "Thông Báo", MessageBoxButtons.OK);
        }

        private void btnViewBannedList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraMessageBox.Show("Xin lỗi! Chức Năng Hiện Đang Xây Dựng!", "Thông Báo", MessageBoxButtons.OK);
        }
    }

}

