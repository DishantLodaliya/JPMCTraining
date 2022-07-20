namespace HandsOnClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] student = new Student[3];
            student[0] = new Student() { studentId=123, studentName = "David John", dob = new DateTime(200,9,15), std="Fresher"};
            student[1] = new Student() { studentId=123, studentName = "David John", dob = new DateTime(200,9,15), std="Fresher"};
            student[2] = new Student() { studentId=123, studentName = "David John", dob = new DateTime(200,9,15), std="Fresher"};

            foreach (Student s in student)
                s.show();
        }
    }
}