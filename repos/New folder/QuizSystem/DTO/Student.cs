using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizSystem.DTO
{
    public class Student
    {
        private int studentID;
        private string name;
        private string birthDate;
        private string facultyID;

        #region get/set
        

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string BirthDate
        {
            get
            {
                return birthDate;
            }

            set
            {
                birthDate = value;
            }
        }

        public string FacultyID
        {
            get
            {
                return facultyID;
            }

            set
            {
                facultyID = value;
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
        #endregion
    }
}
