using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Student
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public Student()
        {
            this.Id = 1;
            this.Name = "Anu";
            this.Address = "pune";
        }
        public Student(int id,string name,string address)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
        }
        public Student(Student stud)
        {
            this.Id = stud.Id;
            this.Name = stud.Name;
            this.Address = stud.Address;
        }
        public void  showdata()
        {
            
            Console.WriteLine("Id="+this.Id);
            Console.WriteLine("Name="+this.Name);
            Console.WriteLine("Address="+this.Address);
        }
    }
}
