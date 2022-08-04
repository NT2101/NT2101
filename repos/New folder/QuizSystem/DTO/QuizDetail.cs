using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizSystem.DTO
{
    public class QuizDetail
    {
        private int quizID;
        private int quesID;

        public int QuizID
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

        public int QuesID
        {
            get
            {
                return quesID;
            }

            set
            {
                quesID = value;
            }
        }
    }
}
