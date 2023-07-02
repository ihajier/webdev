using ASP_api_employee_2.Models;
using Employee_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Employee_API.Data
{
    public class Employee_DbContext : DbContext
    {
        public Employee_DbContext(DbContextOptions<Employee_DbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>()
                .HasOne(t => t.Employee)
                .WithMany(e => e.Teams)
                .HasForeignKey(t => t.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }
    }
}
