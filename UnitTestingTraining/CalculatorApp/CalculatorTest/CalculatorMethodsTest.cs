namespace CalculatorTest;

using CalculatorLibrary;

public class CalculatorMethodsTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestAddition()
    {
        // Arrange: make arrangements to start the test . LINK & IMPORT
        Calculator obj = new Calculator(10,20);

        // Act: do something that triggers the unit to be tested
        int ActualAnswer = obj.Addition();

        // Assert.
        int ExpectedAnswer = 30;

        Assert.AreEqual(ExpectedAnswer, ActualAnswer);

        obj.FirstNumber = 20;
        obj.SecondNumber = -30;

        ExpectedAnswer = -10;
        ActualAnswer = obj.Addition();

        Assert.AreEqual(ExpectedAnswer, ActualAnswer);
        
    }

    [Test]
    public void TestSubtraction()
    {
        // Arrange: make arrangements to start the test . LINK & IMPORT
        Calculator obj = new Calculator(20,10);

        // Act: do something that triggers the unit to be tested
        int ActualAnswer = obj.Subtraction();

        // Assert.
        int ExpectedAnswer = 10;

        Assert.AreEqual(ExpectedAnswer, ActualAnswer);
        
    }

    [Test]
    public void TestMultiplication()
    {
        // Arrange: make arrangements to start the test . LINK & IMPORT
        Calculator obj = new Calculator(20,10);

        // Act: do something that triggers the unit to be tested
        int ActualAnswer = obj.Multiplication();

        // Assert.
        int ExpectedAnswer = 200;

        Assert.AreEqual(ExpectedAnswer, ActualAnswer);
        
    }

    [Test]
    public void TestDivision()
    {
        // Arrange: make arrangements to start the test . LINK & IMPORT
        Calculator obj = new Calculator(10, 0);

        // act and assert: Exception ke liye test karre hai hence return value nhi milegi
        // while checking for exceptions, DO NOT call method by putting brackets
        
        // Assert.Throws<DivideByZeroException>(obj.Division);

        // another way: Using Lambda function
        Exception ex = Assert.Throws<DivideByZeroException>(  ()=>{obj.Division(); }  );
        
        Assert.AreEqual("Cannot divide a number by 0!", ex.Message);

        //  Assert.IsInstanceOf<DivideByZeroException>(ex);

        
    }

    [Test]

    public void TestCalculatorConstructor()
    {
        // arrange and act happens same case here in case of constructor
        Calculator obj = new Calculator(10,20);

        // assert: Object generated shouldn't be null
        Assert.NotNull(obj);

        // check data members are also stored in correct position
        Assert.AreEqual(10, obj.FirstNumber);
        Assert.AreEqual(20, obj.SecondNumber);

        // check whether obj is instance of Calculator
        Assert.IsInstanceOf<Calculator>(obj);

    }

    [Test]
    public void TestExponential()
    {
        // Arrange: make arrangements to start the test . LINK & IMPORT
        Calculator obj = new Calculator(2, 16);

        //act:
        double ActualAnswer = obj.Exponential();

        // assert
        double ExpectedAnswer = 65536.00;

        // floating point me exacly equal kaam nhi karta hai hence we add tolerance value
         Assert.AreEqual(ExpectedAnswer, ActualAnswer, 0.00005);
        
    }

}