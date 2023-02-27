namespace EmployeeLibrary;
public abstract class Employee
{
    private string _employeeName;
    private string _employeeId;
    private float _employeeSalary;

    public Employee(string employeeName, string employeeId, float employeeSalary)
    {
        EmployeeName = employeeName;
        EmployeeId = employeeId;
        EmployeeSalary = employeeSalary;
    }

    public string EmployeeName { get => _employeeName; set => _employeeName = value; }
    public string EmployeeId { get => _employeeId; set => _employeeId = value; }
    public float EmployeeSalary { get => _employeeSalary; set => _employeeSalary = value; }

    public abstract float CalculateTax();




}
