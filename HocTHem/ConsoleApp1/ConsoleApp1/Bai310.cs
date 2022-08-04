using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public  class Bai310
    {       public void Demo()
        {
            Console.WriteLine("*********BAI 3.10 *********");
            Console.WriteLine("Nhap vao chuoi:");
            string Parent = Console.ReadLine();
            Console.WriteLine("Nhap vao chuoi:");
            string Child = Console.ReadLine();
            int index = -1;
            int cout = -1;
            do
            {
                index = Parent.ToUpper().IndexOf(Child.ToUpper(), index + 1);
                cout++;
          
            }
            while (index != -1);
            Console.WriteLine(cout);
            Console.ReadKey();
        }
    }
}
