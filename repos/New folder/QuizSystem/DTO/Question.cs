using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizSystem.DTO
{
    public class Question
    {
        private int questionID;
        private string content;
        private string selectA;
        private string selectB;
        private string selectC;
        private string selectD;
        private string correctAnswer;
        private string theDifficult;
        private string subjectID;
        private string composer;
        #region get/set
        public int QuestionID
        {
            get
            {
                return questionID;
            }

            set
            {
                questionID = value;
            }
        }

        public string Content
        {
            get
            {
                return content;
            }

            set
            {
                content = value;
            }
        }

        public string SelectA
        {
            get
            {
                return selectA;
            }

            set
            {
                selectA = value;
            }
        }

        public string SelectB
        {
            get
            {
                return selectB;
            }

            set
            {
                selectB = value;
            }
        }

        public string SelectC
        {
            get
            {
                return selectC;
            }

            set
            {
                selectC = value;
            }
        }

        public string SelectD
        {
            get
            {
                return selectD;
            }

            set
            {
                selectD = value;
            }
        }

        public string CorrectAnswer
        {
            get
            {
                return correctAnswer;
            }

            set
            {
                correctAnswer = value;
            }
        }

        public string TheDifficult
        {
            get
            {
                return theDifficult;
            }

            set
            {
                theDifficult = value;
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

        public string Composer
        {
            get
            {
                return composer;
            }

            set
            {
                composer = value;
            }
        }
        #endregion

    }
}
