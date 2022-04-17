using Microsoft.EntityFrameworkCore;
using RepositoryPaternWeb.Models;

namespace RepositoryPaternWeb.Data
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options): base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
