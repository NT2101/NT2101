using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Bai32
    {
        public void Demo()
        {
            //    Console.OutputEncoding = Encoding.UTF8;
            //    try
            //    {
            //        Console.WriteLine("*********BAI 3.1 *********");
            //        bool bcheck = true;
            //        do
            //        {
            //            Console.WriteLine("Nhap Diem Cua Sinh Vien");
            //            string Diem = Console.ReadLine();
            //            double result = 0;
            //             bcheck = double.TryParse(Diem, out result);
            //            if (bcheck == false)
            //            {
            //                Console.WriteLine("Diem Nhap Vao Khong Phai la So");

            //            }
            //            else
            //            {
            //                if (result < 0 || result > 10)
            //                {
            //                    Console.WriteLine(" Gia tri phai la so >0 va <10:");
            //                    bcheck = false;
            //                }

            //                else if (result < 5)
            //                {
            //                    Console.WriteLine(" Loai Yeu");
            //                }
            //                else if (5 <= result && result < 6.5)
            //                {
            //                    Console.WriteLine(" Loai Trung Binh");

            //                }
            //                else if (6.5 <= result && result < 7)
            //                {
            //                    Console.WriteLine(" Loai Trung Binh Kha");

            //                }
            //                else if (7 <= result && result < 8)
            //                {
            //                    Console.WriteLine(" Loai Kha");

            //                }
            //                else if (8 <= result && result < 9)
            //                {
            //                    Console.WriteLine(" Gioi");

            //                }


            //            }     
            //        }
            //        while (bcheck  == false);
            //        Console.ReadKey();
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //        Console.ReadKey();
            //    }
            Console.OutputEncoding = Encoding.UTF8;
            try
            {
                Console.WriteLine("*********BAI 3.1 *********");
                bool bcheck = true;
                do
                {
                    Console.WriteLine("Nhap Diem Cua Sinh Vien");
                    string Diem = Console.ReadLine();
                    double result = 0;
                  //  bcheck = double.TryParse(Diem, out result);
                    if (bcheck == false)
                    {
                        Console.WriteLine("Diem Nhap Vao Khong Phai la Chu");

                    }
                    else
                    {
                        if (result < 0 || result > 10)
                        {
                            Console.WriteLine(" Gia tri phai la so Chuw:");
                            bcheck = false;
                        }

                        else if (result < 5)
                        {
                            Console.WriteLine(" Loai Yeu");
                        }
                        else if (5 <= result && result < 6.5)
                        {
                            Console.WriteLine(" Loai Trung Binh");

                        }
                        else if (6.5 <= result && result < 7)
                        {
                            Console.WriteLine(" Loai Trung Binh Kha");

                        }
                        else if (7 <= result && result < 8)
                        {
                            Console.WriteLine(" Loai Kha");

                        }
                        else if (8 <= result && result < 9)
                        {
                            Console.WriteLine(" Gioi");

                        }


                    }
                }
                while (bcheck == false);
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
