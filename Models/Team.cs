using Employee_API.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ASP_api_employee_2.Models
{
    public class Team
    {
        [Key]
        public int TeamId { get; set; }

        public string TeamName { get; set; }

        public string TeamLeader { get; set; }

        public string Size { get; set; }

        public string Color { get; set; }

        public string LogoUrl { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}

