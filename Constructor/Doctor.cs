using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Doctor
    {
       public int Id { get; set; }
        public String Name { get; set; }
        public string Degree { get; set; }
        public  static int NumberOfDoctors { get; set; }

        public Doctor()
        {
            Console.WriteLine("This is parameterless or default  constructor");
            this.Id = 1;
            this.Name = "Ajay";
            this.Degree = "MBBS";

        }

        public Doctor(int id, string Name, string degree)
        {
            Console.WriteLine("This is parameterized constructor");
            this.Id = id;
            this.Name = Name;
            this.Degree = degree;
        }



        public Doctor(Doctor doctor)
        {
            Console.WriteLine("This is the copy constructor");
            this.Id = doctor.Id;
            this.Name = doctor.Name;
            this.Degree = doctor.Degree;


        }
        public void showdata()
        {
            
            Console.WriteLine("Id="+this.Id);
            Console.WriteLine("Name="+this.Name);
            Console.WriteLine("Degree="+this.Degree);
            Console.WriteLine("---------------------------------------------");

        }


        static Doctor()//static constructor
        {

            Console.WriteLine("This is static constructor");
            Doctor.NumberOfDoctors = 5;
        }
        
    }
}
