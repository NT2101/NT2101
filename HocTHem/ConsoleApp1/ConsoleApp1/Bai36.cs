using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Bai36
    {
        public void Demo()
        {
            try
            {
                Console.WriteLine("*********BAI 3.5 *********");
                Console.WriteLine("Nhap vao kick thuoc cua mang");
                int size = Convert.ToInt32(Console.ReadLine());
                string[] arr = new string[size];
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("Nhap Vao Phan Tu Thu" + (i + 1).ToString() + ":");
                    arr[i] = Console.ReadLine();
                }
                Console.WriteLine("Mang Vua Nhap La:");
                Console.WriteLine();
                Console.Write("[");
                int min = Convert.ToInt32(arr[0]);
                int max = Convert.ToInt32(arr[0]);
                for (int i = 0; i < size; i++)
                {
                    Console.Write(arr[i].ToString() + " ");
                    if ( Convert.ToInt32(arr[i]) < min )
                    {
                        min = Convert.ToInt32(arr[i]);
                    }
                    if (Convert.ToInt32(arr[i]) >max)
                    {
                        max = Convert.ToInt32(arr[i]);
                    }

                }
                
                Console.Write("]");
                Console.WriteLine();
                Console.WriteLine("So lon nhat trong mang la :" +max);
                Console.WriteLine("So be nhat trong mang la :" +min);
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
