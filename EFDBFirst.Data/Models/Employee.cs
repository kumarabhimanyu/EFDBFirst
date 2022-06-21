using System;
using System.Collections.Generic;

namespace EFDBFirst.Data.Models
{
    public partial class Employee
    {
        public Employee()
        {
            EmployeeEducations = new HashSet<EmployeeEducation>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }

        public virtual ICollection<EmployeeEducation> EmployeeEducations { get; set; }
    }
}
