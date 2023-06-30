using EmployeeApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeApp.Data
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options): base(options) { }
        public DbSet<Employee> Employees { get; set; } = null!;
        public DbSet<Designation> Designations { get; set; } = null!;
        public DbSet<WorkingHour>WorkingHours { get; set; }= null!;
        public DbSet<PaymentRule> PaymentRules { get; set; }= null!;
    }
}
