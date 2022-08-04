using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Bai39
    {
        public void Demo()
        {
          
            try
            {
                int[] arr = new int[255];
                Console.WriteLine("*********BAI 3.9 *********");
                Console.WriteLine("Nhap vao chuoi ki tu");
                string RootString = Console.ReadLine();
                for (int i = 0; i < 255; i++)
                {
                    for (int j = 0; j < RootString.Length; j++)
                    {
                        if ( i == Convert.ToChar(RootString[j]))
                        {
                         arr[i] += 1;
                        }
                    }
                }
                //Max cua arr
                int max = arr[0];
                for (int i = 0; i < 255; i++)
                {
                    if (max < arr[i])
                    {
                        max = arr[i];
                    }
                }
                // lay vi tri cua phan tu co so lan xuat hien = max
                for (int i = 0; i < 255; i++)
                {
                    if (Convert.ToInt32(arr[i]) == max)
                    {
                        Console.WriteLine("Ky tu xuat hien nhieu lan la :" + Convert.ToChar(i));
                    }
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
               
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
