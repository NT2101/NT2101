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
    public partial class CreateQuiz : UserControl
    {
        private bool flagA;
        private bool flagB;
        private bool flagC;
        private bool flagD;
       // private int currentQues;
        //private List<DTO.Question> quesList = new List<DTO.Question>();
        private DTO.Question question;
        private int selectOfUser;

        public CreateQuiz()
        {
            InitializeComponent();
            flagA = false;
            flagB = false;
            flagC = false;
            flagD = false;
            //currentQues = 0;
            selectOfUser = 0;
            question = new DTO.Question();
        }


        #region Khu vuc ham tu viet
        private void _RefreshForm()
        {
            txtQuesContent.ResetText();
            txtSelectA.ResetText();
            txtSelectB.ResetText();
            txtSelectC.ResetText();
            txtSelectD.ResetText();
            radCorrectA.Checked = false;
            radCorrectB.Checked = false;
            radCorrectC.Checked = false;
            radCorrectD.Checked = false;
            cboDifficult.Text = "--Lựa Chọn--";
            cboSubject.Text = "--Lựa Chọn--";
            cboComposer.Text = "--Lựa Chọn--";
            /*
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    (c as TextBox).Text = "";
                }
                if (c is RadioButton)
                {
                    (c as RadioButton).Checked = false;
                }
                if (c is ComboBox)
                {
                    (c as ComboBox).Text = "--Lựa Chọn--";
                }
            }
            */
            _LoadSourceToGrid();
        }

        private void _TurnOn_OffRadBTN(bool p)
        {
            radCorrectA.Enabled = p;
            radCorrectB.Enabled = p;
            radCorrectC.Enabled = p;
            radCorrectD.Enabled = p;
        }

        //Mo trang thai radio
        private void _SelectOptionOfRadio(int radio)
        {
            switch (radio)
            {
                case 1:
                    radCorrectA.Checked = true;
                    break;
                case 2:
                    radCorrectB.Checked = true;
                    break;
                case 3:
                    radCorrectC.Checked = true;
                    break;
                case 4:
                    radCorrectD.Checked = true;
                    break;
                default:
                    {
                        radCorrectA.Checked = false;
                        radCorrectB.Checked = false;
                        radCorrectC.Checked = false;
                        radCorrectD.Checked = false;
                        break;
                    }
            }
        }

        //Luu lua chon
        private void _SaveSelect()
        {
            if (_CheckRadio() == 1)
            {
                if (radCorrectA.Checked)
                    selectOfUser = 1;
                else if (radCorrectB.Checked)
                {
                    selectOfUser = 2;
                }
                else if (radCorrectC.Checked)
                {
                    selectOfUser = 3;
                }
                else if (radCorrectD.Checked)
                {
                    selectOfUser = 4;
                }
                _ChangeColorCorrectQues();
            }
            else
                selectOfUser = 0;
        }

        //To mau nhung cau tra loi dung
        private void _ChangeColorCorrectQues()
        {
            
        
            if (selectOfUser==1)
            {
                flagA = true;
                flagB = false;
                flagC = false;
                flagD = false;
            }
            else if (selectOfUser==2)
            {
                flagA = false;
                flagB = true;
                flagC = false;
                flagD = false;
            }
            else if (selectOfUser == 3)
            {
                flagA = false;
                flagB = false;
                flagC = true;
                flagD = false;
            }
            else if (selectOfUser == 4)
            {
                flagA = false;
                flagB = false;
                flagC = false;
                flagD = true;
            }
            txtSelectA.ForeColor = flagA ? Color.Orange : Color.Navy;
            txtSelectB.ForeColor = flagB ? Color.Orange : Color.Navy;
            txtSelectC.ForeColor = flagC ? Color.Orange : Color.Navy;
            txtSelectD.ForeColor = flagD ? Color.Orange : Color.Navy;
        }

        private void _LoadSourceToCBO()
        {
            cboSubject.DataSource = new SqlManager().LoadAllSubjects();
            cboSubject.DisplayMember = "Name";
            cboSubject.ValueMember = "SubjectID";
            cboComposer.DataSource = new SqlManager().LoadAllLecturers();
            cboComposer.DisplayMember = "Name";
            cboComposer.ValueMember = "LecturerID";
        }

        //load du lieu vao grid view
        private void _LoadSourceToGrid()
        {
            gridControl1.DataSource = new SqlManager().LoadAllQuestions();
        }

        //Kiem tra co check radio?
        private int _CheckRadio()
        {
            if (radCorrectA.Checked || radCorrectB.Checked || radCorrectC.Checked || radCorrectD.Checked)
                return 1;
            return 0;
        }

        //Kiem tra rong
        private bool _ControlIsEmpty()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text.Equals(""))
                        return true;           
                }
                
                if (c is ComboBox)
                {
                    if (c.Text.Equals("") ||c.Text.Equals("--Lựa Chọn--"))
                        return true;
                }
            }
            return false;
        }
        #endregion
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _RefreshForm();          
        }

        private void btnCreateQues_Click(object sender, EventArgs e)
        {
          
            if  (txtQuesContent.Text.Equals(""))
            {
                MessageBox.Show("Bạn Chưa Nhập Nội Dung!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuesContent.Select();
            }
            else if (txtSelectA.Text.Equals(""))
            {
                MessageBox.Show("Bạn Chưa nhập lựa chọn A!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSelectA.Select();
            }
            else if(txtSelectB.Text.Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập lựa chọn B!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSelectB.Select();
            }
            else if (txtSelectC.Text.Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập lựa chọn C!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSelectC.Select();
            }
            else if (txtSelectD.Text.Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập lựa chọn D!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSelectD.Select();
            }
            else if (cboDifficult.Text.Equals("--Lựa Chọn--"))
            {
                MessageBox.Show("Bạn chưa chọn độ khó cho câu hỏi!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboDifficult.Select();
            }
            else if (cboSubject.Text.Equals("--Lựa Chọn--"))
            {
                MessageBox.Show("Bạn chưa chọn môn học!","Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboSubject.Select();
            }
            else if (cboComposer.Text.Equals("--Lựa Chọn--"))
            {
                MessageBox.Show("Bạn chưa chọn người soạn!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboComposer.Select();
            }
            else if (_CheckRadio() == 0)
            {
                MessageBox.Show("Bạn chưa nhập đáp án cho câu hỏi!\r\nVui lòng nhập vào.", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                _SaveSelect();
                question.Content = txtQuesContent.Text.ToString();
                question.SelectA = txtSelectA.Text.ToString();
                question.SelectB = txtSelectB.Text.ToString();
                question.SelectC = txtSelectC.Text.ToString();
                question.SelectD = txtSelectD.Text.ToString();
                question.TheDifficult = cboDifficult.Text.ToString() ;
                question.SubjectID = cboSubject.SelectedValue.ToString();
                question.Composer = cboComposer.SelectedValue.ToString();
                switch (selectOfUser)
                {
                    case 1:
                        question.CorrectAnswer = "A";
                        break;
                    case 2:
                        question.CorrectAnswer = "B";
                        break;                     
                    case 3:
                        question.CorrectAnswer = "C";
                        break;
                    case 4:
                        question.CorrectAnswer = "D";
                        break;
                    default:
                        MessageBox.Show("Bạn chưa nhập đủ thông tin cần thiết cho câu hỏi!\r\nVui lòng nhập vào.", "Thông Báo", MessageBoxButtons.OK);
                        break;
                }
                SqlDataProcess sqlData = new SqlDataProcess();
                sqlData._Insert_Add_Question(question.Content, question.SelectA, question.SelectB, question.SelectC, question.SelectD, question.CorrectAnswer, question.TheDifficult, question.SubjectID, question.Composer);
            }
            _LoadSourceToGrid();
        }

        private void CreateQuiz_Load(object sender, EventArgs e)
        {
            //_LoadSourceToCBO();
            _LoadSourceToGrid();      
        }

        private void cboSubject_DropDown(object sender, EventArgs e)
        {
            cboSubject.DataSource = new SqlManager().LoadAllSubjects();
            cboSubject.DisplayMember = "Name";
            cboSubject.ValueMember = "SubjectID";
        }

        private void cboComposer_DropDown(object sender, EventArgs e)
        {
            cboComposer.DataSource = new SqlManager().LoadAllLecturers();
            cboComposer.DisplayMember = "Name";
            cboComposer.ValueMember = "LecturerID";
        }

        private void radCorrectA_CheckedChanged(object sender, EventArgs e)
        {
            _SaveSelect();
        }

        private void radCorrectB_CheckedChanged(object sender, EventArgs e)
        {
            _SaveSelect();
        }

        private void radCorrectC_CheckedChanged(object sender, EventArgs e)
        {
            _SaveSelect();
        }

        private void radCorrectD_CheckedChanged(object sender, EventArgs e)
        {
            _SaveSelect();
        }

        private void cardVQues_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtQuesContent.Text = cardVQues.GetRowCellValue(2, "Content").ToString();
            txtSelectA.Text = cardVQues.GetRowCellValue(3, "SelectA").ToString();
            txtSelectB.Text = cardVQues.GetRowCellValue(4, "SelectB").ToString();
            txtSelectC.Text = cardVQues.GetRowCellValue(5, "SelectC").ToString();
            txtSelectD.Text = cardVQues.GetRowCellValue(6, "SelectD").ToString();
            cboDifficult.Text = cardVQues.GetRowCellValue(7, "TheDifficult").ToString();
            cboSubject.Text = cardVQues.GetRowCellValue(8, "SubjectID").ToString();
            cboComposer.Text = cardVQues.GetRowCellValue(9, "Composer").ToString();
        }

        private void btnCreateQuiz_Click(object sender, EventArgs e)
        {
            CreateTestQuiz frmCreateQuiz = new CreateTestQuiz();
            frmCreateQuiz.Show();
        }
    }
}
