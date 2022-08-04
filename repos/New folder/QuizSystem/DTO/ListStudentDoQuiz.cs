using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizSystem.DTO
{
    public class ListStudentDoQuiz
    {
        private string listID;
        private int studentID;
       // ctor
        public string ListID
        {
            get
            {
                return listID;
            }

            set
            {
                listID = value;
            }
        }

        public int StudentID
        {
            get
            {
                return studentID;
            }

            set
            {
                studentID = value;
            }
        }
    }
}
