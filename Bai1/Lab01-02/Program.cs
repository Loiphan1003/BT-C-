using System;
using System.Collections.Generic;

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
                Console.Clear();
                Console.WriteLine("1. Nhập thông tin sinh viên");
                Console.WriteLine("2. Nhập thông tin giảng viên");
                Console.WriteLine("3. Xuất thông tin sinh viên");
                Console.WriteLine("0. Thoát");
                Console.Write("Nhập lựa chọn của bạn: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Đây là lựa chọn 1");
                        Student person = new Student();
                        person.Input();
                        list.Add(person);
                        break;
                    case 3:
                        Output(list);
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
                p.Show();
            }
        }
    }
}
