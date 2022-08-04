using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizSystem.DTO
{
    public class ExamList
    {
        private string examListID;
        private string subjectID;
        private string testRoomID;
        private DateTime examDate;
        private TimeSpan startTime;
        private TimeSpan endTime;

        #region get/set
        public string ExamListID
        {
            get
            {
                return examListID;
            }

            set
            {
                examListID = value;
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

        public string TestRoomID
        {
            get
            {
                return testRoomID;
            }

            set
            {
                testRoomID = value;
            }
        }

        public DateTime ExamDate
        {
            get
            {
                return examDate;
            }

            set
            {
                examDate = value;
            }
        }

        public TimeSpan StartTime
        {
            get
            {
                return startTime;
            }

            set
            {
                startTime = value;
            }
        }

        public TimeSpan EndTime
        {
            get
            {
                return endTime;
            }

            set
            {
                endTime = value;
            }
        }

        #endregion
    }
}
