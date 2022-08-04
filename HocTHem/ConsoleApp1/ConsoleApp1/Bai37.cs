using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Bai37
    {
        public void Demo()
        {
            try
            {
                Console.WriteLine("*********BAI 3.7 *********");
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
                    Console.Write(arr[i] + " ");
                }
                Console.Write("]");
                Console.WriteLine();
                if(arr.Length>0)
                {
                    for(int i = 0; i< size; i++)
                    {
                        for (int j = i + 1; j < size; j++)
                        {
                            string Temp;
                            if(Convert.ToInt32(arr[i]) < Convert.ToInt32(arr[j]))
                                    {
                                Temp = arr[i];
                                arr[i] = arr[j];
                                arr[j] = Temp;

                            }
                        }
                    }
                    Console.WriteLine(" Mang sau khi sap xep:");
                    Console.Write("[");
                    for(int i = 0; i<size; i++)
                    {
                        Console.Write(arr[i] + " ");
                    }
                    Console.Write("]");
                    Console.WriteLine();
                    for (int i = 0; i< size; i++)
                    {
                        if (Convert.ToInt32(arr[i]) <Convert.ToInt32(arr[0]))
                        {
                            Console.WriteLine(" Gia tri lon thu 2 trong mang la:" + arr[i]);
                            break;
                        }
                    }

                }

               
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
