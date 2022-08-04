using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizSystem.DTO
{
    public class TestRoom
    {
        private string roomID;
        private string name;

        #region get/set
        public string RoomID
        {
            get
            {
                return roomID;
            }

            set
            {
                roomID = value;
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
