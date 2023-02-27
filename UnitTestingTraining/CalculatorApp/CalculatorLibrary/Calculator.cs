namespace CalculatorLibrary;
public class Calculator
{
    private int _firstNumber;
    private int _secondNumber;

    public Calculator(int firstNumber, int secondNumber)
    {
        _firstNumber = firstNumber;
        _secondNumber = secondNumber;
    }

    public int FirstNumber { get => _firstNumber; set => _firstNumber = value; }
    public int SecondNumber { get => _secondNumber; set => _secondNumber = value; }

    /*
        adds two numbers and returns integer as output.
    */
    public int Addition()
    {
        return _firstNumber + _secondNumber;
    }

    /*
        Subtracts two numbers and returns integer as output.
    */
    public int Subtraction()
    {
        return _firstNumber - _secondNumber;
    }

    /*
        Multiplies two numbers and returns integer as output.
    */
    public int Multiplication()
    {
        return _firstNumber * _secondNumber;
    }

    /*
        Divides two numbers and returns integer as output.Also checks for division by 0 error using exception handling
    */
    public int Division()
    {
        if(_secondNumber==0)
        {
            throw new DivideByZeroException("Cannot divide a number by 0!");
        }

        else
        {
            return _firstNumber / _secondNumber;
        }
    }

    public int Remainder()
    {
        return _firstNumber % _secondNumber;
    }

    double Exponential()
    {
        int result=1;

        if(_secondNumber==0)
        {
            return result;
        }

        else
        {
            for(int i = 1; i<=_secondNumber; i++)
            {
                result = result  * _firstNumber;
            }
        }

        return result;
    }
}
