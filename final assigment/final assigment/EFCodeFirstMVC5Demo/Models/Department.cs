using System;
using System.Collections.Generic;

namespace EFCodeFirstMVC5Demo.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}