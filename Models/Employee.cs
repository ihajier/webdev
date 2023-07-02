using ASP_api_employee_2.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Employee_API.Models
{
    public class Employee
    {
        [Key]
        public int id { get; set; }

        public string fullName { get; set; }

        public string username { get; set; }

        public string password { get; set; }

        public string email { get; set; }

        public string address { get; set; }

        public long phone { get; set; }

        public int depId { get; set; }

        public string admin_N { get; set; }

        public string pass { get; set; }

        public string role { get; set; } // Added role property

        [InverseProperty("Employee")]
        public ICollection<Team> Teams { get; set; }
    }
}
