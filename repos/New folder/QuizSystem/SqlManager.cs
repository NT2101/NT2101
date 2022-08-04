using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizSystem
{
    public class SqlManager
    {
        QuizSystemDataContext data;

        public SqlManager()
        {
            data = new QuizSystemDataContext();
        }

        #region Load data into datasource
        public List<DTO.Question> LoadAllQuestions()
        {
            return (from question in data.CauHois
                    select new DTO.Question
                    {
                        QuestionID = question.MaSoCH,
                        Content = question.NoiDung,
                        SelectA = question.PhuongAnA,
                        SelectB = question.PhuongAnB,
                        SelectC = question.PhuongAnC,
                        SelectD = question.PhuongAnD,
                        CorrectAnswer = question.DapAnDung.ToString(),
                        TheDifficult = question.DoKho,
                        SubjectID = question.MaSoHP,
                        Composer = question.GiangVienSoan

                    }).ToList();
        }

        public List<DTO.ExamList> LoadAllExamLists()
        {
            return (from examList in data.DanhSachThis
                    select new DTO.ExamList
                    {
                        ExamListID=examList.MaDS,
                        SubjectID=examList.MaSoHP,
                        TestRoomID=examList.MaPhongThi,
                        ExamDate=examList.NgayThi.Value,
                        StartTime=examList.GioBatDau.Value,
                        EndTime=examList.GioKetThuc.Value
                    }).ToList();
        }

        public List<DTO.Faculty> LoadAllFacalties()
        {
            return (from falcuty in data.Khoas
                    select new DTO.Faculty
                    {
                        FacultyID=falcuty.MaKhoa,
                        Name=falcuty.TenKhoa
                    }).ToList();
        }

        public List<DTO.QuizDetail> LoadAllQuizDetails()
        {
            return (from q in data.ChiTietDeThis
                    select new DTO.QuizDetail
                    {
                        QuizID=q.MaDeThi,
                        QuesID=q.MaSoCH
                    }
                    ).ToList();
        }

        public List<DTO.Lecturer> LoadAllLecturers()
        {
            return (from lecture in data.GiangViens
                    select new DTO.Lecturer
                    {
                        LecturerID=lecture.MaSoGV,
                        Name=lecture.HoTen,
                        BirthDate=lecture.NgaySinh.Value,
                        Degree=lecture.HocVi,
                        FacultyID=lecture.MaKhoa
                    }).ToList();
        }

        public List<DTO.Quiz> LoadAllQuizs()
        {
            return (from quiz in data.DeThis
                    select new DTO.Quiz
                    {
                        QuizID = quiz.MaDeThi.ToString(),
                        SubjectID = quiz.MaSoHP,
                        Time = (int)quiz.ThoiGian,
                        NoOfVeryEasyQues= (int)quiz.SoCauRatDe,
                        NoOfEasyQues= (int)quiz.SoCauDe,
                        NoOfMediumQues= (int)quiz.SoCauTB,
                        NoOfHardQues= (int)quiz.SoCauKho,
                        NoOfVeryHardQues= (int)quiz.SoCauRatKho,
                        Examinations=quiz.DotThi
                    }).ToList();
        }

        public List<DTO.Student> LoadAllStudents()
        {
            return (from student in data.SinhViens
                    select new DTO.Student
                    {
                        StudentID=student.MaSoSV,
                        Name=student.HoTen,     
                        BirthDate=student.NgaySinh,
                        FacultyID=student.MaKhoa
                    }).ToList();
        }

        public List<DTO.Subject> LoadAllSubjects()
        {
            return (from subject in data.HocPhans
                    select new DTO.Subject
                    {
                       SubjectID=subject.MaSoHP,
                       Name=subject.TenHP,
                       NoOfCredits=(int)subject.SoTinChi
                    }).ToList();
        }

        public List<DTO.TestRoom> LoadAllTestRooms()
        {
            return (from testRoom in data.PhongThis
                    select new DTO.TestRoom
                    {
                        RoomID=testRoom.MaPhongThi,
                        Name=testRoom.TenPhong
                    }).ToList();
        }

        public List<DTO.ListStudentDoQuiz> LoadAllStudentList()
        {
            return (from sv in data.DanhSachSinhVienThis
                    select new DTO.ListStudentDoQuiz
                    {
                        ListID = sv.MaDS,
                        StudentID = sv.MaSoSV
                    }
                    ).ToList();
        }

        public List<DTO.Question> LoadContentQuestions()
        {
            return (from ques in data.CauHois
                    select new DTO.Question
                    {
                        QuestionID = ques.MaSoCH,
                        Content = ques.NoiDung
                    }).ToList();
        }
        #endregion
    }
}
