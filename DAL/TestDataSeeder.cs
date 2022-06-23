using DAL.DbObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TestDataSeeder
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var db = new EmployeeContext(serviceProvider.GetRequiredService<DbContextOptions<EmployeeContext>>()))
            {
                if (!db.Departments.Any())
                {
                    db.Departments.AddRange(SeedDepartments());
                    db.SaveChanges();
                }

                if (!db.Employees.Any())
                {
                    db.Employees.AddRange(SeedEmployees());
                    db.SaveChanges();
                }
            }
        }

        private static List<DbEmployee> SeedEmployees()
        {
            return new List<DbEmployee>
            {
                new DbEmployee
                {
                    Name = "Frontend Employee1",
                    CompanyEmployeeId = "CID_FrontendEmployee1",
                    Position = "React Developer",
                    Phone = "+36201234567",
                    SuperiorId = 5,
                    DepartmentId = 1
                },
                new DbEmployee
                {
                    Name = "Backend Employee2",
                    CompanyEmployeeId = "CID_BackendEmployee2",
                    Position = "C# Developer",
                    Phone = "+36201234566",
                    SuperiorId = 6,
                    DepartmentId = 2
                },
                new DbEmployee
                {
                    Name = "UX Employee3",
                    CompanyEmployeeId = "CID_UXEmployee3",
                    Position = "UX Designer",
                    Phone = "+36201234568",
                    DepartmentId = 3
                },
                new DbEmployee
                {
                    Name = "Frontend Employee4",
                    CompanyEmployeeId = "CID_FrontendEmployee4",
                    Position = "Angular Developer",
                    Phone = "+36201234578",
                    SuperiorId = 5,
                    DepartmentId = 1
                },
                new DbEmployee
                {
                    Name = "Frontend Employee5",
                    CompanyEmployeeId = "CID_FrontendEmployee5",
                    Position = "Vue Developer",
                    Phone = "+36201234589",
                    DepartmentId = 1
                },
                new DbEmployee
                {
                    Name = "Backend Employee6",
                    CompanyEmployeeId = "CID_BackendEmployee6",
                    Position = ".NET Core Developer",
                    Phone = "+36201234579",
                    DepartmentId = 2
                }
            };
        }

        private static List<DbDepartment> SeedDepartments()
        {
            return new List<DbDepartment>
            {
                new DbDepartment
                {
                    Name = "Frontend Development",
                    Abbreviation = "FE_DEV"
                },
                new DbDepartment
                {
                    Name = "Backend Development",
                    Abbreviation = "BE_DEV"
                },
                new DbDepartment
                {
                    Name = "UX Design",
                    Abbreviation = "UX_DES"
                }
            };
        }
    }
}
