using System;
using System.Collections.Generic;

namespace EFDBFirst.Data.Models
{
    public partial class EmployeeEducation
    {
        public int Id { get; set; }
        public string? CourseName { get; set; }
        public string? UniversityName { get; set; }
        public int PassingYear { get; set; }
        public int MarksPercentage { get; set; }
        public int EmployeeId { get; set; }

        public virtual Employee Employee { get; set; } = null!;
    }
}
