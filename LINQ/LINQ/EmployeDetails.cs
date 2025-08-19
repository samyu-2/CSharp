using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CompanyId { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
    }

    class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    
    class EmployeDetails
    {
        public static List<Employee> GetEmployees()
        {
            return new List<Employee>{
                new Employee { Id = 1, Name = "Alice", CompanyId = 1, Age = 30, Salary = 24000 },
                new Employee { Id = 2, Name = "Bob", CompanyId = 1, Age = 41, Salary = 56000 },
                new Employee { Id = 3, Name = "Charlie", CompanyId = 2, Age = 24, Salary = 42000 },
                new Employee { Id = 4, Name = "David", CompanyId = 3, Age = 40,Salary = 45000 },
                new Employee { Id = 5, Name = "Eve", CompanyId = 3, Age = 70, Salary = 71000 }
            };
        }

        public static List<Company> GetCompanies()
        {
            return new List<Company>
            {
                new Company { Id = 1, Name = "Google" },
                new Company { Id = 2, Name = "Microsoft" },
                new Company { Id = 3, Name = "Amazon" }
            };
        }

        public static void Display()
        {
            List<Employee> employees = GetEmployees();
            List<Company> companies = GetCompanies();


            //INNER JOIN
            var innerJoin = employees.Join(
                companies,
                e => e.CompanyId,
                c => c.Id,
                (e, c) => new { e.Name, CompanyName = c.Name }
                );

            //LEFT OUTER JOIN
            var leftJoin = employees.GroupJoin(
                companies,
                e => e.CompanyId,
                c => c.Id,
                (e, cGroup) => new { employee = e, company = cGroup }
                );

            var leftJoinResult = leftJoin.SelectMany(
                x => x.company.DefaultIfEmpty(),
                (x, c) => new {
                    EmployeeName = x.employee.Name,
                    CompanyName = c?.Name ?? "No Company"
                });
            Console.WriteLine("Left Join");
            foreach (var item in leftJoinResult)
            {
                Console.WriteLine($"{item.EmployeeName} - {item.CompanyName}");
            }

            //RIGHT OUTER JOIN
            //THERE IS NOTHING SPECIFIC FOR RIGHT OUTER JOIN 
            //SO WE JUST SWAP THE TABLES AND USE LEFT JOIN LOGIC
            var rightJoin = companies.GroupJoin(
                employees,
                c => c.Id,
                e => e.CompanyId,
                (c, eGroup) => new { company = c, employee = eGroup }
                ).SelectMany(
                x => x.employee.DefaultIfEmpty(),
                (x,e) => new
                {
                    CompanyName = x.company.Name,
                    EmployeeName = e?.Name ?? "No Employee"
                }
                );

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Right Join");
            foreach (var item in rightJoin)
            {
                Console.WriteLine($"{item.CompanyName} - {item.EmployeeName}");
            }

            //GROUP BY
            var grouped = employees.GroupBy(e => e.CompanyId);
            Console.WriteLine("-------------------------------------------");
            foreach(var group in grouped)
            {
                Console.WriteLine($"Company id: {group.Key}\n{string.Join(", ",group.Select(emp => emp.Name))}");
            }


            //GROUP BY AND JOIN
            var groupedEmployees = employees.GroupBy(
                e => e.CompanyId)
                .Select(g => new
                {
                    CompanyName = companies.First(c => c.Id == g.Key).Name,
                    Employees = g.ToList()
                });
            Console.WriteLine("-------------------------------------------");
            foreach (var group in groupedEmployees)
            {
                Console.WriteLine($"Company: {group.CompanyName}");
                foreach(var emp in group.Employees)
                {
                    Console.WriteLine($" - {emp.Name}");
                }
            }

            //Find all employees older than 30.
            var AgeList = employees.Where(e => e.Age > 30);
            Console.WriteLine("-------------------------------------------");
            foreach (var item in AgeList)
            {
                Console.WriteLine(item.Name);
            }

            //Find employees with salary greater than 50,000
            var salaryList = employees.Where(e => e.Salary > 50000);
            Console.WriteLine("-------------------------------------------");
            foreach (var item in salaryList)
            {
                Console.WriteLine(item.Name);
            }

            //Get all employees working in CompanyId = 2
            var company2List = employees.Where(e => e.CompanyId == 2);
            Console.WriteLine("-------------------------------------------");
            foreach (var item in company2List)
            {
                Console.WriteLine(item.Name);
            }

            //Select only employee names from the list
            var namesOnly = employees.Select(e => e.Name);
            Console.WriteLine("-------------------------------------------");
            foreach (var item in namesOnly)
            {
                Console.WriteLine(item);
            }

            //Select employee name and salary into a new anonymous object            
            var empDeets = employees.Select(e => new { e.Name, e.Salary });
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"Employees: " + string.Join(", ", empDeets.Select(e => $"{e.Name} - {e.Salary}")));

            //Create a list of strings like "Alice - 50000" from employee name and salary.


            //Find the total salary of all employees.
            double avgSalary = employees.Average(e => e.Salary);

            //Find the average age of employees
            double avgAge = employees.Average(e => e.Age);

            //Find the highest salary among employees
            int maxSalary = employees.Max(e => e.Salary);

            //Count how many employees are in each company
            var empCount = employees.GroupBy(e => e.CompanyId)
                .Select(g => new { CompanyId = g.Key, EmployeeCount = g.Count() });
            foreach(var item in empCount)
            {
                Console.WriteLine($"Company Id: {item.CompanyId}, Employee Count: {item.EmployeeCount}");
            }

            //Get employees sorted by salary (ascending)
            var sortedSalary = employees.OrderBy(e => e.Salary);
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"Salary: " + string.Join(", ", sortedSalary.Select(e => e.Salary)));

            //Get employees sorted by name (descending).
            var soretedName = employees.OrderByDescending(e => e.Name);
            Console.WriteLine($"Name: " + string.Join(", ", soretedName.Select(e => e.Name)));

            //Get top 3 highest-paid employees.
            var top3Emp = employees.OrderByDescending(e => e.Salary)
                .Take(3);
            Console.WriteLine($"Highest paid Employee: " + string.Join(", ", top3Emp.Select(e => e.Salary)));

            //Check if any employee has salary greater than 1,00,000.
            Console.WriteLine(employees.Any(e => e.Salary > 100000));

            //Check if all employees are older than 18
            Console.WriteLine(employees.All(e => e.Age > 18));

            //Find the first employee with salary above 60,000.
            var firstEmp = employees.FirstOrDefault(e => e.Salary > 60000);

            Console.WriteLine("-------------------------------------------");

            if (firstEmp != null)
            {
                Console.WriteLine($"{firstEmp.Name} - {firstEmp.Salary}") ;
            }
            else
            {
                Console.WriteLine("No employee > 60000");
            }

            // Get the single employee with Id = 5(should throw error if more than one exists).
            var employeeDeets = employees.SingleOrDefault(e => e.Id == 5);
            Console.WriteLine($"{employeeDeets.Name} - {employeeDeets.Salary}");
        }

    }
}