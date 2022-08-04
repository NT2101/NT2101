using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizSystem.DTO
{
    public class Lecturer
    {
        private string lecturerID;
        private string name;
        private DateTime birthDate;
        private string degree;
        private string facultyID;
        #region get/set
        public string LecturerID
        {
            get
            {
                return lecturerID;
            }

            set
            {
                lecturerID = value;
            }
        }

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

        public DateTime BirthDate
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

        public string Degree
        {
            get
            {
                return degree;
            }

            set
            {
                degree = value;
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
        #endregion

    }
}
