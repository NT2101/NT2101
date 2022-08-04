using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizSystem
{
    public partial class DoQuizGUI : UserControl
    {
        private List<DTO.Question> quesList = new List<DTO.Question>();
        int currentQues = 0;
        //int flag = 0;
        bool flagA = false;
        bool flagB = false;
        bool flagC = false;
        bool flagD = false;
        int totalTimeQuiz;
        int selectOfStudent = 0;
        int noOfCorrectQues = 0; //tinh so cau dung
        float markQuiz = 0; //diem thi
        private DateTime testTime;
        private TimeSpan overTime; //thoi gian het
        private Timer time;
        private bool overTimeBool = false;
        private SqlDataProcess sqlData = new SqlDataProcess();
        private DTO.Quiz quiz = new DTO.Quiz();
        private DTO.Student student = new DTO.Student();
        private List<DTO.QuizDetail> quizDetail = new List<DTO.QuizDetail>();
        private DTO.Question question = new DTO.Question();



        public DoQuizGUI()
        {
            InitializeComponent();
          //  quesList = new SqlManager().LoadAllQuestions();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            //MainGUI frmMain = new MainGUI();
             Application.Exit();
        
           
        }

        #region Xu Ly
        //Bat tat rad
        private void _TurnOn_OffRadBTN(bool p)
        {
            radSelectTopA.Enabled = p;
            radSelectTopB.Enabled = p;
            radSelectTopC.Enabled = p;
            radSelectTopD.Enabled = p;

        }

        //Bat tat Button
        private void _TurnOn_OffButton(bool p)
        {
            btnBack.Enabled = p;
            btnHead.Enabled = p;
            btnLast.Enabled = p;
            btnNext.Enabled = p;
          //  btnStart.Enabled = p;
            btnSubmit.Enabled = p;
           
        }


        //Mo trang thai radio
        private void _SelectOptionOfRadio(int radio)
        {
            switch (radio)
            {
                case 1:
                    radSelectTopA.Checked = true;
                    break;
                case 2:
                    radSelectTopB.Checked = true;
                    break;
                case 3:
                    radSelectTopC.Checked = true;
                    break;
                case 4:
                    radSelectTopD.Checked = true;
                    break;
                default:
                    {
                        radSelectTopA.Checked = false;
                        radSelectTopB.Checked = false;
                        radSelectTopC.Checked = false;
                        radSelectTopD.Checked = false;
                        break;
                    }
            }
        }

        //Kiem tra ket qua thi
        private void _CheckResultTest()
        {
            
            for (int i = 0; i < quesList.Count; i++)
            {

                noOfCorrectQues++;
                markQuiz += (float)10 / noOfCorrectQues;
            }
            DialogResult info;
            info = MessageBox.Show("Tổng số câu đúng: " + noOfCorrectQues + "\rĐiểm: " + markQuiz, "Thông Báo", MessageBoxButtons.OK);
        }

        //Kiem tra co check radio?
        private int _CheckRadio()
        {
            if (radSelectTopA.Checked || radSelectTopB.Checked || radSelectTopC.Checked || radSelectTopD.Checked)
                return 1;
            return 0;
        }

        //Luu lua chon
        private void _SaveSelect()
        {
            if (_CheckRadio() == 1)
            {
                if (radSelectTopA.Checked)
                    selectOfStudent = 1;
                else if (radSelectTopB.Checked)
                {
                    selectOfStudent = 2;
                }
                else if (radSelectTopC.Checked)
                {
                    selectOfStudent = 3;
                }
                else if (radSelectTopD.Checked)
                {
                    selectOfStudent = 4;
                }
            }
            else
                selectOfStudent = 0;
        }


        //To mau nhung cau tra loi dung
        private void _ChangeColorCorrectQues(int currentQues)
        {
            string tempAnswer = quesList[currentQues].CorrectAnswer;
            if (tempAnswer == "A" || tempAnswer == "a")
            {
                flagA = true;
                flagB = false;
                flagC = false;
                flagD = false;
            }
            else if (tempAnswer == "B" || tempAnswer == "b")
            {
                flagA = false;
                flagB = true;
                flagC = false;
                flagD = false;
            }
            else if (tempAnswer == "C" || tempAnswer == "c")
            {
                flagA = false;
                flagB = false;
                flagC = true;
                flagD = false;
            }
            else if (tempAnswer == "D" || tempAnswer == "d")
            {
                flagA = false;
                flagB = false;
                flagC = false;
                flagD = true;
            }
            radSelectTopA.ForeColor = flagA ? Color.Orange : Color.Teal;
            radSelectTopB.ForeColor = flagB ? Color.Orange : Color.Teal;
            radSelectTopC.ForeColor = flagC ? Color.Orange : Color.Teal;
            radSelectTopD.ForeColor = flagD ? Color.Orange : Color.Teal;
        }
       

        #endregion
        private void tmrQuizTime_Tick(object sender, EventArgs e)
        {
            TimeSpan dt = new TimeSpan(0, 0, 1);
           // testTime = testTime.Subtract(dt);
            lblRemainingTime.Text = "Thời Gian Còn Lại: " + testTime.Minute.ToString() + " : " + testTime.Second.ToString();
            if (testTime.Minute==0 &&testTime.Second==0)
            {
                tmrQuizTime.Enabled = false;
                DialogResult mes = MessageBox.Show("Thời Gian Làm Bài Đã Hết! Mời Bạn Xem Kết Quả", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (mes==DialogResult.OK)
                {
                    _CheckResultTest();
                }
            }
        }

        private void DoQuizGUI_Load(object sender, EventArgs e)
        {
            //_LoadData();
            //_AppendQuestion();
            _TurnOn_OffButton(false);
            _TurnOn_OffRadBTN(false);

            //Thieu ham nap cau hoi
        }

        private void _AppendQuestion()
        {
            //quesList = new SqlManager().LoadAllQuestions();
        }

       

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (cboChooseQuiz.Text.Equals("--Lựa Chọn--"))
            {
                MessageBox.Show("Bạn Chưa Chọn Đề Thi! Vu lòng chọn", "Thông Báo", MessageBoxButtons.OK);
                cboChooseQuiz.Select();
            }
            DialogResult info = MessageBox.Show("Thời gian làm bài bắt đầu đếm ngược.\rĐiểm tối đa là 10 điểm.\n\rĐề thi có: " + quesList.Count.ToString() + " câu hỏi\r\nChúc bạn thi tốt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            if (info==DialogResult.OK)
            {
                tmrQuizTime.Start();
                quizDetail = sqlData._SelectQuizDetail(int.Parse(cboChooseQuiz.Text));
                for (int i=0;i<quizDetail.Count;i++)
                {
                    quesList.Add(sqlData._SelectQuestion(quizDetail[i].QuesID));
                }
                _TurnOn_OffRadBTN(true);
                _TurnOn_OffButton(true);
                //uestion = sqlData;
                lblTopContent.Text = "Câu 1: " + quesList[0].Content;
                radSelectTopA.Text = quesList[0].SelectA;
                radSelectTopB.Text = quesList[0].SelectB;
                radSelectTopC.Text = quesList[0].SelectC;
                radSelectTopD.Text = quesList[0].SelectD;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentQues<=quesList.Count-2)
            {
                _ChangeColorCorrectQues(currentQues);
                currentQues++;
                _SelectOptionOfRadio(selectOfStudent);
                lblTopContent.Text = "Câu " + (currentQues + 1).ToString() + ": " + quesList[currentQues].Content;
                radSelectTopA.Text = quesList[currentQues].SelectA;
                radSelectTopB.Text = quesList[currentQues].SelectB;
                radSelectTopC.Text = quesList[currentQues].SelectC;
                radSelectTopD.Text = quesList[currentQues].SelectD;
            }
            if (currentQues>=quesList.Count-1)
            {
                DialogResult mes = MessageBox.Show("Bạn có chắc muốn kết thúc phần thi của mình?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if(mes==DialogResult.OK)
                    _CheckResultTest();
            }
        }

        

        private void btnHead_Click(object sender, EventArgs e)
        {

        }

        private void btnLast_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vui lòng chọn tất cả đáp án\nNếu nộp bài sớm hơn");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (currentQues>0)
            {
                _ChangeColorCorrectQues(currentQues);
                currentQues--;
                if (currentQues > 0)
                {
                    _SelectOptionOfRadio(selectOfStudent);
                    lblTopContent.Text = "Câu " + (currentQues + 1).ToString() + ": " + quesList[currentQues].Content;
                    radSelectTopA.Text = quesList[currentQues].SelectA;
                    radSelectTopB.Text = quesList[currentQues].SelectB;
                    radSelectTopC.Text = quesList[currentQues].SelectC;
                    radSelectTopD.Text = quesList[currentQues].SelectD;
                }
                else
                {
                    currentQues = 0;
                    lblTopContent.Text = "Câu 1: " + quesList[0].Content;
                    radSelectTopA.Text = quesList[0].SelectA;
                    radSelectTopB.Text = quesList[0].SelectB;
                    radSelectTopC.Text = quesList[0].SelectC;
                    radSelectTopD.Text = quesList[0].SelectD;
                }
            }
        }

        private void radSelectTopA_CheckedChanged(object sender, EventArgs e)
        {
            _SaveSelect();
        }

        private void radSelectTopB_CheckedChanged(object sender, EventArgs e)
        {
            _SaveSelect();
        }

        private void radSelectTopC_CheckedChanged(object sender, EventArgs e)
        {
            _SaveSelect();
        }

        private void radSelectTopD_CheckedChanged(object sender, EventArgs e)
        {
            _SaveSelect();
        }

        private void txtStudentID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                student = sqlData._SelectStudent(txtStudentID.Text);
                txtStudentName.Text = student.Name;
                txtFaculty.Text = student.FacultyID;

            }
        }

        private void cboChooseQuiz_DropDown(object sender, EventArgs e)
        {
            cboChooseQuiz.DataSource = new SqlManager().LoadAllQuizs();
            cboChooseQuiz.DisplayMember = "QuizID";
            cboChooseQuiz.ValueMember = "QuizID";
            quiz = sqlData._SelectQuiz(int.Parse(cboChooseQuiz.Text));
            txtSubjectName.Text = quiz.SubjectID;
        }
    }
}
