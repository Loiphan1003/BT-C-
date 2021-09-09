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
            List<Person> list = new List<Person>();
            bool flag = true;
            do {
                
                Console.WriteLine("1. Nhập thông tin sinh viên");
                Console.WriteLine("2. Nhập thông tin giảng viên");
                Console.WriteLine("3. Xuất thông tin sinh viên CNTT");
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
                        OutputSV(list);
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
                if(p is Student && (p as Student).Faculty == "CNTT")
                {
                    p.Show();
                }
            }
        }
    }
}
