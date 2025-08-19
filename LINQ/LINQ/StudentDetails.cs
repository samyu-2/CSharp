using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
        public int Marks { get; set; }
    }

    
    class StudentDetails
    {
        public static List<Student> GetStudents()
        {
            return new List<Student>
            {
                new Student { Id = 8, Name = "Liam", Age = 21, Department = "CSE", Marks = 82 },
                new Student { Id = 10, Name = "Noah", Age = 22, Department = "AIML", Marks = 76 },
                new Student { Id = 12, Name = "William", Age = 23, Department = "ECE", Marks = 69 },
                new Student { Id = 13, Name = "Mia", Age = 20, Department = "EIE", Marks = 92 },
                new Student { Id = 14, Name = "James", Age = 21, Department = "CSE", Marks = 81 },
                new Student { Id = 16, Name = "Benjamin", Age = 20, Department = "EEE", Marks = 85 },
                new Student { Id = 19, Name = "Charlotte", Age = 21, Department = "EIE", Marks = 68 },
                new Student { Id = 20, Name = "Henry", Age = 22, Department = "AIML", Marks = 87 }

            };
        }

        public static void Display()
        {
            List<Student> students = GetStudents();
            

            //FILTERING - WHERE (IND CSE STUDENT)
            //QUERY SYNTAX 
            var cseStudentQ = from s in students
                              where s.Department == "CSE"
                              select s;

            //METHOD SYNTAX
            var cseStudentM = students.Where(s => s.Department == "CSE");

            //USING FOREACH
            foreach (var student in cseStudentQ)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}, Department: {student.Department}, Marks: {student.Marks}");
            }

            Console.WriteLine("------------------");

            //USING STRING.JOIN
            Console.WriteLine("CSE Students: " + string.Join(", ", cseStudentQ.Select(s => s.Name)));

            Console.WriteLine("------------------");

            //USING LINQ + ToList().ForEach
            cseStudentM.ToList().ForEach(s => Console.WriteLine($"{s.Name} ({s.Department}) - Marks: {s.Marks}"));


            //PROJECTION - SELECT (STUDENTS NAME)
            //QUERY SYNTAX
            var namesQ = from s in students
                         select s.Name;
            var namesAndIdQ = from s in students
                              select new { s.Id, s.Name };

            //METHOD SYNTAX
            var namesM = students.Select(s => s.Name);
            var namesAndIdM = students.Select(s => new { s.Name, s.Id });

            Console.WriteLine("------------------");

            Console.WriteLine("Students: " + string.Join(", ", namesQ.Select(s => s)));

            Console.WriteLine("------------------");

            Console.WriteLine("Students: " + string.Join(", ", namesQ));

            Console.WriteLine("------------------");

            Console.WriteLine("Students: " + string.Join(", ", namesAndIdM.Select(s => $"{s.Id} - {s.Name}")));


            //ORDERING - ORDERBY ORDERBYDESCENDING
            //QUERY SYNTAX
            var sortedByAgeQ = from s in students
                               orderby s.Age
                               select s;
            var sortedByMarksQ = from s in students
                                 orderby s.Marks descending
                                 select s;
            var sortedByDeptThenMarksQ = from s in students
                                         orderby s.Department, s.Marks descending
                                         select s;
            var sortedNamesQ = from s in students
                               orderby s.Name
                               select s;


            //METHOD SYNTAX
            var sortedByAgeM = students.OrderBy(s => s.Age);
            var sortedByMarksM = students.OrderByDescending(s => s.Marks);
            var sortByDeptThenMarksM = students.OrderBy(s => s.Department).ThenByDescending(s => s.Marks);

            Console.WriteLine("------------------");

            Console.WriteLine("Sorted by AGE: " + string.Join(", ", sortedByAgeM.Select(s => s.Age)));

            Console.WriteLine("------------------");

            Console.WriteLine("Sorted by DEPT then MARKS:" + string.Join(", ", sortedByDeptThenMarksQ.Select(s => $"{s.Department} - {s.Name}")));


            //AGGREGATION - COUNT SUM MIN MAX AVG
            //QUERY SYNTAX
            var totalStudentsQ = (from s in students select s).Count();
            var totalMarksQ = (from s in students select s.Marks).Sum();
            var avgMarksQ = (from s in students select s.Marks).Average();
            var highestMarkQ = (from s in students select s.Marks).Max();
            var lowestAgeQ = (from s in students select s.Age).Min();

            //METHOD SYNTAX
            int totalStudentsM = students.Count();
            int totalMarksM = students.Sum(s => s.Marks);
            double avgMarksM = students.Average(s => s.Marks);
            int highestMarkM = students.Max(s => s.Marks);
            int lowestAgeM = students.Min(s => s.Age);

            Console.WriteLine("------------------");

            Console.WriteLine("Total Marks: " + totalMarksQ);

            Console.WriteLine("------------------");

            Console.WriteLine("Average Marks: " + avgMarksM);


            //QUANTIFIERS - ANY , ALL , CONTAINS
            //QUERY SYNTAX
            var anyTopperQ = (from s in students
                              where s.Marks > 90
                              select s).Any();
            var allAdultsQ = (from s in students
                              select s.Age).All(age => age >= 18);
            var containsDavidQ = (from s in students
                                  select s.Name).Contains("David");

            //METHOD SYNTAX
            bool hasTopper = students.Any(s => s.Marks > 90);
            bool allAdults = students.All(s => s.Age >= 18);
            bool containsDavid = students.Select(s => s.Name).Contains("David");

            Console.WriteLine("------------------");

            Console.WriteLine("All Adults: " + allAdultsQ);

            Console.WriteLine("------------------");

            Console.WriteLine("Any Topper: " + hasTopper);


            //GROUPING - GROUP BY
            //QUERY SYNTAX
            var groupedByDeptQ = from s in students
                                 group s by s.Department into DeptGroup
                                 select DeptGroup;
            
            //METHOD SYNTAX
            var groupByDept = students.GroupBy(s => s.Department);

            Console.WriteLine("------------------");

            foreach (var group in groupByDept)
            {
                Console.WriteLine($"Department: {group.Key}");
                foreach (var student in group)
                {
                    Console.WriteLine($"  {student.Name} - {student.Marks}");
                }
            }


            

        }
    }
}
