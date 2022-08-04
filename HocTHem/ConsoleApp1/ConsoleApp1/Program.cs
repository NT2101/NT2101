using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        //    string name = "Duc Anh";   //Biến toàn cục
        static void Main(string[] args)
        {


            //Bai32 _bai32 = new Bai32();
            //_bai32.Demo();

            //bai35 _bai35 = new bai35();
            //_bai35.Demo();


            //Bai36 _bai36 = new Bai36();
            //_bai36.Demo();
            //Bai37 _bai37 = new Bai37();
            //_bai37.Demo();
            //Bai39 _bai39 = new Bai39();
            //_bai39.Demo();

            //bai310 _bai310 = new bai310();
            //_bai310.demo();

            bai311 _bai311 = new bai311();
            _bai311.Demo();


            //clsStudent _student = new clsStudent();
            //_student.Run();
            //string Error = "";    //biến cục bộ
            //Program _program = new Program();
            //string chuoitrave = _program.print("CE");
            //Console.WriteLine(chuoitrave);
            //clscommon clscommon = new clscommon();
            //clscommon.ShowMessage(" Chúc bạn may mắn", "Thành công");
            //int Result = _program.tinhtong("3", "6", ref Error);
            //Console.WriteLine("ket qua:" + Result);
            //Console.WriteLine("loi:" + Error);
            //Console.ReadKey();


            //Bài 1
            //string hoten = Console.ReadLine();
            //string namsinh = Console.ReadLine();
            //int a = Convert.ToInt32(namsinh);
            //int currentYear = DateTime.Now.Year;
            //Console.WriteLine("Nhập họ tên:" + hoten);
            //Console.WriteLine("Nhập vào năm sinh:" + namsinh);
            //Console.WriteLine("Tuổi hiện tại là:" + (currentYear - a));
            //Console.ReadKey();

            //try
            //{
            //    int currentYear = DateTime.Now.Year;
            //    Console.WriteLine("Nhập vào họ tên và năm sinh");
            //    string Chuoi = Console.ReadLine();
            //    var arr = Chuoi.Split(' ');
            //    var birthDay = arr[arr.Length - 1];
            //    var Age = currentYear - Convert.ToInt32(birthDay);
            //    var Name = Chuoi.Replace(birthDay, " ");
            //    Console.WriteLine("Xin Chào:" + Name + ",Tuổi:" + Age);
            //    Console.ReadKey();

            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine("Lỗi định dạng dữ liệu:" +ex.Message);
            //    Console.ReadKey();
            //}



            // Bai2
            //    Nhập thông tin điểm
            //    Console.OutputEncoding = Encoding.UTF8;
            //    Console.WriteLine("Nhập thông tin điểm:");
            //    double Diem = Convert.ToDouble(Console.ReadLine());

            //    string loaiHocLuc = " ";
            //    if (Diem < 5)
            //    {
            //        loaiHocLuc = "yeu";
            //    }
            //    else if (5 <= Diem && Diem < 6.5)
            //    {
            //        loaiHocLuc = "Trung Binh";
            //    }
            //    else if (6.5 <= Diem && Diem < 7)
            //    {
            //        loaiHocLuc = "TB Kha";
            //    }
            //    else if (7 <= Diem && Diem < 8)
            //    {
            //        loaiHocLuc = "Kha";
            //    }
            //    else if (8 <= Diem && Diem < 9)
            //    {
            //        loaiHocLuc = "Gioi";
            //    }
            //    else if (9 <= Diem && Diem <= 10)
            //    {
            //        loaiHocLuc = " Xuat Sac";
            //    }
            //    Console.WriteLine("Xep Loai Hoc Luc:" + loaiHocLuc);
            //    Console.ReadKey();
            //}



            //Bai3
            //Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("CHUONG TRINH GIAI PHUONG TRINH");
            //Console.WriteLine("Nhap vao gia tri a:");
            //double a = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Nhap vao gia tri b:");
            //double b = Convert.ToDouble(Console.ReadLine());

            //if (a == 0 && b == 0)
            //{
            //    Console.WriteLine("Chuong Trinh Vo Nghiem");
            //}
            //else if (b == 0 && a != 0)
            //{
            //    Console.WriteLine("Chuong trinh co nghiem x = 0");
            //}
            //else
            //{
            //    double c = -b / a;
            //    Console.WriteLine("Chuong trinh co nghiem x =" + c);
            //}
            //Console.ReadKey();




            //Bai4
            //Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("CHUONG TRINH GIAI PHUONG TRINH");
            //Console.WriteLine("Nhap vao gia tri a:");
            //double a = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Nhap vao gia tri b:");
            //double b = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Nhap vao gia tri c:");
            //double c = Convert.ToDouble(Console.ReadLine());
            //double denta = b * b - 4 * a * c;
            //double x1 = 0;
            //double x2 = 0;
            //if (denta == 0 )
            //{
            //    x1 = -b / (2 * a); 
            //    Console.WriteLine("Chuong Trinh Co 1 Nghiem Kep x1 = x2 :" +x1);
            //}
            //else if (denta < 0)
            //{

            //    Console.WriteLine("Chuong trinh vo nghiem");
            //}
            //else if (denta >0)
            //{
            //    x1 = (-b + Math.Sqrt(denta)) / (2 * a);
            //    x2 = (-b - Math.Sqrt(denta)) / (2 * a);
            //    Console.WriteLine("Chuong trinh co 2 nghiem la:");
            //    Console.WriteLine("x1 = " + x1 + " va x2 = " + x2);
            //}
            //Console.ReadKey();





            //string print(string name)
            //{
            //    Console.WriteLine("Welcome to CEGroup," + name);
            //    return "X";
            //}

            //public int tinhtong(string a, string b, ref string Error)
            //{
            //    try
            //    {

            //        int x = Convert.ToInt32(a);
            //        int y = Convert.ToInt32(b);
            //        return x + y;
            //    }
            //    catch (Exception ex)
            //    {
            //        Error = ex.Message;
            //        return 1;

            //    }

        }
    }
}
