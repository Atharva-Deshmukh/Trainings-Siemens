namespace HRTest;
using EmployeeLibrary;

public class HRTest
{
    HR HRobj;
    // This method is called automatically before any test case method of this class is called
    [SetUp]
    public void Setup()
    {
        this.HRobj = new HR("Atharva","s01",1000.0f,DEPARTMENT.RECRUITMENT);

        System.Console.WriteLine("Test Method Started");

    }

    [Test]
    public void TestCalculateTax()
    {
        // arrange and act
        // used [SetUp]
        HR obj = new HR("Atharva","s01",1000.0f,DEPARTMENT.RECRUITMENT);

        // assert

        //  HR h1 = new HR("Crystal","ST01",1000.0f,DEPARTMENT.RECRUITMENT);

        Assert.NotNull(obj);

        Assert.AreEqual("Atharva",obj.EmployeeName);
        Assert.AreEqual("s01",obj.EmployeeId);
        Assert.AreEqual(1000.0f,obj.EmployeeSalary);
        Assert.AreEqual(DEPARTMENT.RECRUITMENT,obj.HrDepartment);
       

        Assert.IsInstanceOf<HR>(obj);
        Assert.IsInstanceOf<Employee>(obj);


        //act:
        float ActualAnswer = obj.CalculateTax();

        // assert
        float ExpectedAnswer = 100.0f;

        // floating point me exacly equal kaam nhi karta hai hence we add tolerance value
         Assert.AreEqual(ExpectedAnswer, ActualAnswer, 0.00005);
        
    }

    // releases resources used for test after [test] gets job done
    // Executed automatically at END

    // process starts by calling set up method first
    // testHrConstructor is called
    // Teardown() is called
    // call the SetUp()
    // TaerDown() is called


    [TearDown]

    public void TearDown()
    {
        System.Console.WriteLine("Test Method Finished");
    }

}