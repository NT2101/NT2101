using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public  class bai311
    {
        public void Demo()
        {
            try
            {
                string userName = "CE";
                string Password = "123";
                bool check = false;
                int cout = 0;
                do
                {
                    Console.WriteLine("Nhap thong tin:");
                    userName = Console.ReadLine();
                    Password = Console.ReadLine();
                    if (userName == "CE" && Password == "123")
                    {
                        check = true;
                    }
                    cout++;

                } while (cout < 3 && check == false);
                if (check == false)
                {
                    Console.WriteLine("Nhap thong tin loi");
                }
                 
                else
                {
                    Console.WriteLine("nhap thong tin thanh cong");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                
            }
        }
    }
}
