using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizSystem
{
    public class Account
    {
        public string userName { get; set; }
        public string passWord { get; set; }

        public Account(string user,string passWord)
        {
            this.userName = user;
            this.passWord = passWord;
        }
    }
}
