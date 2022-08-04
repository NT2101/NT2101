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
    public partial class CreateTestQuiz : Form
    {
        private SqlManager sql;

        public CreateTestQuiz()
        {
            sql = new SqlManager();
            InitializeComponent();
        }

        #region Ham Tu viet

        private void _RefreshForm()
        {
            cboChooseQuiz.Text = "--Lựa Chọn--";
            _LoadSoure();
            XtraMessageBox.Show("Đã Làm Mới!","Thông Báo",MessageBoxButtons.OK);
        }

        private void _LoadSoure()
        {
            gridQuesList.DataSource = sql.LoadAllQuestions();
            gridQuizDetail.DataSource = sql.LoadAllQuizDetails();
          
        }

        #endregion

        private void CreateTestQuiz_Load(object sender, EventArgs e)
        {
            _LoadSoure();
            Location = new Point(150, 150);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _RefreshForm();
           // _LoadSoureToGrid()
        }

        private void btnToRight_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Đã Di Chuyển 1 Câu Hỏi Qua Bên Phải", "Thông Báo", MessageBoxButtons.OK);
        }

        private void btnToLeft_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Đã Di Chuyển 1 Câu Hỏi Qua Bên Trái", "Thông Báo", MessageBoxButtons.OK);
        }

        private void CreateTestQuiz_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Right)
            {
                btnToRight_Click(sender, e);
            }
            else if (e.KeyCode==Keys.Left)
            {
                btnToLeft_Click(sender, e);
            }
        }

        private void cboChooseQuiz_DropDown(object sender, EventArgs e)
        {
            cboChooseQuiz.DataSource = sql.LoadAllQuizs();
            cboChooseQuiz.DisplayMember = "QuizID";
            cboChooseQuiz.ValueMember = "QuizID";
        }
    }
}
