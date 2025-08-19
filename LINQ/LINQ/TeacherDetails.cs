using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LINQ
{
    class Teacher
    {
        public int Id { get; set; }
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
               new Teacher { Id = 1, Name = "Dr. Mohan", Subject = "Data Structures", Age = 42, Department = "CSE" },
               new Teacher { Id = 2, Name = "Dr. Lakshmi", Subject = "Digital Systems", Age = 47, Department = "ECE" },
               new Teacher { Id = 3, Name = "Dr. Suresh", Subject = "Power Systems", Age = 52, Department = "EEE" },
               new Teacher { Id = 4, Name = "Dr. Kavitha", Subject = "Physics", Age = 39, Department = "Science" },
               new Teacher { Id = 5, Name = "Dr. Rajesh", Subject = "Operating Systems", Age = 44, Department = "CSE" },
               new Teacher { Id = 6, Name = "Dr. Meena", Subject = "Communication Systems", Age = 41, Department = "ECE" },
               new Teacher { Id = 7, Name = "Dr. Natarajan", Subject = "Control Systems", Age = 49, Department = "EEE" },
               new Teacher { Id = 8, Name = "Dr. Rekha", Subject = "Chemistry", Age = 36, Department = "Science" }

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

            //join students with teachers (to see who’s under which teacher)
            var studTeach = students.Join(
                teachers,
                s => s.Department,
                t => t.Department,
                (s, t) => new { StudentName = s.Name, TeacherName = t.Name });

            Console.WriteLine("-----------------------------------------------");

            foreach (var item in studTeach)
            {
                Console.WriteLine($"{item.StudentName} - {item.TeacherName}");
            }

            //Group students by Department and count them
            var studentGroup = students.GroupBy(
                s => s.Department)
                .Select(
                g => new { TeacherDept = g.Key, StudentCount = g.Count() });

            Console.WriteLine("-----------------------------------------------");

            foreach (var item in studentGroup)
            {
                Console.WriteLine($"{item.TeacherDept} - {item.StudentCount}");
            }

            //Top 2 oldest students
            var top2Oldest = students.OrderByDescending(s => s.Age).Take(2);
            Console.WriteLine($"Oldest Student: " + string.Join(", ", top2Oldest.Select(s => s.Name)));

            //Get first student older than 21
            Console.WriteLine( students.FirstOrDefault(s => s.Age > 21).Name);

            //Get single teacher with Id = 3
            Console.WriteLine(teachers.SingleOrDefault(t => t.Id == 3).Name);

            //Students assigned to "Mr. John"
            var joinStudents = students.Join(
                teachers,
                s => s.Department,
                t => t.Department,
                (s, t) => new { s.Name, TeacherName = t.Name }).Where(x => x.TeacherName == "Dr. Suresh");
            Console.WriteLine("-----------------------------------------------");
            foreach (var item in joinStudents)
            {
                Console.WriteLine($"{item.TeacherName} - {item.Name}");
            }

            //All subjects taught without duplicates
            var subjects = teachers.Select(t => t.Subject).Distinct();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine($"Subjects: " + string.Join(", ", subjects));
        }
    }
}
