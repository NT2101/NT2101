using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizSystem.DTO
{
    public class Quiz
    {
        private string quizID;
        private string subjectID;
        private int time;
        private int noOfVeryEasyQues;
        private int noOfEasyQues;
        private int noOfMediumQues;
        private int noOfHardQues;
        private int noOfVeryHardQues;
        private string examinations;

        #region get/set
        public string QuizID
        {
            get
            {
                return quizID;
            }

            set
            {
                quizID = value;
            }
        }

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

        public int Time
        {
            get
            {
                return time;
            }

            set
            {
                time = value;
            }
        }

        public int NoOfVeryEasyQues
        {
            get
            {
                return noOfVeryEasyQues;
            }

            set
            {
                noOfVeryEasyQues = value;
            }
        }

        public int NoOfEasyQues
        {
            get
            {
                return noOfEasyQues;
            }

            set
            {
                noOfEasyQues = value;
            }
        }

        public int NoOfMediumQues
        {
            get
            {
                return noOfMediumQues;
            }

            set
            {
                noOfMediumQues = value;
            }
        }

        public int NoOfHardQues
        {
            get
            {
                return noOfHardQues;
            }

            set
            {
                noOfHardQues = value;
            }
        }

        public int NoOfVeryHardQues
        {
            get
            {
                return noOfVeryHardQues;
            }

            set
            {
                noOfVeryHardQues = value;
            }
        }

        public string Examinations
        {
            get
            {
                return examinations;
            }

            set
            {
                examinations = value;
            }
        }
        #endregion
    }
}
