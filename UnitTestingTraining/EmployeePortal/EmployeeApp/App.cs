using EmployeeLibrary;

public class App
{
    public static void Main(string []args)
    {
        Manager m1 = new Manager("Atharva","S01",3000.0f,4,"Pune");

        HR h1 = new HR("Crystal","ST01",1000.0f,DEPARTMENT.RECRUITMENT);

        System.Console.WriteLine(m1.EmployeeName);

        System.Console.WriteLine(m1);
    }
}