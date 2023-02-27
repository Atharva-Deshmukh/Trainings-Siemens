namespace ManagerTest;
using EmployeeLibrary;

public class ManagerTest
{
    [SetUp]
    public void Setup()
    {

    }

    [Test]
    public void TestCalculateTax()
    {
        // arrange and act
        Manager obj = new Manager("Ad","s01",1000.0f,4,"Pune");

        // assert

        // Manager m1 = new Manager("Atharva","S01",3000.0f,4,"Pune");

        Assert.NotNull(obj);

        Assert.AreEqual("Ad",obj.EmployeeName);
        Assert.AreEqual("s01",obj.EmployeeId);
        Assert.AreEqual(1000.0f,obj.EmployeeSalary);
        Assert.AreEqual(4,obj.ManagerTeamSize);
        Assert.AreEqual("Pune",obj.ManagerLocation);

        Assert.IsInstanceOf<Manager>(obj);
        Assert.IsInstanceOf<Employee>(obj);

         //act:
        float ActualAnswer = obj.CalculateTax();

        // assert
        float ExpectedAnswer = 250.0f;

        // floating point me exacly equal kaam nhi karta hai hence we add tolerance value
         Assert.AreEqual(ExpectedAnswer, ActualAnswer, 0.00005);

        

        
    }
}