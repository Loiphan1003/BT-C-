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

        public string Faculty { get => faculty; set => faculty = value; }
        public string Gender { get => gender; set => gender = value; }

        public Student() { }
        public Student(string fullName, string id, string faculty, string gender) :base(fullName, id)
        {
            this.Faculty = Faculty;
            this.Gender = gender;
        } 

        public void Input()
        {
            base.Input();
            Console.Write("Nhập Khoa: ");
            Faculty = Console.ReadLine();
            Console.Write("Nhập giới tính: ");
            Faculty = Console.ReadLine();            
        }

        public  void Show()
        {
            base.Show();
            Console.Write("Khoa: {0} Giới tính: {1}",this.Faculty, this.Gender);
        }

    }
}

