namespace ERPLibrary;

// since student base class has been used for EngineeringStudent, indirectly the interface is also implemented!
// us class se inherit karre ho jisne contract(interface) follow kiya hai to aapko bhi karna padega
public class EngineeringStudent: Student
{
    private EngineeringDepartment _engineeringDepartment;
    private EngineeringCourse _engineeringCourse;
    private EngineeringSemester _engineeringSemester;


    private int _engineeringStudentTheoryExamTotal;
    private int _engineeringStudentPracticalExamTotal;
    private int _engineeringStudentVivaExamTotal;
   private int _engineeringStudentFinalExamTotal;

   public int EngineeringStudentTheoryExamTotal { get => _engineeringStudentTheoryExamTotal; set => _engineeringStudentTheoryExamTotal = value; }
    public int EngineeringStudentPracticalExamTotal { get => _engineeringStudentPracticalExamTotal; set => _engineeringStudentPracticalExamTotal = value; }
    public int EngineeringStudentVivaExamTotal { get => _engineeringStudentVivaExamTotal; set => _engineeringStudentVivaExamTotal = value; }
    public int EngineeringStudentFinalExamTotal { get => _engineeringStudentFinalExamTotal; set => _engineeringStudentFinalExamTotal = value; }
    public EngineeringDepartment EngineeringDepartment { get => _engineeringDepartment; set => _engineeringDepartment = value; }
    public EngineeringCourse EngineeringCourse { get => _engineeringCourse; set => _engineeringCourse = value; }
    public EngineeringSemester EngineeringSemester { get => _engineeringSemester; set => _engineeringSemester = value; }

    public EngineeringStudent(string studentName, string studentId, float studentFees, 
    int _engineeringStudentTheoryExamTotal, 
    int _engineeringStudentPracticalExamTotal, 
    int _engineeringStudentVivaExamTotal, 
    int _engineeringStudentFinalExamTotal,
     EngineeringDepartment _engineeringDepartment,
     EngineeringCourse _engineeringCourse,
     EngineeringSemester _engineeringSemester) : 
    base(studentName, studentId, studentFees)
    {
        this._engineeringStudentTheoryExamTotal = _engineeringStudentTheoryExamTotal;
        this._engineeringStudentPracticalExamTotal = _engineeringStudentPracticalExamTotal;
        this._engineeringStudentVivaExamTotal = _engineeringStudentVivaExamTotal;
        this._engineeringStudentFinalExamTotal = _engineeringStudentFinalExamTotal;

        this._engineeringCourse=_engineeringCourse;
        this._engineeringDepartment=_engineeringDepartment;
        this._engineeringSemester=_engineeringSemester;
    }

   public override float CaclulateCGPA()
   {
        int ans = EngineeringStudentFinalExamTotal + EngineeringStudentPracticalExamTotal + EngineeringStudentTheoryExamTotal + EngineeringStudentVivaExamTotal;

        return (float) (ans * 100)/400;
   }

    /*    
        Ask user for a choice -change name or department    
        For change name: accept a new value.Ask user to cofirm .If yes,chage sing setter and break the loop.
        Otherwise,    ask user to try again!     
        For ChageDepartment: Provide a switch operation to indicate list of department,for valid inputs,update departmnets    
        IF SEMESTER IS EITHER FIRST OR SECOND       
   */

   public override bool UpdateInformation()
   {
        Console.WriteLine($"Enter 1 to change name, 2 to change department");
        int Choice = Convert.ToUInt16(Console.ReadLine());


        switch(Choice)
        {
            case 1:

                while(true)
                {

                    Console.WriteLine($"Enter New Name -> ");
                    string newName = Console.ReadLine();
                    Console.WriteLine($"You have provided: {newName}\tIs it Correct - Y or N ?");
                    char Reply = Convert.ToChar(Console.ReadLine());

                    if(Reply == 'Y')
                    {
                        this.StudentName = newName;
                        break;
                    }

                    Console.WriteLine($"Plz try again");

                }
                break;

            case 2:

                while(true)
                {
                    Console.WriteLine($"Enter 0 for Computer \n 1 for Civil \n 2 for mechanical \n 3 for Electrical");
                    int choice = Convert.ToUInt16(Console.ReadLine());

                    if( 0 <= choice && choice <= 5)
                    {
                        this._engineeringDepartment = (EngineeringDepartment) choice;
                        Console.WriteLine($"Updated department record");
                        break;
                    }

                    Console.WriteLine($"Plz try again");
                }
                break;


            default:
                Console.WriteLine($"INVALID INPUT!");
                break;

        }

        return true;
   }

    
}

