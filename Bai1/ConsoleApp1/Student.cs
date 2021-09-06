using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        private string studentID;
        private string fullName;
        private float averageScore;
        private string faculty;

        public string StudentID { get => studentID; set => studentID = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string Faculty { get => faculty; set => faculty = value; }
        public float AverageScore { get => averageScore; set => averageScore = value; }

        public Student(string studentID, string fullName, float averageScore, string faculty)
        {
            this.StudentID = studentID;
            this.FullName = fullName;
            this.AverageScore = averageScore;
            this.Faculty = faculty;
        }

        public Student()
        {
        }

        public void Input()
        {
            Console.Write("Nhập Mã Số Sinh Viên: ");
            StudentID = Console.ReadLine();

            Console.Write("Nhập Họ Tên Sinh Viên: ");
            FullName = Console.ReadLine();

            Console.Write("Nhập Điểm Trung Bình Sinh Viên: ");
            AverageScore =(float)Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập Tên Khoa của Sinh Viên: ");
            Faculty = Console.ReadLine();
        }

        public void Output()
        {
            Console.WriteLine("Mã Số Sinh Viên:{0} Họ Tên Sinh Viên:{1} Điểm Trung Bình:{2} Khoa:{3}", this.StudentID, this.FullName, this.AverageScore, this.Faculty);            
        }

        
    }
}
