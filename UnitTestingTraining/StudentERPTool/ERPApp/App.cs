namespace ERPLibrary;

public class App
{
    public static void Main(string[] args)
    {
        // EngineeringStudent obj = new EngineeringStudent("Atharva","z004r8tj",100.0f,100,100,100.100,100,EngineeringDepartment.COMPUTER,EngineeringCourse.BE,EngineeringSemester.INTERNSHIP);

        EngineeringStudent e1 = new EngineeringStudent(_engineeringCourse: EngineeringCourse.B_TECH,
                                                       _engineeringDepartment: EngineeringDepartment.COMPUTER,
                                                       _engineeringSemester: EngineeringSemester.INTERNSHIP,
                                                       _engineeringStudentFinalExamTotal = 100,
                                                       _engineeringStudentPracticalExamTotal = 100,
                                                       _engineeringStudentTheoryExamTotal = 100,
                                                       _engineeringStudentVivaExamTotal = 100
                                                      );
    

        float ans = e1.CaclulateCGPA();
        System.Console.WriteLine($"The CGPA of -> {e1.StudentName} is {ans}");
    }
}