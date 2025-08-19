using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LINQ
{
    class Teacher
    {
        public string Name { get; set; }
        public string Subject { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }

    }
    class TeacherDetails
    {
        public static List<Teacher> GetTeachers()
        {
            return new List<Teacher>
            {
               new Teacher { Name = "Dr. Kumar", Subject = "Programming", Age = 45, Department = "CSE" },
               new Teacher { Name = "Dr. Ramesh", Subject = "Electronics", Age = 50, Department = "ECE" },
               new Teacher { Name = "Dr. Anita", Subject = "Circuits", Age = 40, Department = "EEE" },
               new Teacher { Name = "Dr. Priya", Subject = "Maths", Age = 38, Department = "CSE" }
            };
        }
        public static void Display()
        {
            List<Student> students = StudentDetails.GetStudents();
            List<Teacher> teachers = GetTeachers();
               

            //INNER JOIN
            //METHOD SYNTAX
            //QUERY TO FIND THE DEPARTMENT AND FACULTY DEETS
            var innerJoin = students.Join(
                teachers,
                s => s.Department,
                t => t.Department,
                (s,t) => new {s.Department,t.Name, t.Subject }
                );
            
            foreach(var item in innerJoin)
            {
                Console.WriteLine($"{item.Department} - Teacher: {item.Name} ({item.Subject})");
            } 

            //QUERY TO FIND THE NAME AND MARK OF THE STUDENT USING INNER JOIN
            var nameMark = students.Join(
                teachers,
                s => s.Department,
                t => t.Department,
                (s, t) => new { s.Name, s.Marks, s.Department }
                );

            Console.WriteLine("-----------------------------------------------");

            foreach (var item in nameMark)
            {
                Console.WriteLine($"Department: {item.Department}, Student: {item.Name}, Mark: {item.Marks}");
            } 
            
            //LEFT OUTER JOIN
            //METHOD SYNTAX
            //QUERY TO SHOW ALL STUDENTS EVEN IF TEACHER NO PRESENT 
            var leftOuterJoin = students.GroupJoin(
                teachers,
                s => s.Department,
                t => t.Department,
                (s, tgroup) => new { Student = s, Teachers =  tgroup });

            var leftJoinResult = leftOuterJoin.SelectMany(
                x => x.Teachers.DefaultIfEmpty(),
                (x, t) => new
                {
                    studentName = x.Student.Name,
                    Department = x.Student.Department,
                    TeacherName = t?.Name ?? "No Teacher",
                    Subject = t?.Subject ?? "N/A"
                }
                );

            Console.WriteLine("-----------------------------------------------");

            foreach(var item in leftJoinResult)
            {
                Console.WriteLine($"{item.studentName} ({item.Department}) - Teacher: {item.TeacherName} ({item.Subject})");
            }


            
        }
    }
}
