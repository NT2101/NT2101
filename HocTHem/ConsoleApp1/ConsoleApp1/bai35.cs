using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public  class bai35
    {
        public void Demo()
        {
            try
            {
                Console.WriteLine("*********BAI 3.5 *********");
                Console.WriteLine("Nhap vao kick thuoc cua mang");
                int size = Convert.ToInt32(Console.ReadLine());
                string[] arr = new string[size];
                for (int i= 0; i <size ;i++)
                {
                    Console.WriteLine("Nhap Vao Phan Tu Thu" + (i+1).ToString() +":");
                    arr[i] = Console.ReadLine();
                }
                Console.WriteLine("Mang Vua Nhap La:");
                Console.WriteLine();
                Console.Write("[");
                for (int i = 0; i < size; i++)
                {
                    Console.Write( arr[i].ToString() + " ");
                   
                }
                Console.Write("]");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
               
            }
        }
    }
}
