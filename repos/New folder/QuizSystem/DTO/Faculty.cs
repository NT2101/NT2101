using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizSystem.DTO
{
    public class Faculty
    {
        private string facultyID;
        private string name;

        #region get/set
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
        #endregion
    }
}
