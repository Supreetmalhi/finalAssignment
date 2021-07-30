using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EFCodeFirstMVC5Demo.Models
{
    public class EmployeeInitializer : DropCreateDatabaseAlways<EmployeeDbContext>
    {
        protected override void Seed(EmployeeDbContext context)
        {
            var departments = new List<Department>
            {
                new Department { DepartmentName = "Electrical Department" },
                new Department { DepartmentName = "Civil Department"},
                new Department { DepartmentName = "Bio Science Department"}
            };
            departments.ForEach(x => context.Departments.Add(x));
            context.SaveChanges();
            var employees = new List<Employee>
            {
                new Employee { Name = "Peter", Age = 25, DepartmentID = 1},
                new Employee { Name = "Jon", Age = 25, DepartmentID = 2},
                new Employee { Name = "Ron", Age = 25, DepartmentID = 3},
                new Employee { Name = "Harry", Age = 25, DepartmentID = 1},
                new Employee { Name = "Merry", Age = 25, DepartmentID = 2},
                new Employee { Name = "Maya", Age = 25, DepartmentID = 3},
                new Employee { Name = "Danny", Age = 25, DepartmentID = 1},
            };
            employees.ForEach(x=>context.Employees.Add(x));
            context.SaveChanges();
        }
    }
}