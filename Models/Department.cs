using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Employee_API.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int MaxNumber { get; set; }

        // Navigation property to establish the relationship with Employees
        public ICollection<Employee> Employees { get; set; }
    }
}
