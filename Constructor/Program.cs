﻿using Constructor;

public class Program
{
    public static void Main()
    {
        int a, b;
        int num;
        string str;



        Employee emp1 = new Employee();
        Console.WriteLine("please enter the id");
        Console.WriteLine("please enter the Name");
        Console.WriteLine("please enter the Salary");//(parameterless constructor)
        emp1.showdata();

        Employee emp2 = new Employee(11, "Vijay", 20000);//(Parameterized constructor
        emp2.showdata();

        Employee emp3 = new Employee(12, "Amit", 30000);
        emp3.showdata();

        Employee emp4 = new Employee(13, "Shree", 40000);
        emp4.showdata();

        Employee emp5 = new Employee(14,"Ansh",24000);
        emp5.showdata();

    }
}