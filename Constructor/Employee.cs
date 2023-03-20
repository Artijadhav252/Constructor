using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public Employee()//parametrlees constructor or default 
        {
            this.Id = 10;
            this.Name = "Raaj";
            this.Salary = 10000;
        }

        public Employee(int id, string name,int salary)//parameterrized constructor
        {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
        }

        public void showdata()
        {
            Console.WriteLine("Id:" + this.Id);
            Console.WriteLine("Name:" + this.Name);
            Console.WriteLine("Salary:"+ this.Salary);

        }
        public void getdata()
        {
            //Console.WriteLine("Enter Employee Id:");
            //Id = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Employee Name:");
            //Name = Console.ReadLine();
            //Console.WriteLine("Enter Employee salary:");
            //Salary = Convert.ToInt32(Console.ReadLine());
        }
      

       
    }
}
