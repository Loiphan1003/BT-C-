using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_02
{
    class Student : Person
    {
        private string faculty;
        private string gender;
        private float averageScore;

        public string Faculty { get => faculty; set => faculty = value; }
        public string Gender { get => gender; set => gender = value; }
        public float AverageScore { get => averageScore; set => averageScore = value; }

        public Student() { }
        public Student(string fullName, string id, string faculty, string gender, float averageScore) :base(fullName, id)
        {
            this.Faculty = faculty;
            this.Gender = gender;
            this.AverageScore = averageScore;
        } 

        public new void Input()
        {
            base.Input();
            Console.Write("Nhập Khoa: ");
            Faculty = Console.ReadLine();
            Console.Write("Nhập giới tính: ");
            Gender= Console.ReadLine();
            Console.Write("Nhập điểm trung bình: ");
            AverageScore =(float)Convert.ToDouble( Console.ReadLine());
        }

        public new  void Show()
        {
            base.Show();
            Console.WriteLine(" Khoa: {0} Giới tính: {1} Điiểm trung bình: {2}",this.Faculty, this.Gender, this.AverageScore);
        }

    }
}

