using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<Student> list = NhapDSSV();

            Console.Write("Sinh Vien CNTT");
            List<Student> listCNTT = list.Where(a => a.Faculty == "CNTT" && a.AverageScore >= 5).ToList();
            if(listCNTT.Count == 0)
            {
                Console.Write("Không có sinh viên khoa CNTT");
            }
            else
            {
                XuatDSSinhVien(listCNTT);
            }

            Console.Write("Sinh vien diem tb lon hon 5");
            List<Student> listResult = list.Where(a => a.AverageScore > 5).ToList();

            Console.ReadKey(); 
        }

        private static List<Student> NhapDSSV()
        {
            List<Student> list = new List<Student>();
            Console.Write("Nhập tổng số sinh viên: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập thông tin sinh viên");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhập sinh viên thứ: {0}", i+1);
                Student temp = new Student();
                temp.Input();
                list.Add(temp);
            }
            return list;
        }

        private static void XuatDSSinhVien(List<Student> students)
        {
            Console.WriteLine("Xuất thông tin sinh viên");
            foreach (Student sv in students)
            {
                sv.Output();
            }
        }
    }

}
