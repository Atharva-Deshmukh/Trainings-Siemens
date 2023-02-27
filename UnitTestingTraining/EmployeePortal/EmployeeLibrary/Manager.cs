using EmployeeLibrary;

public class Manager: Employee
{
    private int _managerTeamSize;
    private string _managerLocation;

    public Manager(string employeeName, string employeeId, float employeeSalary, int _managerTeamSize, string _managerLocation) : base(employeeName, employeeId, employeeSalary)
    {
        this._managerTeamSize = _managerTeamSize;
        this._managerLocation = _managerLocation;

    }

    

    public int ManagerTeamSize { get => _managerTeamSize; set => _managerTeamSize = value; }
    public string ManagerLocation { get => _managerLocation; set => _managerLocation = value; }

    public override float CalculateTax()
    {
        return 0.25f * EmployeeSalary;
    }

    // this represents object layout in form of string visible on screen
    public override string ToString()
    {
        string message = $"Manger [ Name : {this.EmployeeName}, Location: {this.ManagerLocation}  ]";

        return message;
    }
}