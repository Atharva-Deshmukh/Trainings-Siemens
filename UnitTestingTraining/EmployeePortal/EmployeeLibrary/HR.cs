using EmployeeLibrary;

public class HR: Employee
{
    // catergorical data is created using enum data type
    private DEPARTMENT _hrDepartment;

    public HR(string employeeName, string employeeId, float employeeSalary, DEPARTMENT _hrDepartment) : base(employeeName, employeeId, employeeSalary)
    {
        this.HrDepartment = _hrDepartment;
    }

    public DEPARTMENT HrDepartment { get => _hrDepartment; set => _hrDepartment = value; }

    public override float CalculateTax()
    {
        return 0.1f * EmployeeSalary;
    }

    
}