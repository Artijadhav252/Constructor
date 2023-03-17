using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Employee
    {

        public Employee()
        {
            Id = 10;
            Name = "Raaj";
            Salary = 10000;
        }

        public Employee(int a,int b)
        {

        }

        public void putdata()
        {
            //Console.WriteLine("Id:"+Id);
            //Console.WriteLine("Name:"+Name);
            //Console.WriteLine("Salary:"+Salary);

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
        public int Id { get; set; }
        public String Name { get; set; }
        public int Salary { get; set; }


       
    }
}
