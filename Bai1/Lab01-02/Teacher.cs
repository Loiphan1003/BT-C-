using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_02
{
    class Teacher:Person
    {
        private string address;

        public string Address { get => address; set => address = value; }

        public Teacher() { }

        public Teacher(string fullName, string id, string address):base(fullName,id) 
        {
            this.Address = address;
        }

        public new void Input()
        {
            base.Input();
            Console.Write("Nhập địa chỉ: ");
            Address = Console.ReadLine();
        }

        public new void Show()
        {
            base.Show();
            Console.Write("Địa chỉ: {0}", this.Address);
        }
    }
}
