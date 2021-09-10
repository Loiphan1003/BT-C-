using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab01_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(" Nhập số lượng cần nhập");

            List<Person> list = new List<Person>(n);

            bool flag = true;
            do {                
                Console.WriteLine("1. Nhập thông tin sinh viên");
                Console.WriteLine("2. Nhập thông tin giảng viên");
                Console.WriteLine("3. Xuất thông tin sinh viên CNTT");
                Console.WriteLine("4. Xuất thông tin sinh viên CNTT có điểm trung bình thấp hơn 5");
                Console.WriteLine("5. Xuất thông tin sinh viên CNTT có điểm trung bình cao nhất");
                Console.WriteLine("6. Xuất thông tin giảng viên có mã CHN060286");
                Console.WriteLine("7. Xuất thông tin giảng viên có địa chỉ ở quận 9");
                Console.WriteLine("0. Thoát");
                Console.Write("Nhập lựa chọn của bạn: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Đây là lựa chọn 1");
                        Student student = new Student();
                        student.Input();
                        list.Add(student);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Đây là lựa chọn 1");
                        Teacher teacher = new Teacher();
                        teacher.Input();
                        list.Add(teacher);
                        break;
                    case 3:
                        Console.Clear();
                        OutputSV(list);
                        Console.WriteLine("");
                        break;
                    case 4:
                        Console.Clear();
                        XuatSVDiemBeHonNam(list);
                        Console.WriteLine("");
                        break;
                    case 5:
                        Console.Clear();
                        XuatSVDiemCaoNhat(list);
                        break;
                    case 6:
                        Console.Clear();
                        XuatGV(list);
                        Console.WriteLine("");
                        break;
                    case 7:
                        Console.Clear();
                        XuatGVQuanChin(list);
                        Console.WriteLine("");
                        break;
                    case 0:
                        Console.Write("Bye");
                        flag = false;
                        break;
                }
            
            } while (flag);
            Console.ReadKey();
        }
        private static void Output(List<Person> list )
        {
            Console.WriteLine("Xuất thông tin sinh viên");
            foreach (Person p in list)
            {
                (p as Student).Show();
                p.Show();
                
            }
        }

        private static void OutputSV(List<Person> list)
        {
            Console.WriteLine("Xuất thông tin sinh viên IT");
            foreach(Person p in list)
            {
                if(p is Student && (p as Student).Faculty.Equals( "CNTT"))
                {
                    (p as Student).Show();

                }
            }
        }

        private static void XuatSVDiemBeHonNam(List<Person> list)
        {
            Console.WriteLine("Xuất thông tin sinh viên IT có điểm trung bình bé hơn 5");
            foreach (Person p in list)
            {
                if (p is Student && (p as Student).Faculty.Equals("CNTT") && (p as Student).AverageScore < 5)
                {
                    (p as Student).Show();

                }
            }
        }
        private static void XuatSVDiemCaoNhat(List<Person> list)
        {            
            float value = 0;
           
            Console.WriteLine("Xuất thông tin sinh viên IT có điểm trung bình cao nhất");
            foreach(Person p in list)
            {
                if(p is Student && (p as Student).Faculty.Equals("CNTT") && (p as Student).AverageScore is float.MaxValue)
                {
                    (p as Student).Show();
                }
            }

        }

        private static void XuatGV(List<Person> list)
        {
            Console.WriteLine("Xuất thông tin giảng viên có mã CHN060286");
            foreach (Person p in list)
            {
                if (p is Teacher && (p as Teacher).Id.Equals("CHN060286"))
                {
                    (p as Teacher).Show();

                }
            }
        }
        private static void XuatGVQuanChin(List<Person> list)
        {
            Console.WriteLine("Xuất thông tin giảng viên có địa chỉ ở quận 9");
            foreach (Person p in list)
            {
                if (p is Teacher && (p as Teacher).Address.Equals("Quan 9"))
                {
                    (p as Teacher).Show();
                }
            }
        }
    }
}
