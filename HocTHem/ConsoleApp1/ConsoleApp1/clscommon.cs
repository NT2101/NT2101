using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class clscommon
    {

        public void ShowMessage(string message, string type)
        {
            //  Console.WriteLine("Loại thông báo là:" + type + ", Thông báo có nội dung là :" + message);
            string result = "abc" + 1;
            Console.WriteLine("Thông báo" + result);
            
            string[][] arrx = new string[3][];
            List<string> arrxy = new List<string>();
            arrxy.Add("Phan Tu 1");
            arrxy.Add("Phan Tu 2");
            string[] arrr = new string[5];
            arrr[0] = "abc";
            var x = arrr.Length;
        }
    }
}
