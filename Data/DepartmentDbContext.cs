using Employee_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Employee_API.Data
{
    public class DepartmentDbContext : DbContext
    {
        public DepartmentDbContext(DbContextOptions<DepartmentDbContext> options) : base(options)
        {
        }

        public DbSet<Department> Departments { get; set; }
    }
}
