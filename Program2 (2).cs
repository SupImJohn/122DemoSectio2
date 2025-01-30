// Written By John
// 1/15/2025

using System.Collections.Generic;

namespace FirstProjectSpring2024A
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Student> aListOfStudents = new List<Student>();
            Student aStudent1 = new Student();
            Student aStudent2 = new Student();
            Student aStudent3 = new Student();
            Student aStudent4 = new Student(4, "Bob", "Evans", "", "Restaurant Management");
            Student aStudent5 = new Student(5, "Alice", "Cullen", "Marie", "Infectious Diseases");
            Student aStudent6 = new Student(6, "Bella", "Cullen", "Esme");

            aStudent1.StudentId = 1;
            aStudent1.FirstName = "Anna";
            aStudent1.LastName = "Romanov";
            aStudent1.MiddleName = "Marie";
            aStudent1.Major = "Biology";

            aStudent2.StudentId = 2;
            aStudent2.FirstName = "Steven";
            aStudent2.LastName = "Trotter";
            aStudent2.MiddleName = "";
            aStudent2.Major = "French";

            aStudent3.StudentId = 3;
            aStudent3.FirstName = "Omar";
            aStudent3.LastName = "Mohanned";
            aStudent3.MiddleName = "Qasai";
            aStudent3.Major = "Computer Science";

            aListOfStudents.Add(aStudent1);
            aListOfStudents.Add(aStudent2);
            aListOfStudents.Add(aStudent3);
            aListOfStudents.Add(aStudent4);
            aListOfStudents.Add(aStudent5);
            aListOfStudents.Add(aStudent6);

            /*
            Console.WriteLine(aStudent1.ToString());
            Console.WriteLine(aStudent2.ToString());
            Console.WriteLine(aStudent3.ToString());
            Console.WriteLine(aStudent4.ToString());
            Console.WriteLine(aStudent5.ToString());
            */

            // This is the current way to do this
            foreach (Student aStudent in aListOfStudents)
            {
                Console.WriteLine(aStudent.ToString()); 
            }

            // This is the old way to do this -- you will see this on the web a lot
            foreach (var s in aListOfStudents)
            {
                Console.WriteLine(s.ToString());
            }
        }
    }
}