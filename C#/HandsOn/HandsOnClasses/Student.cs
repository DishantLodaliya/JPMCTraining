using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClasses
{
    class Student
    {
        public int studentId;
        public string studentName;
        public DateTime dob;
        public string std;

        public void show()
        {
            Console.WriteLine($"Student ID : {studentId}\nStudent Name : {studentName}\nStudent DOB : {dob}\nStudent Standard : {std}");
        }
    }
}
