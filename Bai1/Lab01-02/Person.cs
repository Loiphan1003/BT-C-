using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_02
{
    class Person
    {
        private string fullName;
        private string id;
        
        

        public string FullName { get => fullName; set => fullName = value; }
        public string Id { get => id; set => id = value; }

        public Person()
        {

        }
        public Person(string fullName, string id)
        {
            this.FullName = fullName;
            this.Id = id;
        }

        public  void Input()
        {
            Console.Write("Nhập Mã số: ");
            Id = Console.ReadLine();

            Console.Write("Nhập tên: ");
            FullName = Console.ReadLine();                      
        }

        public void Show()
        {
            Console.Write("ID: {0} Tên: {1}",this.Id, this.FullName);
        }

    }
}
