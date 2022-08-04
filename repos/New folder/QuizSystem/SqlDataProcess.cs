using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizSystem
{
    public class SqlDataProcess
    {
        private QuizSystemDataContext data;
        private SqlConnection cnn;
        private SqlCommand cmd;
        public SqlDataProcess()
        {
            
            cnn = new SqlConnection(@"Data Source=DESKTOP-J0QSODC\MYSQL;Initial Catalog=QuizSystem;Integrated Security=True");
            data = new QuizSystemDataContext();
        }

        public void _Connect()
        {
            if (cnn != null && cnn.State == System.Data.ConnectionState.Closed)
                cnn.Open();
        }

        public void _DisConnect()
        {
            if (cnn != null && cnn.State == System.Data.ConnectionState.Open)
                cnn.Close();
        }

        

        #region Thêm Dữ Liệu
        public int  _CheckQuesID(String quesID)
        {
            _Connect();
            cmd = new SqlCommand("select count(*) from CauHoi where MaSoCH==@quesID", cnn);
            cmd.Parameters.Add("@quesID", System.Data.SqlDbType.Int).Value = int.Parse(quesID);
            int n = (int)cmd.ExecuteScalar();
            _DisConnect();
            return n;
        }

        public DTO.Student _SelectStudent(string studentID)
        {
            var selectStudent = data.SinhViens.Single(s => s.MaSoSV == int.Parse(studentID));
            DTO.Student student = new DTO.Student();
            student.Name = selectStudent.HoTen;
            student.FacultyID = selectStudent.MaKhoa;
            return student;
                   
        }

        public List<DTO.QuizDetail> _SelectQuizDetail(int quizID)
        {
            return (from q in data.ChiTietDeThis
                    where q.MaDeThi == quizID
                    select new DTO.QuizDetail
                    {
                        QuesID=q.MaSoCH,
                        QuizID=q.MaDeThi
                    }).ToList();
        }

        public DTO.Question _SelectQuestion(int quesID)
        {
            var q = data.CauHois.Single(a => a.MaSoCH == quesID);
            DTO.Question ques = new DTO.Question();
            ques.QuestionID = q.MaSoCH;
            ques.Content = q.NoiDung;
            ques.SelectA = q.PhuongAnA;
            ques.SelectB = q.PhuongAnB;
            ques.SelectC = q.PhuongAnC;
            ques.SelectD = q.PhuongAnD;
            ques.CorrectAnswer = q.DapAnDung.ToString();
            ques.TheDifficult = q.DoKho;
            ques.SubjectID = q.MaSoHP;
            ques.Composer = q.GiangVienSoan;
            return ques;
        }

        public DTO.Quiz _SelectQuiz(int quizID)
        {
            var selectQuiz = data.DeThis.Single(q => q.MaDeThi == quizID);
            DTO.Quiz quiz = new DTO.Quiz();
            quiz.QuizID = selectQuiz.MaDeThi.ToString();
            quiz.SubjectID = selectQuiz.MaSoHP;
            return quiz;

        }

        public void _Insert_Add_Question(String content,String a,String b,String c,String d,String correct,String difficult,String subjectID,String composer)
        {
            String query = "insert into CauHoi values (@content,@a,@b,@c,@d,@correct,@difficult,@subjectID,@composer";
            cmd = new SqlCommand(query, cnn);
            cmd.Parameters.Add("@content", SqlDbType.NVarChar).Value = content;
            cmd.Parameters.Add("@a", SqlDbType.NVarChar).Value = a;
            cmd.Parameters.Add("@b", SqlDbType.NVarChar).Value = b;
            cmd.Parameters.Add("@c", SqlDbType.NVarChar).Value = c;
            cmd.Parameters.Add("@d", SqlDbType.NVarChar).Value = d;
            cmd.Parameters.Add("@correct", SqlDbType.Char).Value = correct;
            cmd.Parameters.Add("@difficult", SqlDbType.NVarChar).Value = difficult;
            cmd.Parameters.Add("@subjectID", SqlDbType.VarChar).Value = subjectID;
            cmd.Parameters.Add("@composer", SqlDbType.VarChar).Value = composer;
            _Connect();
            cmd.ExecuteNonQuery();
            _DisConnect();
        }

        public void InsertFalcuty(String id,String name)
        {
            
        }
        #endregion
    }
}
