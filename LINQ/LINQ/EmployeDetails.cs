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
                new Employee { Id = 1, Name = "Alice", CompanyId = 1 },
                new Employee { Id = 2, Name = "Bob", CompanyId = 2 },
                //new Employee { Id = 3, Name = "Charlie", CompanyId = 3 },
                //new Employee { Id = 4, Name = "David", CompanyId = 4 } // no company with Id=4
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

            foreach(var item in leftJoinResult)
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

            foreach(var item in rightJoin)
            {
                Console.WriteLine($"{item.CompanyName} - {item.EmployeeName}");
            }

        }

    }
}
