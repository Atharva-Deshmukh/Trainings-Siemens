namespace ERPLibrary;

public abstract class Student
{
    private string _studentName;
    private string _studentId;
    private float _studentFees;

    // protected is accessible to immediate child only
    protected Student(string studentName, string studentId, float studentFees)
    {
        StudentName = studentName;
        StudentId = studentId;
        StudentFees = studentFees;
    }

    public string StudentName { get => _studentName; set => _studentName = value; }
    public string StudentId { get => _studentId; set => _studentId = value; }
    public float StudentFees { get => _studentFees; set => _studentFees = value; }

    public abstract float CaclulateCGPA();
    
    public abstract bool UpdateInformation();

    // public abstract bool MakeFeePayment();

}

