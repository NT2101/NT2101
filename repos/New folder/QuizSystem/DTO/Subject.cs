using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizSystem.DTO
{
    public class Subject
    {
        private string subjectID;
        private string name;
        private int noOfCredits;

        #region get/set
        public string SubjectID
        {
            get
            {
                return subjectID;
            }

            set
            {
                subjectID = value;
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

        public int NoOfCredits
        {
            get
            {
                return noOfCredits;
            }

            set
            {
                noOfCredits = value;
            }
        }
        #endregion
    }
}
