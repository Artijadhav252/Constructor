using Constructor;

public class Program
{
    public static void Main()
    {
        int a, b;
        int num;
        string str;



        Employee emp1 = new Employee();//(parameterless constructor)
        emp1.showdata();

        Employee emp2 = new Employee(11, "Vijay", 20000);//(Parameterized constructor
        emp2.showdata();

        Employee emp3 = new Employee(12, "Amit", 30000);
        emp3.showdata();

        //Employee emp4 = new Employee(13, "Shree", 40000);
        //emp4.showdata();

        //Employee emp5 = new Employee(14,"Ansh",24000);
        //emp5.showdata();


        Employee emp2copy = new Employee(emp2);//Copy constructor
        emp2copy.showdata();

        Employee emp3copy = new Employee(emp3);
        emp3copy.showdata();

    }
}